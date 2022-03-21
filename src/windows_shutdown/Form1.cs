using System.Diagnostics;

namespace windows_shutdown
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void runCommand(string args)
        {
            /* Runs the Shutdown command with args */
            shutButton.Enabled = false;
            abortButton.Enabled = false;
            
            // Formatting the args to include the shutdown command
            args = String.Format("/C shutdown {0}", args);

            // Making the process with info
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo("powershell.exe", args);

            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;

            // Starting the process
            process.StartInfo = startInfo;
            process.Start();
            string output = process.StandardError.ReadToEnd();

            // Setting the output
            outputTxt.Text = (args);
            outputTxt.AppendText(Environment.NewLine);
            outputTxt.AppendText(output);

            shutButton.Enabled = true;
            abortButton.Enabled = true;
        }

        private double getSeconds()
        {
            // Get total seconds compared to timePicker
            DateTime value = timePicker.Value;
            DateTime now = DateTime.Now;
            TimeSpan ts;

            if (now > value)
                // If its earlier, add a day so it doesn't return a negative
                value = value.AddDays(1);

            // Comparing DateTime and grabbing total seconds
            ts = value - now;
            return Math.Ceiling(ts.TotalSeconds);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            timePicker.Value = DateTime.Now;
        }

        private void abortButton_Click(object sender, EventArgs e)
        {
            runCommand("-a");
        }

        private void shutButton_Click(object sender, EventArgs e)
        {
            double seconds = getSeconds();
            string args = String.Format("-s -t {0}", seconds);

            runCommand(args);
        }
    }
}