namespace Semester_2_Winforms.UserControls.Animal.ModifyAnimal
{
    partial class ModifyShelter
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_EditShelter = new System.Windows.Forms.Button();
            this.richtbx_Address = new System.Windows.Forms.RichTextBox();
            this.tbx_LocationCity = new System.Windows.Forms.TextBox();
            this.tbx_ShelterName = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_EditShelter);
            this.groupBox2.Controls.Add(this.richtbx_Address);
            this.groupBox2.Controls.Add(this.tbx_LocationCity);
            this.groupBox2.Controls.Add(this.tbx_ShelterName);
            this.groupBox2.Location = new System.Drawing.Point(50, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 519);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Shelter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address (Street, Postcode, etc):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Location (City):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Shelter Name:";
            // 
            // btn_EditShelter
            // 
            this.btn_EditShelter.Location = new System.Drawing.Point(24, 470);
            this.btn_EditShelter.Name = "btn_EditShelter";
            this.btn_EditShelter.Size = new System.Drawing.Size(160, 34);
            this.btn_EditShelter.TabIndex = 3;
            this.btn_EditShelter.Text = "Edit Shelter";
            this.btn_EditShelter.UseVisualStyleBackColor = true;
            this.btn_EditShelter.Click += new System.EventHandler(this.btn_EditShelter_Click);
            // 
            // richtbx_Address
            // 
            this.richtbx_Address.Location = new System.Drawing.Point(24, 272);
            this.richtbx_Address.Name = "richtbx_Address";
            this.richtbx_Address.Size = new System.Drawing.Size(307, 144);
            this.richtbx_Address.TabIndex = 2;
            this.richtbx_Address.Text = "";
            // 
            // tbx_LocationCity
            // 
            this.tbx_LocationCity.Location = new System.Drawing.Point(24, 170);
            this.tbx_LocationCity.Name = "tbx_LocationCity";
            this.tbx_LocationCity.Size = new System.Drawing.Size(307, 31);
            this.tbx_LocationCity.TabIndex = 1;
            // 
            // tbx_ShelterName
            // 
            this.tbx_ShelterName.Location = new System.Drawing.Point(24, 71);
            this.tbx_ShelterName.Name = "tbx_ShelterName";
            this.tbx_ShelterName.Size = new System.Drawing.Size(307, 31);
            this.tbx_ShelterName.TabIndex = 0;
            // 
            // ModifyShelter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.Controls.Add(this.groupBox2);
            this.Name = "ModifyShelter";
            this.Size = new System.Drawing.Size(453, 551);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_EditShelter;
        private RichTextBox richtbx_Address;
        private TextBox tbx_LocationCity;
        private TextBox tbx_ShelterName;
    }
}
