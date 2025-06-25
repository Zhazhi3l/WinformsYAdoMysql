namespace AccesoDatosWInForms.WindowsADO
{
    partial class NuevoCliente
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
            groupBox1 = new GroupBox();
            txtCustomerID = new TextBox();
            txtCustomerName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnCreateAccount = new Button();
            groupBox2 = new GroupBox();
            dtpOrderDate = new DateTimePicker();
            numOrderAmount = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            btnPlaceOrder = new Button();
            btnAddAnotherAccount = new Button();
            btnAddFinish = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numOrderAmount).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCustomerID);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(236, 90);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar cuenta";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(127, 50);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.ReadOnly = true;
            txtCustomerID.Size = new Size(100, 23);
            txtCustomerID.TabIndex = 3;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(127, 16);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(100, 23);
            txtCustomerName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 53);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 1;
            label2.Text = "Identificador cliente:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 19);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del cliente:";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(273, 45);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(103, 23);
            btnCreateAccount.TabIndex = 4;
            btnCreateAccount.Text = "Crear cuenta";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpOrderDate);
            groupBox2.Controls.Add(numOrderAmount);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 108);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(236, 100);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Crear pedido";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Format = DateTimePickerFormat.Short;
            dtpOrderDate.Location = new Point(127, 58);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(100, 23);
            dtpOrderDate.TabIndex = 5;
            // 
            // numOrderAmount
            // 
            numOrderAmount.Location = new Point(127, 17);
            numOrderAmount.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numOrderAmount.Name = "numOrderAmount";
            numOrderAmount.Size = new Size(100, 23);
            numOrderAmount.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 58);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 1;
            label4.Text = "Fecha de pedido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 19);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 0;
            label3.Text = "Cantidad de pedido:";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(273, 149);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(103, 23);
            btnPlaceOrder.TabIndex = 6;
            btnPlaceOrder.Text = "Realizar pedido";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnAddAnotherAccount
            // 
            btnAddAnotherAccount.Location = new Point(256, 216);
            btnAddAnotherAccount.Name = "btnAddAnotherAccount";
            btnAddAnotherAccount.Size = new Size(120, 23);
            btnAddAnotherAccount.TabIndex = 7;
            btnAddAnotherAccount.Text = "Agregar otra cuenta";
            btnAddAnotherAccount.UseVisualStyleBackColor = true;
            btnAddAnotherAccount.Click += btnAddAnotherAccount_Click;
            // 
            // btnAddFinish
            // 
            btnAddFinish.Location = new Point(33, 216);
            btnAddFinish.Name = "btnAddFinish";
            btnAddFinish.Size = new Size(103, 23);
            btnAddFinish.TabIndex = 8;
            btnAddFinish.Text = "Finalizar";
            btnAddFinish.UseVisualStyleBackColor = true;
            btnAddFinish.Click += btnAddFinish_Click;
            // 
            // NuevoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 251);
            Controls.Add(btnAddFinish);
            Controls.Add(btnAddAnotherAccount);
            Controls.Add(btnPlaceOrder);
            Controls.Add(groupBox2);
            Controls.Add(btnCreateAccount);
            Controls.Add(groupBox1);
            Name = "NuevoCliente";
            Text = "Cuenta y pedido nuevos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numOrderAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtCustomerID;
        private TextBox txtCustomerName;
        private Label label2;
        private Label label1;
        private Button btnCreateAccount;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpOrderDate;
        private NumericUpDown numOrderAmount;
        private Button btnPlaceOrder;
        private Button btnAddAnotherAccount;
        private Button btnAddFinish;
    }
}