namespace examen_2
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
            cbProd = new ComboBox();
            lblProd = new Label();
            lblPrecioU = new Label();
            lblCant = new Label();
            txbPrecioU = new TextBox();
            numUDCant = new NumericUpDown();
            chebToGo = new CheckBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnVaciar = new Button();
            panel1 = new Panel();
            lblPedReg = new Label();
            dgPedReg = new DataGridView();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)numUDCant).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPedReg).BeginInit();
            SuspendLayout();
            // 
            // cbProd
            // 
            cbProd.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProd.FormattingEnabled = true;
            cbProd.Location = new Point(136, 26);
            cbProd.Name = "cbProd";
            cbProd.Size = new Size(151, 28);
            cbProd.TabIndex = 0;
            // 
            // lblProd
            // 
            lblProd.AutoSize = true;
            lblProd.Location = new Point(12, 29);
            lblProd.Name = "lblProd";
            lblProd.Size = new Size(69, 20);
            lblProd.TabIndex = 1;
            lblProd.Text = "Producto";
            // 
            // lblPrecioU
            // 
            lblPrecioU.AutoSize = true;
            lblPrecioU.Location = new Point(12, 84);
            lblPrecioU.Name = "lblPrecioU";
            lblPrecioU.Size = new Size(107, 20);
            lblPrecioU.TabIndex = 2;
            lblPrecioU.Text = "Precio Unitario";
            // 
            // lblCant
            // 
            lblCant.AutoSize = true;
            lblCant.Location = new Point(12, 137);
            lblCant.Name = "lblCant";
            lblCant.Size = new Size(69, 20);
            lblCant.TabIndex = 3;
            lblCant.Text = "Cantidad";
            // 
            // txbPrecioU
            // 
            txbPrecioU.Location = new Point(136, 81);
            txbPrecioU.Name = "txbPrecioU";
            txbPrecioU.ReadOnly = true;
            txbPrecioU.Size = new Size(125, 27);
            txbPrecioU.TabIndex = 6;
            // 
            // numUDCant
            // 
            numUDCant.Location = new Point(136, 135);
            numUDCant.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numUDCant.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUDCant.Name = "numUDCant";
            numUDCant.Size = new Size(125, 27);
            numUDCant.TabIndex = 8;
            numUDCant.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // chebToGo
            // 
            chebToGo.AutoSize = true;
            chebToGo.Location = new Point(13, 183);
            chebToGo.Name = "chebToGo";
            chebToGo.Size = new Size(222, 24);
            chebToGo.TabIndex = 9;
            chebToGo.Text = "Para llevar (+ 5$ por pedido)";
            chebToGo.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(14, 235);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(140, 247);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnVaciar
            // 
            btnVaciar.Location = new Point(252, 235);
            btnVaciar.Name = "btnVaciar";
            btnVaciar.Size = new Size(94, 29);
            btnVaciar.TabIndex = 12;
            btnVaciar.Text = "Vaciar";
            btnVaciar.UseVisualStyleBackColor = true;
            btnVaciar.Click += btnVaciar_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnVaciar);
            panel1.Controls.Add(chebToGo);
            panel1.Controls.Add(btnAgregar);
            panel1.Location = new Point(11, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 286);
            panel1.TabIndex = 13;
            // 
            // lblPedReg
            // 
            lblPedReg.AutoSize = true;
            lblPedReg.Location = new Point(476, 12);
            lblPedReg.Name = "lblPedReg";
            lblPedReg.Size = new Size(139, 20);
            lblPedReg.TabIndex = 14;
            lblPedReg.Text = "Pedidos registrados";
            // 
            // dgPedReg
            // 
            dgPedReg.AllowUserToAddRows = false;
            dgPedReg.AllowUserToDeleteRows = false;
            dgPedReg.AllowUserToOrderColumns = true;
            dgPedReg.AllowUserToResizeColumns = false;
            dgPedReg.AllowUserToResizeRows = false;
            dgPedReg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPedReg.Location = new Point(476, 35);
            dgPedReg.Name = "dgPedReg";
            dgPedReg.ReadOnly = true;
            dgPedReg.RowHeadersWidth = 51;
            dgPedReg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPedReg.Size = new Size(654, 230);
            dgPedReg.TabIndex = 15;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(1038, 278);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(92, 20);
            lblTotal.TabIndex = 16;
            lblTotal.Text = "TOTAL: $0.00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 450);
            Controls.Add(lblTotal);
            Controls.Add(dgPedReg);
            Controls.Add(lblPedReg);
            Controls.Add(btnEliminar);
            Controls.Add(numUDCant);
            Controls.Add(txbPrecioU);
            Controls.Add(lblCant);
            Controls.Add(lblPrecioU);
            Controls.Add(lblProd);
            Controls.Add(cbProd);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Examen 2";
            ((System.ComponentModel.ISupportInitialize)numUDCant).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgPedReg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbProd;
        private Label lblProd;
        private Label lblPrecioU;
        private Label lblCant;
        private TextBox txbPrecioU;
        private NumericUpDown numUDCant;
        private CheckBox chebToGo;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnVaciar;
        private Panel panel1;
        private Label lblPedReg;
        private DataGridView dgPedReg;
        private Label lblTotal;
    }
}
