namespace Presentacion
{
    partial class FrmPrincipal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlMenu = new Panel();
            lblSesion = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            imgMenu = new ImageList(components);
            btnReportes = new Button();
            btnPagos = new Button();
            btnEmpleados = new Button();
            label2 = new Label();
            btnProductos = new Button();
            btnClientes = new Button();
            btnProveedores = new Button();
            btnCompras = new Button();
            label1 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label17 = new Label();
            lblTotalClientes = new Label();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            panel2 = new Panel();
            label18 = new Label();
            label6 = new Label();
            pictureBox5 = new PictureBox();
            label7 = new Label();
            panel3 = new Panel();
            label19 = new Label();
            label8 = new Label();
            pictureBox6 = new PictureBox();
            label9 = new Label();
            panel4 = new Panel();
            label20 = new Label();
            label10 = new Label();
            pictureBox7 = new PictureBox();
            label11 = new Label();
            panel5 = new Panel();
            label21 = new Label();
            label12 = new Label();
            pictureBox8 = new PictureBox();
            label13 = new Label();
            panel6 = new Panel();
            label22 = new Label();
            label14 = new Label();
            panel7 = new Panel();
            label23 = new Label();
            label15 = new Label();
            pictureBox9 = new PictureBox();
            label16 = new Label();
            dgvBajoStock = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colProducto = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            lblHora = new Label();
            lblFecha = new Label();
            tmrReloj = new System.Windows.Forms.Timer(components);
            label24 = new Label();
            label25 = new Label();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBajoStock).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = SystemColors.HotTrack;
            pnlMenu.Controls.Add(label25);
            pnlMenu.Controls.Add(label24);
            pnlMenu.Controls.Add(lblSesion);
            pnlMenu.Controls.Add(pictureBox2);
            pnlMenu.Controls.Add(pictureBox1);
            pnlMenu.Controls.Add(button2);
            pnlMenu.Controls.Add(btnReportes);
            pnlMenu.Controls.Add(btnPagos);
            pnlMenu.Controls.Add(btnEmpleados);
            pnlMenu.Controls.Add(label2);
            pnlMenu.Controls.Add(btnProductos);
            pnlMenu.Controls.Add(btnClientes);
            pnlMenu.Controls.Add(btnProveedores);
            pnlMenu.Controls.Add(btnCompras);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(200, 450);
            pnlMenu.TabIndex = 1;
            // 
            // lblSesion
            // 
            lblSesion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSesion.Location = new Point(67, 388);
            lblSesion.Name = "lblSesion";
            lblSesion.Size = new Size(130, 48);
            lblSesion.TabIndex = 21;
            lblSesion.Text = "Usuario Conectado";
            lblSesion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 388);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.ImageIndex = 6;
            button2.ImageList = imgMenu;
            button2.Location = new Point(20, 116);
            button2.Name = "button2";
            button2.Size = new Size(165, 33);
            button2.TabIndex = 12;
            button2.Text = "Marcas";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            // 
            // imgMenu
            // 
            imgMenu.ColorDepth = ColorDepth.Depth32Bit;
            imgMenu.ImageStream = (ImageListStreamer)resources.GetObject("imgMenu.ImageStream");
            imgMenu.TransparentColor = Color.Transparent;
            imgMenu.Images.SetKeyName(0, "ordenador-portatil.png");
            imgMenu.Images.SetKeyName(1, "grafico-de-barras.png");
            imgMenu.Images.SetKeyName(2, "id-simbolo-dibujado-a-mano.png");
            imgMenu.Images.SetKeyName(3, "usuario.png");
            imgMenu.Images.SetKeyName(4, "shipping-and-delivery.png");
            imgMenu.Images.SetKeyName(5, "tarjeta-de-credito.png");
            imgMenu.Images.SetKeyName(6, "shopping-store.png");
            // 
            // btnReportes
            // 
            btnReportes.ImageIndex = 1;
            btnReportes.ImageList = imgMenu;
            btnReportes.Location = new Point(20, 303);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(165, 34);
            btnReportes.TabIndex = 9;
            btnReportes.Text = "Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleRight;
            btnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnPagos
            // 
            btnPagos.ImageIndex = 5;
            btnPagos.ImageList = imgMenu;
            btnPagos.Location = new Point(20, 268);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(165, 29);
            btnPagos.TabIndex = 10;
            btnPagos.Text = "Pagos";
            btnPagos.TextAlign = ContentAlignment.MiddleRight;
            btnPagos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPagos.UseVisualStyleBackColor = true;
            // 
            // btnEmpleados
            // 
            btnEmpleados.ImageIndex = 3;
            btnEmpleados.ImageList = imgMenu;
            btnEmpleados.Location = new Point(20, 343);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(165, 33);
            btnEmpleados.TabIndex = 11;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.TextAlign = ContentAlignment.MiddleRight;
            btnEmpleados.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmpleados.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(67, 9);
            label2.Name = "label2";
            label2.Size = new Size(118, 30);
            label2.TabIndex = 3;
            label2.Text = "PARCIAL 2";
            // 
            // btnProductos
            // 
            btnProductos.ImageIndex = 0;
            btnProductos.ImageList = imgMenu;
            btnProductos.Location = new Point(20, 155);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(165, 31);
            btnProductos.TabIndex = 5;
            btnProductos.Text = "Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleRight;
            btnProductos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProductos.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            btnClientes.ImageAlign = ContentAlignment.MiddleRight;
            btnClientes.ImageIndex = 3;
            btnClientes.ImageList = imgMenu;
            btnClientes.Location = new Point(20, 77);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(165, 33);
            btnClientes.TabIndex = 7;
            btnClientes.Text = "Clientes";
            btnClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnProveedores
            // 
            btnProveedores.ImageIndex = 3;
            btnProveedores.ImageList = imgMenu;
            btnProveedores.Location = new Point(20, 192);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(165, 33);
            btnProveedores.TabIndex = 8;
            btnProveedores.Text = "Proveedores";
            btnProveedores.TextAlign = ContentAlignment.MiddleRight;
            btnProveedores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProveedores.UseVisualStyleBackColor = true;
            // 
            // btnCompras
            // 
            btnCompras.ImageIndex = 4;
            btnCompras.ImageList = imgMenu;
            btnCompras.Location = new Point(20, 231);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(165, 31);
            btnCompras.TabIndex = 6;
            btnCompras.Text = "Compras";
            btnCompras.TextAlign = ContentAlignment.MiddleRight;
            btnCompras.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCompras.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 8);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 2;
            label1.Text = "Sumario del Sistema:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(219, 171);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 3;
            label3.Text = "Productos bajo stock:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label17);
            panel1.Controls.Add(lblTotalClientes);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(219, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(90, 120);
            panel1.TabIndex = 4;
            // 
            // label17
            // 
            label17.ForeColor = SystemColors.Highlight;
            label17.Location = new Point(3, 95);
            label17.Name = "label17";
            label17.Size = new Size(82, 15);
            label17.TabIndex = 21;
            label17.Text = "15. 485";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalClientes
            // 
            lblTotalClientes.AutoSize = true;
            lblTotalClientes.Location = new Point(42, 94);
            lblTotalClientes.Name = "lblTotalClientes";
            lblTotalClientes.Size = new Size(0, 15);
            lblTotalClientes.TabIndex = 5;
            lblTotalClientes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-1, 34);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(90, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(-1, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 31);
            label4.TabIndex = 5;
            label4.Text = "Clientes";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-1, 34);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(90, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(-1, 0);
            label5.Name = "label5";
            label5.Size = new Size(90, 31);
            label5.TabIndex = 5;
            label5.Text = "Empleados";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label18);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(315, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(90, 120);
            panel2.TabIndex = 5;
            // 
            // label18
            // 
            label18.ForeColor = SystemColors.Highlight;
            label18.Location = new Point(3, 93);
            label18.Name = "label18";
            label18.Size = new Size(82, 15);
            label18.TabIndex = 22;
            label18.Text = "170";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 94);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 5;
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(-1, 34);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(90, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.ActiveCaptionText;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(-1, 0);
            label7.Name = "label7";
            label7.Size = new Size(90, 31);
            label7.TabIndex = 5;
            label7.Text = "Proveedor";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label19);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(411, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(90, 120);
            panel3.TabIndex = 6;
            // 
            // label19
            // 
            label19.ForeColor = SystemColors.Highlight;
            label19.Location = new Point(3, 94);
            label19.Name = "label19";
            label19.Size = new Size(82, 15);
            label19.TabIndex = 23;
            label19.Text = "124";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 94);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 5;
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(-1, 34);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(90, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // label9
            // 
            label9.BackColor = SystemColors.ActiveCaptionText;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(-1, 0);
            label9.Name = "label9";
            label9.Size = new Size(90, 31);
            label9.TabIndex = 5;
            label9.Text = "Productos";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label20);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(pictureBox6);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(507, 30);
            panel4.Name = "panel4";
            panel4.Size = new Size(90, 120);
            panel4.TabIndex = 15;
            // 
            // label20
            // 
            label20.ForeColor = SystemColors.Highlight;
            label20.Location = new Point(3, 94);
            label20.Name = "label20";
            label20.Size = new Size(82, 15);
            label20.TabIndex = 24;
            label20.Text = "131.928";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(42, 94);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 5;
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(-1, 34);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(90, 50);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 14;
            pictureBox7.TabStop = false;
            // 
            // label11
            // 
            label11.BackColor = SystemColors.ActiveCaptionText;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(-1, 0);
            label11.Name = "label11";
            label11.Size = new Size(90, 31);
            label11.TabIndex = 5;
            label11.Text = "Compras";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label21);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(pictureBox7);
            panel5.Controls.Add(label11);
            panel5.Location = new Point(603, 30);
            panel5.Name = "panel5";
            panel5.Size = new Size(90, 120);
            panel5.TabIndex = 15;
            // 
            // label21
            // 
            label21.ForeColor = SystemColors.Highlight;
            label21.Location = new Point(7, 94);
            label21.Name = "label21";
            label21.Size = new Size(82, 15);
            label21.TabIndex = 25;
            label21.Text = "15. 485";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(42, 94);
            label12.Name = "label12";
            label12.Size = new Size(0, 15);
            label12.TabIndex = 5;
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(-1, 34);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(90, 50);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 14;
            pictureBox8.TabStop = false;
            // 
            // label13
            // 
            label13.BackColor = SystemColors.ActiveCaptionText;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(-1, 0);
            label13.Name = "label13";
            label13.Size = new Size(90, 31);
            label13.TabIndex = 5;
            label13.Text = "Cajas";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label22);
            panel6.Controls.Add(label14);
            panel6.Controls.Add(pictureBox8);
            panel6.Controls.Add(label13);
            panel6.Location = new Point(699, 29);
            panel6.Name = "panel6";
            panel6.Size = new Size(90, 120);
            panel6.TabIndex = 15;
            // 
            // label22
            // 
            label22.ForeColor = SystemColors.Highlight;
            label22.Location = new Point(3, 95);
            label22.Name = "label22";
            label22.Size = new Size(82, 15);
            label22.TabIndex = 26;
            label22.Text = "1.852.871";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(42, 94);
            label14.Name = "label14";
            label14.Size = new Size(0, 15);
            label14.TabIndex = 5;
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label23);
            panel7.Controls.Add(label15);
            panel7.Controls.Add(pictureBox9);
            panel7.Controls.Add(label16);
            panel7.Location = new Point(795, 29);
            panel7.Name = "panel7";
            panel7.Size = new Size(90, 120);
            panel7.TabIndex = 16;
            // 
            // label23
            // 
            label23.ForeColor = SystemColors.Highlight;
            label23.Location = new Point(3, 95);
            label23.Name = "label23";
            label23.Size = new Size(82, 15);
            label23.TabIndex = 27;
            label23.Text = "197";
            label23.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(42, 94);
            label15.Name = "label15";
            label15.Size = new Size(0, 15);
            label15.TabIndex = 5;
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(-1, 34);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(90, 50);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 14;
            pictureBox9.TabStop = false;
            // 
            // label16
            // 
            label16.BackColor = SystemColors.ActiveCaptionText;
            label16.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.ButtonHighlight;
            label16.Location = new Point(-1, 0);
            label16.Name = "label16";
            label16.Size = new Size(90, 31);
            label16.TabIndex = 5;
            label16.Text = "Marcas";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvBajoStock
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBajoStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBajoStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBajoStock.Columns.AddRange(new DataGridViewColumn[] { colId, colProducto, colStock });
            dgvBajoStock.Location = new Point(222, 198);
            dgvBajoStock.Name = "dgvBajoStock";
            dgvBajoStock.Size = new Size(343, 240);
            dgvBajoStock.TabIndex = 17;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.Name = "colId";
            // 
            // colProducto
            // 
            colProducto.DataPropertyName = "Producto";
            colProducto.HeaderText = "Producto";
            colProducto.Name = "colProducto";
            // 
            // colStock
            // 
            colStock.DataPropertyName = "Stock";
            colStock.HeaderText = "Stock";
            colStock.Name = "colStock";
            // 
            // lblHora
            // 
            lblHora.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(680, 267);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(128, 30);
            lblHora.TabIndex = 19;
            lblHora.Text = "00:00:00";
            // 
            // lblFecha
            // 
            lblFecha.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(588, 303);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(313, 56);
            lblFecha.TabIndex = 20;
            lblFecha.Text = "Fecha actual";
            // 
            // tmrReloj
            // 
            tmrReloj.Interval = 1000;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label24.ForeColor = SystemColors.ButtonFace;
            label24.Location = new Point(67, 40);
            label24.Name = "label24";
            label24.Size = new Size(101, 15);
            label24.TabIndex = 22;
            label24.Text = "Maria Townshend";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label25.ForeColor = SystemColors.ButtonFace;
            label25.Location = new Point(91, 55);
            label25.Name = "label25";
            label25.Size = new Size(41, 15);
            label25.TabIndex = 23;
            label25.Text = "1IL133";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 450);
            Controls.Add(lblFecha);
            Controls.Add(lblHora);
            Controls.Add(dgvBajoStock);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pnlMenu);
            Name = "FrmPrincipal";
            Text = "Parcial 2 - Maria Townshend";
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBajoStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMenu;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button btnProductos;
        private Button btnCompras;
        private Button btnClientes;
        private Button btnProveedores;
        private Button btnReportes;
        private Button btnPagos;
        private Button btnEmpleados;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button2;
        private ImageList imgMenu;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private Label lblTotalClientes;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label5;
        private Panel panel2;
        private Label label6;
        private PictureBox pictureBox5;
        private Label label7;
        private Panel panel3;
        private Label label8;
        private PictureBox pictureBox6;
        private Label label9;
        private Panel panel4;
        private Label label10;
        private PictureBox pictureBox7;
        private Label label11;
        private Panel panel5;
        private Label label12;
        private PictureBox pictureBox8;
        private Label label13;
        private Panel panel6;
        private Label label14;
        private Panel panel7;
        private Label label15;
        private PictureBox pictureBox9;
        private Label label16;
        private DataGridView dgvBajoStock;
        private Label lblHora;
        private Label lblFecha;
        private System.Windows.Forms.Timer tmrReloj;
        private Label lblSesion;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colStock;
        private Label label25;
        private Label label24;
    }
}