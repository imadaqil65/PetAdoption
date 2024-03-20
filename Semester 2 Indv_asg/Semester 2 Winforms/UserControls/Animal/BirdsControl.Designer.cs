namespace Semester_2_Winforms.UserControls
{
	partial class BirdsControl
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
            this.button_ViewAllBirds = new System.Windows.Forms.Button();
            this.flp_AvailableBirds = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.nud_Wingspan = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radiobtn_IsVoiceMimic = new System.Windows.Forms.RadioButton();
            this.radiobtn_NotVoiceMimic = new System.Windows.Forms.RadioButton();
            this.GenericAnimal = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_BirdName = new System.Windows.Forms.TextBox();
            this.cbx_BirdGender = new System.Windows.Forms.ComboBox();
            this.nud_BirdAge = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richtbx_BirdDesc = new System.Windows.Forms.RichTextBox();
            this.cbx_BirdShelter = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Cbx_ActivityLevel = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_BirdBreed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_AddBird = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Wingspan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.GenericAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_BirdAge)).BeginInit();
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
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SandyBrown;
            this.tabPage1.Controls.Add(this.button_ViewAllBirds);
            this.tabPage1.Controls.Add(this.flp_AvailableBirds);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1073, 744);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Available Birds";
            // 
            // button_ViewAllBirds
            // 
            this.button_ViewAllBirds.Location = new System.Drawing.Point(6, 34);
            this.button_ViewAllBirds.Name = "button_ViewAllBirds";
            this.button_ViewAllBirds.Size = new System.Drawing.Size(181, 34);
            this.button_ViewAllBirds.TabIndex = 1;
            this.button_ViewAllBirds.Text = "Refresh Birds";
            this.button_ViewAllBirds.UseVisualStyleBackColor = true;
            this.button_ViewAllBirds.Click += new System.EventHandler(this.button_ViewAllBirds_Click);
            // 
            // flp_AvailableBirds
            // 
            this.flp_AvailableBirds.AutoScroll = true;
            this.flp_AvailableBirds.Location = new System.Drawing.Point(6, 74);
            this.flp_AvailableBirds.Name = "flp_AvailableBirds";
            this.flp_AvailableBirds.Size = new System.Drawing.Size(1061, 664);
            this.flp_AvailableBirds.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SandyBrown;
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.nud_Wingspan);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.GenericAnimal);
            this.tabPage2.Controls.Add(this.Cbx_ActivityLevel);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tbx_BirdBreed);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btn_AddBird);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1073, 744);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Birds";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(810, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 25);
            this.label9.TabIndex = 36;
            this.label9.Text = "cm";
            // 
            // nud_Wingspan
            // 
            this.nud_Wingspan.Location = new System.Drawing.Point(686, 195);
            this.nud_Wingspan.Name = "nud_Wingspan";
            this.nud_Wingspan.Size = new System.Drawing.Size(121, 31);
            this.nud_Wingspan.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(524, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "Wingspan";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radiobtn_IsVoiceMimic);
            this.groupBox2.Controls.Add(this.radiobtn_NotVoiceMimic);
            this.groupBox2.Location = new System.Drawing.Point(524, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 96);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Voice Mimic";
            // 
            // radiobtn_IsVoiceMimic
            // 
            this.radiobtn_IsVoiceMimic.AutoSize = true;
            this.radiobtn_IsVoiceMimic.Location = new System.Drawing.Point(17, 41);
            this.radiobtn_IsVoiceMimic.Name = "radiobtn_IsVoiceMimic";
            this.radiobtn_IsVoiceMimic.Size = new System.Drawing.Size(64, 29);
            this.radiobtn_IsVoiceMimic.TabIndex = 25;
            this.radiobtn_IsVoiceMimic.TabStop = true;
            this.radiobtn_IsVoiceMimic.Text = "yes";
            this.radiobtn_IsVoiceMimic.UseVisualStyleBackColor = true;
            // 
            // radiobtn_NotVoiceMimic
            // 
            this.radiobtn_NotVoiceMimic.AutoSize = true;
            this.radiobtn_NotVoiceMimic.Location = new System.Drawing.Point(156, 41);
            this.radiobtn_NotVoiceMimic.Name = "radiobtn_NotVoiceMimic";
            this.radiobtn_NotVoiceMimic.Size = new System.Drawing.Size(59, 29);
            this.radiobtn_NotVoiceMimic.TabIndex = 26;
            this.radiobtn_NotVoiceMimic.TabStop = true;
            this.radiobtn_NotVoiceMimic.Text = "no";
            this.radiobtn_NotVoiceMimic.UseVisualStyleBackColor = true;
            // 
            // GenericAnimal
            // 
            this.GenericAnimal.Controls.Add(this.label2);
            this.GenericAnimal.Controls.Add(this.tbx_BirdName);
            this.GenericAnimal.Controls.Add(this.cbx_BirdGender);
            this.GenericAnimal.Controls.Add(this.nud_BirdAge);
            this.GenericAnimal.Controls.Add(this.label1);
            this.GenericAnimal.Controls.Add(this.label3);
            this.GenericAnimal.Controls.Add(this.label4);
            this.GenericAnimal.Controls.Add(this.label5);
            this.GenericAnimal.Controls.Add(this.richtbx_BirdDesc);
            this.GenericAnimal.Controls.Add(this.cbx_BirdShelter);
            this.GenericAnimal.Controls.Add(this.label10);
            this.GenericAnimal.Location = new System.Drawing.Point(53, 43);
            this.GenericAnimal.Name = "GenericAnimal";
            this.GenericAnimal.Size = new System.Drawing.Size(445, 449);
            this.GenericAnimal.TabIndex = 33;
            this.GenericAnimal.TabStop = false;
            this.GenericAnimal.Text = "Basic Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // tbx_BirdName
            // 
            this.tbx_BirdName.Location = new System.Drawing.Point(140, 45);
            this.tbx_BirdName.Name = "tbx_BirdName";
            this.tbx_BirdName.Size = new System.Drawing.Size(277, 31);
            this.tbx_BirdName.TabIndex = 0;
            // 
            // cbx_BirdGender
            // 
            this.cbx_BirdGender.FormattingEnabled = true;
            this.cbx_BirdGender.Location = new System.Drawing.Point(140, 148);
            this.cbx_BirdGender.Name = "cbx_BirdGender";
            this.cbx_BirdGender.Size = new System.Drawing.Size(146, 33);
            this.cbx_BirdGender.TabIndex = 1;
            // 
            // nud_BirdAge
            // 
            this.nud_BirdAge.Location = new System.Drawing.Point(140, 96);
            this.nud_BirdAge.Name = "nud_BirdAge";
            this.nud_BirdAge.Size = new System.Drawing.Size(146, 31);
            this.nud_BirdAge.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Year(s) Old";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Description";
            // 
            // richtbx_BirdDesc
            // 
            this.richtbx_BirdDesc.Location = new System.Drawing.Point(140, 257);
            this.richtbx_BirdDesc.Name = "richtbx_BirdDesc";
            this.richtbx_BirdDesc.Size = new System.Drawing.Size(277, 163);
            this.richtbx_BirdDesc.TabIndex = 8;
            this.richtbx_BirdDesc.Text = "";
            // 
            // cbx_BirdShelter
            // 
            this.cbx_BirdShelter.FormattingEnabled = true;
            this.cbx_BirdShelter.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbx_BirdShelter.Location = new System.Drawing.Point(140, 202);
            this.cbx_BirdShelter.Name = "cbx_BirdShelter";
            this.cbx_BirdShelter.Size = new System.Drawing.Size(277, 33);
            this.cbx_BirdShelter.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Shelter";
            // 
            // Cbx_ActivityLevel
            // 
            this.Cbx_ActivityLevel.FormattingEnabled = true;
            this.Cbx_ActivityLevel.Location = new System.Drawing.Point(686, 137);
            this.Cbx_ActivityLevel.Name = "Cbx_ActivityLevel";
            this.Cbx_ActivityLevel.Size = new System.Drawing.Size(178, 33);
            this.Cbx_ActivityLevel.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(524, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "Activity Level";
            // 
            // tbx_BirdBreed
            // 
            this.tbx_BirdBreed.Location = new System.Drawing.Point(686, 87);
            this.tbx_BirdBreed.Name = "tbx_BirdBreed";
            this.tbx_BirdBreed.Size = new System.Drawing.Size(277, 31);
            this.tbx_BirdBreed.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(524, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Breed";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "Prefilled";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // btn_AddBird
            // 
            this.btn_AddBird.Location = new System.Drawing.Point(524, 434);
            this.btn_AddBird.Name = "btn_AddBird";
            this.btn_AddBird.Size = new System.Drawing.Size(221, 58);
            this.btn_AddBird.TabIndex = 18;
            this.btn_AddBird.Text = "Add Bird";
            this.btn_AddBird.UseVisualStyleBackColor = true;
            this.btn_AddBird.Click += new System.EventHandler(this.btn_AddBird_Click);
            // 
            // BirdsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.Controls.Add(this.tabControl1);
            this.Name = "BirdsControl";
            this.Size = new System.Drawing.Size(1087, 788);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Wingspan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GenericAnimal.ResumeLayout(false);
            this.GenericAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_BirdAge)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private TabControl tabControl1;
		private TabPage tabPage1;
		private Button button_ViewAllBirds;
		private FlowLayoutPanel flp_AvailableBirds;
		private TabPage tabPage2;
		private GroupBox groupBox2;
		private RadioButton radiobtn_IsVoiceMimic;
		private RadioButton radiobtn_NotVoiceMimic;
		private GroupBox GenericAnimal;
		private Label label2;
		private TextBox tbx_BirdName;
		private ComboBox cbx_BirdGender;
		private NumericUpDown nud_BirdAge;
		private Label label1;
		private Label label3;
		private Label label4;
		private Label label5;
		private RichTextBox richtbx_BirdDesc;
		private ComboBox cbx_BirdShelter;
		private Label label10;
		private ComboBox Cbx_ActivityLevel;
		private Label label8;
		private TextBox tbx_BirdBreed;
		private Label label6;
		private Button button1;
		private Button btn_AddBird;
        private Label label7;
        private NumericUpDown nud_Wingspan;
        private Label label9;
    }
}
