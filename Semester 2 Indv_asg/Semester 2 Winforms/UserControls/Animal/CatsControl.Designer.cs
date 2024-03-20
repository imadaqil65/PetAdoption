namespace Semester_2_Winforms.UserControls
{
    partial class CatsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_ViewAllCats = new System.Windows.Forms.Button();
            this.flp_AvailableCats = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiobtn_CatSterile = new System.Windows.Forms.RadioButton();
            this.radiobtn_CatNotSterile = new System.Windows.Forms.RadioButton();
            this.GenericAnimal = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbx_CatShelter = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbx_CatName = new System.Windows.Forms.TextBox();
            this.cbx_CatGender = new System.Windows.Forms.ComboBox();
            this.nud_CatAge = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.richtbx_CatDesc = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_AddCat = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.richtbx_CatAllergies = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_CatFurColor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_CatBreed = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GenericAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CatAge)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1081, 782);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SandyBrown;
            this.tabPage1.Controls.Add(this.button_ViewAllCats);
            this.tabPage1.Controls.Add(this.flp_AvailableCats);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1073, 744);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Available Cats";
            // 
            // button_ViewAllCats
            // 
            this.button_ViewAllCats.Location = new System.Drawing.Point(6, 34);
            this.button_ViewAllCats.Name = "button_ViewAllCats";
            this.button_ViewAllCats.Size = new System.Drawing.Size(181, 34);
            this.button_ViewAllCats.TabIndex = 1;
            this.button_ViewAllCats.Text = "Refresh Cats";
            this.button_ViewAllCats.UseVisualStyleBackColor = true;
            this.button_ViewAllCats.Click += new System.EventHandler(this.button_ViewAllCats_Click);
            // 
            // flp_AvailableCats
            // 
            this.flp_AvailableCats.AutoScroll = true;
            this.flp_AvailableCats.Location = new System.Drawing.Point(6, 74);
            this.flp_AvailableCats.Name = "flp_AvailableCats";
            this.flp_AvailableCats.Size = new System.Drawing.Size(1061, 664);
            this.flp_AvailableCats.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SandyBrown;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.GenericAnimal);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btn_AddCat);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.richtbx_CatAllergies);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tbx_CatFurColor);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tbx_CatBreed);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1073, 744);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Cat";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiobtn_CatSterile);
            this.groupBox1.Controls.Add(this.radiobtn_CatNotSterile);
            this.groupBox1.Location = new System.Drawing.Point(560, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 93);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sterile";
            // 
            // radiobtn_CatSterile
            // 
            this.radiobtn_CatSterile.AutoSize = true;
            this.radiobtn_CatSterile.Location = new System.Drawing.Point(26, 41);
            this.radiobtn_CatSterile.Name = "radiobtn_CatSterile";
            this.radiobtn_CatSterile.Size = new System.Drawing.Size(63, 29);
            this.radiobtn_CatSterile.TabIndex = 16;
            this.radiobtn_CatSterile.TabStop = true;
            this.radiobtn_CatSterile.Text = "Yes";
            this.radiobtn_CatSterile.UseVisualStyleBackColor = true;
            // 
            // radiobtn_CatNotSterile
            // 
            this.radiobtn_CatNotSterile.AutoSize = true;
            this.radiobtn_CatNotSterile.Location = new System.Drawing.Point(181, 41);
            this.radiobtn_CatNotSterile.Name = "radiobtn_CatNotSterile";
            this.radiobtn_CatNotSterile.Size = new System.Drawing.Size(62, 29);
            this.radiobtn_CatNotSterile.TabIndex = 17;
            this.radiobtn_CatNotSterile.TabStop = true;
            this.radiobtn_CatNotSterile.Text = "No";
            this.radiobtn_CatNotSterile.UseVisualStyleBackColor = true;
            // 
            // GenericAnimal
            // 
            this.GenericAnimal.Controls.Add(this.label11);
            this.GenericAnimal.Controls.Add(this.label13);
            this.GenericAnimal.Controls.Add(this.cbx_CatShelter);
            this.GenericAnimal.Controls.Add(this.label14);
            this.GenericAnimal.Controls.Add(this.label15);
            this.GenericAnimal.Controls.Add(this.label16);
            this.GenericAnimal.Controls.Add(this.tbx_CatName);
            this.GenericAnimal.Controls.Add(this.cbx_CatGender);
            this.GenericAnimal.Controls.Add(this.nud_CatAge);
            this.GenericAnimal.Controls.Add(this.label1);
            this.GenericAnimal.Controls.Add(this.richtbx_CatDesc);
            this.GenericAnimal.Location = new System.Drawing.Point(52, 43);
            this.GenericAnimal.Name = "GenericAnimal";
            this.GenericAnimal.Size = new System.Drawing.Size(445, 449);
            this.GenericAnimal.TabIndex = 34;
            this.GenericAnimal.TabStop = false;
            this.GenericAnimal.Text = "Basic Information";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 25);
            this.label11.TabIndex = 4;
            this.label11.Text = "Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 25);
            this.label13.TabIndex = 5;
            this.label13.Text = "Age";
            // 
            // cbx_CatShelter
            // 
            this.cbx_CatShelter.FormattingEnabled = true;
            this.cbx_CatShelter.Location = new System.Drawing.Point(134, 200);
            this.cbx_CatShelter.Name = "cbx_CatShelter";
            this.cbx_CatShelter.Size = new System.Drawing.Size(277, 33);
            this.cbx_CatShelter.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 25);
            this.label14.TabIndex = 6;
            this.label14.Text = "Gender";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 263);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 25);
            this.label15.TabIndex = 7;
            this.label15.Text = "Description";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 208);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 25);
            this.label16.TabIndex = 20;
            this.label16.Text = "Shelter";
            // 
            // tbx_CatName
            // 
            this.tbx_CatName.Location = new System.Drawing.Point(134, 43);
            this.tbx_CatName.Name = "tbx_CatName";
            this.tbx_CatName.Size = new System.Drawing.Size(277, 31);
            this.tbx_CatName.TabIndex = 0;
            // 
            // cbx_CatGender
            // 
            this.cbx_CatGender.FormattingEnabled = true;
            this.cbx_CatGender.Location = new System.Drawing.Point(134, 146);
            this.cbx_CatGender.Name = "cbx_CatGender";
            this.cbx_CatGender.Size = new System.Drawing.Size(146, 33);
            this.cbx_CatGender.TabIndex = 1;
            // 
            // nud_CatAge
            // 
            this.nud_CatAge.Location = new System.Drawing.Point(134, 94);
            this.nud_CatAge.Name = "nud_CatAge";
            this.nud_CatAge.Size = new System.Drawing.Size(146, 31);
            this.nud_CatAge.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Year(s) Old";
            // 
            // richtbx_CatDesc
            // 
            this.richtbx_CatDesc.Location = new System.Drawing.Point(134, 255);
            this.richtbx_CatDesc.Name = "richtbx_CatDesc";
            this.richtbx_CatDesc.Size = new System.Drawing.Size(277, 163);
            this.richtbx_CatDesc.TabIndex = 8;
            this.richtbx_CatDesc.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "Prefilled";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_AddCat
            // 
            this.btn_AddCat.Location = new System.Drawing.Point(560, 434);
            this.btn_AddCat.Name = "btn_AddCat";
            this.btn_AddCat.Size = new System.Drawing.Size(221, 58);
            this.btn_AddCat.TabIndex = 18;
            this.btn_AddCat.Text = "Add Cat";
            this.btn_AddCat.UseVisualStyleBackColor = true;
            this.btn_AddCat.Click += new System.EventHandler(this.btn_AddCat_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(560, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Allergies";
            // 
            // richtbx_CatAllergies
            // 
            this.richtbx_CatAllergies.Location = new System.Drawing.Point(685, 190);
            this.richtbx_CatAllergies.Name = "richtbx_CatAllergies";
            this.richtbx_CatAllergies.Size = new System.Drawing.Size(281, 123);
            this.richtbx_CatAllergies.TabIndex = 13;
            this.richtbx_CatAllergies.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(560, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fur Color";
            // 
            // tbx_CatFurColor
            // 
            this.tbx_CatFurColor.Location = new System.Drawing.Point(685, 140);
            this.tbx_CatFurColor.Name = "tbx_CatFurColor";
            this.tbx_CatFurColor.Size = new System.Drawing.Size(277, 31);
            this.tbx_CatFurColor.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(560, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Breed";
            // 
            // tbx_CatBreed
            // 
            this.tbx_CatBreed.Location = new System.Drawing.Point(685, 87);
            this.tbx_CatBreed.Name = "tbx_CatBreed";
            this.tbx_CatBreed.Size = new System.Drawing.Size(277, 31);
            this.tbx_CatBreed.TabIndex = 9;
            // 
            // CatsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.Controls.Add(this.tabControl1);
            this.Name = "CatsControl";
            this.Size = new System.Drawing.Size(1087, 788);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GenericAnimal.ResumeLayout(false);
            this.GenericAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CatAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox tbx_CatName;
        private ComboBox cbx_CatGender;
        private NumericUpDown nud_CatAge;
        private Label label1;
        private RichTextBox richtbx_CatDesc;
        private TextBox tbx_CatBreed;
        private Label label6;
        private TextBox tbx_CatFurColor;
        private Label label7;
        private RichTextBox richtbx_CatAllergies;
        private Label label8;
        private RadioButton radiobtn_CatSterile;
        private RadioButton radiobtn_CatNotSterile;
        private Button btn_AddCat;
        private ComboBox cbx_CatShelter;
        private Button button1;
        private FlowLayoutPanel flp_AvailableCats;
        private Button button_ViewAllCats;
        private GroupBox GenericAnimal;
        private Label label11;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private GroupBox groupBox1;
    }
}
