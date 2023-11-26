namespace Presentacion.Formularios
{
    partial class FrmEncomiendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.col_direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_contenido_encomienda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_id_persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_numero_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_id_tipo_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tipo_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_id_rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombre_rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombre_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblTitutloFormulario = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.boxTipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccionDestino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccionOrigen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
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
            this.btnEliminar.Location = new System.Drawing.Point(670, 507);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnEliminar.Size = new System.Drawing.Size(79, 30);
            this.btnEliminar.TabIndex = 456;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(344, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 19);
            this.label10.TabIndex = 455;
            this.label10.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(347, 54);
            this.txtTelefono.MaxLength = 15;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(151, 27);
            this.txtTelefono.TabIndex = 454;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Location = new System.Drawing.Point(256, 513);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnRestaurar.Size = new System.Drawing.Size(136, 24);
            this.btnRestaurar.TabIndex = 453;
            this.btnRestaurar.Text = "Limpiar busqueda";
            this.btnRestaurar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(166, 513);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnBuscar.Size = new System.Drawing.Size(85, 25);
            this.btnBuscar.TabIndex = 452;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIdUsuario.BackColor = System.Drawing.Color.DarkGray;
            this.txtIdUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtIdUsuario.Location = new System.Drawing.Point(11, 112);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(22, 27);
            this.txtIdUsuario.TabIndex = 451;
            this.txtIdUsuario.Text = "0";
            this.txtIdUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdUsuario.Visible = false;
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tabla.BackgroundColor = System.Drawing.Color.Silver;
            this.tabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_direccion,
            this.col_id_usuario,
            this.col_contenido_encomienda,
            this.col_id_persona,
            this.col_nombres,
            this.col_apellidos,
            this.col_numero_documento,
            this.col_id_tipo_documento,
            this.col_tipo_documento,
            this.col_id_rol,
            this.col_nombre_rol,
            this.col_telefono,
            this.col_nombre_usuario});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla.DefaultCellStyle = dataGridViewCellStyle5;
            this.tabla.Location = new System.Drawing.Point(11, 144);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(103)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tabla.RowHeadersWidth = 20;
            this.tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla.Size = new System.Drawing.Size(835, 357);
            this.tabla.TabIndex = 450;
            // 
            // col_direccion
            // 
            this.col_direccion.HeaderText = "Direccion";
            this.col_direccion.MinimumWidth = 8;
            this.col_direccion.Name = "col_direccion";
            this.col_direccion.ReadOnly = true;
            this.col_direccion.Width = 109;
            // 
            // col_id_usuario
            // 
            this.col_id_usuario.HeaderText = "Id empleado";
            this.col_id_usuario.MinimumWidth = 8;
            this.col_id_usuario.Name = "col_id_usuario";
            this.col_id_usuario.ReadOnly = true;
            this.col_id_usuario.Visible = false;
            this.col_id_usuario.Width = 127;
            // 
            // col_contenido_encomienda
            // 
            this.col_contenido_encomienda.HeaderText = "Contenido";
            this.col_contenido_encomienda.MinimumWidth = 6;
            this.col_contenido_encomienda.Name = "col_contenido_encomienda";
            this.col_contenido_encomienda.ReadOnly = true;
            this.col_contenido_encomienda.Width = 112;
            // 
            // col_id_persona
            // 
            this.col_id_persona.HeaderText = "Id persona";
            this.col_id_persona.MinimumWidth = 8;
            this.col_id_persona.Name = "col_id_persona";
            this.col_id_persona.ReadOnly = true;
            this.col_id_persona.Visible = false;
            this.col_id_persona.Width = 116;
            // 
            // col_nombres
            // 
            this.col_nombres.HeaderText = "Nombres";
            this.col_nombres.MinimumWidth = 8;
            this.col_nombres.Name = "col_nombres";
            this.col_nombres.ReadOnly = true;
            this.col_nombres.Width = 103;
            // 
            // col_apellidos
            // 
            this.col_apellidos.HeaderText = "Apellidos";
            this.col_apellidos.MinimumWidth = 8;
            this.col_apellidos.Name = "col_apellidos";
            this.col_apellidos.ReadOnly = true;
            this.col_apellidos.Width = 103;
            // 
            // col_numero_documento
            // 
            this.col_numero_documento.HeaderText = "N° documento";
            this.col_numero_documento.MinimumWidth = 8;
            this.col_numero_documento.Name = "col_numero_documento";
            this.col_numero_documento.ReadOnly = true;
            this.col_numero_documento.Width = 129;
            // 
            // col_id_tipo_documento
            // 
            this.col_id_tipo_documento.HeaderText = "Id tipo documento";
            this.col_id_tipo_documento.MinimumWidth = 8;
            this.col_id_tipo_documento.Name = "col_id_tipo_documento";
            this.col_id_tipo_documento.ReadOnly = true;
            this.col_id_tipo_documento.Visible = false;
            this.col_id_tipo_documento.Width = 168;
            // 
            // col_tipo_documento
            // 
            this.col_tipo_documento.HeaderText = "Tipo de documento";
            this.col_tipo_documento.MinimumWidth = 8;
            this.col_tipo_documento.Name = "col_tipo_documento";
            this.col_tipo_documento.ReadOnly = true;
            this.col_tipo_documento.Width = 161;
            // 
            // col_id_rol
            // 
            this.col_id_rol.HeaderText = "Id rol";
            this.col_id_rol.MinimumWidth = 8;
            this.col_id_rol.Name = "col_id_rol";
            this.col_id_rol.ReadOnly = true;
            this.col_id_rol.Visible = false;
            this.col_id_rol.Width = 70;
            // 
            // col_nombre_rol
            // 
            this.col_nombre_rol.HeaderText = "Rol";
            this.col_nombre_rol.MinimumWidth = 8;
            this.col_nombre_rol.Name = "col_nombre_rol";
            this.col_nombre_rol.ReadOnly = true;
            this.col_nombre_rol.Width = 61;
            // 
            // col_telefono
            // 
            this.col_telefono.HeaderText = "Telefono";
            this.col_telefono.MinimumWidth = 8;
            this.col_telefono.Name = "col_telefono";
            this.col_telefono.ReadOnly = true;
            this.col_telefono.Width = 98;
            // 
            // col_nombre_usuario
            // 
            this.col_nombre_usuario.HeaderText = "Nombre de usuario";
            this.col_nombre_usuario.MinimumWidth = 8;
            this.col_nombre_usuario.Name = "col_nombre_usuario";
            this.col_nombre_usuario.ReadOnly = true;
            this.col_nombre_usuario.Width = 162;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(723, 32);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnCancelar.Size = new System.Drawing.Size(95, 30);
            this.btnCancelar.TabIndex = 449;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReporte.BackColor = System.Drawing.Color.Teal;
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Location = new System.Drawing.Point(755, 507);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnReporte.Size = new System.Drawing.Size(91, 30);
            this.btnReporte.TabIndex = 448;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFiltro.Location = new System.Drawing.Point(11, 514);
            this.txtFiltro.MaxLength = 15;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(150, 27);
            this.txtFiltro.TabIndex = 447;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(723, 72);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnLimpiar.Size = new System.Drawing.Size(95, 30);
            this.btnLimpiar.TabIndex = 446;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblTitutloFormulario
            // 
            this.lblTitutloFormulario.AutoSize = true;
            this.lblTitutloFormulario.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitutloFormulario.ForeColor = System.Drawing.Color.Black;
            this.lblTitutloFormulario.Location = new System.Drawing.Point(6, 0);
            this.lblTitutloFormulario.Name = "lblTitutloFormulario";
            this.lblTitutloFormulario.Size = new System.Drawing.Size(304, 30);
            this.lblTitutloFormulario.TabIndex = 445;
            this.lblTitutloFormulario.Text = "Gestor de Encomiendas:";
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
            this.btnGuardar.Location = new System.Drawing.Point(723, 108);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnGuardar.Size = new System.Drawing.Size(95, 30);
            this.btnGuardar.TabIndex = 442;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(504, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 19);
            this.label8.TabIndex = 444;
            this.label8.Text = "Tamaño:";
            // 
            // boxTipo
            // 
            this.boxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxTipo.FormattingEnabled = true;
            this.boxTipo.Location = new System.Drawing.Point(504, 54);
            this.boxTipo.Name = "boxTipo";
            this.boxTipo.Size = new System.Drawing.Size(150, 27);
            this.boxTipo.TabIndex = 440;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 19);
            this.label5.TabIndex = 441;
            this.label5.Text = "Dirección Destino:";
            // 
            // txtDireccionDestino
            // 
            this.txtDireccionDestino.Location = new System.Drawing.Point(187, 53);
            this.txtDireccionDestino.MaxLength = 15;
            this.txtDireccionDestino.Name = "txtDireccionDestino";
            this.txtDireccionDestino.Size = new System.Drawing.Size(151, 27);
            this.txtDireccionDestino.TabIndex = 437;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 19);
            this.label3.TabIndex = 439;
            this.label3.Text = "Dirección Origen:";
            // 
            // txtDireccionOrigen
            // 
            this.txtDireccionOrigen.Location = new System.Drawing.Point(46, 54);
            this.txtDireccionOrigen.MaxLength = 15;
            this.txtDireccionOrigen.Name = "txtDireccionOrigen";
            this.txtDireccionOrigen.Size = new System.Drawing.Size(135, 27);
            this.txtDireccionOrigen.TabIndex = 436;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 458;
            this.label1.Text = "Peso Encomienda:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(47, 108);
            this.txtPeso.MaxLength = 15;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(147, 27);
            this.txtPeso.TabIndex = 459;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 460;
            this.label2.Text = "Contenido:";
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(357, 108);
            this.txtContenido.MaxLength = 15;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(297, 27);
            this.txtContenido.TabIndex = 461;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 462;
            this.label4.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(200, 108);
            this.txtValor.MaxLength = 15;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(151, 27);
            this.txtValor.TabIndex = 463;
            // 
            // FrmEncomiendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 550);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblTitutloFormulario);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.boxTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDireccionDestino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDireccionOrigen);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmEncomiendas";
            this.Text = "0";
            this.Load += new System.EventHandler(this.FrmViajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblTitutloFormulario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox boxTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccionDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDireccionOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_contenido_encomienda;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id_persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_numero_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id_tipo_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tipo_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id_rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombre_rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombre_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
    }
}