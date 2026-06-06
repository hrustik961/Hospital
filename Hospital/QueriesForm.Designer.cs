namespace Hospital
{
    partial class QueriesForm
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
            lstQueries = new ListBox();
            lblDescription = new Label();
            btnExecute = new Button();
            dgvResults = new DataGridView();
            lblParamHint = new Label();
            txbParamText = new TextBox();
            txbParamNumber = new TextBox();
            tabControl1 = new TabControl();
            tabQueryPage = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            tabControl1.SuspendLayout();
            tabQueryPage.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(697, 409);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(91, 29);
            btnBack.TabIndex = 0;
            btnBack.Text = "назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lstQueries
            // 
            lstQueries.FormattingEnabled = true;
            lstQueries.Location = new Point(12, 26);
            lstQueries.Name = "lstQueries";
            lstQueries.Size = new Size(201, 144);
            lstQueries.TabIndex = 1;
            lstQueries.SelectedIndexChanged += lstQueries_SelectedIndexChanged;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(236, 38);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(50, 20);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "label1";
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(497, 151);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(171, 29);
            btnExecute.TabIndex = 4;
            btnExecute.Text = "Виконати запит";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click;
            // 
            // dgvResults
            // 
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Location = new Point(3, 6);
            dgvResults.Name = "dgvResults";
            dgvResults.RowHeadersWidth = 51;
            dgvResults.Size = new Size(456, 124);
            dgvResults.TabIndex = 5;
            // 
            // lblParamHint
            // 
            lblParamHint.AutoSize = true;
            lblParamHint.Location = new Point(236, 69);
            lblParamHint.Name = "lblParamHint";
            lblParamHint.Size = new Size(210, 20);
            lblParamHint.TabIndex = 6;
            lblParamHint.Text = "Введіть значення параметра";
            // 
            // txbParamText
            // 
            txbParamText.Location = new Point(236, 109);
            txbParamText.Name = "txbParamText";
            txbParamText.Size = new Size(125, 27);
            txbParamText.TabIndex = 7;
            // 
            // txbParamNumber
            // 
            txbParamNumber.Location = new Point(367, 109);
            txbParamNumber.Name = "txbParamNumber";
            txbParamNumber.Size = new Size(125, 27);
            txbParamNumber.TabIndex = 8;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabQueryPage);
            tabControl1.Location = new Point(236, 208);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(473, 169);
            tabControl1.TabIndex = 9;
            // 
            // tabQueryPage
            // 
            tabQueryPage.Controls.Add(dgvResults);
            tabQueryPage.Location = new Point(4, 29);
            tabQueryPage.Name = "tabQueryPage";
            tabQueryPage.Padding = new Padding(3);
            tabQueryPage.Size = new Size(465, 136);
            tabQueryPage.TabIndex = 0;
            tabQueryPage.Text = ".";
            tabQueryPage.UseVisualStyleBackColor = true;
            // 
            // QueriesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(txbParamNumber);
            Controls.Add(txbParamText);
            Controls.Add(lblParamHint);
            Controls.Add(btnExecute);
            Controls.Add(lblDescription);
            Controls.Add(lstQueries);
            Controls.Add(btnBack);
            Name = "QueriesForm";
            Text = "QueriesForm";
            Load += QueriesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            tabControl1.ResumeLayout(false);
            tabQueryPage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private ListBox lstQueries;
        private Label lblDescription;
        private Button btnExecute;
        private DataGridView dgvResults;
        private Label lblParamHint;
        private TextBox txbParamText;
        private TextBox txbParamNumber;
        private TabControl tabControl1;
        private TabPage tabQueryPage;
    }
}