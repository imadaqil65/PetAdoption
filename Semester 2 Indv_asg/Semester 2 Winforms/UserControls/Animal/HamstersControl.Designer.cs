namespace Semester_2_Winforms.UserControls
{
	partial class HamstersControl
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
            this.button_ViewAllHamsters = new System.Windows.Forms.Button();
            this.flp_AvailableDogs = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radiobtn_IsHouseTrained = new System.Windows.Forms.RadioButton();
            this.radiobtn_NotHouseTrained = new System.Windows.Forms.RadioButton();
            this.GenericAnimal = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_DogName = new System.Windows.Forms.TextBox();
            this.cbx_DogGender = new System.Windows.Forms.ComboBox();
            this.nud_DogAge = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richtbx_DogDesc = new System.Windows.Forms.RichTextBox();
            this.cbx_DogShelter = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiobtn_IsSterile = new System.Windows.Forms.RadioButton();
            this.radiobtn_NotSterile = new System.Windows.Forms.RadioButton();
            this.Cbx_ActivityLevel = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_DogBreed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_AddDog = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GenericAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_DogAge)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.button_ViewAllHamsters);
            this.tabPage1.Controls.Add(this.flp_AvailableDogs);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1073, 744);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Available Hamsters";
            // 
            // button_ViewAllHamsters
            // 
            this.button_ViewAllHamsters.Location = new System.Drawing.Point(6, 34);
            this.button_ViewAllHamsters.Name = "button_ViewAllHamsters";
            this.button_ViewAllHamsters.Size = new System.Drawing.Size(181, 34);
            this.button_ViewAllHamsters.TabIndex = 1;
            this.button_ViewAllHamsters.Text = "View All Hamsters";
            this.button_ViewAllHamsters.UseVisualStyleBackColor = true;
            // 
            // flp_AvailableDogs
            // 
            this.flp_AvailableDogs.Location = new System.Drawing.Point(6, 74);
            this.flp_AvailableDogs.Name = "flp_AvailableDogs";
            this.flp_AvailableDogs.Size = new System.Drawing.Size(1061, 664);
            this.flp_AvailableDogs.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SandyBrown;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.GenericAnimal);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.Cbx_ActivityLevel);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tbx_DogBreed);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btn_AddDog);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1073, 744);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Hamsters";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radiobtn_IsHouseTrained);
            this.groupBox2.Controls.Add(this.radiobtn_NotHouseTrained);
            this.groupBox2.Location = new System.Drawing.Point(521, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 96);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Housetrained";
            // 
            // radiobtn_IsHouseTrained
            // 
            this.radiobtn_IsHouseTrained.AutoSize = true;
            this.radiobtn_IsHouseTrained.Location = new System.Drawing.Point(17, 41);
            this.radiobtn_IsHouseTrained.Name = "radiobtn_IsHouseTrained";
            this.radiobtn_IsHouseTrained.Size = new System.Drawing.Size(64, 29);
            this.radiobtn_IsHouseTrained.TabIndex = 25;
            this.radiobtn_IsHouseTrained.TabStop = true;
            this.radiobtn_IsHouseTrained.Text = "yes";
            this.radiobtn_IsHouseTrained.UseVisualStyleBackColor = true;
            // 
            // radiobtn_NotHouseTrained
            // 
            this.radiobtn_NotHouseTrained.AutoSize = true;
            this.radiobtn_NotHouseTrained.Location = new System.Drawing.Point(156, 41);
            this.radiobtn_NotHouseTrained.Name = "radiobtn_NotHouseTrained";
            this.radiobtn_NotHouseTrained.Size = new System.Drawing.Size(59, 29);
            this.radiobtn_NotHouseTrained.TabIndex = 26;
            this.radiobtn_NotHouseTrained.TabStop = true;
            this.radiobtn_NotHouseTrained.Text = "no";
            this.radiobtn_NotHouseTrained.UseVisualStyleBackColor = true;
            // 
            // GenericAnimal
            // 
            this.GenericAnimal.Controls.Add(this.label2);
            this.GenericAnimal.Controls.Add(this.tbx_DogName);
            this.GenericAnimal.Controls.Add(this.cbx_DogGender);
            this.GenericAnimal.Controls.Add(this.nud_DogAge);
            this.GenericAnimal.Controls.Add(this.label1);
            this.GenericAnimal.Controls.Add(this.label3);
            this.GenericAnimal.Controls.Add(this.label4);
            this.GenericAnimal.Controls.Add(this.label5);
            this.GenericAnimal.Controls.Add(this.richtbx_DogDesc);
            this.GenericAnimal.Controls.Add(this.cbx_DogShelter);
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
            // tbx_DogName
            // 
            this.tbx_DogName.Location = new System.Drawing.Point(140, 45);
            this.tbx_DogName.Name = "tbx_DogName";
            this.tbx_DogName.Size = new System.Drawing.Size(277, 31);
            this.tbx_DogName.TabIndex = 0;
            // 
            // cbx_DogGender
            // 
            this.cbx_DogGender.FormattingEnabled = true;
            this.cbx_DogGender.Location = new System.Drawing.Point(140, 148);
            this.cbx_DogGender.Name = "cbx_DogGender";
            this.cbx_DogGender.Size = new System.Drawing.Size(146, 33);
            this.cbx_DogGender.TabIndex = 1;
            // 
            // nud_DogAge
            // 
            this.nud_DogAge.Location = new System.Drawing.Point(140, 96);
            this.nud_DogAge.Name = "nud_DogAge";
            this.nud_DogAge.Size = new System.Drawing.Size(146, 31);
            this.nud_DogAge.TabIndex = 2;
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
            this.label3.Location = new System.Drawing.Point(18, 99);
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
            // richtbx_DogDesc
            // 
            this.richtbx_DogDesc.Location = new System.Drawing.Point(140, 257);
            this.richtbx_DogDesc.Name = "richtbx_DogDesc";
            this.richtbx_DogDesc.Size = new System.Drawing.Size(277, 163);
            this.richtbx_DogDesc.TabIndex = 8;
            this.richtbx_DogDesc.Text = "";
            // 
            // cbx_DogShelter
            // 
            this.cbx_DogShelter.FormattingEnabled = true;
            this.cbx_DogShelter.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbx_DogShelter.Location = new System.Drawing.Point(140, 202);
            this.cbx_DogShelter.Name = "cbx_DogShelter";
            this.cbx_DogShelter.Size = new System.Drawing.Size(277, 33);
            this.cbx_DogShelter.TabIndex = 19;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiobtn_IsSterile);
            this.groupBox1.Controls.Add(this.radiobtn_NotSterile);
            this.groupBox1.Location = new System.Drawing.Point(521, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 96);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sterile";
            // 
            // radiobtn_IsSterile
            // 
            this.radiobtn_IsSterile.AutoSize = true;
            this.radiobtn_IsSterile.Location = new System.Drawing.Point(20, 41);
            this.radiobtn_IsSterile.Name = "radiobtn_IsSterile";
            this.radiobtn_IsSterile.Size = new System.Drawing.Size(64, 29);
            this.radiobtn_IsSterile.TabIndex = 30;
            this.radiobtn_IsSterile.TabStop = true;
            this.radiobtn_IsSterile.Text = "yes";
            this.radiobtn_IsSterile.UseVisualStyleBackColor = true;
            // 
            // radiobtn_NotSterile
            // 
            this.radiobtn_NotSterile.AutoSize = true;
            this.radiobtn_NotSterile.Location = new System.Drawing.Point(152, 41);
            this.radiobtn_NotSterile.Name = "radiobtn_NotSterile";
            this.radiobtn_NotSterile.Size = new System.Drawing.Size(59, 29);
            this.radiobtn_NotSterile.TabIndex = 31;
            this.radiobtn_NotSterile.TabStop = true;
            this.radiobtn_NotSterile.Text = "no";
            this.radiobtn_NotSterile.UseVisualStyleBackColor = true;
            // 
            // Cbx_ActivityLevel
            // 
            this.Cbx_ActivityLevel.FormattingEnabled = true;
            this.Cbx_ActivityLevel.Location = new System.Drawing.Point(686, 137);
            this.Cbx_ActivityLevel.Name = "Cbx_ActivityLevel";
            this.Cbx_ActivityLevel.Size = new System.Drawing.Size(160, 33);
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
            // tbx_DogBreed
            // 
            this.tbx_DogBreed.Location = new System.Drawing.Point(686, 87);
            this.tbx_DogBreed.Name = "tbx_DogBreed";
            this.tbx_DogBreed.Size = new System.Drawing.Size(277, 31);
            this.tbx_DogBreed.TabIndex = 23;
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
            // 
            // btn_AddDog
            // 
            this.btn_AddDog.Location = new System.Drawing.Point(521, 434);
            this.btn_AddDog.Name = "btn_AddDog";
            this.btn_AddDog.Size = new System.Drawing.Size(221, 58);
            this.btn_AddDog.TabIndex = 18;
            this.btn_AddDog.Text = "Add Dog";
            this.btn_AddDog.UseVisualStyleBackColor = true;
            // 
            // HamstersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.Controls.Add(this.tabControl1);
            this.Name = "HamstersControl";
            this.Size = new System.Drawing.Size(1087, 788);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GenericAnimal.ResumeLayout(false);
            this.GenericAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_DogAge)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private TabControl tabControl1;
		private TabPage tabPage1;
		private Button button_ViewAllHamsters;
		private FlowLayoutPanel flp_AvailableDogs;
		private TabPage tabPage2;
		private GroupBox groupBox2;
		private RadioButton radiobtn_IsHouseTrained;
		private RadioButton radiobtn_NotHouseTrained;
		private GroupBox GenericAnimal;
		private Label label2;
		private TextBox tbx_DogName;
		private ComboBox cbx_DogGender;
		private NumericUpDown nud_DogAge;
		private Label label1;
		private Label label3;
		private Label label4;
		private Label label5;
		private RichTextBox richtbx_DogDesc;
		private ComboBox cbx_DogShelter;
		private Label label10;
		private GroupBox groupBox1;
		private RadioButton radiobtn_IsSterile;
		private RadioButton radiobtn_NotSterile;
		private ComboBox Cbx_ActivityLevel;
		private Label label8;
		private TextBox tbx_DogBreed;
		private Label label6;
		private Button button1;
		private Button btn_AddDog;
	}
}
