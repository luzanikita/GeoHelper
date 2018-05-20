namespace GeoHelper
{
    partial class DeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteForm));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBoxRadio = new System.Windows.Forms.GroupBox();
            this.radioButtonContinent = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonCountry = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonCity = new System.Windows.Forms.RadioButton();
            this.comboBoxContinent = new System.Windows.Forms.ComboBox();
            this.continentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.countryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxRadio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.continentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(147, 215);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(126, 28);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(12, 215);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(126, 28);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // groupBoxRadio
            // 
            this.groupBoxRadio.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxRadio.Controls.Add(this.radioButtonContinent);
            this.groupBoxRadio.Controls.Add(this.label3);
            this.groupBoxRadio.Controls.Add(this.label2);
            this.groupBoxRadio.Controls.Add(this.radioButtonCountry);
            this.groupBoxRadio.Controls.Add(this.label1);
            this.groupBoxRadio.Controls.Add(this.radioButtonCity);
            this.groupBoxRadio.Location = new System.Drawing.Point(12, 12);
            this.groupBoxRadio.Name = "groupBoxRadio";
            this.groupBoxRadio.Size = new System.Drawing.Size(261, 75);
            this.groupBoxRadio.TabIndex = 11;
            this.groupBoxRadio.TabStop = false;
            // 
            // radioButtonContinent
            // 
            this.radioButtonContinent.AutoSize = true;
            this.radioButtonContinent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonContinent.Location = new System.Drawing.Point(38, 43);
            this.radioButtonContinent.Name = "radioButtonContinent";
            this.radioButtonContinent.Size = new System.Drawing.Size(14, 13);
            this.radioButtonContinent.TabIndex = 7;
            this.radioButtonContinent.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Город";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Страна";
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
            // 
            // comboBoxContinent
            // 
            this.comboBoxContinent.DataSource = this.continentBindingSource;
            this.comboBoxContinent.DisplayMember = "Name";
            this.comboBoxContinent.FormattingEnabled = true;
            this.comboBoxContinent.Location = new System.Drawing.Point(83, 13);
            this.comboBoxContinent.Name = "comboBoxContinent";
            this.comboBoxContinent.Size = new System.Drawing.Size(155, 21);
            this.comboBoxContinent.TabIndex = 29;
            this.comboBoxContinent.SelectedIndexChanged += new System.EventHandler(this.comboBoxContinent_SelectedIndexChanged);
            // 
            // continentBindingSource
            // 
            this.continentBindingSource.DataSource = typeof(GeoHelper.Continent);
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DataSource = this.countryBindingSource;
            this.comboBoxCountry.DisplayMember = "Name";
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(83, 41);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(155, 21);
            this.comboBoxCountry.TabIndex = 28;
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataSource = typeof(GeoHelper.Country);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxCity);
            this.groupBox1.Controls.Add(this.comboBoxContinent);
            this.groupBox1.Controls.Add(this.comboBoxCountry);
            this.groupBox1.Location = new System.Drawing.Point(12, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 109);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Город";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Страна";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Континент";
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.DataSource = this.countryBindingSource1;
            this.comboBoxCity.DisplayMember = "Name";
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(83, 68);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(155, 21);
            this.comboBoxCity.TabIndex = 30;
            // 
            // countryBindingSource1
            // 
            this.countryBindingSource1.DataSource = typeof(GeoHelper.Country);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 256);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxRadio);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удалить";
            this.Load += new System.EventHandler(this.DeleteForm_Load);
            this.groupBoxRadio.ResumeLayout(false);
            this.groupBoxRadio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.continentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBoxRadio;
        private System.Windows.Forms.RadioButton radioButtonContinent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonCity;
        private System.Windows.Forms.ComboBox comboBoxContinent;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.BindingSource continentBindingSource;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private System.Windows.Forms.BindingSource countryBindingSource1;
    }
}