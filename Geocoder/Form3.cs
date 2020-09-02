using System;
using System.Configuration;
using System.Windows.Forms;

namespace Geocoder
{
    public partial class Form_Options : Form
    {
        private Configuration CONFIG = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
        private string OLD_LIC = ConfigurationManager.AppSettings["LicenseKey"];
 
        public Form_Options()
        {
            InitializeComponent();
        }   

        private void Form_Options_Shown(object sender, EventArgs e)
        {
            textBox_License_Key.Text = OLD_LIC;
            label_Exp_Date.Text = Util.Services.Decrypt(textBox_License_Key.Text);
            textBox_Bing_API_Key.Text = ConfigurationManager.AppSettings["BingApiKey"];
            textBox_Google_API_Key.Text = ConfigurationManager.AppSettings["GoogleApiKey"];
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            CONFIG.AppSettings.Settings["LicenseKey"].Value = textBox_License_Key.Text.Trim();
            CONFIG.AppSettings.Settings["BingApiKey"].Value = textBox_Bing_API_Key.Text.Trim();
            CONFIG.AppSettings.Settings["GoogleApiKey"].Value = textBox_Google_API_Key.Text.Trim();
            CONFIG.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");

            if (textBox_License_Key.Text.Trim() != OLD_LIC)
                Global.Options_Saved = true;

            this.Close();
        }

        private void textBox_License_Key_TextChanged(object sender, EventArgs e)
        {
            label_Exp_Date.Text = Util.Services.Decrypt(textBox_License_Key.Text);
        }
    }
}