namespace GeoHelper
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пошукToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxNavigation = new System.Windows.Forms.GroupBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.listBoxContinent = new System.Windows.Forms.ListBox();
            this.continentListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelContinent = new System.Windows.Forms.Label();
            this.listBoxCountry = new System.Windows.Forms.ListBox();
            this.countryListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.continentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxCity = new System.Windows.Forms.ListBox();
            this.cityListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.groupBoxRadio = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonContinent = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonCountry = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonCity = new System.Windows.Forms.RadioButton();
            this.groupBoxCountryInfo = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.countryGovernment = new System.Windows.Forms.Label();
            this.countryPopulation = new System.Windows.Forms.Label();
            this.countryArea = new System.Windows.Forms.Label();
            this.countryCapital = new System.Windows.Forms.Label();
            this.countryName = new System.Windows.Forms.Label();
            this.groupBoxContinentInfo = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.continentPopulation = new System.Windows.Forms.Label();
            this.continentArea = new System.Windows.Forms.Label();
            this.continentName = new System.Windows.Forms.Label();
            this.groupBoxCityInfo = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cityIsCapital = new System.Windows.Forms.Label();
            this.cityPopulation = new System.Windows.Forms.Label();
            this.cityArea = new System.Windows.Forms.Label();
            this.cityCoordinates = new System.Windows.Forms.Label();
            this.cityName = new System.Windows.Forms.Label();
            this.groupBoxMap = new System.Windows.Forms.GroupBox();
            this.pictureBoxMarker = new System.Windows.Forms.PictureBox();
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.buttonFilterOff = new System.Windows.Forms.Button();
            this.buttonFilterOn = new System.Windows.Forms.Button();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.textBoxMaxArea = new System.Windows.Forms.TextBox();
            this.textBoxMaxPopulation = new System.Windows.Forms.TextBox();
            this.comboBoxGeoType = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxMinArea = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxMinPopulation = new System.Windows.Forms.TextBox();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBoxNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.continentListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.continentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityListBindingSource)).BeginInit();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxRadio.SuspendLayout();
            this.groupBoxCountryInfo.SuspendLayout();
            this.groupBoxContinentInfo.SuspendLayout();
            this.groupBoxCityInfo.SuspendLayout();
            this.groupBoxMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            this.groupBoxFilters.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.ToolStripMenuItem,
            this.пошукToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripMenuItem.Image")));
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.сохранитьToolStripMenuItem.Text = "Зберегти";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripMenuItem.Image")));
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.открытьToolStripMenuItem.Text = "Відкрити";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(121, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выходToolStripMenuItem.Image")));
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.выходToolStripMenuItem.Text = "Вихід";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.ToolStripMenuItem.Text = "Редагувати";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripMenuItem.Image")));
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.addToolStripMenuItem.Text = "Додати";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.editToolStripMenuItem.Text = "Змінити";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.deleteToolStripMenuItem.Text = "Видалити";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // пошукToolStripMenuItem
            // 
            this.пошукToolStripMenuItem.Name = "пошукToolStripMenuItem";
            this.пошукToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.пошукToolStripMenuItem.Text = "Пошук";
            this.пошукToolStripMenuItem.Click += new System.EventHandler(this.пошукToolStripMenuItem_Click);
            // 
            // groupBoxNavigation
            // 
            this.groupBoxNavigation.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBoxNavigation.Controls.Add(this.labelCity);
            this.groupBoxNavigation.Controls.Add(this.labelCountry);
            this.groupBoxNavigation.Controls.Add(this.listBoxContinent);
            this.groupBoxNavigation.Controls.Add(this.labelContinent);
            this.groupBoxNavigation.Controls.Add(this.listBoxCountry);
            this.groupBoxNavigation.Controls.Add(this.listBoxCity);
            this.groupBoxNavigation.Location = new System.Drawing.Point(27, 348);
            this.groupBoxNavigation.Name = "groupBoxNavigation";
            this.groupBoxNavigation.Size = new System.Drawing.Size(555, 247);
            this.groupBoxNavigation.TabIndex = 1;
            this.groupBoxNavigation.TabStop = false;
            this.groupBoxNavigation.Text = "Навігація";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(440, 22);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(35, 13);
            this.labelCity.TabIndex = 5;
            this.labelCity.Text = "Місто";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(256, 22);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(41, 13);
            this.labelCountry.TabIndex = 4;
            this.labelCountry.Text = "Країна";
            // 
            // listBoxContinent
            // 
            this.listBoxContinent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxContinent.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listBoxContinent.DataSource = this.continentListBindingSource;
            this.listBoxContinent.DisplayMember = "Name";
            this.listBoxContinent.FormattingEnabled = true;
            this.listBoxContinent.Location = new System.Drawing.Point(20, 48);
            this.listBoxContinent.Name = "listBoxContinent";
            this.listBoxContinent.Size = new System.Drawing.Size(156, 186);
            this.listBoxContinent.TabIndex = 2;
            this.listBoxContinent.SelectedIndexChanged += new System.EventHandler(this.listBoxContinent_SelectedIndexChanged);
            // 
            // continentListBindingSource
            // 
            this.continentListBindingSource.DataMember = "ContinentList";
            this.continentListBindingSource.DataSource = this.companionBindingSource;
            // 
            // companionBindingSource
            // 
            this.companionBindingSource.DataSource = typeof(GeoHelper.Companion);
            // 
            // labelContinent
            // 
            this.labelContinent.AutoSize = true;
            this.labelContinent.Location = new System.Drawing.Point(64, 22);
            this.labelContinent.Name = "labelContinent";
            this.labelContinent.Size = new System.Drawing.Size(60, 13);
            this.labelContinent.TabIndex = 3;
            this.labelContinent.Text = "Континент";
            // 
            // listBoxCountry
            // 
            this.listBoxCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxCountry.DataSource = this.countryListBindingSource;
            this.listBoxCountry.DisplayMember = "Name";
            this.listBoxCountry.FormattingEnabled = true;
            this.listBoxCountry.Location = new System.Drawing.Point(201, 48);
            this.listBoxCountry.Name = "listBoxCountry";
            this.listBoxCountry.Size = new System.Drawing.Size(156, 186);
            this.listBoxCountry.TabIndex = 1;
            this.listBoxCountry.SelectedIndexChanged += new System.EventHandler(this.listBoxCountry_SelectedIndexChanged);
            // 
            // countryListBindingSource
            // 
            this.countryListBindingSource.DataMember = "CountryList";
            this.countryListBindingSource.DataSource = this.continentBindingSource;
            // 
            // continentBindingSource
            // 
            this.continentBindingSource.DataSource = typeof(GeoHelper.Continent);
            // 
            // listBoxCity
            // 
            this.listBoxCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxCity.DataSource = this.cityListBindingSource;
            this.listBoxCity.DisplayMember = "Name";
            this.listBoxCity.FormattingEnabled = true;
            this.listBoxCity.Location = new System.Drawing.Point(381, 48);
            this.listBoxCity.Name = "listBoxCity";
            this.listBoxCity.Size = new System.Drawing.Size(156, 186);
            this.listBoxCity.TabIndex = 0;
            this.listBoxCity.SelectedIndexChanged += new System.EventHandler(this.listBoxCity_SelectedIndexChanged);
            // 
            // cityListBindingSource
            // 
            this.cityListBindingSource.DataMember = "CityList";
            this.cityListBindingSource.DataSource = this.countryListBindingSource;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxInfo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBoxInfo.Controls.Add(this.groupBoxCityInfo);
            this.groupBoxInfo.Controls.Add(this.groupBoxRadio);
            this.groupBoxInfo.Controls.Add(this.groupBoxCountryInfo);
            this.groupBoxInfo.Controls.Add(this.groupBoxContinentInfo);
            this.groupBoxInfo.Location = new System.Drawing.Point(599, 36);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(299, 305);
            this.groupBoxInfo.TabIndex = 2;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Інформація";
            // 
            // groupBoxRadio
            // 
            this.groupBoxRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxRadio.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxRadio.Controls.Add(this.label3);
            this.groupBoxRadio.Controls.Add(this.radioButtonContinent);
            this.groupBoxRadio.Controls.Add(this.label2);
            this.groupBoxRadio.Controls.Add(this.radioButtonCountry);
            this.groupBoxRadio.Controls.Add(this.label1);
            this.groupBoxRadio.Controls.Add(this.radioButtonCity);
            this.groupBoxRadio.Location = new System.Drawing.Point(15, 210);
            this.groupBoxRadio.Name = "groupBoxRadio";
            this.groupBoxRadio.Size = new System.Drawing.Size(271, 75);
            this.groupBoxRadio.TabIndex = 3;
            this.groupBoxRadio.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Місто";
            // 
            // radioButtonContinent
            // 
            this.radioButtonContinent.AutoSize = true;
            this.radioButtonContinent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonContinent.Location = new System.Drawing.Point(39, 43);
            this.radioButtonContinent.Name = "radioButtonContinent";
            this.radioButtonContinent.Size = new System.Drawing.Size(14, 13);
            this.radioButtonContinent.TabIndex = 0;
            this.radioButtonContinent.UseVisualStyleBackColor = true;
            this.radioButtonContinent.CheckedChanged += new System.EventHandler(this.radioButtonContinent_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Країна";
            // 
            // radioButtonCountry
            // 
            this.radioButtonCountry.AutoSize = true;
            this.radioButtonCountry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonCountry.Location = new System.Drawing.Point(124, 43);
            this.radioButtonCountry.Name = "radioButtonCountry";
            this.radioButtonCountry.Size = new System.Drawing.Size(14, 13);
            this.radioButtonCountry.TabIndex = 1;
            this.radioButtonCountry.UseVisualStyleBackColor = true;
            this.radioButtonCountry.CheckedChanged += new System.EventHandler(this.radioButtonCountry_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Континент";
            // 
            // radioButtonCity
            // 
            this.radioButtonCity.AutoSize = true;
            this.radioButtonCity.Checked = true;
            this.radioButtonCity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonCity.Location = new System.Drawing.Point(213, 43);
            this.radioButtonCity.Name = "radioButtonCity";
            this.radioButtonCity.Size = new System.Drawing.Size(14, 13);
            this.radioButtonCity.TabIndex = 2;
            this.radioButtonCity.TabStop = true;
            this.radioButtonCity.UseVisualStyleBackColor = true;
            this.radioButtonCity.CheckedChanged += new System.EventHandler(this.radioButtonCity_CheckedChanged);
            // 
            // groupBoxCountryInfo
            // 
            this.groupBoxCountryInfo.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxCountryInfo.Controls.Add(this.label8);
            this.groupBoxCountryInfo.Controls.Add(this.label9);
            this.groupBoxCountryInfo.Controls.Add(this.label10);
            this.groupBoxCountryInfo.Controls.Add(this.label11);
            this.groupBoxCountryInfo.Controls.Add(this.countryGovernment);
            this.groupBoxCountryInfo.Controls.Add(this.countryPopulation);
            this.groupBoxCountryInfo.Controls.Add(this.countryArea);
            this.groupBoxCountryInfo.Controls.Add(this.countryCapital);
            this.groupBoxCountryInfo.Controls.Add(this.countryName);
            this.groupBoxCountryInfo.Location = new System.Drawing.Point(15, 19);
            this.groupBoxCountryInfo.Name = "groupBoxCountryInfo";
            this.groupBoxCountryInfo.Size = new System.Drawing.Size(270, 171);
            this.groupBoxCountryInfo.TabIndex = 10;
            this.groupBoxCountryInfo.TabStop = false;
            this.groupBoxCountryInfo.Text = "Інофрмація про країну";
            this.groupBoxCountryInfo.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Форма держ. упр.:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Населення:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Площа:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Столиця:";
            // 
            // countryGovernment
            // 
            this.countryGovernment.AutoSize = true;
            this.countryGovernment.Location = new System.Drawing.Point(141, 131);
            this.countryGovernment.Name = "countryGovernment";
            this.countryGovernment.Size = new System.Drawing.Size(10, 13);
            this.countryGovernment.TabIndex = 4;
            this.countryGovernment.Text = "-";
            // 
            // countryPopulation
            // 
            this.countryPopulation.AutoSize = true;
            this.countryPopulation.Location = new System.Drawing.Point(141, 106);
            this.countryPopulation.Name = "countryPopulation";
            this.countryPopulation.Size = new System.Drawing.Size(10, 13);
            this.countryPopulation.TabIndex = 3;
            this.countryPopulation.Text = "-";
            // 
            // countryArea
            // 
            this.countryArea.AutoSize = true;
            this.countryArea.Location = new System.Drawing.Point(141, 80);
            this.countryArea.Name = "countryArea";
            this.countryArea.Size = new System.Drawing.Size(10, 13);
            this.countryArea.TabIndex = 2;
            this.countryArea.Text = "-";
            // 
            // countryCapital
            // 
            this.countryCapital.AutoSize = true;
            this.countryCapital.Location = new System.Drawing.Point(141, 53);
            this.countryCapital.Name = "countryCapital";
            this.countryCapital.Size = new System.Drawing.Size(10, 13);
            this.countryCapital.TabIndex = 1;
            this.countryCapital.Text = "-";
            // 
            // countryName
            // 
            this.countryName.AutoSize = true;
            this.countryName.Location = new System.Drawing.Point(15, 26);
            this.countryName.Name = "countryName";
            this.countryName.Size = new System.Drawing.Size(10, 13);
            this.countryName.TabIndex = 0;
            this.countryName.Text = "-";
            // 
            // groupBoxContinentInfo
            // 
            this.groupBoxContinentInfo.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxContinentInfo.Controls.Add(this.label13);
            this.groupBoxContinentInfo.Controls.Add(this.label14);
            this.groupBoxContinentInfo.Controls.Add(this.continentPopulation);
            this.groupBoxContinentInfo.Controls.Add(this.continentArea);
            this.groupBoxContinentInfo.Controls.Add(this.continentName);
            this.groupBoxContinentInfo.Location = new System.Drawing.Point(15, 19);
            this.groupBoxContinentInfo.Name = "groupBoxContinentInfo";
            this.groupBoxContinentInfo.Size = new System.Drawing.Size(270, 171);
            this.groupBoxContinentInfo.TabIndex = 10;
            this.groupBoxContinentInfo.TabStop = false;
            this.groupBoxContinentInfo.Text = "Інофрмація про континент";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Населення:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Площа:";
            // 
            // continentPopulation
            // 
            this.continentPopulation.AutoSize = true;
            this.continentPopulation.Location = new System.Drawing.Point(141, 79);
            this.continentPopulation.Name = "continentPopulation";
            this.continentPopulation.Size = new System.Drawing.Size(10, 13);
            this.continentPopulation.TabIndex = 3;
            this.continentPopulation.Text = "-";
            // 
            // continentArea
            // 
            this.continentArea.AutoSize = true;
            this.continentArea.Location = new System.Drawing.Point(141, 53);
            this.continentArea.Name = "continentArea";
            this.continentArea.Size = new System.Drawing.Size(10, 13);
            this.continentArea.TabIndex = 2;
            this.continentArea.Text = "-";
            // 
            // continentName
            // 
            this.continentName.AutoSize = true;
            this.continentName.Location = new System.Drawing.Point(15, 26);
            this.continentName.Name = "continentName";
            this.continentName.Size = new System.Drawing.Size(10, 13);
            this.continentName.TabIndex = 0;
            this.continentName.Text = "-";
            // 
            // groupBoxCityInfo
            // 
            this.groupBoxCityInfo.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxCityInfo.Controls.Add(this.label7);
            this.groupBoxCityInfo.Controls.Add(this.label6);
            this.groupBoxCityInfo.Controls.Add(this.label5);
            this.groupBoxCityInfo.Controls.Add(this.label4);
            this.groupBoxCityInfo.Controls.Add(this.cityIsCapital);
            this.groupBoxCityInfo.Controls.Add(this.cityPopulation);
            this.groupBoxCityInfo.Controls.Add(this.cityArea);
            this.groupBoxCityInfo.Controls.Add(this.cityCoordinates);
            this.groupBoxCityInfo.Controls.Add(this.cityName);
            this.groupBoxCityInfo.Location = new System.Drawing.Point(15, 19);
            this.groupBoxCityInfo.Name = "groupBoxCityInfo";
            this.groupBoxCityInfo.Size = new System.Drawing.Size(270, 171);
            this.groupBoxCityInfo.TabIndex = 4;
            this.groupBoxCityInfo.TabStop = false;
            this.groupBoxCityInfo.Text = "Інформація про місто";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Статус столиці:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Населення:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Площа:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Координати:";
            // 
            // cityIsCapital
            // 
            this.cityIsCapital.AutoSize = true;
            this.cityIsCapital.Location = new System.Drawing.Point(141, 131);
            this.cityIsCapital.Name = "cityIsCapital";
            this.cityIsCapital.Size = new System.Drawing.Size(10, 13);
            this.cityIsCapital.TabIndex = 4;
            this.cityIsCapital.Text = "-";
            // 
            // cityPopulation
            // 
            this.cityPopulation.AutoSize = true;
            this.cityPopulation.Location = new System.Drawing.Point(141, 106);
            this.cityPopulation.Name = "cityPopulation";
            this.cityPopulation.Size = new System.Drawing.Size(10, 13);
            this.cityPopulation.TabIndex = 3;
            this.cityPopulation.Text = "-";
            // 
            // cityArea
            // 
            this.cityArea.AutoSize = true;
            this.cityArea.Location = new System.Drawing.Point(141, 80);
            this.cityArea.Name = "cityArea";
            this.cityArea.Size = new System.Drawing.Size(10, 13);
            this.cityArea.TabIndex = 2;
            this.cityArea.Text = "-";
            // 
            // cityCoordinates
            // 
            this.cityCoordinates.AutoSize = true;
            this.cityCoordinates.Location = new System.Drawing.Point(141, 53);
            this.cityCoordinates.Name = "cityCoordinates";
            this.cityCoordinates.Size = new System.Drawing.Size(10, 13);
            this.cityCoordinates.TabIndex = 1;
            this.cityCoordinates.Text = "-";
            // 
            // cityName
            // 
            this.cityName.AutoSize = true;
            this.cityName.Location = new System.Drawing.Point(15, 26);
            this.cityName.Name = "cityName";
            this.cityName.Size = new System.Drawing.Size(10, 13);
            this.cityName.TabIndex = 0;
            this.cityName.Text = "-";
            // 
            // groupBoxMap
            // 
            this.groupBoxMap.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBoxMap.Controls.Add(this.pictureBoxMarker);
            this.groupBoxMap.Controls.Add(this.pictureBoxMap);
            this.groupBoxMap.Location = new System.Drawing.Point(27, 36);
            this.groupBoxMap.Name = "groupBoxMap";
            this.groupBoxMap.Size = new System.Drawing.Size(555, 305);
            this.groupBoxMap.TabIndex = 3;
            this.groupBoxMap.TabStop = false;
            this.groupBoxMap.Text = "Карта";
            // 
            // pictureBoxMarker
            // 
            this.pictureBoxMarker.Image = global::GeoHelper.Properties.Resources.red_47690_960_720;
            this.pictureBoxMarker.Location = new System.Drawing.Point(285, 125);
            this.pictureBoxMarker.Name = "pictureBoxMarker";
            this.pictureBoxMarker.Size = new System.Drawing.Size(11, 11);
            this.pictureBoxMarker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMarker.TabIndex = 1;
            this.pictureBoxMarker.TabStop = false;
            this.pictureBoxMarker.Visible = false;
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMap.Image")));
            this.pictureBoxMap.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(540, 280);
            this.pictureBoxMap.TabIndex = 0;
            this.pictureBoxMap.TabStop = false;
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBoxFilters.Controls.Add(this.buttonFilterOff);
            this.groupBoxFilters.Controls.Add(this.buttonFilterOn);
            this.groupBoxFilters.Controls.Add(this.groupBoxFilter);
            this.groupBoxFilters.Location = new System.Drawing.Point(599, 348);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(299, 246);
            this.groupBoxFilters.TabIndex = 4;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Фільтри";
            // 
            // buttonFilterOff
            // 
            this.buttonFilterOff.Location = new System.Drawing.Point(159, 205);
            this.buttonFilterOff.Name = "buttonFilterOff";
            this.buttonFilterOff.Size = new System.Drawing.Size(128, 34);
            this.buttonFilterOff.TabIndex = 8;
            this.buttonFilterOff.Text = "Скасувати";
            this.buttonFilterOff.UseVisualStyleBackColor = true;
            this.buttonFilterOff.Click += new System.EventHandler(this.buttonFilterOff_Click);
            // 
            // buttonFilterOn
            // 
            this.buttonFilterOn.Location = new System.Drawing.Point(15, 205);
            this.buttonFilterOn.Name = "buttonFilterOn";
            this.buttonFilterOn.Size = new System.Drawing.Size(128, 34);
            this.buttonFilterOn.TabIndex = 7;
            this.buttonFilterOn.Text = "Застосувати";
            this.buttonFilterOn.UseVisualStyleBackColor = true;
            this.buttonFilterOn.Click += new System.EventHandler(this.buttonFilterOn_Click);
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxFilter.Controls.Add(this.textBoxMaxArea);
            this.groupBoxFilter.Controls.Add(this.textBoxMaxPopulation);
            this.groupBoxFilter.Controls.Add(this.comboBoxGeoType);
            this.groupBoxFilter.Controls.Add(this.label21);
            this.groupBoxFilter.Controls.Add(this.label18);
            this.groupBoxFilter.Controls.Add(this.label19);
            this.groupBoxFilter.Controls.Add(this.label20);
            this.groupBoxFilter.Controls.Add(this.textBoxMinArea);
            this.groupBoxFilter.Controls.Add(this.label17);
            this.groupBoxFilter.Controls.Add(this.label16);
            this.groupBoxFilter.Controls.Add(this.label15);
            this.groupBoxFilter.Controls.Add(this.textBoxMinPopulation);
            this.groupBoxFilter.Controls.Add(this.comboBoxSort);
            this.groupBoxFilter.Controls.Add(this.label12);
            this.groupBoxFilter.Location = new System.Drawing.Point(15, 22);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(271, 177);
            this.groupBoxFilter.TabIndex = 40;
            this.groupBoxFilter.TabStop = false;
            // 
            // textBoxMaxArea
            // 
            this.textBoxMaxArea.Location = new System.Drawing.Point(202, 130);
            this.textBoxMaxArea.Name = "textBoxMaxArea";
            this.textBoxMaxArea.Size = new System.Drawing.Size(63, 20);
            this.textBoxMaxArea.TabIndex = 6;
            // 
            // textBoxMaxPopulation
            // 
            this.textBoxMaxPopulation.Location = new System.Drawing.Point(202, 95);
            this.textBoxMaxPopulation.Name = "textBoxMaxPopulation";
            this.textBoxMaxPopulation.Size = new System.Drawing.Size(63, 20);
            this.textBoxMaxPopulation.TabIndex = 4;
            // 
            // comboBoxGeoType
            // 
            this.comboBoxGeoType.FormattingEnabled = true;
            this.comboBoxGeoType.Items.AddRange(new object[] {
            "Континент",
            "Страна",
            "Город"});
            this.comboBoxGeoType.Location = new System.Drawing.Point(105, 59);
            this.comboBoxGeoType.Name = "comboBoxGeoType";
            this.comboBoxGeoType.Size = new System.Drawing.Size(160, 21);
            this.comboBoxGeoType.TabIndex = 2;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 62);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 13);
            this.label21.TabIndex = 12;
            this.label21.Text = "Застосувати до";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(178, 133);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "до";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(80, 133);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 13);
            this.label19.TabIndex = 10;
            this.label19.Text = "від";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(11, 133);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 13);
            this.label20.TabIndex = 9;
            this.label20.Text = "Площа";
            // 
            // textBoxMinArea
            // 
            this.textBoxMinArea.Location = new System.Drawing.Point(105, 130);
            this.textBoxMinArea.Name = "textBoxMinArea";
            this.textBoxMinArea.Size = new System.Drawing.Size(63, 20);
            this.textBoxMinArea.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(179, 98);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "до";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(81, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "від";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Населення";
            // 
            // textBoxMinPopulation
            // 
            this.textBoxMinPopulation.Location = new System.Drawing.Point(105, 95);
            this.textBoxMinPopulation.Name = "textBoxMinPopulation";
            this.textBoxMinPopulation.Size = new System.Drawing.Size(63, 20);
            this.textBoxMinPopulation.TabIndex = 3;
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "Алфавит",
            "Площадь",
            "Население"});
            this.comboBoxSort.Location = new System.Drawing.Point(105, 23);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(160, 21);
            this.comboBoxSort.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Сортувати за";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(910, 606);
            this.Controls.Add(this.groupBoxFilters);
            this.Controls.Add(this.groupBoxMap);
            this.Controls.Add(this.groupBoxNavigation);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBoxInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeoHelper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxNavigation.ResumeLayout(false);
            this.groupBoxNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.continentListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.continentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityListBindingSource)).EndInit();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxRadio.ResumeLayout(false);
            this.groupBoxRadio.PerformLayout();
            this.groupBoxCountryInfo.ResumeLayout(false);
            this.groupBoxCountryInfo.PerformLayout();
            this.groupBoxContinentInfo.ResumeLayout(false);
            this.groupBoxContinentInfo.PerformLayout();
            this.groupBoxCityInfo.ResumeLayout(false);
            this.groupBoxCityInfo.PerformLayout();
            this.groupBoxMap.ResumeLayout(false);
            this.groupBoxMap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxNavigation;
        private System.Windows.Forms.ListBox listBoxContinent;
        private System.Windows.Forms.ListBox listBoxCountry;
        private System.Windows.Forms.ListBox listBoxCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelContinent;
        private System.Windows.Forms.BindingSource cityListBindingSource;
        private System.Windows.Forms.BindingSource countryListBindingSource;
        private System.Windows.Forms.BindingSource continentBindingSource;
        private System.Windows.Forms.BindingSource continentListBindingSource;
        private System.Windows.Forms.BindingSource companionBindingSource;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.RadioButton radioButtonCity;
        private System.Windows.Forms.RadioButton radioButtonCountry;
        private System.Windows.Forms.RadioButton radioButtonContinent;
        private System.Windows.Forms.GroupBox groupBoxRadio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxCityInfo;
        private System.Windows.Forms.Label cityCoordinates;
        private System.Windows.Forms.Label cityName;
        private System.Windows.Forms.Label cityIsCapital;
        private System.Windows.Forms.Label cityPopulation;
        private System.Windows.Forms.Label cityArea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxCountryInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label countryGovernment;
        private System.Windows.Forms.Label countryPopulation;
        private System.Windows.Forms.Label countryArea;
        private System.Windows.Forms.Label countryCapital;
        private System.Windows.Forms.Label countryName;
        private System.Windows.Forms.GroupBox groupBoxContinentInfo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label continentPopulation;
        private System.Windows.Forms.Label continentArea;
        private System.Windows.Forms.Label continentName;
        private System.Windows.Forms.GroupBox groupBoxMap;
        private System.Windows.Forms.PictureBox pictureBoxMap;
        private System.Windows.Forms.PictureBox pictureBoxMarker;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.TextBox textBoxMaxArea;
        private System.Windows.Forms.TextBox textBoxMaxPopulation;
        private System.Windows.Forms.ComboBox comboBoxGeoType;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxMinArea;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxMinPopulation;
        private System.Windows.Forms.Button buttonFilterOff;
        private System.Windows.Forms.Button buttonFilterOn;
        private System.Windows.Forms.ToolStripMenuItem пошукToolStripMenuItem;
    }
}

