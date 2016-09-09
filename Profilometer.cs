using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;


namespace ProfilometerAutomation
{
    public class Profilometer 
    {
        int paramIndex = 0;
        //Profilometer Commands Dictionary
        public Dictionary<string, string> control = new Dictionary<string, string>();
        public Dictionary<int, string> read = new Dictionary<int, string>();


        SerialPort ComPort = new SerialPort();
        
        string InputData = String.Empty;
        private List<string> parameter = new List<string>();
        private bool isActive = false;
       
        public string commandReturnString;


        public Profilometer()
        {
            ComPort.DataReceived += new SerialDataReceivedEventHandler(PortDataReceived);
            control.Add("Start", "CTSTA\r");   //Starts measurement
            control.Add("Retract", "CTESP\r"); //Retracts the detector
            control.Add("Return", "CTRTN\r");  //returns from retract state
            read.Add(0, "RDSTU00\r");          //"Status"
            read.Add(1, "RDRES02,01,00\r");    //"Param1"
            read.Add(2, "RDRES02,02,00\r");    //"Param2"
            read.Add(3, "RDRES02,03,00\r");    //"Param3"
            read.Add(4, "RDRES02,04,00\r");    //"Param4"
            read.Add(5, "RDRES02,05,00\r");    //"Param5"
            read.Add(6, "RDRES02,06,00\r");    // "Param6"
        }                                   

        /// <summary>
        /// Serial Comm data received event handler
        /// Will execute once it has recieved data from the profilometer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PortDataReceived(object sender, SerialDataReceivedEventArgs e)

        {
            
            Thread.Sleep(1000);                     //Gives the profilometer time to finish sending the entire message
            InputData = ComPort.ReadExisting();     //Reads the message i.e the parameter value

            if (InputData != String.Empty)          
            {
                commandReturnString = InputData;    //Assign the return value to a string object
                ComPort.DiscardInBuffer();          //Clear the input buffer to get ready for next message
                SetText(InputData);                 //Call Set text method

                //this.BeginInvoke(new SetTextCallback(SetText), new object[] { InputData });
            }
        }

        /// <summary>
        /// Adds the result of the parameter coming from the profilometer
        /// to the Parameter List object.
        /// </summary>
        /// <param name="text">result string from profilometer</param>
        private void SetText(string text)
        {
            if((!text.Contains("OK000\r")) && (!text.Contains("OK001\r")) && (!text.Contains("OK002\r")))
            {
                Parameter.Add(text);
               
            }
            
               
        }

       
        /// <summary>
        /// This method calls the command function to start the profilometer measurement
        /// it will then keep checking if the profilometer is still measuring by calling
        /// the IsActive method which returns a boolean
        /// </summary>
        public void Start()
        {
            Command(control["Start"]); //begin measurement
   
            //Poll the profilometer
            //and check if the measurement
            //process is still in progress
            while(IsActive())
            {
                //Think about using tasks instead 
                Thread.Sleep(3000); //Check every 3 seconds
            }
        }


        public string DetectorPosition()
        {
            return commandReturnString;
        }

        /// <summary>
        /// Sends the RDSTU00 command to the profilometer
        /// and returns the status (See SJ-210(ENG) File section 17.12 for commands)
        /// </summary>
        /// <returns></returns>
        public string DetectorStatus()
        {
            Command(read[0]);
            return commandReturnString;
        }
        
        /// <summary>
        /// Returns the list of parameters returned
        /// from the profilometer
        /// </summary>
        public List<string> Parameter
        {
            get {return parameter;}
            set{parameter = value;}
        }

        /// <summary>
        ///  Will display all 6 parameters to a Rich TextBox Control
        /// </summary>
        public void results(RichTextBox rtbIncoming)
        {
            //Go through each read parameter command
            foreach (var command in read)
            {
                Command(command.Value);
               
                //When last parameter read is executed
                if (command.Key == 6)
                {
                    
                    rtbIncoming.Clear();
      
                    //Read the results inside parameter list
                    foreach (var results in Parameter)
                    {
                        rtbIncoming.Text += results;
                    }
                        
                }
                else
                {

                }

            }
        }

        /// <summary>
        /// Checks status of profilometer for activity
        /// if it is still measuring
        /// </summary>
        /// <returns>Returns True if still measuring False if otherwise</returns>
        public bool IsActive()
        {
            if (DetectorStatus() == "OK000\r")
            {
                isActive = false;
            }
            else
                isActive = true;

            return isActive;
        }

        /// <summary>
        /// Allowing for manual commands
        /// Intended for realtime debugging
        /// </summary>
        /// <param name="keyPressed">Connected to the Enter key to execute command</param>
        /// <param name="handle"></param>
        /// <param name="txtCommand">Where the command string is held</param>
        public void UserCommand(char keyPressed, bool handle, RichTextBox txtCommand)
        {
            if (keyPressed == (char)13) // enter key  
            {
                Command(txtCommand.Text+"\r");
                System.Threading.Thread.Sleep(1000);
                txtCommand.Text = "";
            }
            else if (keyPressed < 32 || keyPressed > 126)
            {
                handle = true; // ignores anything else outside printable ASCII range  
            }
            else
            {
                //Wrap around try catch because will 
                //will throw exception if port is closed
                try
                {
                    ComPort.Write(keyPressed.ToString());
                }
                catch(InvalidOperationException error)
                {
                    MessageBox.Show(error.Message);
                }
                   
                
                
                
            }
        }

        /// <summary>
        /// As of now is required to open the serial port to the controller manually.
        /// Should set up so that the ports are opened at start of application.
        /// Will keep this method in the end to allow for manual closing or opening
        /// of serial port
        /// </summary>
        /// <param name="btnPortState"></param>
        /// <param name="cboPorts"></param>
        /// <param name="cboBaudRate"></param>
        /// <param name="cboDataBits"></param>
        /// <param name="cboStopBits"></param>
        /// <param name="cboHandShaking"></param>
        /// <param name="cboParity"></param>
        public void PortState(Button btnPortState, ComboBox cboPorts, ComboBox cboBaudRate, ComboBox cboDataBits, 
                              ComboBox cboStopBits, ComboBox cboHandShaking, ComboBox cboParity)
        {
            if (btnPortState.Text == "Closed")
            {
                btnPortState.Text = "Open";
                ComPort.PortName = Convert.ToString(cboPorts.Text);
                ComPort.BaudRate = Convert.ToInt32(cboBaudRate.Text);
                ComPort.DataBits = Convert.ToInt16(cboDataBits.Text);
                ComPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cboStopBits.Text);
                ComPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), cboHandShaking.Text);
                ComPort.Parity = (Parity)Enum.Parse(typeof(Parity), cboParity.Text);
                ComPort.Open();
            }
            else if (btnPortState.Text == "Open")
            {
                btnPortState.Text = "Closed";
                ComPort.Close();

            }
        }

        /// <summary>
        /// Writes all commands to the profilometer and waits 
        /// 600ms after the write before it fetches the received data
        /// </summary>
        /// <param name="command">The command that will be written to the controller</param>
        public void Command(string command)
        {
           
            ComPort.Write(command);
            Thread.Sleep(600);
        }

        /// <summary>
        /// Sets up the serial port setting for the profilometer
        /// </summary>
        /// <param name="cboBaudRate"></param>
        /// <param name="cboPorts"></param>
        /// <param name="cboDataBits"></param>
        /// <param name="cboStopBits"></param>
        /// <param name="cboParity"></param>
        /// <param name="cboHandShaking"></param>
        /// <param name="portsButtonClicked"></param>
        public void GetSerialPorts(ComboBox cboBaudRate, ComboBox cboPorts, ComboBox cboDataBits, ComboBox cboStopBits, ComboBox cboParity, 
                                   ComboBox cboHandShaking, bool portsButtonClicked)
        {
            string[] ArrayComPortsNames = null;
            int index = -1;
            string ComPortName = null;

            //Com Ports
            ArrayComPortsNames = SerialPort.GetPortNames();
            do
            {
                index += 1;
                cboPorts.Items.Add(ArrayComPortsNames[index]);


            } while (!((ArrayComPortsNames[index] == ComPortName) || (index == ArrayComPortsNames.GetUpperBound(0))));
            Array.Sort(ArrayComPortsNames);

            if (index == ArrayComPortsNames.GetUpperBound(0))
            {
                ComPortName = ArrayComPortsNames[0];
            }
            //get first item print in text
            cboPorts.Text = ArrayComPortsNames[0];
            //Baud Rate
            cboBaudRate.Items.Add(300);
            cboBaudRate.Items.Add(600);
            cboBaudRate.Items.Add(1200);
            cboBaudRate.Items.Add(2400);
            cboBaudRate.Items.Add(9600);
            cboBaudRate.Items.Add(14400);
            cboBaudRate.Items.Add(19200);
            cboBaudRate.Items.Add(38400);
            cboBaudRate.Items.Add(57600);
            cboBaudRate.Items.Add(115200);
            cboBaudRate.Items.ToString();
            //9600 Baud Rate as default
            cboBaudRate.Text = cboBaudRate.Items[4].ToString();
            //Data Bits
            cboDataBits.Items.Add(7);
            cboDataBits.Items.Add(8);
            //8 data bits as default 
            cboDataBits.Text = cboDataBits.Items[1].ToString();

            //Stop Bits
            cboStopBits.Items.Add("One");
            cboStopBits.Items.Add("OnePointFive");
            cboStopBits.Items.Add("Two");
            //get the first item print in the text
            cboStopBits.Text = cboStopBits.Items[0].ToString();
            //Parity 
            cboParity.Items.Add("None");
            cboParity.Items.Add("Even");
            cboParity.Items.Add("Mark");
            cboParity.Items.Add("Odd");
            cboParity.Items.Add("Space");
            //get the first item print in the text
            cboParity.Text = cboParity.Items[0].ToString();
            //Handshake
            cboHandShaking.Items.Add("None");
            cboHandShaking.Items.Add("XOnXOff");
            cboHandShaking.Items.Add("RequestToSend");
            cboHandShaking.Items.Add("RequestToSendXOnXOff");
            //get the first item print it in the text 
            cboHandShaking.Text = cboHandShaking.Items[0].ToString();

            
        }
    }
}
