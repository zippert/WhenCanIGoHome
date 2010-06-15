using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WhenCanIGoHome
{
    public partial class Form1 : Form
    {
        private static readonly int DEFAULT_LUNCH_TIME = 30;
        private int currLunchtime = DEFAULT_LUNCH_TIME;
        private static readonly string REGKEY_ARRIVALPICKER = "arrivalTimeDefault";
        private static readonly string REGKEY_LUNCH = "lunchTimeDefault";
        private static readonly string REG_SUBKEY = "Software\\Tedkomp\\WhenCanIGoHome";
        
        public Form1()
        {
            InitializeComponent();
            loadStartValuesFromRegistry();
            

            resultLabel.Text = "You can leave at " + departurePicker.Value.ToShortTimeString();
            robinTime.Text = "";
            flexField.Text = "";
        }

        private void loadStartValuesFromRegistry()
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(REG_SUBKEY);
            if (reg == null)
            {
                arrivalPicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,DateTime.Now.Hour , DateTime.Now.Minute, 0);
                departurePicker.Value = arrivalPicker.Value.AddHours(8);
                departurePicker.Value = departurePicker.Value.AddMinutes(DEFAULT_LUNCH_TIME);
                
            }
            else
            {
                //Can't just copy from saved, since it might have been saved on the "wrong" day
                DateTime savedVal = new DateTime(Int64.Parse((string)reg.GetValue(REGKEY_ARRIVALPICKER)));
                arrivalPicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, savedVal.Hour, savedVal.Minute, 0);

                currLunchtime = Convert.ToInt32(reg.GetValue(REGKEY_LUNCH));
                
            }
            lunchtime.Text = currLunchtime.ToString();
        }

        private void goneHome_CheckedChanged(object sender, EventArgs e)
        {
            departureBox.Enabled = goneHome.Checked;
            flexField.Visible = goneHome.Checked;
            robinTime.Visible = goneHome.Checked;
            updateResult();
        }

        private void lunchtime_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (lunchtime.Text.Equals(""))
                {
                    lunchtimeError.SetError(label4, "Please enter lunch time");
                }
                else
                {
                    currLunchtime = Convert.ToInt32(lunchtime.Text);
                    lunchtimeError.SetError(label4, "");
                    goneHome.Enabled = true;
                    if (currLunchtime < 30)
                    {
                        lunchtimeError.SetError(label4, "Lunch needs to be >= 30 minutes");
                        lunchtime.ForeColor = Color.Red;
                    }
                }

            }
            catch (FormatException)
            {
                lunchtimeError.SetError(label4, "Invalid format!");
                lunchtime.ForeColor = Color.Red;
            }
            catch (OverflowException)
            {
                lunchtimeError.SetError(label4, "The lunch feels a bit too long...");
                goneHome.Enabled = false;
            }
        }

        private void lunchtime_Enter(object sender, EventArgs e)
        {
            lunchtime.ForeColor = Color.Black;
        }

        private void departurePicker_ValueChanged(object sender, EventArgs e)
        {
            //do not allow to count negative working hours
            if (departurePicker.Value.CompareTo(arrivalPicker.Value.AddMinutes(currLunchtime)) > 0)
            {
                //Allow change
                TimeSpan diff = departurePicker.Value - arrivalPicker.Value - TimeSpan.FromMinutes(Convert.ToDouble(lunchtime.Text));
                String minutes = diff.Minutes < 10 ? "0" + diff.Minutes : diff.Minutes.ToString();

                resultLabel.Text = String.Format("You have worked {0} hours and {1} minutes", diff.Hours + diff.Days * 24, minutes);

                robinTime.Text = String.Format("({0:F2} or {1}:{2})", diff.TotalHours, diff.Hours + diff.Days * 24, minutes);
                double flex = diff.TotalHours - 8;
                flexField.Text = String.Format("Flex: {0:F2}", flex);
                if (flex == 0)
                {
                    flexField.ForeColor = Color.Black;
                }
                else if (flex < 0)
                {
                    flexField.ForeColor = Color.Red;
                }
                else if (flex > 0)
                {
                    flexField.ForeColor = Color.Green;
                    flexField.Text = String.Format("{0} ({1})", flexField.Text, CreatePlusFlexString());
                }
                robinTime.Visible = true;
                flexField.Visible = true;
            }
            else
            {
                departurePicker.Value = arrivalPicker.Value.AddMinutes(currLunchtime);
                resultLabel.Text = "You haven't worked! Get to it!";
                robinTime.Visible = false;
                flexField.Visible = false;
            }
           
        }

        private string CreatePlusFlexString()
        {
            DateTime from = arrivalPicker.Value;
            DateTime to = departurePicker.Value;
            StringBuilder result = new StringBuilder();
            TimeSpan overtime = to - from.AddHours(8).AddMinutes(currLunchtime);
            if (from.Date == to.Date)
            {
                if (to.Hour >= 20)
                {
                    from = from.AddHours(8).AddMinutes(currLunchtime);
                    double minutes = 60 - from.Minute;
                    from = from.AddMinutes(minutes);
                    double hoursTo20 = 20 - from.Hour;
                    if (minutes == 60)
                    {
                        minutes = 0;
                        hoursTo20++;
                    }
                    result.AppendFormat("Ö1= {0}:{1}/{0},{2:F0}", hoursTo20, minutes < 10 ? "0" + minutes : Convert.ToString(minutes), minutes * 100 / 60);
                    double hoursAfter20 = to.Hour - 20;
                    minutes = to.Minute;
                    result.AppendFormat(" && Ö2= {0}:{1}/{0},{2:F0}", hoursAfter20, minutes < 10 ? "0" + minutes : Convert.ToString(minutes), minutes * 100 / 60);
                }
                else
                {
                    result.AppendFormat("Ö1= {0}:{1}/{0},{2:F0}", overtime.Hours, overtime.Minutes < 10 ? "0" + overtime.Minutes : Convert.ToString(overtime.Minutes), overtime.Minutes * 100 / 60);
                }
            }
            else
            {
                from = from.AddHours(8).AddMinutes(currLunchtime);
                if (from.Hour < 20 && from.Day != to.Day )
                {
                    double minutes = 60 - from.Minute;
                    from = from.AddMinutes(minutes);
                    double hoursTo20 = 20 - from.Hour;
                    if (minutes == 60)
                    {
                        minutes = 0;
                        hoursTo20++;
                    }
                    result.AppendFormat("Ö1= {0}:{1}/{0},{2:F0} && ", hoursTo20, minutes < 10 ? "0" + minutes : Convert.ToString(minutes), minutes * 100 / 60);
                    from = from.AddHours(hoursTo20);
                    //By now, "from" is 20:00
                }

                TimeSpan ov2 = to - from;
                result.AppendFormat("Ö2= {0}:{1}/{0},{2:F0}", ov2.Hours, ov2.Minutes < 10 ? "0" + ov2.Minutes : Convert.ToString(ov2.Minutes), ov2.Minutes * 100 / 60);
            }
           

            return result.ToString();
        }

        private void lunchtime_Leave(object sender, EventArgs e)
        {
            try
            {
                currLunchtime = Convert.ToInt32(lunchtime.Text);
                updateResult();
            }
            catch (FormatException) { }
            catch (OverflowException)
            {
                //Do nothing, let validation handle the error
            }

        }

        private void updateResult()
        {

            if (goneHome.Checked)
            {
                departurePicker_ValueChanged(null, null);
            }
            else
            {
                DateTime diff = arrivalPicker.Value;
                diff = diff.AddHours(8);
                diff = diff.AddMinutes(currLunchtime);

                resultLabel.Text = String.Format("You can leave at {0}", diff.ToShortTimeString());
            }
        }

        private void arrivalPicker_ValueChanged(object sender, EventArgs e)
        {
            updateResult();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            WhenCanIGoHome3._5.AboutBox1 aboutB = new WhenCanIGoHome3._5.AboutBox1();
            aboutB.Visible = true;
        }

        private void quitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void lunchtime_TextChanged(object sender, EventArgs e)
        {
            try
            {
                currLunchtime = Convert.ToInt32(lunchtime.Text);
                updateResult();
            }
            catch (FormatException) { }
            catch (OverflowException)
            {
                //Do nothing, let validation handle the error
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            RegistryKey key = Registry.CurrentUser.CreateSubKey(REG_SUBKEY);

            if (key != null)
            {
                key.SetValue(REGKEY_ARRIVALPICKER, arrivalPicker.Value.Ticks);
                //key.SetValue(REGKEY_DEPARTUREPICKER, departurePicker.Value.Ticks);

                //if application is closed with invalid (<30)
                key.SetValue(REGKEY_LUNCH, currLunchtime >= 30 ? currLunchtime : 30);
                
            }
        }

        private void setTimeToNowButton_Click(object sender, EventArgs e)
        {
            arrivalPicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0);
        }

        private void nextDayButton_CheckedChanged(object sender, EventArgs e)
        {
            if (nextDayButton.Checked)
            {
                departurePicker.Value = departurePicker.Value.AddDays(1);
            }
            else
            {
                departurePicker.Value = departurePicker.Value.Subtract(new TimeSpan(24, 0, 0));
            }
            updateResult();
        }
    }
}
