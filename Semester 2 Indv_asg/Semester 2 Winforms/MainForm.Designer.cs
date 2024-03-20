namespace Semester_2_Winforms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_RegisterAdmin = new System.Windows.Forms.Button();
            this.lbl_User = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_PendingAdoption = new System.Windows.Forms.Button();
            this.btn_Shelters = new System.Windows.Forms.Button();
            this.btn_AdoptedAnimals = new System.Windows.Forms.Button();
            this.btn_Hamsters = new System.Windows.Forms.Button();
            this.btn_Birds = new System.Windows.Forms.Button();
            this.btn_Dogs = new System.Windows.Forms.Button();
            this.btn_Cats = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_RegisterAdmin);
            this.groupBox1.Controls.Add(this.lbl_User);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Logout);
            this.groupBox1.Controls.Add(this.btn_PendingAdoption);
            this.groupBox1.Controls.Add(this.btn_Shelters);
            this.groupBox1.Controls.Add(this.btn_AdoptedAnimals);
            this.groupBox1.Controls.Add(this.btn_Hamsters);
            this.groupBox1.Controls.Add(this.btn_Birds);
            this.groupBox1.Controls.Add(this.btn_Dogs);
            this.groupBox1.Controls.Add(this.btn_Cats);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 806);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Box";
            // 
            // btn_RegisterAdmin
            // 
            this.btn_RegisterAdmin.BackColor = System.Drawing.Color.SeaShell;
            this.btn_RegisterAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegisterAdmin.Location = new System.Drawing.Point(179, 743);
            this.btn_RegisterAdmin.Name = "btn_RegisterAdmin";
            this.btn_RegisterAdmin.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.btn_RegisterAdmin.Size = new System.Drawing.Size(113, 45);
            this.btn_RegisterAdmin.TabIndex = 11;
            this.btn_RegisterAdmin.Text = "Register";
            this.btn_RegisterAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RegisterAdmin.UseVisualStyleBackColor = false;
            this.btn_RegisterAdmin.Click += new System.EventHandler(this.btn_RegisterAdmin_Click);
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(12, 42);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(177, 28);
            this.lbl_User.TabIndex = 10;
            this.lbl_User.Text = "Welcome {User}!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Store Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Animals";
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.SeaShell;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Location = new System.Drawing.Point(12, 743);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.btn_Logout.Size = new System.Drawing.Size(107, 45);
            this.btn_Logout.TabIndex = 7;
            this.btn_Logout.Text = "Log Out";
            this.btn_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_PendingAdoption
            // 
            this.btn_PendingAdoption.BackColor = System.Drawing.Color.SeaShell;
            this.btn_PendingAdoption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PendingAdoption.Location = new System.Drawing.Point(10, 413);
            this.btn_PendingAdoption.Name = "btn_PendingAdoption";
            this.btn_PendingAdoption.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_PendingAdoption.Size = new System.Drawing.Size(282, 45);
            this.btn_PendingAdoption.TabIndex = 6;
            this.btn_PendingAdoption.Text = "Pending Adoptions";
            this.btn_PendingAdoption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PendingAdoption.UseVisualStyleBackColor = false;
            this.btn_PendingAdoption.Click += new System.EventHandler(this.btn_PendingAdoption_Click);
            // 
            // btn_Shelters
            // 
            this.btn_Shelters.BackColor = System.Drawing.Color.SeaShell;
            this.btn_Shelters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Shelters.Location = new System.Drawing.Point(10, 464);
            this.btn_Shelters.Name = "btn_Shelters";
            this.btn_Shelters.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_Shelters.Size = new System.Drawing.Size(282, 45);
            this.btn_Shelters.TabIndex = 5;
            this.btn_Shelters.Text = "Shelters";
            this.btn_Shelters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Shelters.UseVisualStyleBackColor = false;
            this.btn_Shelters.Click += new System.EventHandler(this.btn_Shelters_Click);
            // 
            // btn_AdoptedAnimals
            // 
            this.btn_AdoptedAnimals.BackColor = System.Drawing.Color.SeaShell;
            this.btn_AdoptedAnimals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AdoptedAnimals.Location = new System.Drawing.Point(10, 515);
            this.btn_AdoptedAnimals.Name = "btn_AdoptedAnimals";
            this.btn_AdoptedAnimals.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_AdoptedAnimals.Size = new System.Drawing.Size(282, 45);
            this.btn_AdoptedAnimals.TabIndex = 4;
            this.btn_AdoptedAnimals.Text = "Adopted Animals";
            this.btn_AdoptedAnimals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AdoptedAnimals.UseVisualStyleBackColor = false;
            this.btn_AdoptedAnimals.Click += new System.EventHandler(this.btn_AdoptedAnimals_Click);
            // 
            // btn_Hamsters
            // 
            this.btn_Hamsters.BackColor = System.Drawing.Color.SeaShell;
            this.btn_Hamsters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Hamsters.Location = new System.Drawing.Point(10, 283);
            this.btn_Hamsters.Name = "btn_Hamsters";
            this.btn_Hamsters.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_Hamsters.Size = new System.Drawing.Size(282, 45);
            this.btn_Hamsters.TabIndex = 3;
            this.btn_Hamsters.Text = "Hamsters";
            this.btn_Hamsters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Hamsters.UseVisualStyleBackColor = false;
            this.btn_Hamsters.Visible = false;
            this.btn_Hamsters.Click += new System.EventHandler(this.btn_Hamsters_Click);
            // 
            // btn_Birds
            // 
            this.btn_Birds.BackColor = System.Drawing.Color.SeaShell;
            this.btn_Birds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Birds.Location = new System.Drawing.Point(10, 232);
            this.btn_Birds.Name = "btn_Birds";
            this.btn_Birds.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_Birds.Size = new System.Drawing.Size(282, 45);
            this.btn_Birds.TabIndex = 2;
            this.btn_Birds.Text = "Birds";
            this.btn_Birds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Birds.UseVisualStyleBackColor = false;
            this.btn_Birds.Click += new System.EventHandler(this.btn_Birds_Click);
            // 
            // btn_Dogs
            // 
            this.btn_Dogs.BackColor = System.Drawing.Color.SeaShell;
            this.btn_Dogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dogs.Location = new System.Drawing.Point(10, 181);
            this.btn_Dogs.Name = "btn_Dogs";
            this.btn_Dogs.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_Dogs.Size = new System.Drawing.Size(282, 45);
            this.btn_Dogs.TabIndex = 1;
            this.btn_Dogs.Text = "Dogs";
            this.btn_Dogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dogs.UseVisualStyleBackColor = false;
            this.btn_Dogs.Click += new System.EventHandler(this.btn_Dogs_Click);
            // 
            // btn_Cats
            // 
            this.btn_Cats.BackColor = System.Drawing.Color.SeaShell;
            this.btn_Cats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cats.Location = new System.Drawing.Point(10, 132);
            this.btn_Cats.Name = "btn_Cats";
            this.btn_Cats.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_Cats.Size = new System.Drawing.Size(282, 45);
            this.btn_Cats.TabIndex = 0;
            this.btn_Cats.Text = "Cats";
            this.btn_Cats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cats.UseVisualStyleBackColor = false;
            this.btn_Cats.Click += new System.EventHandler(this.btn_Cats_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::Semester_2_Winforms.Properties.Resources.Branding;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(308, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1087, 788);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(10, 566);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(282, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Customers";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1406, 806);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_Logout;
        private Button btn_PendingAdoption;
        private Button btn_Shelters;
        private Button btn_AdoptedAnimals;
        private Button btn_Hamsters;
        private Button btn_Birds;
        private Button btn_Dogs;
        private Button btn_Cats;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lbl_User;
        private Button btn_RegisterAdmin;
        private Button button1;
    }
}