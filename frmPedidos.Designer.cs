namespace Cafeteria_El_buen_sabor
{
    partial class frmPedidos
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
            label1 = new Label();
            txtCliente = new TextBox();
            l = new Label();
            dtpFecha = new DateTimePicker();
            chkFrecuente = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            txtProducto = new TextBox();
            txtPrecio = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            rbtGrande = new RadioButton();
            rbtNormal = new RadioButton();
            groupBox2 = new GroupBox();
            rbtLocal = new RadioButton();
            rbtLlevar = new RadioButton();
            chkPorcionExtra = new CheckBox();
            btnAgregar = new Button();
            lblEncabezado = new Label();
            lstPedido = new ListBox();
            v = new Label();
            lblSubtotal = new Label();
            label5 = new Label();
            lblDescuento = new Label();
            label6 = new Label();
            lblEmpaque = new Label();
            label7 = new Label();
            lblItbis = new Label();
            label8 = new Label();
            lblTotal = new Label();
            btnCalcular = new Button();
            btnSalir = new Button();
            btnLimpiar = new Button();
            nudCantidad = new NumericUpDown();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(29, 30);
            label1.Name = "label1";
            label1.Size = new Size(91, 30);
            label1.TabIndex = 0;
            label1.Text = "Cliente: ";
            // 
            // txtCliente
            // 
            txtCliente.BorderStyle = BorderStyle.FixedSingle;
            txtCliente.Location = new Point(138, 29);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(323, 31);
            txtCliente.TabIndex = 1;
            // 
            // l
            // 
            l.AutoSize = true;
            l.Font = new Font("Segoe UI", 11F);
            l.ForeColor = SystemColors.Desktop;
            l.Location = new Point(29, 121);
            l.Name = "l";
            l.Size = new Size(80, 30);
            l.TabIndex = 2;
            l.Text = "Fecha: ";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(138, 121);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(323, 31);
            dtpFecha.TabIndex = 3;
            // 
            // chkFrecuente
            // 
            chkFrecuente.AutoSize = true;
            chkFrecuente.Font = new Font("Segoe UI", 11F);
            chkFrecuente.ForeColor = SystemColors.Desktop;
            chkFrecuente.Location = new Point(29, 81);
            chkFrecuente.Name = "chkFrecuente";
            chkFrecuente.Size = new Size(208, 34);
            chkFrecuente.TabIndex = 4;
            chkFrecuente.Text = "Cliente Frecuente";
            chkFrecuente.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(29, 174);
            label2.Name = "label2";
            label2.Size = new Size(112, 30);
            label2.TabIndex = 5;
            label2.Text = "Producto: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(29, 233);
            label3.Name = "label3";
            label3.Size = new Size(84, 30);
            label3.TabIndex = 7;
            label3.Text = "Precio: ";
            // 
            // txtProducto
            // 
            txtProducto.BorderStyle = BorderStyle.FixedSingle;
            txtProducto.Location = new Point(138, 173);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(323, 31);
            txtProducto.TabIndex = 6;
            // 
            // txtPrecio
            // 
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.Location = new Point(138, 232);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(323, 31);
            txtPrecio.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = SystemColors.Desktop;
            label4.Location = new Point(29, 291);
            label4.Name = "label4";
            label4.Size = new Size(118, 30);
            label4.TabIndex = 9;
            label4.Text = "Cantodad: ";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(rbtGrande);
            groupBox1.Controls.Add(rbtNormal);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(44, 360);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 139);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tamaño";
            // 
            // rbtGrande
            // 
            rbtGrande.AutoSize = true;
            rbtGrande.Location = new Point(16, 86);
            rbtGrande.Name = "rbtGrande";
            rbtGrande.Size = new Size(221, 34);
            rbtGrande.TabIndex = 1;
            rbtGrande.TabStop = true;
            rbtGrande.Text = "Grande (+RD$25)";
            rbtGrande.UseVisualStyleBackColor = true;
            // 
            // rbtNormal
            // 
            rbtNormal.AutoSize = true;
            rbtNormal.Location = new Point(16, 35);
            rbtNormal.Name = "rbtNormal";
            rbtNormal.Size = new Size(115, 34);
            rbtNormal.TabIndex = 0;
            rbtNormal.TabStop = true;
            rbtNormal.Text = "Normal";
            rbtNormal.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveBorder;
            groupBox2.Controls.Add(rbtLocal);
            groupBox2.Controls.Add(rbtLlevar);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(300, 360);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(256, 139);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Servicio";
            // 
            // rbtLocal
            // 
            rbtLocal.AutoSize = true;
            rbtLocal.Location = new Point(6, 35);
            rbtLocal.Name = "rbtLocal";
            rbtLocal.Size = new Size(191, 34);
            rbtLocal.TabIndex = 2;
            rbtLocal.TabStop = true;
            rbtLocal.Text = "Comer en local";
            rbtLocal.UseVisualStyleBackColor = true;
            // 
            // rbtLlevar
            // 
            rbtLlevar.AutoSize = true;
            rbtLlevar.Location = new Point(6, 86);
            rbtLlevar.Name = "rbtLlevar";
            rbtLlevar.Size = new Size(254, 34);
            rbtLlevar.TabIndex = 2;
            rbtLlevar.TabStop = true;
            rbtLlevar.Text = "Para llevar (+RD$20)";
            rbtLlevar.UseVisualStyleBackColor = true;
            // 
            // chkPorcionExtra
            // 
            chkPorcionExtra.AutoSize = true;
            chkPorcionExtra.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkPorcionExtra.Location = new Point(44, 526);
            chkPorcionExtra.Name = "chkPorcionExtra";
            chkPorcionExtra.Size = new Size(264, 34);
            chkPorcionExtra.TabIndex = 13;
            chkPorcionExtra.Text = "Porcion extra (+$RD30)";
            chkPorcionExtra.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(576, 29);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(454, 61);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar al Pedido";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblEncabezado
            // 
            lblEncabezado.AutoSize = true;
            lblEncabezado.Location = new Point(578, 116);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(324, 25);
            lblEncabezado.TabIndex = 15;
            lblEncabezado.Text = "cant  producto                 precio     total";
            lblEncabezado.Click += lblEncabezado_Click;
            // 
            // lstPedido
            // 
            lstPedido.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstPedido.FormattingEnabled = true;
            lstPedido.Location = new Point(578, 144);
            lstPedido.Name = "lstPedido";
            lstPedido.Size = new Size(428, 229);
            lstPedido.TabIndex = 16;
            // 
            // v
            // 
            v.AutoSize = true;
            v.Font = new Font("Segoe UI", 11F);
            v.Location = new Point(591, 410);
            v.Name = "v";
            v.Size = new Size(93, 30);
            v.TabIndex = 17;
            v.Text = "Subtotal";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.BorderStyle = BorderStyle.FixedSingle;
            lblSubtotal.Font = new Font("Segoe UI", 11F);
            lblSubtotal.Location = new Point(777, 410);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(95, 32);
            lblSubtotal.TabIndex = 18;
            lblSubtotal.Text = "Subtotal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(591, 446);
            label5.Name = "label5";
            label5.Size = new Size(115, 30);
            label5.TabIndex = 19;
            label5.Text = "Descuento";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.BorderStyle = BorderStyle.FixedSingle;
            lblDescuento.Font = new Font("Segoe UI", 11F);
            lblDescuento.Location = new Point(777, 448);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(117, 32);
            lblDescuento.TabIndex = 20;
            lblDescuento.Text = "Descuento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(591, 484);
            label6.Name = "label6";
            label6.Size = new Size(104, 30);
            label6.TabIndex = 21;
            label6.Text = "Empaque";
            // 
            // lblEmpaque
            // 
            lblEmpaque.AutoSize = true;
            lblEmpaque.BorderStyle = BorderStyle.FixedSingle;
            lblEmpaque.Font = new Font("Segoe UI", 11F);
            lblEmpaque.Location = new Point(777, 484);
            lblEmpaque.Name = "lblEmpaque";
            lblEmpaque.Size = new Size(106, 32);
            lblEmpaque.TabIndex = 22;
            lblEmpaque.Text = "Empaque";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(591, 526);
            label7.Name = "label7";
            label7.Size = new Size(124, 30);
            label7.TabIndex = 23;
            label7.Text = "ITBIS (18%)";
            // 
            // lblItbis
            // 
            lblItbis.AutoSize = true;
            lblItbis.BorderStyle = BorderStyle.FixedSingle;
            lblItbis.Font = new Font("Segoe UI", 11F);
            lblItbis.Location = new Point(777, 522);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(126, 32);
            lblItbis.TabIndex = 24;
            lblItbis.Text = "ITBIS (18%)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(569, 571);
            label8.Name = "label8";
            label8.Size = new Size(166, 30);
            label8.TabIndex = 25;
            label8.Text = "TOTAL A PAGAR";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BorderStyle = BorderStyle.FixedSingle;
            lblTotal.Font = new Font("Segoe UI", 11F);
            lblTotal.Location = new Point(777, 571);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(168, 32);
            lblTotal.TabIndex = 26;
            lblTotal.Text = "TOTAL A PAGAR";
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCalcular.Location = new Point(49, 592);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(163, 48);
            btnCalcular.TabIndex = 27;
            btnCalcular.Text = "Calcular Total";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSalir.Location = new Point(387, 592);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(163, 48);
            btnSalir.TabIndex = 28;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLimpiar.Location = new Point(218, 592);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(163, 48);
            btnLimpiar.TabIndex = 29;
            btnLimpiar.Text = "Nuevo Pedido";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(137, 290);
            nudCantidad.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(324, 31);
            nudCantidad.TabIndex = 30;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cafeteria
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 690);
            Controls.Add(nudCantidad);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSalir);
            Controls.Add(btnCalcular);
            Controls.Add(lblTotal);
            Controls.Add(label8);
            Controls.Add(lblItbis);
            Controls.Add(label7);
            Controls.Add(lblEmpaque);
            Controls.Add(label6);
            Controls.Add(lblDescuento);
            Controls.Add(label5);
            Controls.Add(lblSubtotal);
            Controls.Add(v);
            Controls.Add(lstPedido);
            Controls.Add(lblEncabezado);
            Controls.Add(btnAgregar);
            Controls.Add(chkPorcionExtra);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(txtPrecio);
            Controls.Add(label3);
            Controls.Add(txtProducto);
            Controls.Add(label2);
            Controls.Add(chkFrecuente);
            Controls.Add(dtpFecha);
            Controls.Add(l);
            Controls.Add(txtCliente);
            Controls.Add(label1);
            Name = "cafeteria";
            Text = "Cafeteria El Buen Sabor - Pedidos";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCliente;
        private Label l;
        private DateTimePicker dtpFecha;
        private CheckBox chkFrecuente;
        private Label label2;
        private Label label3;
        private TextBox txtProducto;
        private TextBox txtPrecio;
        private Label label4;
        private GroupBox groupBox1;
        private RadioButton rbtGrande;
        private RadioButton rbtNormal;
        private GroupBox groupBox2;
        private RadioButton rbtLocal;
        private RadioButton rbtLlevar;
        private CheckBox chkPorcionExtra;
        private Button btnAgregar;
        private Label lblEncabezado;
        private ListBox lstPedido;
        private Label v;
        private Label lblSubtotal;
        private Label label5;
        private Label lblDescuento;
        private Label label6;
        private Label lblEmpaque;
        private Label label7;
        private Label lblItbis;
        private Label label8;
        private Label lblTotal;
        private Button btnCalcular;
        private Button btnSalir;
        private Button btnLimpiar;
        private NumericUpDown nudCantidad;
    }
}
