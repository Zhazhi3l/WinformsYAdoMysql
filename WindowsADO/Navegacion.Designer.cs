namespace AccesoDatosWInForms.WindowsADO
{
    partial class Navegacion
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
            btnGoToAdd = new Button();
            btnGoToFillOrCancel = new Button();
            label1 = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnGoToAdd
            // 
            btnGoToAdd.Location = new Point(93, 37);
            btnGoToAdd.Name = "btnGoToAdd";
            btnGoToAdd.Size = new Size(191, 42);
            btnGoToAdd.TabIndex = 0;
            btnGoToAdd.Text = "Agregar una cuenta";
            btnGoToAdd.UseVisualStyleBackColor = true;
            btnGoToAdd.Click += btnGoToAdd_Click;
            // 
            // btnGoToFillOrCancel
            // 
            btnGoToFillOrCancel.Location = new Point(93, 85);
            btnGoToFillOrCancel.Name = "btnGoToFillOrCancel";
            btnGoToFillOrCancel.Size = new Size(191, 42);
            btnGoToFillOrCancel.TabIndex = 1;
            btnGoToFillOrCancel.Text = "Rellenar o cancelar un pedido";
            btnGoToFillOrCancel.UseVisualStyleBackColor = true;
            btnGoToFillOrCancel.Click += btnGoToFillOrCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 19);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 2;
            label1.Text = "¿Que desea hacer?";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(275, 159);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(92, 34);
            btnExit.TabIndex = 3;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Navegacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 205);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(btnGoToFillOrCancel);
            Controls.Add(btnGoToAdd);
            Name = "Navegacion";
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGoToAdd;
        private Button btnGoToFillOrCancel;
        private Label label1;
        private Button btnExit;
    }
}