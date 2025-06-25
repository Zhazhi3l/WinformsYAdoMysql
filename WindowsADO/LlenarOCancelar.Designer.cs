namespace AccesoDatosWInForms.WindowsADO
{
    partial class LlenarOCancelar
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
            txtOrderID = new TextBox();
            btnFindByOrderID = new Button();
            btnCancelOrder = new Button();
            btnFillOrder = new Button();
            btnFinishUpdates = new Button();
            dgvCustomerOrders = new DataGridView();
            label2 = new Label();
            dtpFillDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerOrders).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 0;
            label1.Text = "Identificador de pedido:";
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(151, 19);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(161, 23);
            txtOrderID.TabIndex = 1;
            // 
            // btnFindByOrderID
            // 
            btnFindByOrderID.Location = new Point(318, 18);
            btnFindByOrderID.Name = "btnFindByOrderID";
            btnFindByOrderID.Size = new Size(75, 23);
            btnFindByOrderID.TabIndex = 2;
            btnFindByOrderID.Text = "Buscar pedido";
            btnFindByOrderID.UseVisualStyleBackColor = true;
            btnFindByOrderID.Click += btnFindByOrderID_Click;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.Location = new Point(12, 308);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(106, 23);
            btnCancelOrder.TabIndex = 3;
            btnCancelOrder.Text = "Cancelar pedido";
            btnCancelOrder.UseVisualStyleBackColor = true;
            btnCancelOrder.Click += btnCancelOrder_Click;
            // 
            // btnFillOrder
            // 
            btnFillOrder.Location = new Point(124, 308);
            btnFillOrder.Name = "btnFillOrder";
            btnFillOrder.Size = new Size(105, 23);
            btnFillOrder.TabIndex = 4;
            btnFillOrder.Text = "Rellenar pedido";
            btnFillOrder.UseVisualStyleBackColor = true;
            btnFillOrder.Click += btnFillOrder_Click;
            // 
            // btnFinishUpdates
            // 
            btnFinishUpdates.Location = new Point(305, 308);
            btnFinishUpdates.Name = "btnFinishUpdates";
            btnFinishUpdates.Size = new Size(88, 23);
            btnFinishUpdates.TabIndex = 5;
            btnFinishUpdates.Text = "Finalizar";
            btnFinishUpdates.UseVisualStyleBackColor = true;
            btnFinishUpdates.Click += btnFinishUpdates_Click;
            // 
            // dgvCustomerOrders
            // 
            dgvCustomerOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerOrders.Location = new Point(12, 99);
            dgvCustomerOrders.Name = "dgvCustomerOrders";
            dgvCustomerOrders.ReadOnly = true;
            dgvCustomerOrders.RowHeadersVisible = false;
            dgvCustomerOrders.Size = new Size(381, 203);
            dgvCustomerOrders.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(212, 30);
            label2.TabIndex = 7;
            label2.Text = "Si está llenando un pedido, especifique\r\nla fecha rellenada";
            // 
            // dtpFillDate
            // 
            dtpFillDate.Format = DateTimePickerFormat.Short;
            dtpFillDate.Location = new Point(230, 66);
            dtpFillDate.Name = "dtpFillDate";
            dtpFillDate.Size = new Size(114, 23);
            dtpFillDate.TabIndex = 8;
            // 
            // LlenarOCancelar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 343);
            Controls.Add(dtpFillDate);
            Controls.Add(label2);
            Controls.Add(dgvCustomerOrders);
            Controls.Add(btnFinishUpdates);
            Controls.Add(btnFillOrder);
            Controls.Add(btnCancelOrder);
            Controls.Add(btnFindByOrderID);
            Controls.Add(txtOrderID);
            Controls.Add(label1);
            Name = "LlenarOCancelar";
            Text = "Rellenar o cancelar un pedido";
            ((System.ComponentModel.ISupportInitialize)dgvCustomerOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtOrderID;
        private Button btnFindByOrderID;
        private Button btnCancelOrder;
        private Button btnFillOrder;
        private Button btnFinishUpdates;
        private DataGridView dgvCustomerOrders;
        private Label label2;
        private DateTimePicker dtpFillDate;
    }
}