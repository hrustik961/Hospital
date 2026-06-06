namespace Hospital
{
    partial class ReportsForm
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
            btnBack = new Button();
            dgvReport = new DataGridView();
            tabControl1 = new TabControl();
            tabReportPage = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            tabControl1.SuspendLayout();
            tabReportPage.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(694, 409);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 0;
            btnBack.Text = "назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvReport
            // 
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(6, 3);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 51;
            dgvReport.Size = new Size(303, 203);
            dgvReport.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabReportPage);
            tabControl1.Location = new Point(12, 74);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(321, 245);
            tabControl1.TabIndex = 2;
            // 
            // tabReportPage
            // 
            tabReportPage.Controls.Add(dgvReport);
            tabReportPage.Location = new Point(4, 29);
            tabReportPage.Name = "tabReportPage";
            tabReportPage.Padding = new Padding(3);
            tabReportPage.Size = new Size(313, 212);
            tabReportPage.TabIndex = 0;
            tabReportPage.Text = "Таблиця завантаженості";
            tabReportPage.UseVisualStyleBackColor = true;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(btnBack);
            Name = "ReportsForm";
            Text = "ReportsForm";
            Load += ReportsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            tabControl1.ResumeLayout(false);
            tabReportPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private DataGridView dgvReport;
        private TabControl tabControl1;
        private TabPage tabReportPage;
    }
}