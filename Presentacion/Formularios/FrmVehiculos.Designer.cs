namespace Presentacion.Formularios
{
    partial class FrmVehiculos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.col_id_vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_id_conductor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_id_persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_numero_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_id_tipo_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tipo_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReporte = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblTitutloFormulario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.numericAño = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAsignarCliente = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreCompletoCliente = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtIdVehiculo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAño)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(671, 509);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnEliminar.Size = new System.Drawing.Size(79, 30);
            this.btnEliminar.TabIndex = 433;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Location = new System.Drawing.Point(257, 515);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnRestaurar.Size = new System.Drawing.Size(136, 24);
            this.btnRestaurar.TabIndex = 432;
            this.btnRestaurar.Text = "Limpiar busqueda";
            this.btnRestaurar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(167, 515);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnBuscar.Size = new System.Drawing.Size(85, 25);
            this.btnBuscar.TabIndex = 431;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tabla.BackgroundColor = System.Drawing.Color.Silver;
            this.tabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id_vehiculo,
            this.col_id_conductor,
            this.col_marca,
            this.col_modelo,
            this.col_placa,
            this.col_año,
            this.col_id_persona,
            this.col_nombre,
            this.col_apellido,
            this.col_numero_documento,
            this.col_id_tipo_documento,
            this.col_tipo_documento,
            this.col_telefono,
            this.col_direccion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabla.Location = new System.Drawing.Point(12, 126);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(103)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tabla.RowHeadersWidth = 20;
            this.tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla.Size = new System.Drawing.Size(835, 377);
            this.tabla.TabIndex = 430;
            this.tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_CellClick);
            this.tabla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_CellDoubleClick);
            // 
            // col_id_vehiculo
            // 
            this.col_id_vehiculo.HeaderText = "Id Vehiculo";
            this.col_id_vehiculo.Name = "col_id_vehiculo";
            this.col_id_vehiculo.ReadOnly = true;
            this.col_id_vehiculo.Visible = false;
            // 
            // col_id_conductor
            // 
            this.col_id_conductor.HeaderText = "Id Conductor";
            this.col_id_conductor.Name = "col_id_conductor";
            this.col_id_conductor.ReadOnly = true;
            this.col_id_conductor.Visible = false;
            // 
            // col_marca
            // 
            this.col_marca.HeaderText = "Marca";
            this.col_marca.Name = "col_marca";
            this.col_marca.ReadOnly = true;
            // 
            // col_modelo
            // 
            this.col_modelo.HeaderText = "Modelo";
            this.col_modelo.Name = "col_modelo";
            this.col_modelo.ReadOnly = true;
            // 
            // col_placa
            // 
            this.col_placa.HeaderText = "Placa";
            this.col_placa.Name = "col_placa";
            this.col_placa.ReadOnly = true;
            // 
            // col_año
            // 
            this.col_año.HeaderText = "Año";
            this.col_año.Name = "col_año";
            this.col_año.ReadOnly = true;
            // 
            // col_id_persona
            // 
            this.col_id_persona.HeaderText = "Id persona";
            this.col_id_persona.Name = "col_id_persona";
            this.col_id_persona.ReadOnly = true;
            this.col_id_persona.Visible = false;
            // 
            // col_nombre
            // 
            this.col_nombre.HeaderText = "nombre";
            this.col_nombre.Name = "col_nombre";
            this.col_nombre.ReadOnly = true;
            this.col_nombre.Visible = false;
            // 
            // col_apellido
            // 
            this.col_apellido.HeaderText = "apellido";
            this.col_apellido.Name = "col_apellido";
            this.col_apellido.ReadOnly = true;
            this.col_apellido.Visible = false;
            // 
            // col_numero_documento
            // 
            this.col_numero_documento.HeaderText = "num doc";
            this.col_numero_documento.Name = "col_numero_documento";
            this.col_numero_documento.ReadOnly = true;
            this.col_numero_documento.Visible = false;
            // 
            // col_id_tipo_documento
            // 
            this.col_id_tipo_documento.HeaderText = "id tipo doc";
            this.col_id_tipo_documento.Name = "col_id_tipo_documento";
            this.col_id_tipo_documento.ReadOnly = true;
            this.col_id_tipo_documento.Visible = false;
            // 
            // col_tipo_documento
            // 
            this.col_tipo_documento.HeaderText = "tipo doc";
            this.col_tipo_documento.Name = "col_tipo_documento";
            this.col_tipo_documento.ReadOnly = true;
            this.col_tipo_documento.Visible = false;
            // 
            // col_telefono
            // 
            this.col_telefono.HeaderText = "tel";
            this.col_telefono.Name = "col_telefono";
            this.col_telefono.ReadOnly = true;
            this.col_telefono.Visible = false;
            // 
            // col_direccion
            // 
            this.col_direccion.HeaderText = "direc";
            this.col_direccion.Name = "col_direccion";
            this.col_direccion.ReadOnly = true;
            this.col_direccion.Visible = false;
            // 
            // btnReporte
            // 
            this.btnReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReporte.BackColor = System.Drawing.Color.Teal;
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Location = new System.Drawing.Point(756, 509);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnReporte.Size = new System.Drawing.Size(91, 30);
            this.btnReporte.TabIndex = 429;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFiltro.Location = new System.Drawing.Point(12, 516);
            this.txtFiltro.MaxLength = 15;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(150, 23);
            this.txtFiltro.TabIndex = 428;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 435;
            this.label3.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(12, 56);
            this.txtMarca.MaxLength = 15;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(120, 23);
            this.txtMarca.TabIndex = 434;
            // 
            // lblTitutloFormulario
            // 
            this.lblTitutloFormulario.AutoSize = true;
            this.lblTitutloFormulario.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitutloFormulario.ForeColor = System.Drawing.Color.Black;
            this.lblTitutloFormulario.Location = new System.Drawing.Point(12, 9);
            this.lblTitutloFormulario.Name = "lblTitutloFormulario";
            this.lblTitutloFormulario.Size = new System.Drawing.Size(207, 24);
            this.lblTitutloFormulario.TabIndex = 436;
            this.lblTitutloFormulario.Text = "Gestor de vehiculos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 438;
            this.label1.Text = "Modelo:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(138, 56);
            this.txtModelo.MaxLength = 15;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(120, 23);
            this.txtModelo.TabIndex = 437;
            // 
            // numericAño
            // 
            this.numericAño.Location = new System.Drawing.Point(264, 56);
            this.numericAño.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numericAño.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.numericAño.Name = "numericAño";
            this.numericAño.Size = new System.Drawing.Size(59, 23);
            this.numericAño.TabIndex = 439;
            this.numericAño.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 440;
            this.label2.Text = "Año";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 442;
            this.label4.Text = "Placa:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(329, 56);
            this.txtPlaca.MaxLength = 15;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(120, 23);
            this.txtPlaca.TabIndex = 441;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.btnAsignarCliente);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtNombreCompletoCliente);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(455, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 72);
            this.groupBox2.TabIndex = 443;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información del conductor";
            // 
            // btnAsignarCliente
            // 
            this.btnAsignarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.btnAsignarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignarCliente.FlatAppearance.BorderSize = 0;
            this.btnAsignarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(123)))), ((int)(((byte)(150)))));
            this.btnAsignarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(89)))), ((int)(((byte)(109)))));
            this.btnAsignarCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarCliente.ForeColor = System.Drawing.Color.White;
            this.btnAsignarCliente.Location = new System.Drawing.Point(298, 19);
            this.btnAsignarCliente.Name = "btnAsignarCliente";
            this.btnAsignarCliente.Size = new System.Drawing.Size(88, 43);
            this.btnAsignarCliente.TabIndex = 12;
            this.btnAsignarCliente.Text = "Asignar conductor";
            this.btnAsignarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAsignarCliente.UseVisualStyleBackColor = false;
            this.btnAsignarCliente.Click += new System.EventHandler(this.btnAsignarCliente_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(5, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nombre completo:";
            // 
            // txtNombreCompletoCliente
            // 
            this.txtNombreCompletoCliente.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtNombreCompletoCliente.ForeColor = System.Drawing.Color.Black;
            this.txtNombreCompletoCliente.Location = new System.Drawing.Point(8, 39);
            this.txtNombreCompletoCliente.MaxLength = 15;
            this.txtNombreCompletoCliente.Name = "txtNombreCompletoCliente";
            this.txtNombreCompletoCliente.ReadOnly = true;
            this.txtNombreCompletoCliente.Size = new System.Drawing.Size(284, 23);
            this.txtNombreCompletoCliente.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(586, 90);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnCancelar.Size = new System.Drawing.Size(80, 30);
            this.btnCancelar.TabIndex = 446;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(669, 90);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnLimpiar.Size = new System.Drawing.Size(87, 30);
            this.btnLimpiar.TabIndex = 445;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(123)))), ((int)(((byte)(150)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(89)))), ((int)(((byte)(109)))));
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(760, 90);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnGuardar.Size = new System.Drawing.Size(87, 30);
            this.btnGuardar.TabIndex = 444;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtIdVehiculo
            // 
            this.txtIdVehiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIdVehiculo.BackColor = System.Drawing.Color.DarkGray;
            this.txtIdVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdVehiculo.ForeColor = System.Drawing.Color.Black;
            this.txtIdVehiculo.Location = new System.Drawing.Point(12, 97);
            this.txtIdVehiculo.Name = "txtIdVehiculo";
            this.txtIdVehiculo.Size = new System.Drawing.Size(22, 23);
            this.txtIdVehiculo.TabIndex = 447;
            this.txtIdVehiculo.Text = "0";
            this.txtIdVehiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdVehiculo.Visible = false;
            // 
            // FrmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 551);
            this.Controls.Add(this.txtIdVehiculo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericAño);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblTitutloFormulario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.txtFiltro);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmVehiculos";
            this.Text = "FrmVehiculos";
            this.Load += new System.EventHandler(this.FrmVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAño)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblTitutloFormulario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.NumericUpDown numericAño;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAsignarCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreCompletoCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtIdVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id_vehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id_conductor;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_año;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id_persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_numero_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id_tipo_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tipo_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_direccion;
    }
}