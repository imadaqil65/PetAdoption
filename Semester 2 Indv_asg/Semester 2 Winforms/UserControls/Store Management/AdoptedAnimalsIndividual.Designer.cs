namespace Semester_2_Winforms.UserControls.Store_Management
{
    partial class AdoptedAnimalsIndividual
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
            this.lbl_Animal = new System.Windows.Forms.Label();
            this.lbl_Adopter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Animal
            // 
            this.lbl_Animal.AutoSize = true;
            this.lbl_Animal.Location = new System.Drawing.Point(3, 41);
            this.lbl_Animal.Name = "lbl_Animal";
            this.lbl_Animal.Size = new System.Drawing.Size(59, 25);
            this.lbl_Animal.TabIndex = 0;
            this.lbl_Animal.Text = "label1";
            // 
            // lbl_Adopter
            // 
            this.lbl_Adopter.AutoSize = true;
            this.lbl_Adopter.Location = new System.Drawing.Point(3, 140);
            this.lbl_Adopter.Name = "lbl_Adopter";
            this.lbl_Adopter.Size = new System.Drawing.Size(59, 25);
            this.lbl_Adopter.TabIndex = 1;
            this.lbl_Adopter.Text = "label2";
            // 
            // AdoptedAnimalsIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lbl_Adopter);
            this.Controls.Add(this.lbl_Animal);
            this.Name = "AdoptedAnimalsIndividual";
            this.Size = new System.Drawing.Size(259, 279);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Animal;
        private Label lbl_Adopter;
    }
}
