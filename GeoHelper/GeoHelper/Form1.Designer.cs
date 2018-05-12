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
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.SuspendLayout();
            this.groupBoxNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.continentListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.continentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.ToolStripMenuItem.Text = "Редактировать";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.addToolStripMenuItem.Text = "Добвать";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.editToolStripMenuItem.Text = "Изменить";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
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
            this.groupBoxNavigation.Location = new System.Drawing.Point(12, 401);
            this.groupBoxNavigation.Name = "groupBoxNavigation";
            this.groupBoxNavigation.Size = new System.Drawing.Size(352, 193);
            this.groupBoxNavigation.TabIndex = 1;
            this.groupBoxNavigation.TabStop = false;
            this.groupBoxNavigation.Text = "Навигация";
            this.groupBoxNavigation.Enter += new System.EventHandler(this.groupBoxNavigator_Enter);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(269, 29);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(37, 13);
            this.labelCity.TabIndex = 5;
            this.labelCity.Text = "Город";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(154, 29);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(43, 13);
            this.labelCountry.TabIndex = 4;
            this.labelCountry.Text = "Страна";
            // 
            // listBoxContinent
            // 
            this.listBoxContinent.DataSource = this.continentListBindingSource;
            this.listBoxContinent.DisplayMember = "Name";
            this.listBoxContinent.FormattingEnabled = true;
            this.listBoxContinent.Location = new System.Drawing.Point(6, 48);
            this.listBoxContinent.Name = "listBoxContinent";
            this.listBoxContinent.Size = new System.Drawing.Size(108, 134);
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
            this.labelContinent.Location = new System.Drawing.Point(32, 29);
            this.labelContinent.Name = "labelContinent";
            this.labelContinent.Size = new System.Drawing.Size(60, 13);
            this.labelContinent.TabIndex = 3;
            this.labelContinent.Text = "Континент";
            // 
            // listBoxCountry
            // 
            this.listBoxCountry.DataSource = this.countryListBindingSource;
            this.listBoxCountry.DisplayMember = "Name";
            this.listBoxCountry.FormattingEnabled = true;
            this.listBoxCountry.Location = new System.Drawing.Point(120, 48);
            this.listBoxCountry.Name = "listBoxCountry";
            this.listBoxCountry.Size = new System.Drawing.Size(108, 134);
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
            this.listBoxCity.DataSource = this.cityListBindingSource;
            this.listBoxCity.DisplayMember = "Name";
            this.listBoxCity.FormattingEnabled = true;
            this.listBoxCity.Location = new System.Drawing.Point(234, 48);
            this.listBoxCity.Name = "listBoxCity";
            this.listBoxCity.Size = new System.Drawing.Size(108, 134);
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
            this.groupBoxInfo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBoxInfo.Location = new System.Drawing.Point(615, 27);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(283, 368);
            this.groupBoxInfo.TabIndex = 2;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Информация";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(910, 606);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.groupBoxNavigation);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeoHelper";
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
    }
}

