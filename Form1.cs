using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Excel = Microsoft.Office.Interop.Excel;
namespace ProfilometerAutomation
{

    public partial class Form1 : Form
    {
        int i = 0;
        int xCellIndex;
        SerialPort ComPort = new SerialPort();

        Profilometer profilometer = new Profilometer();

        MotionController controller;

        //a;sdkjfl

        bool portsButtonClicked = false;

        #region
        /*
        //Make a vallidation method that displays
        // a message box
        string message = "Open the ports first you fool";
        string caption = "error";
        MessageBoxButtons button = MessageBoxButtons.OK;

        string errorMissingInitial = "Program Missing #INITIAL Label or Program is already running";
        StringBuilder builder = new StringBuilder();
        */
        #endregion


        string profResult = String.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            bool connected = false;
            GalilWidgets.GalilWidget wi; //for casting to Widget Interface
            wi = (GalilWidgets.GalilWidget)gwTerm1; gwComs1.GWRegisterWidget(ref wi);
            wi = (GalilWidgets.GalilWidget)gwDatRec1; gwComs1.GWRegisterWidget(ref wi);
            wi = (GalilWidgets.GalilWidget)gwDatRec2; gwComs1.GWRegisterWidget(ref wi);
            wi = (GalilWidgets.GalilWidget)gwPoll1; gwComs1.GWRegisterWidget(ref wi);
            wi = (GalilWidgets.GalilWidget)gwSettings1; gwComs1.GWRegisterWidget(ref wi);
            string gi = GalilWidgets.LibraryPath.GclibDllPath_; gi = "C:\\Program Files (x86)\\Galil\\gclib\\dll\\x64\\gclib.dll";
            string xmlPath = "C:\\Users\\cbracamontes\\Downloads\\galilwidgets_15\\xml\\4000\\";
            gwPoll1.GWLoadFile(xmlPath + "GWPoll_Revised.xml");
            gwDatRec2.GWLoadFile(xmlPath + "GWDatRec_IO.xml"); //assuming #2 is upper right
            gwDatRec1.GWLoadFile(xmlPath + "GWDatRec_Axis_A_Revised.xml");
            gwSettings1.GWLoadFile(xmlPath + "GWSettings_Revised.xml");
            connected = gwComs1.GWOpen("172.18.114.194"); //put the correct connection address here
            controller = new MotionController(gwComs1);
            profilometer.GetSerialPorts(cboBaudRate, cboPorts, cboDataBits, cboStopBits,
                                        cboParity, cboHandShaking, portsButtonClicked);
            cboBaudRate.Hide();
            cboDataBits.Hide();
            cboHandShaking.Hide();
            cboParity.Hide();
            cboPorts.Hide();
            cboStopBits.Hide();
            btnPorts.Hide();
            btnPortState.Hide();
            btnHello.Hide();


        }


        private void btnGetSerialPorts_Click(object sender, EventArgs e)
        {
            

            //Acknowledge this button has been clicked
            portsButtonClicked = true;
            #region commented out old code
            /*
            string[] ArrayComPortsNames = null;
            int index = -1;
            string ComPortName = null;

            //Acknowledge this button has been clicked
            portsButtonClicked = true;
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
            */
            #endregion

        }

        
        private void btnPortState_Click(object sender, EventArgs e)
        {
            profilometer.PortState(btnPortState, cboPorts, cboBaudRate, cboDataBits, cboStopBits, cboHandShaking, cboParity);
            #region
            /*
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
            */
            #endregion
        }

        private void rtbOutgoing_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // enter key  
            {
                System.Threading.Thread.Sleep(1000);
                profilometer.Command(txtCommand.Text + "\r");
                System.Threading.Thread.Sleep(2000);
                while (profilometer.Parameter.Count == 0)
                {
                    e.Handled = false;
                }
                if (profilometer.Parameter.Count > 0)
                {
                    rtbIncoming.Text += profilometer.Parameter[i];
                    i = i + 1;
                }



                txtCommand.Text = "";
            }
            else if (e.KeyChar < 32 || e.KeyChar > 126)
            {
                e.Handled = true; // ignores anything else outside printable ASCII range  
            }
            else
            {
                //Wrap around try catch because will 
                //will throw exception if port is closed
                try
                {
                    // ComPort.Write(e.KeyChar.ToString());
                }
                catch (InvalidOperationException error)
                {
                    MessageBox.Show(error.Message);
                }
                //profilometer.UserCommand(e.KeyChar, e.Handled, txtCommand);    

                #region Old Code
                /*
                if (e.KeyChar == (char)13) // enter key  
                {
                    ComPort.Write("\r\n");
                    txtCommand.Text = "";
                }
                else if (e.KeyChar < 32 || e.KeyChar > 126)
                {
                    e.Handled = true; // ignores anything else outside printable ASCII range  
                }
                else
                {
                    ComPort.Write(e.KeyChar.ToString());
                }
                */
                #endregion
            }
        }


        private void btnHello_Click(object sender, EventArgs e)
        {
            profilometer.results(rtbIncoming);
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            // Will add the Xpoints, lenght between, Rotations, Rotaion Step
            //Come back here and handle possible errors in textbox
            // like unwanted characters or numbers i.e. Rotations*RotationsStep <= 360(full rev)
            
            int inches;
            int rotations;
            int rotationStep;
            if (textBoxLengthBetweenPointsX != null)
            {
                inches = int.Parse(textBoxLengthBetweenPointsX.Text);
                rotations = int.Parse(textBoxRotations.Text);
                rotationStep = int.Parse(textBoxLengthBetweenPointsDegrees.Text);
            }
            else
            {
                inches = 0;
                rotations = 0;
                rotationStep = 0;
            }
            
            controller.CheckProgramLoaded(comboBoxMeasurePoints.SelectedIndex+1,inches,rotations,rotationStep);
        }

        private void rtbIncoming_TextChanged(object sender, EventArgs e)
        {
            if (profResult == "OK000\r")
            {
                //string command2 = "ST";
                //gwComs1.GWCommand(ref command2);
                //System.Threading.Thread.Sleep(1000);
                //gwComs1.GWCommand(ref command, true);
            }
            else
            {
                //rtbIncoming.Clear();
                // ComPort.Write("RDSTU00\r");
            }
            //stateMachine();
            /*
            
            if (profResult == "OK\nOK001\n")
            {
                
            }
            */
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.CloseController();
        }

        /// <summary>
        /// Where program logic flows through
        /// Returns a message from the motion controller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Message(ref GalilWidgets.GWComs sender, ref string e)
        {
            
            if (!controller.InMotion(e))
            {
                System.Threading.Thread.Sleep(1000);
                profilometer.Start();               //Begin profilometer measurement
                profilometer.results(rtbIncoming); //Display contents of results to rich text box
                controller.Resume();               //Resume controller to next position
            }
        }

        private void XlExportButton_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("You a fool", "Error");
            }

            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(Type.Missing);
           
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.ActiveSheet; xlWorkSheet.Name = "Profilometer"; 

            foreach (var parameter in profilometer.Parameter)
            {
                xCellIndex += 1;
                xlWorkSheet.Cells[xCellIndex, 1] = parameter;
                
            }

            xlWorkBook.SaveAs("csharp_excel.xls");
            xlWorkBook.Close(true, "csharp_excel.xls");
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file C:\\csharp_excel.xls");

        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }        

        private void checkBoxManualSetting_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxManualSetting.Checked)
            {
                cboBaudRate.Show();
                cboDataBits.Show();
                cboHandShaking.Show();
                cboParity.Show();
                cboPorts.Show();
                cboStopBits.Show();
                btnPorts.Show();
                btnPortState.Show();
                btnHello.Show();

            }
            else
            {
                cboBaudRate.Hide();
                cboDataBits.Hide();
                cboHandShaking.Hide();
                cboParity.Hide();
                cboPorts.Hide();
                cboStopBits.Hide();
                btnPorts.Hide();
                btnPortState.Hide();
                btnHello.Hide();
            }

        }

        private void comboBoxMeasurePoints_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.CommandController("DA *[]"); //Will deallocate motion controller arrays to allow for a new set
        }
    }
}
