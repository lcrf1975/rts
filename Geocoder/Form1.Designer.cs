namespace Geocoder
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.listView_LOCATIONS = new System.Windows.Forms.ListView();
            this.columnHeader_SEL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_COUNT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_DESC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_ADDR_LINE1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_CITY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_STATE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_POSTAL_CODE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_COUNTRY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_QUALITY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_SOURCE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_VERIFIED = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_LAT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_LON = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_CREATION_DATE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkBox_EXCLUDE_VERIFIED_LOC = new System.Windows.Forms.CheckBox();
            this.dateTimePicker_CREATION_DT_END = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_CREATION_DT_START = new System.Windows.Forms.DateTimePicker();
            this.label_CREATION_DATE = new System.Windows.Forms.Label();
            this.comboBox_GEOCODE_QUALITY = new System.Windows.Forms.ComboBox();
            this.label_GEOCODE_QUALITY = new System.Windows.Forms.Label();
            this.label_LOCATIONS = new System.Windows.Forms.Label();
            this.button_FILTER_LOCATIONS = new System.Windows.Forms.Button();
            this.comboBox_REGIONS = new System.Windows.Forms.ComboBox();
            this.label_REGION = new System.Windows.Forms.Label();
            this.panel_FILTER = new System.Windows.Forms.Panel();
            this.numericUpDown_LIMIT = new System.Windows.Forms.NumericUpDown();
            this.checkBox_LIMIT = new System.Windows.Forms.CheckBox();
            this.label_ODBC_DB_NAME = new System.Windows.Forms.Label();
            this.label_ODBC_DB_NAME_VALUE = new System.Windows.Forms.Label();
            this.label_ODBC_RTS_SCHEMA_VERSION = new System.Windows.Forms.Label();
            this.label_ODBC_SERVER_VERSION = new System.Windows.Forms.Label();
            this.label_ODBC_DRIVER = new System.Windows.Forms.Label();
            this.label_ODBC_DATA_SOURCE = new System.Windows.Forms.Label();
            this.label_ODBC_SERVER_VERSION_VALUE = new System.Windows.Forms.Label();
            this.label_ODBC_RTS_SCHEMA_VERSION_VALUE = new System.Windows.Forms.Label();
            this.label_ODBC_DRIVER_VALUE = new System.Windows.Forms.Label();
            this.label_ODBC_DATA_SOURCE_VALUE = new System.Windows.Forms.Label();
            this.panel_LOCATIONS = new System.Windows.Forms.Panel();
            this.button_RESET = new System.Windows.Forms.Button();
            this.panel_WAIT = new System.Windows.Forms.Panel();
            this.progressBar_WAIT = new System.Windows.Forms.ProgressBar();
            this.pictureBox_WAIT = new System.Windows.Forms.PictureBox();
            this.button_VIEW_MAP = new System.Windows.Forms.Button();
            this.button_SAVE_RTS = new System.Windows.Forms.Button();
            this.panel_ODBC = new System.Windows.Forms.Panel();
            this.panel_GEOCODE = new System.Windows.Forms.Panel();
            this.radioButton_ANY_ADDRESS = new System.Windows.Forms.RadioButton();
            this.radioButton_BAD_ADDRESS = new System.Windows.Forms.RadioButton();
            this.label_LOC_GEO_VALUE = new System.Windows.Forms.Label();
            this.label_LOC_GEO = new System.Windows.Forms.Label();
            this.button_GEOCODE_LOCATIONS = new System.Windows.Forms.Button();
            this.label_LOCS_SEL_VALUE = new System.Windows.Forms.Label();
            this.label_LOCS_SEL = new System.Windows.Forms.Label();
            this.comboBox_SOURCE = new System.Windows.Forms.ComboBox();
            this.label_SOURCE = new System.Windows.Forms.Label();
            this.panel_LOGO = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_LOGO = new System.Windows.Forms.PictureBox();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_Check_License = new System.Windows.Forms.Timer(this.components);
            this.panel_FILTER.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LIMIT)).BeginInit();
            this.panel_LOCATIONS.SuspendLayout();
            this.panel_WAIT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_WAIT)).BeginInit();
            this.panel_ODBC.SuspendLayout();
            this.panel_GEOCODE.SuspendLayout();
            this.panel_LOGO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LOGO)).BeginInit();
            this.menuStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_LOCATIONS
            // 
            this.listView_LOCATIONS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_LOCATIONS.CheckBoxes = true;
            this.listView_LOCATIONS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_SEL,
            this.columnHeader_COUNT,
            this.columnHeader_ID,
            this.columnHeader_DESC,
            this.columnHeader_ADDR_LINE1,
            this.columnHeader_CITY,
            this.columnHeader_STATE,
            this.columnHeader_POSTAL_CODE,
            this.columnHeader_COUNTRY,
            this.columnHeader_QUALITY,
            this.columnHeader_SOURCE,
            this.columnHeader_VERIFIED,
            this.columnHeader_LAT,
            this.columnHeader_LON,
            this.columnHeader_CREATION_DATE});
            this.listView_LOCATIONS.FullRowSelect = true;
            this.listView_LOCATIONS.LabelWrap = false;
            this.listView_LOCATIONS.Location = new System.Drawing.Point(5, 19);
            this.listView_LOCATIONS.MultiSelect = false;
            this.listView_LOCATIONS.Name = "listView_LOCATIONS";
            this.listView_LOCATIONS.ShowGroups = false;
            this.listView_LOCATIONS.Size = new System.Drawing.Size(1228, 411);
            this.listView_LOCATIONS.TabIndex = 1;
            this.listView_LOCATIONS.UseCompatibleStateImageBehavior = false;
            this.listView_LOCATIONS.View = System.Windows.Forms.View.Details;
            this.listView_LOCATIONS.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_LOCATIONS_ColumnClick);
            this.listView_LOCATIONS.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView_LOCATIONS_ItemChecked);
            // 
            // columnHeader_SEL
            // 
            this.columnHeader_SEL.Text = "";
            this.columnHeader_SEL.Width = 18;
            // 
            // columnHeader_COUNT
            // 
            this.columnHeader_COUNT.Text = "#";
            this.columnHeader_COUNT.Width = 45;
            // 
            // columnHeader_ID
            // 
            this.columnHeader_ID.Text = "ID";
            this.columnHeader_ID.Width = 80;
            // 
            // columnHeader_DESC
            // 
            this.columnHeader_DESC.Text = "DESCRIPTION";
            this.columnHeader_DESC.Width = 160;
            // 
            // columnHeader_ADDR_LINE1
            // 
            this.columnHeader_ADDR_LINE1.Text = "ADDRESS (LINE1)";
            this.columnHeader_ADDR_LINE1.Width = 252;
            // 
            // columnHeader_CITY
            // 
            this.columnHeader_CITY.Text = "City";
            this.columnHeader_CITY.Width = 136;
            // 
            // columnHeader_STATE
            // 
            this.columnHeader_STATE.Text = "ST";
            this.columnHeader_STATE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_STATE.Width = 30;
            // 
            // columnHeader_POSTAL_CODE
            // 
            this.columnHeader_POSTAL_CODE.Text = "POSTAL";
            // 
            // columnHeader_COUNTRY
            // 
            this.columnHeader_COUNTRY.Text = "CTRY";
            this.columnHeader_COUNTRY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_COUNTRY.Width = 42;
            // 
            // columnHeader_QUALITY
            // 
            this.columnHeader_QUALITY.Text = "QUALITY";
            this.columnHeader_QUALITY.Width = 128;
            // 
            // columnHeader_SOURCE
            // 
            this.columnHeader_SOURCE.Tag = "";
            this.columnHeader_SOURCE.Text = "S";
            this.columnHeader_SOURCE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_SOURCE.Width = 21;
            // 
            // columnHeader_VERIFIED
            // 
            this.columnHeader_VERIFIED.Text = "V";
            this.columnHeader_VERIFIED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_VERIFIED.Width = 22;
            // 
            // columnHeader_LAT
            // 
            this.columnHeader_LAT.Text = "LAT";
            this.columnHeader_LAT.Width = 72;
            // 
            // columnHeader_LON
            // 
            this.columnHeader_LON.Text = "LON";
            this.columnHeader_LON.Width = 72;
            // 
            // columnHeader_CREATION_DATE
            // 
            this.columnHeader_CREATION_DATE.Text = "CR DATE";
            this.columnHeader_CREATION_DATE.Width = 70;
            // 
            // checkBox_EXCLUDE_VERIFIED_LOC
            // 
            this.checkBox_EXCLUDE_VERIFIED_LOC.AutoSize = true;
            this.checkBox_EXCLUDE_VERIFIED_LOC.Checked = true;
            this.checkBox_EXCLUDE_VERIFIED_LOC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_EXCLUDE_VERIFIED_LOC.Location = new System.Drawing.Point(5, 124);
            this.checkBox_EXCLUDE_VERIFIED_LOC.Name = "checkBox_EXCLUDE_VERIFIED_LOC";
            this.checkBox_EXCLUDE_VERIFIED_LOC.Size = new System.Drawing.Size(151, 17);
            this.checkBox_EXCLUDE_VERIFIED_LOC.TabIndex = 7;
            this.checkBox_EXCLUDE_VERIFIED_LOC.Text = "Exclude Verified Locations";
            this.checkBox_EXCLUDE_VERIFIED_LOC.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_CREATION_DT_END
            // 
            this.dateTimePicker_CREATION_DT_END.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_CREATION_DT_END.Location = new System.Drawing.Point(129, 98);
            this.dateTimePicker_CREATION_DT_END.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_CREATION_DT_END.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_CREATION_DT_END.Name = "dateTimePicker_CREATION_DT_END";
            this.dateTimePicker_CREATION_DT_END.Size = new System.Drawing.Size(117, 20);
            this.dateTimePicker_CREATION_DT_END.TabIndex = 6;
            // 
            // dateTimePicker_CREATION_DT_START
            // 
            this.dateTimePicker_CREATION_DT_START.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_CREATION_DT_START.Location = new System.Drawing.Point(5, 98);
            this.dateTimePicker_CREATION_DT_START.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_CREATION_DT_START.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_CREATION_DT_START.Name = "dateTimePicker_CREATION_DT_START";
            this.dateTimePicker_CREATION_DT_START.Size = new System.Drawing.Size(117, 20);
            this.dateTimePicker_CREATION_DT_START.TabIndex = 5;
            // 
            // label_CREATION_DATE
            // 
            this.label_CREATION_DATE.AutoSize = true;
            this.label_CREATION_DATE.Location = new System.Drawing.Point(5, 82);
            this.label_CREATION_DATE.Name = "label_CREATION_DATE";
            this.label_CREATION_DATE.Size = new System.Drawing.Size(75, 13);
            this.label_CREATION_DATE.TabIndex = 4;
            this.label_CREATION_DATE.Text = "Creation Date:";
            // 
            // comboBox_GEOCODE_QUALITY
            // 
            this.comboBox_GEOCODE_QUALITY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_GEOCODE_QUALITY.FormattingEnabled = true;
            this.comboBox_GEOCODE_QUALITY.Items.AddRange(new object[] {
            "0000 - NOT GEOCODED",
            "5601 - STREET EXACT",
            "5501 - HIGH CONFIDENCE",
            "5401 - MEDIUM CONFIDENCE",
            "5301 - LOW CONFIDENCE",
            "5201 - AMBIGUOUS STREET",
            "5001 - AUTO STREET",
            "5100 - MANUAL STREET",
            "5200 - AUTO CROSS STREET",
            "9001 - SELF GEOCODED",
            "9003 - USER SUPPLIED",
            "9004 - GPS",
            "1001 - POSTAL",
            "1004 - POSTAL EXTENDED",
            "1005 - CITY GEOCODED",
            "9999 - ALL"});
            this.comboBox_GEOCODE_QUALITY.Location = new System.Drawing.Point(5, 59);
            this.comboBox_GEOCODE_QUALITY.Name = "comboBox_GEOCODE_QUALITY";
            this.comboBox_GEOCODE_QUALITY.Size = new System.Drawing.Size(241, 21);
            this.comboBox_GEOCODE_QUALITY.TabIndex = 3;
            // 
            // label_GEOCODE_QUALITY
            // 
            this.label_GEOCODE_QUALITY.AutoSize = true;
            this.label_GEOCODE_QUALITY.Location = new System.Drawing.Point(5, 43);
            this.label_GEOCODE_QUALITY.Name = "label_GEOCODE_QUALITY";
            this.label_GEOCODE_QUALITY.Size = new System.Drawing.Size(89, 13);
            this.label_GEOCODE_QUALITY.TabIndex = 2;
            this.label_GEOCODE_QUALITY.Text = "Geocode Quality:";
            // 
            // label_LOCATIONS
            // 
            this.label_LOCATIONS.AutoSize = true;
            this.label_LOCATIONS.Location = new System.Drawing.Point(5, 3);
            this.label_LOCATIONS.Name = "label_LOCATIONS";
            this.label_LOCATIONS.Size = new System.Drawing.Size(56, 13);
            this.label_LOCATIONS.TabIndex = 0;
            this.label_LOCATIONS.Text = "Locations:";
            // 
            // button_FILTER_LOCATIONS
            // 
            this.button_FILTER_LOCATIONS.Location = new System.Drawing.Point(5, 179);
            this.button_FILTER_LOCATIONS.Name = "button_FILTER_LOCATIONS";
            this.button_FILTER_LOCATIONS.Size = new System.Drawing.Size(241, 23);
            this.button_FILTER_LOCATIONS.TabIndex = 8;
            this.button_FILTER_LOCATIONS.Text = "FILTER LOCATIONS";
            this.button_FILTER_LOCATIONS.UseVisualStyleBackColor = true;
            this.button_FILTER_LOCATIONS.Click += new System.EventHandler(this.button_FILTER_LOCATIONS_Click);
            // 
            // comboBox_REGIONS
            // 
            this.comboBox_REGIONS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_REGIONS.FormattingEnabled = true;
            this.comboBox_REGIONS.Location = new System.Drawing.Point(5, 20);
            this.comboBox_REGIONS.Name = "comboBox_REGIONS";
            this.comboBox_REGIONS.Size = new System.Drawing.Size(241, 21);
            this.comboBox_REGIONS.TabIndex = 1;
            this.comboBox_REGIONS.SelectedIndexChanged += new System.EventHandler(this.comboBox_REGIONS_SelectedIndexChanged);
            // 
            // label_REGION
            // 
            this.label_REGION.AutoSize = true;
            this.label_REGION.Location = new System.Drawing.Point(5, 3);
            this.label_REGION.Name = "label_REGION";
            this.label_REGION.Size = new System.Drawing.Size(44, 13);
            this.label_REGION.TabIndex = 0;
            this.label_REGION.Text = "Region:";
            // 
            // panel_FILTER
            // 
            this.panel_FILTER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_FILTER.Controls.Add(this.numericUpDown_LIMIT);
            this.panel_FILTER.Controls.Add(this.checkBox_LIMIT);
            this.panel_FILTER.Controls.Add(this.checkBox_EXCLUDE_VERIFIED_LOC);
            this.panel_FILTER.Controls.Add(this.dateTimePicker_CREATION_DT_END);
            this.panel_FILTER.Controls.Add(this.dateTimePicker_CREATION_DT_START);
            this.panel_FILTER.Controls.Add(this.label_CREATION_DATE);
            this.panel_FILTER.Controls.Add(this.comboBox_GEOCODE_QUALITY);
            this.panel_FILTER.Controls.Add(this.label_GEOCODE_QUALITY);
            this.panel_FILTER.Controls.Add(this.button_FILTER_LOCATIONS);
            this.panel_FILTER.Controls.Add(this.comboBox_REGIONS);
            this.panel_FILTER.Controls.Add(this.label_REGION);
            this.panel_FILTER.Enabled = false;
            this.panel_FILTER.Location = new System.Drawing.Point(277, 25);
            this.panel_FILTER.Name = "panel_FILTER";
            this.panel_FILTER.Size = new System.Drawing.Size(254, 208);
            this.panel_FILTER.TabIndex = 1;
            // 
            // numericUpDown_LIMIT
            // 
            this.numericUpDown_LIMIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_LIMIT.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_LIMIT.Location = new System.Drawing.Point(129, 140);
            this.numericUpDown_LIMIT.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown_LIMIT.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_LIMIT.Name = "numericUpDown_LIMIT";
            this.numericUpDown_LIMIT.Size = new System.Drawing.Size(117, 20);
            this.numericUpDown_LIMIT.TabIndex = 10;
            this.numericUpDown_LIMIT.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // checkBox_LIMIT
            // 
            this.checkBox_LIMIT.AutoSize = true;
            this.checkBox_LIMIT.Checked = true;
            this.checkBox_LIMIT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_LIMIT.Location = new System.Drawing.Point(5, 143);
            this.checkBox_LIMIT.Name = "checkBox_LIMIT";
            this.checkBox_LIMIT.Size = new System.Drawing.Size(121, 17);
            this.checkBox_LIMIT.TabIndex = 9;
            this.checkBox_LIMIT.Text = "Filter Locations Limit";
            this.checkBox_LIMIT.UseVisualStyleBackColor = true;
            this.checkBox_LIMIT.CheckedChanged += new System.EventHandler(this.checkBox_LIMIT_CheckedChanged);
            // 
            // label_ODBC_DB_NAME
            // 
            this.label_ODBC_DB_NAME.AutoSize = true;
            this.label_ODBC_DB_NAME.Location = new System.Drawing.Point(5, 120);
            this.label_ODBC_DB_NAME.Name = "label_ODBC_DB_NAME";
            this.label_ODBC_DB_NAME.Size = new System.Drawing.Size(87, 13);
            this.label_ODBC_DB_NAME.TabIndex = 6;
            this.label_ODBC_DB_NAME.Text = "Database Name:";
            // 
            // label_ODBC_DB_NAME_VALUE
            // 
            this.label_ODBC_DB_NAME_VALUE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_ODBC_DB_NAME_VALUE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_ODBC_DB_NAME_VALUE.Location = new System.Drawing.Point(5, 136);
            this.label_ODBC_DB_NAME_VALUE.Name = "label_ODBC_DB_NAME_VALUE";
            this.label_ODBC_DB_NAME_VALUE.Size = new System.Drawing.Size(241, 20);
            this.label_ODBC_DB_NAME_VALUE.TabIndex = 7;
            this.label_ODBC_DB_NAME_VALUE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_ODBC_RTS_SCHEMA_VERSION
            // 
            this.label_ODBC_RTS_SCHEMA_VERSION.AutoSize = true;
            this.label_ODBC_RTS_SCHEMA_VERSION.Location = new System.Drawing.Point(5, 162);
            this.label_ODBC_RTS_SCHEMA_VERSION.Name = "label_ODBC_RTS_SCHEMA_VERSION";
            this.label_ODBC_RTS_SCHEMA_VERSION.Size = new System.Drawing.Size(112, 13);
            this.label_ODBC_RTS_SCHEMA_VERSION.TabIndex = 8;
            this.label_ODBC_RTS_SCHEMA_VERSION.Text = "RTS Schema Version:";
            // 
            // label_ODBC_SERVER_VERSION
            // 
            this.label_ODBC_SERVER_VERSION.AutoSize = true;
            this.label_ODBC_SERVER_VERSION.Location = new System.Drawing.Point(5, 81);
            this.label_ODBC_SERVER_VERSION.Name = "label_ODBC_SERVER_VERSION";
            this.label_ODBC_SERVER_VERSION.Size = new System.Drawing.Size(79, 13);
            this.label_ODBC_SERVER_VERSION.TabIndex = 4;
            this.label_ODBC_SERVER_VERSION.Text = "Server Version:";
            // 
            // label_ODBC_DRIVER
            // 
            this.label_ODBC_DRIVER.AutoSize = true;
            this.label_ODBC_DRIVER.Location = new System.Drawing.Point(5, 42);
            this.label_ODBC_DRIVER.Name = "label_ODBC_DRIVER";
            this.label_ODBC_DRIVER.Size = new System.Drawing.Size(38, 13);
            this.label_ODBC_DRIVER.TabIndex = 2;
            this.label_ODBC_DRIVER.Text = "Driver:";
            // 
            // label_ODBC_DATA_SOURCE
            // 
            this.label_ODBC_DATA_SOURCE.AutoSize = true;
            this.label_ODBC_DATA_SOURCE.Location = new System.Drawing.Point(5, 3);
            this.label_ODBC_DATA_SOURCE.Name = "label_ODBC_DATA_SOURCE";
            this.label_ODBC_DATA_SOURCE.Size = new System.Drawing.Size(70, 13);
            this.label_ODBC_DATA_SOURCE.TabIndex = 0;
            this.label_ODBC_DATA_SOURCE.Text = "Data Source:";
            // 
            // label_ODBC_SERVER_VERSION_VALUE
            // 
            this.label_ODBC_SERVER_VERSION_VALUE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_ODBC_SERVER_VERSION_VALUE.Location = new System.Drawing.Point(5, 97);
            this.label_ODBC_SERVER_VERSION_VALUE.Name = "label_ODBC_SERVER_VERSION_VALUE";
            this.label_ODBC_SERVER_VERSION_VALUE.Size = new System.Drawing.Size(241, 20);
            this.label_ODBC_SERVER_VERSION_VALUE.TabIndex = 5;
            this.label_ODBC_SERVER_VERSION_VALUE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_ODBC_RTS_SCHEMA_VERSION_VALUE
            // 
            this.label_ODBC_RTS_SCHEMA_VERSION_VALUE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_ODBC_RTS_SCHEMA_VERSION_VALUE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_ODBC_RTS_SCHEMA_VERSION_VALUE.Location = new System.Drawing.Point(5, 178);
            this.label_ODBC_RTS_SCHEMA_VERSION_VALUE.Name = "label_ODBC_RTS_SCHEMA_VERSION_VALUE";
            this.label_ODBC_RTS_SCHEMA_VERSION_VALUE.Size = new System.Drawing.Size(241, 20);
            this.label_ODBC_RTS_SCHEMA_VERSION_VALUE.TabIndex = 9;
            this.label_ODBC_RTS_SCHEMA_VERSION_VALUE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_ODBC_DRIVER_VALUE
            // 
            this.label_ODBC_DRIVER_VALUE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_ODBC_DRIVER_VALUE.Location = new System.Drawing.Point(5, 58);
            this.label_ODBC_DRIVER_VALUE.Name = "label_ODBC_DRIVER_VALUE";
            this.label_ODBC_DRIVER_VALUE.Size = new System.Drawing.Size(241, 20);
            this.label_ODBC_DRIVER_VALUE.TabIndex = 3;
            this.label_ODBC_DRIVER_VALUE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_ODBC_DATA_SOURCE_VALUE
            // 
            this.label_ODBC_DATA_SOURCE_VALUE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_ODBC_DATA_SOURCE_VALUE.Location = new System.Drawing.Point(5, 19);
            this.label_ODBC_DATA_SOURCE_VALUE.Name = "label_ODBC_DATA_SOURCE_VALUE";
            this.label_ODBC_DATA_SOURCE_VALUE.Size = new System.Drawing.Size(241, 20);
            this.label_ODBC_DATA_SOURCE_VALUE.TabIndex = 1;
            this.label_ODBC_DATA_SOURCE_VALUE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_LOCATIONS
            // 
            this.panel_LOCATIONS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_LOCATIONS.Controls.Add(this.button_RESET);
            this.panel_LOCATIONS.Controls.Add(this.panel_WAIT);
            this.panel_LOCATIONS.Controls.Add(this.button_VIEW_MAP);
            this.panel_LOCATIONS.Controls.Add(this.button_SAVE_RTS);
            this.panel_LOCATIONS.Controls.Add(this.listView_LOCATIONS);
            this.panel_LOCATIONS.Controls.Add(this.label_LOCATIONS);
            this.panel_LOCATIONS.Enabled = false;
            this.panel_LOCATIONS.Location = new System.Drawing.Point(12, 245);
            this.panel_LOCATIONS.Name = "panel_LOCATIONS";
            this.panel_LOCATIONS.Size = new System.Drawing.Size(1240, 467);
            this.panel_LOCATIONS.TabIndex = 3;
            // 
            // button_RESET
            // 
            this.button_RESET.Location = new System.Drawing.Point(5, 436);
            this.button_RESET.Name = "button_RESET";
            this.button_RESET.Size = new System.Drawing.Size(240, 23);
            this.button_RESET.TabIndex = 2;
            this.button_RESET.Text = "RESET";
            this.button_RESET.UseVisualStyleBackColor = true;
            this.button_RESET.Click += new System.EventHandler(this.button_RESET_Click);
            // 
            // panel_WAIT
            // 
            this.panel_WAIT.BackColor = System.Drawing.SystemColors.Control;
            this.panel_WAIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_WAIT.Controls.Add(this.progressBar_WAIT);
            this.panel_WAIT.Controls.Add(this.pictureBox_WAIT);
            this.panel_WAIT.Location = new System.Drawing.Point(553, 160);
            this.panel_WAIT.Name = "panel_WAIT";
            this.panel_WAIT.Size = new System.Drawing.Size(132, 154);
            this.panel_WAIT.TabIndex = 5;
            this.panel_WAIT.Visible = false;
            // 
            // progressBar_WAIT
            // 
            this.progressBar_WAIT.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar_WAIT.Location = new System.Drawing.Point(1, 128);
            this.progressBar_WAIT.Name = "progressBar_WAIT";
            this.progressBar_WAIT.Size = new System.Drawing.Size(128, 23);
            this.progressBar_WAIT.Step = 1;
            this.progressBar_WAIT.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_WAIT.TabIndex = 1;
            // 
            // pictureBox_WAIT
            // 
            this.pictureBox_WAIT.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox_WAIT.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_WAIT.Image")));
            this.pictureBox_WAIT.Location = new System.Drawing.Point(1, 1);
            this.pictureBox_WAIT.Name = "pictureBox_WAIT";
            this.pictureBox_WAIT.Size = new System.Drawing.Size(128, 128);
            this.pictureBox_WAIT.TabIndex = 0;
            this.pictureBox_WAIT.TabStop = false;
            // 
            // button_VIEW_MAP
            // 
            this.button_VIEW_MAP.Location = new System.Drawing.Point(249, 436);
            this.button_VIEW_MAP.Name = "button_VIEW_MAP";
            this.button_VIEW_MAP.Size = new System.Drawing.Size(240, 23);
            this.button_VIEW_MAP.TabIndex = 4;
            this.button_VIEW_MAP.Text = "VIEW ON MAP";
            this.button_VIEW_MAP.UseVisualStyleBackColor = true;
            this.button_VIEW_MAP.Click += new System.EventHandler(this.button_VIEW_MAP_Click);
            // 
            // button_SAVE_RTS
            // 
            this.button_SAVE_RTS.Enabled = false;
            this.button_SAVE_RTS.Location = new System.Drawing.Point(493, 436);
            this.button_SAVE_RTS.Name = "button_SAVE_RTS";
            this.button_SAVE_RTS.Size = new System.Drawing.Size(240, 23);
            this.button_SAVE_RTS.TabIndex = 3;
            this.button_SAVE_RTS.Text = "SAVE TO RTS";
            this.button_SAVE_RTS.UseVisualStyleBackColor = true;
            this.button_SAVE_RTS.Click += new System.EventHandler(this.button_SAVE_RTS_Click);
            // 
            // panel_ODBC
            // 
            this.panel_ODBC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ODBC.Controls.Add(this.label_ODBC_DB_NAME);
            this.panel_ODBC.Controls.Add(this.label_ODBC_DB_NAME_VALUE);
            this.panel_ODBC.Controls.Add(this.label_ODBC_RTS_SCHEMA_VERSION);
            this.panel_ODBC.Controls.Add(this.label_ODBC_SERVER_VERSION);
            this.panel_ODBC.Controls.Add(this.label_ODBC_DRIVER);
            this.panel_ODBC.Controls.Add(this.label_ODBC_DATA_SOURCE);
            this.panel_ODBC.Controls.Add(this.label_ODBC_SERVER_VERSION_VALUE);
            this.panel_ODBC.Controls.Add(this.label_ODBC_RTS_SCHEMA_VERSION_VALUE);
            this.panel_ODBC.Controls.Add(this.label_ODBC_DRIVER_VALUE);
            this.panel_ODBC.Controls.Add(this.label_ODBC_DATA_SOURCE_VALUE);
            this.panel_ODBC.Location = new System.Drawing.Point(12, 25);
            this.panel_ODBC.Name = "panel_ODBC";
            this.panel_ODBC.Size = new System.Drawing.Size(254, 208);
            this.panel_ODBC.TabIndex = 0;
            // 
            // panel_GEOCODE
            // 
            this.panel_GEOCODE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_GEOCODE.Controls.Add(this.radioButton_ANY_ADDRESS);
            this.panel_GEOCODE.Controls.Add(this.radioButton_BAD_ADDRESS);
            this.panel_GEOCODE.Controls.Add(this.label_LOC_GEO_VALUE);
            this.panel_GEOCODE.Controls.Add(this.label_LOC_GEO);
            this.panel_GEOCODE.Controls.Add(this.button_GEOCODE_LOCATIONS);
            this.panel_GEOCODE.Controls.Add(this.label_LOCS_SEL_VALUE);
            this.panel_GEOCODE.Controls.Add(this.label_LOCS_SEL);
            this.panel_GEOCODE.Controls.Add(this.comboBox_SOURCE);
            this.panel_GEOCODE.Controls.Add(this.label_SOURCE);
            this.panel_GEOCODE.Enabled = false;
            this.panel_GEOCODE.Location = new System.Drawing.Point(542, 25);
            this.panel_GEOCODE.Name = "panel_GEOCODE";
            this.panel_GEOCODE.Size = new System.Drawing.Size(254, 208);
            this.panel_GEOCODE.TabIndex = 2;
            // 
            // radioButton_ANY_ADDRESS
            // 
            this.radioButton_ANY_ADDRESS.AutoSize = true;
            this.radioButton_ANY_ADDRESS.Location = new System.Drawing.Point(5, 142);
            this.radioButton_ANY_ADDRESS.Name = "radioButton_ANY_ADDRESS";
            this.radioButton_ANY_ADDRESS.Size = new System.Drawing.Size(212, 17);
            this.radioButton_ANY_ADDRESS.TabIndex = 7;
            this.radioButton_ANY_ADDRESS.Text = "Geocode By Postal Code (Any Address)";
            this.radioButton_ANY_ADDRESS.UseVisualStyleBackColor = true;
            // 
            // radioButton_BAD_ADDRESS
            // 
            this.radioButton_BAD_ADDRESS.AutoSize = true;
            this.radioButton_BAD_ADDRESS.Checked = true;
            this.radioButton_BAD_ADDRESS.Location = new System.Drawing.Point(5, 124);
            this.radioButton_BAD_ADDRESS.Name = "radioButton_BAD_ADDRESS";
            this.radioButton_BAD_ADDRESS.Size = new System.Drawing.Size(213, 17);
            this.radioButton_BAD_ADDRESS.TabIndex = 6;
            this.radioButton_BAD_ADDRESS.TabStop = true;
            this.radioButton_BAD_ADDRESS.Text = "Geocode By Postal Code (Bad Address)";
            this.radioButton_BAD_ADDRESS.UseVisualStyleBackColor = true;
            // 
            // label_LOC_GEO_VALUE
            // 
            this.label_LOC_GEO_VALUE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_LOC_GEO_VALUE.Location = new System.Drawing.Point(5, 98);
            this.label_LOC_GEO_VALUE.Name = "label_LOC_GEO_VALUE";
            this.label_LOC_GEO_VALUE.Size = new System.Drawing.Size(240, 20);
            this.label_LOC_GEO_VALUE.TabIndex = 5;
            this.label_LOC_GEO_VALUE.Text = "0";
            this.label_LOC_GEO_VALUE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_LOC_GEO
            // 
            this.label_LOC_GEO.AutoSize = true;
            this.label_LOC_GEO.Location = new System.Drawing.Point(5, 82);
            this.label_LOC_GEO.Name = "label_LOC_GEO";
            this.label_LOC_GEO.Size = new System.Drawing.Size(109, 13);
            this.label_LOC_GEO.TabIndex = 4;
            this.label_LOC_GEO.Text = "Locations Geocoded:";
            // 
            // button_GEOCODE_LOCATIONS
            // 
            this.button_GEOCODE_LOCATIONS.Location = new System.Drawing.Point(5, 179);
            this.button_GEOCODE_LOCATIONS.Name = "button_GEOCODE_LOCATIONS";
            this.button_GEOCODE_LOCATIONS.Size = new System.Drawing.Size(241, 23);
            this.button_GEOCODE_LOCATIONS.TabIndex = 8;
            this.button_GEOCODE_LOCATIONS.Text = "GEOCODE LOCATIONS";
            this.button_GEOCODE_LOCATIONS.UseVisualStyleBackColor = true;
            this.button_GEOCODE_LOCATIONS.Click += new System.EventHandler(this.button_GEOCODE_LOCATIONS_Click);
            // 
            // label_LOCS_SEL_VALUE
            // 
            this.label_LOCS_SEL_VALUE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_LOCS_SEL_VALUE.Location = new System.Drawing.Point(5, 59);
            this.label_LOCS_SEL_VALUE.Name = "label_LOCS_SEL_VALUE";
            this.label_LOCS_SEL_VALUE.Size = new System.Drawing.Size(240, 20);
            this.label_LOCS_SEL_VALUE.TabIndex = 3;
            this.label_LOCS_SEL_VALUE.Text = "0";
            this.label_LOCS_SEL_VALUE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_LOCS_SEL
            // 
            this.label_LOCS_SEL.AutoSize = true;
            this.label_LOCS_SEL.Location = new System.Drawing.Point(5, 43);
            this.label_LOCS_SEL.Name = "label_LOCS_SEL";
            this.label_LOCS_SEL.Size = new System.Drawing.Size(101, 13);
            this.label_LOCS_SEL.TabIndex = 2;
            this.label_LOCS_SEL.Text = "Locations Selected:";
            // 
            // comboBox_SOURCE
            // 
            this.comboBox_SOURCE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SOURCE.FormattingEnabled = true;
            this.comboBox_SOURCE.Items.AddRange(new object[] {
            "BING",
            "GOOGLE"});
            this.comboBox_SOURCE.Location = new System.Drawing.Point(5, 20);
            this.comboBox_SOURCE.Name = "comboBox_SOURCE";
            this.comboBox_SOURCE.Size = new System.Drawing.Size(241, 21);
            this.comboBox_SOURCE.TabIndex = 1;
            // 
            // label_SOURCE
            // 
            this.label_SOURCE.AutoSize = true;
            this.label_SOURCE.Location = new System.Drawing.Point(5, 3);
            this.label_SOURCE.Name = "label_SOURCE";
            this.label_SOURCE.Size = new System.Drawing.Size(44, 13);
            this.label_SOURCE.TabIndex = 0;
            this.label_SOURCE.Text = "Source:";
            // 
            // panel_LOGO
            // 
            this.panel_LOGO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_LOGO.Controls.Add(this.label1);
            this.panel_LOGO.Controls.Add(this.pictureBox_LOGO);
            this.panel_LOGO.Location = new System.Drawing.Point(808, 25);
            this.panel_LOGO.Name = "panel_LOGO";
            this.panel_LOGO.Size = new System.Drawing.Size(444, 208);
            this.panel_LOGO.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(304, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "INTERNAL USE ONLY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_LOGO
            // 
            this.pictureBox_LOGO.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_LOGO.Image")));
            this.pictureBox_LOGO.Location = new System.Drawing.Point(72, 60);
            this.pictureBox_LOGO.Name = "pictureBox_LOGO";
            this.pictureBox_LOGO.Size = new System.Drawing.Size(299, 81);
            this.pictureBox_LOGO.TabIndex = 5;
            this.pictureBox_LOGO.TabStop = false;
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip_Main.TabIndex = 0;
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.optionsToolStripMenuItem.ShowShortcutKeys = false;
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.ShowShortcutKeys = false;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // timer_Check_License
            // 
            this.timer_Check_License.Enabled = true;
            this.timer_Check_License.Interval = 1000;
            this.timer_Check_License.Tick += new System.EventHandler(this.timer_Check_License_Tick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 725);
            this.Controls.Add(this.panel_LOGO);
            this.Controls.Add(this.panel_GEOCODE);
            this.Controls.Add(this.panel_FILTER);
            this.Controls.Add(this.panel_LOCATIONS);
            this.Controls.Add(this.panel_ODBC);
            this.Controls.Add(this.menuStrip_Main);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_Main;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RTS External Geocoder (Beta)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_FormClosed);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.Shown += new System.EventHandler(this.Form_Main_Shown);
            this.panel_FILTER.ResumeLayout(false);
            this.panel_FILTER.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LIMIT)).EndInit();
            this.panel_LOCATIONS.ResumeLayout(false);
            this.panel_LOCATIONS.PerformLayout();
            this.panel_WAIT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_WAIT)).EndInit();
            this.panel_ODBC.ResumeLayout(false);
            this.panel_ODBC.PerformLayout();
            this.panel_GEOCODE.ResumeLayout(false);
            this.panel_GEOCODE.PerformLayout();
            this.panel_LOGO.ResumeLayout(false);
            this.panel_LOGO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LOGO)).EndInit();
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_LOCATIONS;
        private System.Windows.Forms.ColumnHeader columnHeader_SEL;
        private System.Windows.Forms.ColumnHeader columnHeader_COUNT;
        private System.Windows.Forms.ColumnHeader columnHeader_ID;
        private System.Windows.Forms.ColumnHeader columnHeader_DESC;
        private System.Windows.Forms.ColumnHeader columnHeader_ADDR_LINE1;
        private System.Windows.Forms.ColumnHeader columnHeader_CITY;
        private System.Windows.Forms.ColumnHeader columnHeader_STATE;
        private System.Windows.Forms.ColumnHeader columnHeader_POSTAL_CODE;
        private System.Windows.Forms.ColumnHeader columnHeader_COUNTRY;
        private System.Windows.Forms.ColumnHeader columnHeader_QUALITY;
        private System.Windows.Forms.ColumnHeader columnHeader_VERIFIED;
        private System.Windows.Forms.ColumnHeader columnHeader_LAT;
        private System.Windows.Forms.ColumnHeader columnHeader_LON;
        private System.Windows.Forms.ColumnHeader columnHeader_CREATION_DATE;
        private System.Windows.Forms.CheckBox checkBox_EXCLUDE_VERIFIED_LOC;
        private System.Windows.Forms.DateTimePicker dateTimePicker_CREATION_DT_END;
        private System.Windows.Forms.DateTimePicker dateTimePicker_CREATION_DT_START;
        private System.Windows.Forms.Label label_CREATION_DATE;
        private System.Windows.Forms.ComboBox comboBox_GEOCODE_QUALITY;
        private System.Windows.Forms.Label label_GEOCODE_QUALITY;
        private System.Windows.Forms.Label label_LOCATIONS;
        private System.Windows.Forms.Button button_FILTER_LOCATIONS;
        private System.Windows.Forms.ComboBox comboBox_REGIONS;
        private System.Windows.Forms.Label label_REGION;
        private System.Windows.Forms.Panel panel_FILTER;
        private System.Windows.Forms.Label label_ODBC_DB_NAME;
        private System.Windows.Forms.Label label_ODBC_DB_NAME_VALUE;
        private System.Windows.Forms.Label label_ODBC_RTS_SCHEMA_VERSION;
        private System.Windows.Forms.Label label_ODBC_SERVER_VERSION;
        private System.Windows.Forms.Label label_ODBC_DRIVER;
        private System.Windows.Forms.Label label_ODBC_DATA_SOURCE;
        private System.Windows.Forms.Label label_ODBC_SERVER_VERSION_VALUE;
        private System.Windows.Forms.Label label_ODBC_RTS_SCHEMA_VERSION_VALUE;
        private System.Windows.Forms.Label label_ODBC_DRIVER_VALUE;
        private System.Windows.Forms.Label label_ODBC_DATA_SOURCE_VALUE;
        private System.Windows.Forms.Panel panel_LOCATIONS;
        private System.Windows.Forms.Panel panel_ODBC;
        private System.Windows.Forms.Panel panel_GEOCODE;
        private System.Windows.Forms.ComboBox comboBox_SOURCE;
        private System.Windows.Forms.Label label_SOURCE;
        private System.Windows.Forms.Label label_LOCS_SEL_VALUE;
        private System.Windows.Forms.Label label_LOCS_SEL;
        private System.Windows.Forms.Button button_GEOCODE_LOCATIONS;
        private System.Windows.Forms.Label label_LOC_GEO_VALUE;
        private System.Windows.Forms.Label label_LOC_GEO;
        private System.Windows.Forms.Panel panel_LOGO;
        private System.Windows.Forms.PictureBox pictureBox_LOGO;
        private System.Windows.Forms.Button button_SAVE_RTS;
        private System.Windows.Forms.Button button_VIEW_MAP;
        private System.Windows.Forms.Panel panel_WAIT;
        private System.Windows.Forms.PictureBox pictureBox_WAIT;
        private System.Windows.Forms.RadioButton radioButton_ANY_ADDRESS;
        private System.Windows.Forms.RadioButton radioButton_BAD_ADDRESS;
        private System.Windows.Forms.Button button_RESET;
        private System.Windows.Forms.ColumnHeader columnHeader_SOURCE;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar_WAIT;
        private System.Windows.Forms.NumericUpDown numericUpDown_LIMIT;
        private System.Windows.Forms.CheckBox checkBox_LIMIT;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_Check_License;
    }
}

