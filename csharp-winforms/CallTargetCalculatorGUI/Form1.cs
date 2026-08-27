using System;
using System.Windows.Forms;

namespace CallTargetCalculatorGUI
{
    public partial class Form1 : Form
    {
        private const int DAILY_TARGET_CALLS = 200;
        private const double DAILY_NET_HOURS = 8.5;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Değişkenler
            double loginHours;
            double breakMinutes;
            int callsTaken;

            // Parse
            bool okLogin = double.TryParse(txtLoginHours.Text.Trim(), out loginHours);
            bool okBreak = double.TryParse(txtBreakMinutes.Text.Trim(), out breakMinutes);
            bool okCalls = int.TryParse(txtCallsTaken.Text.Trim(), out callsTaken);

            if (!okLogin || !okBreak || !okCalls)
            {
                MessageBox.Show("Please enter valid numbers in all fields.");

                return;
            }

            double netWorkedHours = loginHours - (breakMinutes / 60.0);
            if (netWorkedHours < 0) netWorkedHours = 0;

            double remainingNetHours = DAILY_NET_HOURS - netWorkedHours;
            if (remainingNetHours < 0) remainingNetHours = 0;

            int remainingCalls = DAILY_TARGET_CALLS - callsTaken;

            if (remainingCalls <= 0)
            {
                txtOutput.Text = "You're in Bonus mod 😄";
                return;
            }

            if (remainingNetHours == 0)
            {
                txtOutput.Text = "Remaining net hours is 0.\r\n" +
                    "Required pace cannot be calculated.";
                return;
            }

            double requiredCallsPerHour = remainingCalls / remainingNetHours;

            txtOutput.Text =
                $"Net worked hours: {netWorkedHours:F2} hours\r\n" +
                $"Remaining hours: {remainingNetHours:F2} hours\r\n" +
                $"Remaining calls: {remainingCalls}\r\n" +
                $"Required pace: {requiredCallsPerHour:F2} calls/hours";
        }
    }
}
