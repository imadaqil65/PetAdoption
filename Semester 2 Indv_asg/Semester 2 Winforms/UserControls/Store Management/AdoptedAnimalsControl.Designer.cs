namespace Semester_2_Winforms.UserControls.Store_Management
{
    partial class AdoptedAnimalsControl
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
            this.btn_ViewAllRequests = new System.Windows.Forms.Button();
            this.flp_AdoptionRequests = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btn_ViewAllRequests
            // 
            this.btn_ViewAllRequests.Location = new System.Drawing.Point(12, 62);
            this.btn_ViewAllRequests.Name = "btn_ViewAllRequests";
            this.btn_ViewAllRequests.Size = new System.Drawing.Size(217, 34);
            this.btn_ViewAllRequests.TabIndex = 3;
            this.btn_ViewAllRequests.Text = "Refresh Requests";
            this.btn_ViewAllRequests.UseVisualStyleBackColor = true;
            // 
            // flp_AdoptionRequests
            // 
            this.flp_AdoptionRequests.AutoScroll = true;
            this.flp_AdoptionRequests.BackColor = System.Drawing.Color.SandyBrown;
            this.flp_AdoptionRequests.Location = new System.Drawing.Point(11, 114);
            this.flp_AdoptionRequests.Name = "flp_AdoptionRequests";
            this.flp_AdoptionRequests.Size = new System.Drawing.Size(1061, 656);
            this.flp_AdoptionRequests.TabIndex = 2;
            // 
            // AdoptedAnimalsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.Controls.Add(this.btn_ViewAllRequests);
            this.Controls.Add(this.flp_AdoptionRequests);
            this.Name = "AdoptedAnimalsControl";
            this.Size = new System.Drawing.Size(1087, 788);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_ViewAllRequests;
        private FlowLayoutPanel flp_AdoptionRequests;
    }
}
