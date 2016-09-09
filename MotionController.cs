using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalilWidgets;
using System.Windows.Forms;

namespace ProfilometerAutomation
{
    public class MotionController
    {
       //If you succeeded you will see this message doggy
       //hello from the past
        private double locationX;
        private double locationY;
        private double locationZ;

        private double[] posA;
        private double[] posB;
        private double[] posC;

        private int limitY;
        private bool inMotion = false;
        bool finished = false;

        public string commandReturnString;
        

        GWComs gwComs1 = new GWComs();
        
        
        
        //Make a vallidation method that displays
        // a message box
        string message = "Open the ports first you fool";
        string caption = "error";
        MessageBoxButtons button = MessageBoxButtons.OK;

        string errorMissingInitial = "Program Missing #INITIAL Label or Program is already running";
        StringBuilder builder = new StringBuilder();

        public MotionController()
        {
           
        }

        public MotionController(GWComs gwComs1)
        {
            this.gwComs1 = gwComs1;
            
        }

        /// <summary>
        /// Should Check that there is a program loaded to the controller
        /// Should also initialize some user defined parameters to the controller program
        /// How it checks: After first command executes this will either run smoothly and 
        ///                continue running or will return an exception. The exception
        ///                means that either the program does not have an #INITIAL label
        ///                meaning the correct program was not loaded or that a command
        ///                was trying to execute that is not allowed while a program is 
        ///                runnning (There are certain commands that cant be used while program is running)
        /// </summary>
        /// <param name="points">The Amount of points to measure on X axis</param>
        /// <param name="inchOffset">The lenght between each point in inches</param>
        /// <param name="rotations">The number of times the part will rotate</param>
        /// <param name="rotationStep">Angle at which the part will rotate each time in degrees</param>
        public void CheckProgramLoaded(int points, int inchOffset, int rotations, int rotationStep)
        {
            bool run = true; // Will remove this
           
            if (run)
            {
                string command = "XQ#INITIAL"; 
                string command2 = "XQ#INITARR";
               

                try
                {
                    CommandController(command); //Initializes a lot of the variables
                   
                    
                    CommandController("size = " + points); //Will re-initialize the size variable

                    //This is a check for the inchOffset user input
                    //checking if the value is empty
                    //Should also check the other user inputs
                    if(inchOffset != 0)
                    {
                        CommandController("offset = " + inchOffset); //Re-initialize offset variable
                    }
                    CommandController("rotation = " + rotations); //re-initialize rotation variable
                    
                    CommandController("rStep = " + rotationStep); //re-initialize rStep variable

                    CommandController(command2); //Declare arrays and a few parameters

                }
                catch (Exception error)
                {
                    //Carries the message output to the 
                    //MessageBox Pop up, More Efficient this way?
                    builder.Append(errorMissingInitial)
                            .Append("\n")
                            .Append(error.Message);
                    MessageBox.Show(builder.ToString(), caption, button);
                }

            }
            else
                MessageBox.Show(message, caption, button);
        }

        public void CloseController()
        {
            
            string stopCmd = "ST";
            try
            {
                //Will throw exception if connection is closed
                //Then user exits the application
                CommandController(stopCmd);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, caption, button);
            }
            
        }

        /// <summary>
        /// Will send a command to the motion controller
        /// </summary>
        /// <param name="command">The Entire Command String</param>
        /// <returns></returns>
        public string CommandController(string command)
        {
            return gwComs1.GWCommand(ref command);
        }
        
        /// <summary>
        /// Checks if controller is in Motion
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool InMotion(string message)
        {
            commandReturnString = message;
            
            finished = commandReturnString.Contains("HALTING WHILE MEASURING");
            if (finished)
            {
                commandReturnString = "Beginning Measurement";
                //MessageBox.Show(commandReturnString, caption, button);
                inMotion = false;
            }
            else
            {

                commandReturnString = "";//MessageBox.Show("You Wack");
                inMotion = true;
            }
            return inMotion;
        }

        /// <summary>
        /// Used to to resume execution in the 
        /// motion controller program. It is invoked
        /// once the measurement from the profilometer
        /// has been output.
        /// </summary>
        public void Resume()
        {
            CommandController("XQ#RESUME");  //Resumes execution
            inMotion = true;                 //Acknowledges that controller is in motion
        }

        //Make method that checks all inputs and does any necessary error checking
        //before beginning program
  

       
    }
}
