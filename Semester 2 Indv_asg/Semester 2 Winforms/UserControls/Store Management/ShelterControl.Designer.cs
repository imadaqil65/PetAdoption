namespace Semester_2_Winforms.UserControls.Store_Management
{
    partial class ShelterControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CreateShelter = new System.Windows.Forms.Button();
            this.richtbx_Address = new System.Windows.Forms.RichTextBox();
            this.tbx_LocationCity = new System.Windows.Forms.TextBox();
            this.tbx_ShelterName = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btn_Refresh);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(10, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1065, 757);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shelter";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_CreateShelter);
            this.groupBox2.Controls.Add(this.richtbx_Address);
            this.groupBox2.Controls.Add(this.tbx_LocationCity);
            this.groupBox2.Controls.Add(this.tbx_ShelterName);
            this.groupBox2.Location = new System.Drawing.Point(707, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 565);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Shelter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address (Street, Postcode, etc):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Location (City):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Shelter Name:";
            // 
            // btn_CreateShelter
            // 
            this.btn_CreateShelter.Location = new System.Drawing.Point(24, 476);
            this.btn_CreateShelter.Name = "btn_CreateShelter";
            this.btn_CreateShelter.Size = new System.Drawing.Size(160, 34);
            this.btn_CreateShelter.TabIndex = 3;
            this.btn_CreateShelter.Text = "Create Shelter";
            this.btn_CreateShelter.UseVisualStyleBackColor = true;
            this.btn_CreateShelter.Click += new System.EventHandler(this.btn_CreateShelter_Click);
            // 
            // richtbx_Address
            // 
            this.richtbx_Address.Location = new System.Drawing.Point(24, 310);
            this.richtbx_Address.Name = "richtbx_Address";
            this.richtbx_Address.Size = new System.Drawing.Size(307, 144);
            this.richtbx_Address.TabIndex = 2;
            this.richtbx_Address.Text = "";
            // 
            // tbx_LocationCity
            // 
            this.tbx_LocationCity.Location = new System.Drawing.Point(24, 208);
            this.tbx_LocationCity.Name = "tbx_LocationCity";
            this.tbx_LocationCity.Size = new System.Drawing.Size(307, 31);
            this.tbx_LocationCity.TabIndex = 1;
            // 
            // tbx_ShelterName
            // 
            this.tbx_ShelterName.Location = new System.Drawing.Point(24, 109);
            this.tbx_ShelterName.Name = "tbx_ShelterName";
            this.tbx_ShelterName.Size = new System.Drawing.Size(307, 31);
            this.tbx_ShelterName.TabIndex = 0;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(6, 62);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(169, 34);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.Text = "Refresh List";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(43, 102);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(658, 649);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ShelterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.Controls.Add(this.groupBox1);
            this.Name = "ShelterControl";
            this.Size = new System.Drawing.Size(1087, 788);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_Refresh;
        private GroupBox groupBox2;
        private TextBox tbx_ShelterName;
        private TextBox tbx_LocationCity;
        private RichTextBox richtbx_Address;
        private Button btn_CreateShelter;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
