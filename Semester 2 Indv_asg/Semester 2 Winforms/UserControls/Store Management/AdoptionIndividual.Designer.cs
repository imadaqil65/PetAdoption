namespace Semester_2_Winforms.UserControls.Store_Management
{
    partial class AdoptionIndividual
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
            this.btn_Accept = new System.Windows.Forms.Button();
            this.btn_Decline = new System.Windows.Forms.Button();
            this.lbl_Adopter = new System.Windows.Forms.Label();
            this.lbl_Animal = new System.Windows.Forms.Label();
            this.lbl_shelter = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_FullDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Accept
            // 
            this.btn_Accept.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Accept.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Accept.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Accept.Location = new System.Drawing.Point(13, 235);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(86, 34);
            this.btn_Accept.TabIndex = 0;
            this.btn_Accept.Text = "Accept";
            this.btn_Accept.UseVisualStyleBackColor = false;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // btn_Decline
            // 
            this.btn_Decline.BackColor = System.Drawing.Color.Red;
            this.btn_Decline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Decline.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Decline.Location = new System.Drawing.Point(105, 235);
            this.btn_Decline.Name = "btn_Decline";
            this.btn_Decline.Size = new System.Drawing.Size(86, 34);
            this.btn_Decline.TabIndex = 1;
            this.btn_Decline.Text = "Decline";
            this.btn_Decline.UseVisualStyleBackColor = false;
            this.btn_Decline.Click += new System.EventHandler(this.btn_Decline_Click);
            // 
            // lbl_Adopter
            // 
            this.lbl_Adopter.AutoSize = true;
            this.lbl_Adopter.Location = new System.Drawing.Point(13, 36);
            this.lbl_Adopter.Name = "lbl_Adopter";
            this.lbl_Adopter.Size = new System.Drawing.Size(59, 25);
            this.lbl_Adopter.TabIndex = 2;
            this.lbl_Adopter.Text = "label1";
            // 
            // lbl_Animal
            // 
            this.lbl_Animal.AutoSize = true;
            this.lbl_Animal.Location = new System.Drawing.Point(13, 98);
            this.lbl_Animal.Name = "lbl_Animal";
            this.lbl_Animal.Size = new System.Drawing.Size(59, 25);
            this.lbl_Animal.TabIndex = 3;
            this.lbl_Animal.Text = "label2";
            // 
            // lbl_shelter
            // 
            this.lbl_shelter.AutoSize = true;
            this.lbl_shelter.Location = new System.Drawing.Point(13, 161);
            this.lbl_shelter.Name = "lbl_shelter";
            this.lbl_shelter.Size = new System.Drawing.Size(59, 25);
            this.lbl_shelter.TabIndex = 4;
            this.lbl_shelter.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Requester:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Requested Animal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Shelter:";
            // 
            // btn_FullDetails
            // 
            this.btn_FullDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_FullDetails.Location = new System.Drawing.Point(13, 197);
            this.btn_FullDetails.Name = "btn_FullDetails";
            this.btn_FullDetails.Size = new System.Drawing.Size(178, 32);
            this.btn_FullDetails.TabIndex = 8;
            this.btn_FullDetails.Text = "Full Details";
            this.btn_FullDetails.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_FullDetails.UseVisualStyleBackColor = true;
            this.btn_FullDetails.Click += new System.EventHandler(this.btn_FullDetails_Click);
            // 
            // AdoptionIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.btn_FullDetails);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_shelter);
            this.Controls.Add(this.lbl_Animal);
            this.Controls.Add(this.lbl_Adopter);
            this.Controls.Add(this.btn_Decline);
            this.Controls.Add(this.btn_Accept);
            this.Name = "AdoptionIndividual";
            this.Size = new System.Drawing.Size(206, 279);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Accept;
        private Button btn_Decline;
        private Label lbl_Adopter;
        private Label lbl_Animal;
        private Label lbl_shelter;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btn_FullDetails;
    }
}
