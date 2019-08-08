using System;
using System.Configuration;
using System.Threading;
using System.Windows.Forms;

namespace Geocoder
{
    public partial class Form_Map : Form
    {
        private string ADDRESS;
        private string LAT;
        private string LON;
        private string SOURCE;
        private string URL;

        public Form_Map(string p_SOURCE, string p_LAT, string p_LON, string p_ADDRESS)
        {
            InitializeComponent();

            SOURCE = p_SOURCE;
            LAT = p_LAT;
            LON = p_LON;
            ADDRESS = p_ADDRESS.ToUpper();
        }

        private void Form_Map_Shown(object sender, EventArgs e)
        {
            comboBox_ZOOM.SelectedIndex = 1;
            panel_WAIT.Refresh();
            label_ADDRESS.Text = ADDRESS
                + " (" + LAT + ", " + LON + ")";

            Build_URL(false, "MEDIUM");
            webBrowser_Map.Navigate(URL);
        }

        private void webBrowser_Map_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            Thread.Sleep(1000);
            panel_WAIT.Visible = false;
        }

        private void Reload_Map()
        {
            panel_WAIT.Visible = true;
            panel_WAIT.Refresh();

            if (checkBox_SAT_VIEW.Checked)
                Build_URL(true, comboBox_ZOOM.SelectedItem.ToString());
            else
                Build_URL(false, comboBox_ZOOM.SelectedItem.ToString());

            webBrowser_Map.Navigate(URL);
        }

        private void checkBox_SAT_VIEW_CheckedChanged(object sender, EventArgs e)
        {
            Reload_Map();
        }

        private void Build_URL(bool SAT, string ZOOM)
        {
            int ZOOM_VALUE = 0;

            switch (ZOOM)
            {
                case "HIGH":
                    {
                        ZOOM_VALUE = int.Parse(ConfigurationManager.AppSettings["MapsZoomHigh"]);
                        break;
                    }
                case "MEDIUM":
                    {
                        ZOOM_VALUE = int.Parse(ConfigurationManager.AppSettings["MapsZoomMedium"]);
                        break;
                    }
                case "LOW":
                    {
                        ZOOM_VALUE = int.Parse(ConfigurationManager.AppSettings["MapsZoomLow"]);
                        break;
                    }
            }

            switch (SOURCE)
            {
                case "BING":
                {
                        if (SAT)
                            URL = ConfigurationManager.AppSettings["BingStaticApiAerialURL"];
                        else
                            URL = ConfigurationManager.AppSettings["BingStaticApiStreetURL"];

                        URL += LAT + "," + LON
                                + "/" + ZOOM_VALUE.ToString() + "/?mapSize=640,640&format=png&pushpin="
                                + LAT + "," + LON
                                + ";7;X&key=" + ConfigurationManager.AppSettings["BingApiKey"];
                        break;
                }
                case "GOOGLE": // Google
                    {
                        URL = ConfigurationManager.AppSettings["GoogleStaticApiURL"]
                            + "zoom="+ ZOOM_VALUE + "&size=640x640";

                        if (SAT)
                            URL += "&maptype=hybrid";

                        URL += "&markers=color:red|"
                            + LAT + "," + LON
                            + "&key=" + ConfigurationManager.AppSettings["GoogleApiKey"];
                    break;
                }
            }
        }

        private void comboBox_ZOOM_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reload_Map();
        }
    }
}
