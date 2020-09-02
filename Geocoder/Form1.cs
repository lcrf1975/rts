using System;
using System.Configuration;
using System.Data.Odbc;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Geocoder
{
    public partial class Form_Main : Form
    {
        //private string form_LABEL = "RTS External Geocoder (Beta)";

        private OdbcConnection odbc_CONN;

        private string Access_Driver_Id = ConfigurationManager.AppSettings["Access_Driver_ID"];
        private string Oracle_Driver_Id = ConfigurationManager.AppSettings["Oracle_Driver_ID"];

        private string param_DSN_NAME = ConfigurationManager.AppSettings["Param_DSN_Name"];
        private string param_DSN_PASSWORD = ConfigurationManager.AppSettings["Param_DSN_Password"];
        private string Param_DSN_USER = ConfigurationManager.AppSettings["Param_DSN_User"];     

        private string odbc_ACCESS_DRIVER_ID = ConfigurationManager.AppSettings["Access_Driver_ID"];

        private string sql_CHECK_SCHEMA_VERSION = ConfigurationManager.AppSettings["SQL_Check_SCHEMA_Version"];
        private string sql_MIN_MAX_DATE = ConfigurationManager.AppSettings["SQL_Min_Max_Date"];
        private string sql_COUNT_LOCATIONS = ConfigurationManager.AppSettings["SQL_Count_Locations"];
        private string sql_SELECT_LOCATIONS = ConfigurationManager.AppSettings["SQL_Select_Locations"];
        private string sql_UPDATE_LOCATIONS = ConfigurationManager.AppSettings["SQL_Update_Locations"];
        private string sql_SELECT_REGIONS = ConfigurationManager.AppSettings["SQL_Select_Regions"];
 
        private int param_ADDR_MIN = int.Parse(ConfigurationManager.AppSettings["Address_Min"]);
        private int param_CITY_MIN = int.Parse(ConfigurationManager.AppSettings["City_Min"]);
        private int param_GPS_MIN = int.Parse(ConfigurationManager.AppSettings["GPS_Min"]);
        private int param_POSTAL_CODE_MIN = int.Parse(ConfigurationManager.AppSettings["Postal_Code_Min"]);

        public Form_Main()
        {
            InitializeComponent();
        }

        private bool DSN_Connect()
        {
            odbc_CONN = new System.Data.Odbc.OdbcConnection();
            odbc_CONN.ConnectionString = "DSN=" + param_DSN_NAME
                + ";UID=" + Param_DSN_USER
                + ";Pwd=" + param_DSN_PASSWORD + ";";

            try
            {
                odbc_CONN.Open();

                return true;
            }
            catch (Exception ERROR)
            {
                MessageBox.Show(First_Error(ERROR.Message)
                    , "WARNING"
                    , MessageBoxButtons.OK);

                return false;
            }
        }

        // Check DB Driver Compability
        private void Check_DB_Driver_Id()
        {
            string ODBC_Driver_Id = label_ODBC_DRIVER_VALUE.Text.Substring(0, 3);

            if (ODBC_Driver_Id == Access_Driver_Id)
            {
                MessageBox.Show("Not Compatible DB Engine."
                    , "ERROR"
                    , MessageBoxButtons.OK);

                Environment.Exit(0);
            }
        }

        private string First_Error(string Error_Msg)
        {
            string[] Msg_Result = Error_Msg.Split(new String[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            return Msg_Result[0];
        }

        private void Read_ODBC_Info()
        {
            label_ODBC_DATA_SOURCE_VALUE.Text = odbc_CONN.DataSource.ToUpper();
            label_ODBC_DRIVER_VALUE.Text = odbc_CONN.Driver.ToUpper();
            label_ODBC_SERVER_VERSION_VALUE.Text = odbc_CONN.ServerVersion.ToUpper();
            label_ODBC_DB_NAME_VALUE.Text = 
                label_ODBC_DB_NAME_VALUE.Text.Length > 0 ? odbc_CONN.Database.ToUpper() : "NOT PROVIDED BY THE DRIVER";
            label_ODBC_RTS_SCHEMA_VERSION_VALUE.Text = SCHEMA_Version();
        }

        private string SCHEMA_Version()
        {
            string RESULT = "SCHEMA VERSION ERROR";
            string temp_SQL = Remove_TSDBA(sql_CHECK_SCHEMA_VERSION);

            OdbcCommand odbc_CMD = new OdbcCommand(temp_SQL, odbc_CONN);

            try
            {
                OdbcDataReader odbc_RESULT = odbc_CMD.ExecuteReader();

                if (odbc_RESULT.HasRows)
                {
                    odbc_RESULT.Read();
                    RESULT= odbc_RESULT.GetString(0);
                }

                odbc_RESULT.Close();

                return RESULT;

            }
            catch (Exception ERROR)
            {
                MessageBox.Show(First_Error(ERROR.Message)
                    , "WARNING"
                    , MessageBoxButtons.OK);
                return "SCHEMA VERSION ERROR";
            }
            finally
            {
                odbc_CMD.Dispose();
            }
        }

        private string Remove_TSDBA(string p_SQL)
        {
            string odbc_DRIVER_ID = odbc_CONN.Driver.ToUpper().Substring(0, 3);

            if (odbc_DRIVER_ID == odbc_ACCESS_DRIVER_ID)
            {
                int POS = p_SQL.IndexOf("TSDBA");
                p_SQL = p_SQL.Remove(POS, 6);
            }

            return p_SQL;
        }

        private void Read_Regions()
        {
            string temp_SQL = Remove_TSDBA(sql_SELECT_REGIONS);

            OdbcCommand odbc_CMD = new OdbcCommand(temp_SQL, odbc_CONN);

            try
            {
                OdbcDataReader odbc_RESULT = odbc_CMD.ExecuteReader();

                if (odbc_RESULT.HasRows)
                {
                    while (odbc_RESULT.Read())
                    {
                        comboBox_REGIONS.Items.Add(odbc_RESULT.GetString(0)
                            + " [" + odbc_RESULT.GetString(1) + "]");
                    }

                    comboBox_REGIONS.SelectedIndex = 0;
                }

                odbc_RESULT.Close();
            }
            catch (Exception ERROR)
            {
                MessageBox.Show(First_Error(ERROR.Message)
                    , "WARNING"
                    , MessageBoxButtons.OK);
            }
            finally
            {
                odbc_CMD.Dispose();
            }
        }

        private void DSN_Disconnect()
        {
            try
            {
                odbc_CONN.Close();
            }
            catch (Exception ERROR)
            {
                MessageBox.Show(First_Error(ERROR.Message)
                    , "WARNING"
                    , MessageBoxButtons.OK);
            }
        }

        private void comboBox_REGIONS_SelectedIndexChanged(object sender, EventArgs e)
        {
            Check_Limit();
            Select_Min_Max_Date();
        }

        private void Select_Min_Max_Date()
        {
            string temp_SQL = Remove_TSDBA(sql_MIN_MAX_DATE);
            string[] REGION = comboBox_REGIONS.SelectedItem.ToString().Split('[');

            temp_SQL += " WHERE REGION_ID = '"
                + REGION[0].Trim() + "'";

            OdbcCommand odbc_CMD = new OdbcCommand(temp_SQL, odbc_CONN);

            try
            {
                OdbcDataReader odbc_RESULT = odbc_CMD.ExecuteReader();

                if (odbc_RESULT.HasRows)
                {
                    odbc_RESULT.Read();

                    //dateTimePicker_CREATION_DT_START.MinDate = odbc_RESULT.GetDateTime(0);
                    //dateTimePicker_CREATION_DT_START.MaxDate = odbc_RESULT.GetDateTime(1);

                    //dateTimePicker_CREATION_DT_END.MinDate = odbc_RESULT.GetDateTime(0);
                    //dateTimePicker_CREATION_DT_END.MaxDate = odbc_RESULT.GetDateTime(1);
                    
                    dateTimePicker_CREATION_DT_START.Value = odbc_RESULT.GetDateTime(0);
                    dateTimePicker_CREATION_DT_END.Value = odbc_RESULT.GetDateTime(1);
                }

                odbc_RESULT.Close();
            }
            catch (Exception ERROR)
            {
                MessageBox.Show(First_Error(ERROR.Message)
                    , "WARNING"
                    , MessageBoxButtons.OK);
            }
            finally
            {
                odbc_CMD.Dispose();
            }
        }

        private int Count_Locations (string FILTERS)
        {
            int COUNT = 0;
            string temp_SQL = Remove_TSDBA(sql_COUNT_LOCATIONS);

            temp_SQL += FILTERS;

            OdbcCommand odbc_CMD = new OdbcCommand(temp_SQL, odbc_CONN);

            try
            {
                OdbcDataReader odbc_RESULT = odbc_CMD.ExecuteReader();

                if (odbc_RESULT.HasRows)
                {
                    while (odbc_RESULT.Read())
                    {
                        COUNT = int.Parse(odbc_RESULT.GetString(0));
                    }
                }

                odbc_RESULT.Close();
            }
            catch (Exception ERROR)
            {
                MessageBox.Show(First_Error(ERROR.Message)
                    , "WARNING"
                    , MessageBoxButtons.OK);
            }
            finally
            {
                odbc_CMD.Dispose();
            }

            return COUNT;
        }

        private void button_FILTER_LOCATIONS_Click(object sender, EventArgs e)
        {
            if (comboBox_REGIONS.SelectedIndex >= 0)
            {
                Reset_Form(2);

                string FILTERS = "";
                string temp_SQL = Remove_TSDBA(sql_SELECT_LOCATIONS);
                string[] REGION = comboBox_REGIONS.SelectedItem.ToString().Split('[');
                string[] QUALITY = comboBox_GEOCODE_QUALITY.SelectedItem.ToString().Split('-');

                FILTERS += " and REGION_ID = '"
                    + REGION[0].Trim() + "'";

                QUALITY[0] = QUALITY[0].Trim();
                if (QUALITY[0] != "9999")
                {
                    FILTERS += " and LOCQUALITY = '"
                    + QUALITY[0] + "'";
                }

                FILTERS += " and (DATE_ADDED between ";

                FILTERS += label_ODBC_DRIVER_VALUE.Text.Contains(Oracle_Driver_Id) ? "TO_DATE('" : "'";

                FILTERS += String.Format("{0:yyyy/MM/dd}", dateTimePicker_CREATION_DT_START.Value);

                FILTERS += label_ODBC_DRIVER_VALUE.Text.Contains(Oracle_Driver_Id) ? "', 'yyyy/mm/dd') and TO_DATE('" : "' and '";

                FILTERS += String.Format("{0:yyyy/MM/dd}", dateTimePicker_CREATION_DT_END.Value);

                FILTERS += label_ODBC_DRIVER_VALUE.Text.Contains(Oracle_Driver_Id) ? "', 'yyyy/mm/dd'))" : "')";

                if (checkBox_EXCLUDE_VERIFIED_LOC.Checked)
                {
                    FILTERS += " and GEOCODE_VERIFIED = 'F'";
                }

                panel_WAIT.Visible = true;
                panel_WAIT.Refresh();

                progressBar_WAIT.Minimum = 1;
                progressBar_WAIT.Value = progressBar_WAIT.Minimum;
                progressBar_WAIT.Maximum = Count_Locations(FILTERS);

                int LIMIT = int.Parse(numericUpDown_LIMIT.Value.ToString());

                if (checkBox_LIMIT.Checked
                    && progressBar_WAIT.Maximum > LIMIT)
                {
                    progressBar_WAIT.Maximum = LIMIT;
                }
                
                OdbcCommand odbc_CMD = new OdbcCommand(temp_SQL+ FILTERS, odbc_CONN);

                try
                {
                    OdbcDataReader odbc_RESULT = odbc_CMD.ExecuteReader();

                    if (odbc_RESULT.HasRows)
                    {
                        int COUNT = 0;
                        string BASE = "1";
                        char PAD = '0';
                        double FACTOR = 0.1 / int.Parse(BASE.PadRight(param_GPS_MIN, PAD));

                        int P_QUALITY = 0;
                        string GEO_QUALITY = "";
                        string GEO_SOURCE = "";

                        listView_LOCATIONS.Enabled = true;

                        while (odbc_RESULT.Read()
                            && COUNT < progressBar_WAIT.Maximum)
                        {
                            COUNT++;

                            if (odbc_RESULT.IsDBNull(7))
                                P_QUALITY = 0;
                            else
                                P_QUALITY = Convert.ToInt32(odbc_RESULT.GetValue(7).ToString());

                            GEO_QUALITY = Util.Services.Convert_RTSGeoCodeQuality(P_QUALITY);
                                
                            if (odbc_RESULT.IsDBNull(8))
                                GEO_SOURCE = "R";
                            else
                            {
                                GEO_SOURCE = odbc_RESULT.GetString(8).Trim();
                                GEO_SOURCE = GEO_SOURCE.Length > 0 ? odbc_RESULT.GetString(8).Substring(0, 1) : "R";
                            }
                            
                            listView_LOCATIONS.Items.Add(new ListViewItem(new string[]
                            {
                                "",
                                COUNT.ToString(),
                                odbc_RESULT.GetString(0), // Id
                                odbc_RESULT.IsDBNull(1) ? "" : odbc_RESULT.GetString(1), // Description
                                odbc_RESULT.IsDBNull(2) ? "" : odbc_RESULT.GetString(2), // Address Line 1
                                odbc_RESULT.IsDBNull(3) ? "" : odbc_RESULT.GetString(3), // City
                                odbc_RESULT.IsDBNull(4) ? "" : odbc_RESULT.GetString(4), // State
                                odbc_RESULT.IsDBNull(5) ? "" : odbc_RESULT.GetString(5), // CEP
                                odbc_RESULT.IsDBNull(6) ? "" : odbc_RESULT.GetString(6), // Country
                                GEO_QUALITY, // Quality
                                GEO_SOURCE, // Geocode Source
                                Util.Services.Convert_RTSGeoCodeVerified(odbc_RESULT.IsDBNull(9) ? "" : odbc_RESULT.GetString(9)), // Verified
                                (odbc_RESULT.GetInt32(10) * FACTOR).ToString().Replace(",", "."), // Latitude
                                (odbc_RESULT.GetInt32(11) * FACTOR).ToString().Replace(",", "."), // Longitude                            
                                String.Format("{0:yyyy/MM/dd}", odbc_RESULT.GetDateTime(12)) // Date Added
                            }));

                            progressBar_WAIT.Value = COUNT;
                            progressBar_WAIT.Refresh();
                        }

                        odbc_RESULT.Close();

                        panel_LOCATIONS.Enabled = true;
                        panel_GEOCODE.Enabled = true;
                    }

                    odbc_RESULT.Close();
                }
                catch (Exception ERROR)
                {
                    MessageBox.Show(First_Error(ERROR.Message)
                        , "WARNING"
                        , MessageBoxButtons.OK);
                }
                finally
                {
                    odbc_CMD.Dispose();
                }
 
                panel_WAIT.Visible = false;
            }
        }

        private void listView_LOCATIONS_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0)
            {
                panel_LOCATIONS.Enabled = false;

                for (int COUNT = 0; COUNT < listView_LOCATIONS.Items.Count; COUNT++)
                {
                    listView_LOCATIONS.Items[COUNT].Checked = !listView_LOCATIONS.Items[COUNT].Checked;
                }

                if (listView_LOCATIONS.Items.Count > 0)
                {
                    label_LOCS_SEL_VALUE.Text = listView_LOCATIONS.CheckedItems.Count.ToString();
                    panel_LOCATIONS.Enabled = true;
                }
            }
        }

        private void listView_LOCATIONS_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (panel_LOCATIONS.Enabled)
            {
                label_LOCS_SEL_VALUE.Text = listView_LOCATIONS.CheckedItems.Count.ToString();
                label_LOC_GEO_VALUE.Text = "0";
            }
        }

        private bool Geo_API_Key()
        {
            string MSG = "";
 
            switch (comboBox_SOURCE.SelectedIndex)
            {
                case 0: // Bing
                    {
                        if (ConfigurationManager.AppSettings["BingApiKey"].Trim().Length > 0)
                        {
                            return true;
                        }
                        else
                        {
                            MSG = "Invalid or Null Bing API Key.";
                        }
                        
                        break;
                    }
                case 1: // Google
                    {
                        if (ConfigurationManager.AppSettings["GoogleApiKey"].Trim().Length > 0)
                        {
                            return true;
                        }
                        else
                        {
                            MSG = "Invalid or Null Google API Key.";
                        }

                        break;
                    }
            }

            MessageBox.Show(MSG
                , "WARNING"
                , MessageBoxButtons.OK);

            return false;
        }

        private void button_GEOCODE_LOCATIONS_Click(object sender, EventArgs e)
        {
            if (listView_LOCATIONS.CheckedItems.Count > 0)
            {
                int LAG = 1; // Time to geocode
                TimeSpan TIME_S = TimeSpan.FromSeconds(listView_LOCATIONS.CheckedItems.Count * LAG);
                string TIME_HMS = TIME_S.ToString(@"hh\:mm\:ss\:");

                string MSG = listView_LOCATIONS.CheckedItems.Count.ToString()
                    + " location(s) selected for "
                    + comboBox_SOURCE.Items[comboBox_SOURCE.SelectedIndex].ToString()
                    + " geocoding. The estimate time to process is " + TIME_HMS
                    + ". Proceed?";

                DialogResult RESULT = MessageBox.Show(MSG,
                    "CONFIRMATION",
                    MessageBoxButtons.YesNo);

                if (RESULT == DialogResult.Yes
                    && Geo_API_Key())
                {
                    int GEO_COUNT = 0;
                    string ADDR = "";
                    string NOTE = "";

                    Geo.Services.Location LOC = new Geo.Services.Location();

                    progressBar_WAIT.Minimum = 0;
                    progressBar_WAIT.Value = progressBar_WAIT.Minimum;
                    progressBar_WAIT.Maximum = listView_LOCATIONS.CheckedItems.Count;

                    panel_WAIT.Visible = true;
                    panel_WAIT.Refresh();

                    for (int COUNT = 0; COUNT < listView_LOCATIONS.Items.Count; COUNT++)
                    {
                        if (listView_LOCATIONS.Items[COUNT].Checked)
                        {
                            if (!radioButton_ANY_ADDRESS.Checked
                                    && listView_LOCATIONS.Items[COUNT].SubItems[4].Text.Length >= param_ADDR_MIN
                                    && listView_LOCATIONS.Items[COUNT].SubItems[5].Text.Length >= param_CITY_MIN
                                    && listView_LOCATIONS.Items[COUNT].SubItems[6].Text.Length == 2 // State
                                    && listView_LOCATIONS.Items[COUNT].SubItems[8].Text.Length == 2) // Coutry
                            {
                                ADDR = listView_LOCATIONS.Items[COUNT].SubItems[4].Text + ", " + // Address
                                    listView_LOCATIONS.Items[COUNT].SubItems[5].Text + " - " + // City
                                    listView_LOCATIONS.Items[COUNT].SubItems[6].Text; // State

                                if (listView_LOCATIONS.Items[COUNT].SubItems[7].Text.Length >= param_POSTAL_CODE_MIN)
                                {
                                    ADDR += " " + listView_LOCATIONS.Items[COUNT].SubItems[7].Text; // Postal Code
                                }

                                ADDR += " " + listView_LOCATIONS.Items[COUNT].SubItems[8].Text; // Country

                                NOTE = "";
                            }
                            else
                            {
                                ADDR = "";
                                NOTE = "[ZIP] ";

                                switch (comboBox_SOURCE.SelectedIndex)
                                {
                                    case 0: // Bing
                                        {
                                            if (listView_LOCATIONS.Items[COUNT].SubItems[7].Text.Length >= param_POSTAL_CODE_MIN
                                                    && listView_LOCATIONS.Items[COUNT].SubItems[5].Text.Length >= param_CITY_MIN
                                                    && listView_LOCATIONS.Items[COUNT].SubItems[6].Text.Length == 2 // State
                                                    && listView_LOCATIONS.Items[COUNT].SubItems[8].Text.Length == 2) // Coutry
                                            {
                                                ADDR = listView_LOCATIONS.Items[COUNT].SubItems[5].Text + " - " + // City
                                                    listView_LOCATIONS.Items[COUNT].SubItems[6].Text + " " + // State
                                                    listView_LOCATIONS.Items[COUNT].SubItems[7].Text + " " + // Postal Code
                                                    listView_LOCATIONS.Items[COUNT].SubItems[8].Text; // Country
                                            }
                                            else
                                            {
                                                NOTE = "MISSING DATA";
                                            }

                                            break;
                                        }
                                    case 1: // Google
                                        {
                                            if (listView_LOCATIONS.Items[COUNT].SubItems[7].Text.Length >= param_POSTAL_CODE_MIN
                                                && listView_LOCATIONS.Items[COUNT].SubItems[8].Text.Length == 2) // Country
                                            {
                                                ADDR = listView_LOCATIONS.Items[COUNT].SubItems[7].Text // Postal Code
                                                    + " " + listView_LOCATIONS.Items[COUNT].SubItems[8].Text; // Country
                                            }
                                            else
                                            {
                                                NOTE = "MISSING DATA";
                                            }

                                            break;
                                        }
                                }
                            }

                            if (ADDR.Length > 0)
                            {
                                switch (comboBox_SOURCE.SelectedIndex)
                                {
                                    case 0: // Bing
                                        {
                                            LOC = Geo.Services.Geocode_Bing(ADDR);
                                            break;
                                        }
                                    case 1: // Google
                                        {
                                            LOC = Geo.Services.Geocode_Google(ADDR);
                                            break;
                                        }
                                }

                                LOC.Quality = NOTE + LOC.Quality;
                                listView_LOCATIONS.Items[COUNT].SubItems[10].Text = comboBox_SOURCE.Items[comboBox_SOURCE.SelectedIndex].ToString().Substring(0, 1);
                                listView_LOCATIONS.Items[COUNT].SubItems[12].Text = LOC.Lat.ToString().Replace(",", "."); // LAT
                                listView_LOCATIONS.Items[COUNT].SubItems[13].Text = LOC.Lon.ToString().Replace(",", "."); // LON
                            }
                            else
                            {
                                LOC.Quality = NOTE;
                            }

                            listView_LOCATIONS.Items[COUNT].SubItems[9].Text = LOC.Quality.ToUpper();

                            GEO_COUNT++;

                            label_LOC_GEO_VALUE.Text = GEO_COUNT.ToString();
                            label_LOC_GEO_VALUE.Refresh();

                            progressBar_WAIT.Value = GEO_COUNT;
                            progressBar_WAIT.Refresh();
                        }
                    }

                    if (int.Parse(label_LOC_GEO_VALUE.Text) > 0)
                    {
                        button_SAVE_RTS.Enabled = true;
                    }
                }

                panel_WAIT.Visible = false;
            }
            else
            {
                MessageBox.Show("No Locations Selected For Geocoding."
                    , "WARNING"
                    , MessageBoxButtons.OK);
            }
        }

        private void button_VIEW_MAP_Click(object sender, EventArgs e)
        {
            if ((listView_LOCATIONS.SelectedItems.Count > 0) &&
                    (listView_LOCATIONS.SelectedItems[0].SubItems[12].Text != "0") &&
                    (listView_LOCATIONS.SelectedItems[0].SubItems[13].Text != "0"))
            {
                string LAT = listView_LOCATIONS.SelectedItems[0].SubItems[12].Text;
                string LON = listView_LOCATIONS.SelectedItems[0].SubItems[13].Text;
                string ADDRESS = listView_LOCATIONS.SelectedItems[0].SubItems[4].Text
                    + " " + listView_LOCATIONS.SelectedItems[0].SubItems[5].Text
                    + " - " + listView_LOCATIONS.SelectedItems[0].SubItems[6].Text
                    + " " + listView_LOCATIONS.SelectedItems[0].SubItems[7].Text
                    + " " + listView_LOCATIONS.SelectedItems[0].SubItems[8].Text;

                    Form_Map FORM = new Form_Map(comboBox_SOURCE.SelectedItem.ToString(), LAT, LON, ADDRESS);
                    FORM.ShowDialog();
            }
            else
            {
                MessageBox.Show("Location Not Selected or Not Geocoded."
                    , "WARNING"
                    , MessageBoxButtons.OK);
            }
        }

        private void Reset_Form(int p_LEVEL)
        {
            if (p_LEVEL > 2)
            {
                comboBox_REGIONS.SelectedIndex = 0;
                comboBox_GEOCODE_QUALITY.SelectedIndex = 0;
                checkBox_EXCLUDE_VERIFIED_LOC.Checked = true;
                checkBox_LIMIT.Checked = true;
                numericUpDown_LIMIT.Value = 500;
            }

            if (p_LEVEL > 1)
            {
                comboBox_SOURCE.SelectedIndex = 0;
                label_LOCS_SEL_VALUE.Text = "0";
                label_LOC_GEO_VALUE.Text = "0";
                radioButton_BAD_ADDRESS.Checked = true;
                panel_GEOCODE.Enabled = false;
            }

            if (p_LEVEL > 0)
            {
                listView_LOCATIONS.Items.Clear();
                panel_LOCATIONS.Enabled = false;
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void button_RESET_Click(object sender, EventArgs e)
        {
            Reset_Form(3);
        }

        private string Fix_LAT_LON (string p_VALUE)
        {
            string DIFF = "";
            string[] COORD = p_VALUE.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

            if (COORD.Length > 1)
            {
                if (COORD[1].Length > param_GPS_MIN)
                {
                    DIFF = COORD[1].Substring(0, param_GPS_MIN);
                }
                else
                {
                    DIFF = COORD[1].Substring(0, COORD[1].Length);
                    for (int COUNT = 0; COUNT < (param_GPS_MIN - COORD[1].Length); COUNT++)
                    {
                        DIFF += "0";
                    }
                }
            }

            return COORD[0] + DIFF;
        }

        private bool Save_Location (string p_LAT, string p_LON, string p_QUALITY, string p_INFO, string p_ID)
        {
            string temp_SQL = Remove_TSDBA(sql_UPDATE_LOCATIONS);

            p_LAT = Fix_LAT_LON(p_LAT);
            p_LON = Fix_LAT_LON(p_LON);

            temp_SQL += " set LATITUDE ='" + p_LAT
                + "', LONGITUDE = '" + p_LON
                + "', LOCQUALITY = '" + p_QUALITY
                + "', ALTERNATE_CONTACT = '" + p_INFO
                + "' WHERE ID = '" + p_ID + "'";

            OdbcCommand odbc_CMD = new OdbcCommand(temp_SQL, odbc_CONN);

            try
            {
                odbc_CMD.ExecuteNonQuery();

                return true;
            }
            catch (Exception ERROR)
            {
                MessageBox.Show(ERROR.Message
                    , "WARNING"
                    , MessageBoxButtons.OK);

                return false;
            }
            finally
            {
                odbc_CMD.Dispose();
            }
        }

        private void button_SAVE_RTS_Click(object sender, EventArgs e)
        {
            if (listView_LOCATIONS.Items.Count > 0)
            {
                progressBar_WAIT.Minimum = 0;
                progressBar_WAIT.Value = progressBar_WAIT.Minimum;
                progressBar_WAIT.Maximum = listView_LOCATIONS.CheckedItems.Count;

                int progressBar_COUNT = 0;

                panel_WAIT.Visible = true;
                panel_WAIT.Refresh();

                for (int COUNT = 0; COUNT < listView_LOCATIONS.Items.Count; COUNT++)
                {
                    if (listView_LOCATIONS.Items[COUNT].Checked
                        && listView_LOCATIONS.Items[COUNT].SubItems[10].Text != "R") // Geocoded
                    {
                        if (Save_Location(listView_LOCATIONS.Items[COUNT].SubItems[12].Text, // LAT
                            listView_LOCATIONS.Items[COUNT].SubItems[13].Text, // LON
                            "9003", // QUALITY - USER SUPPLIED
                            (listView_LOCATIONS.Items[COUNT].SubItems[10].Text == "B") ? "BING" : "GOOGLE"                      
                                + " - " + listView_LOCATIONS.Items[COUNT].SubItems[9].Text, // SOURCE + QUALITY
                            listView_LOCATIONS.Items[COUNT].SubItems[2].Text)) // ID
                        {
                            listView_LOCATIONS.Items[COUNT].Checked = false;
                        }

                        progressBar_COUNT++;
                    }

                    progressBar_WAIT.Value = progressBar_COUNT;
                    progressBar_WAIT.Refresh();
                }

                button_SAVE_RTS.Enabled = false;
            }
            else
            {
                MessageBox.Show("No Location Selected For Save."
                    , "WARNING"
                    , MessageBoxButtons.OK);
            }

            panel_WAIT.Visible = false;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Options FORM = new Form_Options();
            FORM.ShowDialog();
        }

        private void Check_Limit()
        {
            string[] REGION = comboBox_REGIONS.SelectedItem.ToString().Split('[');
            string SIZE = REGION[1].Substring(0, REGION[1].Length - 1);

            if (checkBox_LIMIT.Checked)
            {
                numericUpDown_LIMIT.Enabled = true;
            }
            else
            {
                numericUpDown_LIMIT.Enabled = false;

                if (int.Parse(SIZE) > 5000)
                {
                    MessageBox.Show("Region [" + REGION[0] + "] Has " + SIZE
                        + " Locations. The Filter Operation Will Take a Long Time to Complete."
                        , "WARNING"
                        , MessageBoxButtons.OK);
                }
            }
        }

        private void checkBox_LIMIT_CheckedChanged(object sender, EventArgs e)
        {
            Check_Limit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_About FORM = new Form_About();
            FORM.ShowDialog();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            CultureInfo NewCultureInfo = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            NewCultureInfo.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            Thread.CurrentThread.CurrentCulture = NewCultureInfo;

            if (DSN_Connect())
            {
                Global.Options_Saved = false;
                Read_ODBC_Info();
                Check_DB_Driver_Id();
                panel_FILTER.Enabled = true;
                Read_Regions();
                comboBox_GEOCODE_QUALITY.SelectedIndex = 0;
                comboBox_SOURCE.SelectedIndex = 0;
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            DSN_Disconnect();
            Application.Exit();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult RESULT = MessageBox.Show("Closed Application?",
                "CONFIRMATION",
                MessageBoxButtons.YesNo);

            if (RESULT == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form_Main_Shown(object sender, EventArgs e)
        {
            Check_License(false);
        }

        public void Check_License(bool RESET)
        {
            if (RESET)
                Reset_Form(3);

            //this.Text = form_LABEL;
            panel_FILTER.Enabled = false;

            string KEY = ConfigurationManager.AppSettings["LicenseKey"].Trim();

            if (KEY.Length == 64)
            {
                DateTime EXP_DT = Convert.ToDateTime (Util.Services.Decrypt(KEY));

                DateTime TODAY = DateTime.Today;
                DateTime SYS_DT = DateTime.Today;

                string temp_SQL = Remove_TSDBA(sql_MIN_MAX_DATE);

                OdbcCommand odbc_CMD = new OdbcCommand(temp_SQL, odbc_CONN);

                try
                {
                    OdbcDataReader odbc_RESULT = odbc_CMD.ExecuteReader();

                    if (odbc_RESULT.HasRows)
                    {
                        odbc_RESULT.Read();
                        if (!odbc_RESULT.IsDBNull(1))
                        {
                            SYS_DT = odbc_RESULT.GetDateTime(1);
                        }  
                    }

                    odbc_RESULT.Close();
                }
                catch (Exception ERROR)
                {
                    MessageBox.Show(First_Error(ERROR.Message)
                        , "ERROR"
                        , MessageBoxButtons.OK);

                    Environment.Exit(0);
                }
                finally
                {
                    odbc_CMD.Dispose();
                }

                if (EXP_DT < TODAY
                    || EXP_DT < SYS_DT)
                {
                   this.Text += " - License Expired";

                    MessageBox.Show("License Expired on "
                        + EXP_DT.ToShortDateString() + ". Contact Omnitracs Support."
                        , "WARNING"
                        , MessageBoxButtons.OK);
                }
                else
                {
                    panel_FILTER.Enabled = true;
                }
            }
            else
            {
                this.Text += " - Invalid License";

                MessageBox.Show("Invalid License Key.Contact Omnitracs Support."
                    , "ERROR"
                    , MessageBoxButtons.OK);
            }
        }

        private void timer_Check_License_Tick(object sender, EventArgs e)
        {
            if (Global.Options_Saved)
            {
                Global.Options_Saved = false;
                Check_License(true);
            }
        }
    }
}