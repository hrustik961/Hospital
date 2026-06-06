namespace Hospital
{
    // ВИПРАВЛЕНО: тепер назва класу строго InputForm, як і має бути!
    partial class InputForm
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
            label2 = new Label();
            label3 = new Label();
            txbPhone = new TextBox();
            txbName = new TextBox();
            btnSave = new Button();
            btnBack = new Button();
            cmbDepts = new ComboBox();
            dgvPatients = new DataGridView();
            tabControl1 = new TabControl();
            tabQueryPage = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            tabControl1.SuspendLayout();
            tabQueryPage.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 52);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "ПІБ пацієнта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 52);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Телефон";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(387, 52);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 2;
            label3.Text = "Оберіть відділення";
            // 
            // txbPhone
            // 
            txbPhone.Location = new Point(222, 75);
            txbPhone.Name = "txbPhone";
            txbPhone.Size = new Size(125, 27);
            txbPhone.TabIndex = 4;
            // 
            // txbName
            // 
            txbName.Location = new Point(52, 75);
            txbName.Name = "txbName";
            txbName.Size = new Size(125, 27);
            txbName.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(531, 128);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Зберегти пацієнта";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(699, 409);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(89, 29);
            btnBack.TabIndex = 7;
            btnBack.Text = "назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // cmbDepts
            // 
            cmbDepts.FormattingEnabled = true;
            cmbDepts.Location = new Point(387, 75);
            cmbDepts.Name = "cmbDepts";
            cmbDepts.Size = new Size(151, 28);
            cmbDepts.TabIndex = 8;
            // 
            // dgvPatients
            // 
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Location = new Point(6, 6);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.RowHeadersWidth = 51;
            dgvPatients.Size = new Size(457, 159);
            dgvPatients.TabIndex = 9;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabQueryPage);
            tabControl1.Location = new Point(52, 128);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(477, 204);
            tabControl1.TabIndex = 10;
            // 
            // tabQueryPage
            // 
            tabQueryPage.Controls.Add(dgvPatients);
            tabQueryPage.Location = new Point(4, 29);
            tabQueryPage.Name = "tabQueryPage";
            tabQueryPage.Padding = new Padding(3);
            tabQueryPage.Size = new Size(469, 171);
            tabQueryPage.TabIndex = 0;
            tabQueryPage.Text = "База пацієнтів";
            tabQueryPage.UseVisualStyleBackColor = true;
            // 
            // InputForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(cmbDepts);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(txbName);
            Controls.Add(txbPhone);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InputForm";
            Text = "Введення та модифікація даних";
            Load += InputForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            tabControl1.ResumeLayout(false);
            tabQueryPage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbDepts;
        private System.Windows.Forms.DataGridView dgvPatients;
        private TabControl tabControl1;
        private TabPage tabQueryPage;
    }
}