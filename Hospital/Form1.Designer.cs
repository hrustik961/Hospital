namespace Hospital
{
    partial class Form1
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
            btnOpenInput = new Button();
            btnOpenQueries = new Button();
            btnOpenReports = new Button();
            SuspendLayout();
            // 
            // btnOpenInput
            // 
            btnOpenInput.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnOpenInput.Location = new Point(31, 100);
            btnOpenInput.Name = "btnOpenInput";
            btnOpenInput.Size = new Size(285, 49);
            btnOpenInput.TabIndex = 0;
            btnOpenInput.Text = "Форми введення даних";
            btnOpenInput.UseVisualStyleBackColor = true;
            btnOpenInput.Click += btnOpenInput_Click;
            // 
            // btnOpenQueries
            // 
            btnOpenQueries.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOpenQueries.Location = new Point(31, 166);
            btnOpenQueries.Name = "btnOpenQueries";
            btnOpenQueries.Size = new Size(285, 50);
            btnOpenQueries.TabIndex = 1;
            btnOpenQueries.Text = "Запити";
            btnOpenQueries.UseVisualStyleBackColor = true;
            btnOpenQueries.Click += btnOpenQueries_Click;
            // 
            // btnOpenReports
            // 
            btnOpenReports.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOpenReports.Location = new Point(31, 240);
            btnOpenReports.Name = "btnOpenReports";
            btnOpenReports.Size = new Size(285, 52);
            btnOpenReports.TabIndex = 2;
            btnOpenReports.Text = "Звіти та графіки";
            btnOpenReports.UseVisualStyleBackColor = true;
            btnOpenReports.Click += btnOpenReports_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOpenReports);
            Controls.Add(btnOpenQueries);
            Controls.Add(btnOpenInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox3;
        private Button btnOpenInput;
        private Button btnOpenQueries;
        private Button btnOpenReports;
    }
}
