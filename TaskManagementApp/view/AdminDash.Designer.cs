namespace TaskManagementApp.view
{
    partial class AdminDash
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
            label1 = new Label();
            dataGridViewTugasAdmin = new DataGridView();
            label2 = new Label();
            button1 = new Button();
            buttonKembaliWC = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTugasAdmin).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(282, 34);
            label1.Name = "label1";
            label1.Size = new Size(255, 38);
            label1.TabIndex = 0;
            label1.Text = "Dashboard Admin";
            // 
            // dataGridViewTugasAdmin
            // 
            dataGridViewTugasAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTugasAdmin.Location = new Point(125, 162);
            dataGridViewTugasAdmin.Name = "dataGridViewTugasAdmin";
            dataGridViewTugasAdmin.RowHeadersWidth = 51;
            dataGridViewTugasAdmin.Size = new Size(551, 188);
            dataGridViewTugasAdmin.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(125, 129);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 2;
            label2.Text = "Daftar Tugas";
            // 
            // button1
            // 
            button1.Location = new Point(468, 386);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Tambah";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonKembaliWC
            // 
            buttonKembaliWC.Location = new Point(582, 386);
            buttonKembaliWC.Name = "buttonKembaliWC";
            buttonKembaliWC.Size = new Size(94, 29);
            buttonKembaliWC.TabIndex = 4;
            buttonKembaliWC.Text = "Kembali";
            buttonKembaliWC.UseVisualStyleBackColor = true;
            // 
            // AdminDash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonKembaliWC);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(dataGridViewTugasAdmin);
            Controls.Add(label1);
            Name = "AdminDash";
            Text = "AdminDash";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTugasAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewTugasAdmin;
        private Label label2;
        private Button button1;
        private Button buttonKembaliWC;
    }
}