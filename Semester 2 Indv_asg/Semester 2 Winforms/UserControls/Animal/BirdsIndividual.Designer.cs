namespace Semester_2_Winforms.UserControls
{
	partial class BirdsIndividual
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Shelter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Modify
            // 
            this.btn_Modify.Location = new System.Drawing.Point(43, 141);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(112, 34);
            this.btn_Modify.TabIndex = 0;
            this.btn_Modify.Text = "Modify";
            this.btn_Modify.UseVisualStyleBackColor = true;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(43, 181);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(112, 34);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(-1, 23);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(59, 25);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "label1";
            // 
            // lbl_Shelter
            // 
            this.lbl_Shelter.AutoSize = true;
            this.lbl_Shelter.Location = new System.Drawing.Point(-1, 81);
            this.lbl_Shelter.Name = "lbl_Shelter";
            this.lbl_Shelter.Size = new System.Drawing.Size(59, 25);
            this.lbl_Shelter.TabIndex = 3;
            this.lbl_Shelter.Text = "label2";
            // 
            // BirdsIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.lbl_Shelter);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Modify);
            this.Name = "BirdsIndividual";
            this.Size = new System.Drawing.Size(206, 225);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Button btn_Modify;
		private Button btn_Delete;
        private Label lbl_Name;
        private Label lbl_Shelter;
    }
}
