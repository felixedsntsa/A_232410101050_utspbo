namespace TaskManagementApp
{
    partial class HalWelcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            buttonHalTugas = new Button();
            buttonRegisUser = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(160, 45);
            label1.Name = "label1";
            label1.Size = new Size(486, 38);
            label1.TabIndex = 0;
            label1.Text = "Welcome To Task Management App\r\n";
            // 
            // buttonHalTugas
            // 
            buttonHalTugas.Location = new Point(294, 158);
            buttonHalTugas.Name = "buttonHalTugas";
            buttonHalTugas.Size = new Size(179, 29);
            buttonHalTugas.TabIndex = 1;
            buttonHalTugas.Text = "Halaman Tugas";
            buttonHalTugas.UseVisualStyleBackColor = true;
            buttonHalTugas.Click += buttonHalTugas_Click;
            // 
            // buttonRegisUser
            // 
            buttonRegisUser.Location = new Point(294, 212);
            buttonRegisUser.Name = "buttonRegisUser";
            buttonRegisUser.Size = new Size(179, 29);
            buttonRegisUser.TabIndex = 2;
            buttonRegisUser.Text = "Halaman Regis User\r\n";
            buttonRegisUser.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(294, 270);
            button1.Name = "button1";
            button1.Size = new Size(179, 29);
            button1.TabIndex = 3;
            button1.Text = "Halaman Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // HalWelcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(buttonRegisUser);
            Controls.Add(buttonHalTugas);
            Controls.Add(label1);
            Name = "HalWelcome";
            Text = "HalWelcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonHalTugas;
        private Button buttonRegisUser;
        private Button button1;
    }
}
