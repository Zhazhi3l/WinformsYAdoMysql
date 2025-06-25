namespace AccesoDatosWInForms
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
            btnGuardar = new Button();
            cboCategory = new ComboBox();
            dgvControl = new DataGridView();
            btnSaveAsync = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvControl).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(411, 290);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 29);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(99, 12);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(311, 28);
            cboCategory.TabIndex = 1;
            // 
            // dgvControl
            // 
            dgvControl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvControl.Location = new Point(12, 46);
            dgvControl.Name = "dgvControl";
            dgvControl.RowHeadersWidth = 51;
            dgvControl.Size = new Size(485, 188);
            dgvControl.TabIndex = 2;
            // 
            // btnSaveAsync
            // 
            btnSaveAsync.Location = new Point(264, 290);
            btnSaveAsync.Name = "btnSaveAsync";
            btnSaveAsync.Size = new Size(141, 29);
            btnSaveAsync.TabIndex = 3;
            btnSaveAsync.Text = "Guardar asincrono";
            btnSaveAsync.UseVisualStyleBackColor = true;
            btnSaveAsync.Click += btnSaveAsync_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 335);
            Controls.Add(btnSaveAsync);
            Controls.Add(dgvControl);
            Controls.Add(cboCategory);
            Controls.Add(btnGuardar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvControl).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGuardar;
        private ComboBox cboCategory;
        private DataGridView dgvControl;
        private Button btnSaveAsync;
    }
}
