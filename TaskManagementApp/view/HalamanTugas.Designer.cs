namespace TaskManagementApp.view
{
    partial class HalamanTugas
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
            dataGridViewHalTugas = new DataGridView();
            buttonKembali = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHalTugas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(290, 64);
            label1.Name = "label1";
            label1.Size = new Size(217, 38);
            label1.TabIndex = 0;
            label1.Text = "Halaman Tugas";
            // 
            // dataGridViewHalTugas
            // 
            dataGridViewHalTugas.BackgroundColor = SystemColors.Window;
            dataGridViewHalTugas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHalTugas.Location = new Point(125, 154);
            dataGridViewHalTugas.Name = "dataGridViewHalTugas";
            dataGridViewHalTugas.RowHeadersWidth = 51;
            dataGridViewHalTugas.Size = new Size(533, 188);
            dataGridViewHalTugas.TabIndex = 1;
            // 
            // buttonKembali
            // 
            buttonKembali.Location = new Point(336, 388);
            buttonKembali.Name = "buttonKembali";
            buttonKembali.Size = new Size(94, 29);
            buttonKembali.TabIndex = 2;
            buttonKembali.Text = "Kembali";
            buttonKembali.UseVisualStyleBackColor = true;
            buttonKembali.Click += buttonKembali_Click;
            // 
            // HalamanTugas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonKembali);
            Controls.Add(dataGridViewHalTugas);
            Controls.Add(label1);
            Name = "HalamanTugas";
            Text = "HalamanTugas";
            ((System.ComponentModel.ISupportInitialize)dataGridViewHalTugas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewHalTugas;
        private Button buttonKembali;
    }
}