namespace Semester_2_Winforms.UserControls.Store_Management
{
    partial class ShelterIndividual
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
            this.btn_Modify = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lbl_ShelterName = new System.Windows.Forms.Label();
            this.lbl_location = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Modify
            // 
            this.btn_Modify.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Modify.Location = new System.Drawing.Point(33, 160);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(219, 28);
            this.btn_Modify.TabIndex = 0;
            this.btn_Modify.Text = "Modify";
            this.btn_Modify.UseVisualStyleBackColor = true;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Delete.Location = new System.Drawing.Point(33, 194);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(219, 28);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lbl_ShelterName
            // 
            this.lbl_ShelterName.AutoSize = true;
            this.lbl_ShelterName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ShelterName.Location = new System.Drawing.Point(11, 13);
            this.lbl_ShelterName.Name = "lbl_ShelterName";
            this.lbl_ShelterName.Size = new System.Drawing.Size(59, 25);
            this.lbl_ShelterName.TabIndex = 2;
            this.lbl_ShelterName.Text = "label1";
            // 
            // lbl_location
            // 
            this.lbl_location.AutoSize = true;
            this.lbl_location.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_location.Location = new System.Drawing.Point(11, 66);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(59, 25);
            this.lbl_location.TabIndex = 3;
            this.lbl_location.Text = "label1";
            // 
            // ShelterIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.lbl_location);
            this.Controls.Add(this.lbl_ShelterName);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Modify);
            this.Name = "ShelterIndividual";
            this.Size = new System.Drawing.Size(285, 233);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Modify;
        private Button btn_Delete;
        private Label lbl_ShelterName;
        private Label lbl_location;
    }
}
