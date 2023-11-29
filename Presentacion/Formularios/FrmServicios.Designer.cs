namespace Presentacion.Formularios
{
    partial class FrmServicios
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
            this.col_id_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_conductor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_direccion_origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_direccion_destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fecha_creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReporte = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAsignarConductor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreCompletoConductor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAsignarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCompletoCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDirDestino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDirOrigen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtIdServicio = new System.Windows.Forms.TextBox();
            this.btnPdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.btnEliminar.TabIndex = 439;
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
            this.btnRestaurar.TabIndex = 438;
            this.btnRestaurar.Text = "Limpiar busqueda";
            this.btnRestaurar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(167, 515);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnBuscar.Size = new System.Drawing.Size(85, 25);
            this.btnBuscar.TabIndex = 437;
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
            this.col_id_servicio,
            this.Id_cliente,
            this.id_conductor,
            this.col_direccion_origen,
            this.col_direccion_destino,
            this.col_tarifa,
            this.col_estado,
            this.col_fecha_creacion,
            this.col_id_cliente});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabla.Location = new System.Drawing.Point(12, 139);
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
            this.tabla.Size = new System.Drawing.Size(835, 364);
            this.tabla.TabIndex = 436;
            this.tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_CellClick);
            // 
            // col_id_servicio
            // 
            this.col_id_servicio.HeaderText = "Id";
            this.col_id_servicio.MinimumWidth = 6;
            this.col_id_servicio.Name = "col_id_servicio";
            this.col_id_servicio.ReadOnly = true;
            // 
            // Id_cliente
            // 
            this.Id_cliente.HeaderText = "Id cliente";
            this.Id_cliente.MinimumWidth = 6;
            this.Id_cliente.Name = "Id_cliente";
            this.Id_cliente.ReadOnly = true;
            this.Id_cliente.Visible = false;
            // 
            // id_conductor
            // 
            this.id_conductor.HeaderText = "id conductor";
            this.id_conductor.MinimumWidth = 6;
            this.id_conductor.Name = "id_conductor";
            this.id_conductor.ReadOnly = true;
            this.id_conductor.Visible = false;
            // 
            // col_direccion_origen
            // 
            this.col_direccion_origen.HeaderText = "Dirección Origen";
            this.col_direccion_origen.MinimumWidth = 6;
            this.col_direccion_origen.Name = "col_direccion_origen";
            this.col_direccion_origen.ReadOnly = true;
            // 
            // col_direccion_destino
            // 
            this.col_direccion_destino.HeaderText = "Dirección Destino";
            this.col_direccion_destino.MinimumWidth = 6;
            this.col_direccion_destino.Name = "col_direccion_destino";
            this.col_direccion_destino.ReadOnly = true;
            // 
            // col_tarifa
            // 
            this.col_tarifa.HeaderText = "Tarifa";
            this.col_tarifa.MinimumWidth = 6;
            this.col_tarifa.Name = "col_tarifa";
            this.col_tarifa.ReadOnly = true;
            // 
            // col_estado
            // 
            this.col_estado.HeaderText = "estado";
            this.col_estado.MinimumWidth = 6;
            this.col_estado.Name = "col_estado";
            this.col_estado.ReadOnly = true;
            this.col_estado.Visible = false;
            // 
            // col_fecha_creacion
            // 
            this.col_fecha_creacion.HeaderText = "Fecha de creación";
            this.col_fecha_creacion.MinimumWidth = 6;
            this.col_fecha_creacion.Name = "col_fecha_creacion";
            this.col_fecha_creacion.ReadOnly = true;
            // 
            // col_id_cliente
            // 
            this.col_id_cliente.HeaderText = "id cliente";
            this.col_id_cliente.MinimumWidth = 6;
            this.col_id_cliente.Name = "col_id_cliente";
            this.col_id_cliente.ReadOnly = true;
            this.col_id_cliente.Visible = false;
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
            this.btnReporte.TabIndex = 435;
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
            this.txtFiltro.Size = new System.Drawing.Size(150, 27);
            this.txtFiltro.TabIndex = 434;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.btnAsignarConductor);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtNombreCompletoConductor);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(410, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 72);
            this.groupBox2.TabIndex = 444;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información del conductor";
            // 
            // btnAsignarConductor
            // 
            this.btnAsignarConductor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.btnAsignarConductor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignarConductor.FlatAppearance.BorderSize = 0;
            this.btnAsignarConductor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(123)))), ((int)(((byte)(150)))));
            this.btnAsignarConductor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(89)))), ((int)(((byte)(109)))));
            this.btnAsignarConductor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarConductor.ForeColor = System.Drawing.Color.White;
            this.btnAsignarConductor.Location = new System.Drawing.Point(298, 19);
            this.btnAsignarConductor.Name = "btnAsignarConductor";
            this.btnAsignarConductor.Size = new System.Drawing.Size(88, 43);
            this.btnAsignarConductor.TabIndex = 12;
            this.btnAsignarConductor.Text = "Asignar conductor";
            this.btnAsignarConductor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAsignarConductor.UseVisualStyleBackColor = false;
            this.btnAsignarConductor.Click += new System.EventHandler(this.btnAsignarConductor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(5, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nombre completo:";
            // 
            // txtNombreCompletoConductor
            // 
            this.txtNombreCompletoConductor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtNombreCompletoConductor.ForeColor = System.Drawing.Color.Black;
            this.txtNombreCompletoConductor.Location = new System.Drawing.Point(8, 39);
            this.txtNombreCompletoConductor.MaxLength = 15;
            this.txtNombreCompletoConductor.Name = "txtNombreCompletoConductor";
            this.txtNombreCompletoConductor.ReadOnly = true;
            this.txtNombreCompletoConductor.Size = new System.Drawing.Size(284, 27);
            this.txtNombreCompletoConductor.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.btnAsignarCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombreCompletoCliente);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 72);
            this.groupBox1.TabIndex = 445;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del cliente";
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
            this.btnAsignarCliente.Text = "Asignar cliente";
            this.btnAsignarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAsignarCliente.UseVisualStyleBackColor = false;
            this.btnAsignarCliente.Click += new System.EventHandler(this.btnAsignarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre completo:";
            // 
            // txtNombreCompletoCliente
            // 
            this.txtNombreCompletoCliente.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtNombreCompletoCliente.ForeColor = System.Drawing.Color.Black;
            this.txtNombreCompletoCliente.Location = new System.Drawing.Point(8, 39);
            this.txtNombreCompletoCliente.MaxLength = 15;
            this.txtNombreCompletoCliente.Name = "txtNombreCompletoCliente";
            this.txtNombreCompletoCliente.ReadOnly = true;
            this.txtNombreCompletoCliente.Size = new System.Drawing.Size(284, 27);
            this.txtNombreCompletoCliente.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 19);
            this.label2.TabIndex = 449;
            this.label2.Text = "Direción destino:";
            // 
            // txtDirDestino
            // 
            this.txtDirDestino.Location = new System.Drawing.Point(212, 110);
            this.txtDirDestino.MaxLength = 15;
            this.txtDirDestino.Name = "txtDirDestino";
            this.txtDirDestino.Size = new System.Drawing.Size(194, 27);
            this.txtDirDestino.TabIndex = 448;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 19);
            this.label3.TabIndex = 447;
            this.label3.Text = "Dirección origen:";
            // 
            // txtDirOrigen
            // 
            this.txtDirOrigen.Location = new System.Drawing.Point(12, 110);
            this.txtDirOrigen.MaxLength = 15;
            this.txtDirOrigen.Name = "txtDirOrigen";
            this.txtDirOrigen.Size = new System.Drawing.Size(194, 27);
            this.txtDirOrigen.TabIndex = 446;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 451;
            this.label4.Text = "Tarifa:";
            // 
            // txtTarifa
            // 
            this.txtTarifa.Location = new System.Drawing.Point(410, 110);
            this.txtTarifa.MaxLength = 15;
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(120, 27);
            this.txtTarifa.TabIndex = 450;
            this.txtTarifa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTarifa_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(536, 103);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnCancelar.Size = new System.Drawing.Size(80, 30);
            this.btnCancelar.TabIndex = 454;
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
            this.btnLimpiar.Location = new System.Drawing.Point(619, 103);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnLimpiar.Size = new System.Drawing.Size(87, 30);
            this.btnLimpiar.TabIndex = 453;
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
            this.btnGuardar.Location = new System.Drawing.Point(710, 103);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnGuardar.Size = new System.Drawing.Size(87, 30);
            this.btnGuardar.TabIndex = 452;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtIdServicio
            // 
            this.txtIdServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIdServicio.BackColor = System.Drawing.Color.DarkGray;
            this.txtIdServicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdServicio.ForeColor = System.Drawing.Color.Black;
            this.txtIdServicio.Location = new System.Drawing.Point(825, 108);
            this.txtIdServicio.Name = "txtIdServicio";
            this.txtIdServicio.Size = new System.Drawing.Size(22, 27);
            this.txtIdServicio.TabIndex = 455;
            this.txtIdServicio.Text = "0";
            this.txtIdServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdServicio.Visible = false;
            // 
            // btnPdf
            // 
            this.btnPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPdf.BackColor = System.Drawing.Color.Firebrick;
            this.btnPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPdf.FlatAppearance.BorderSize = 0;
            this.btnPdf.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.ForeColor = System.Drawing.Color.White;
            this.btnPdf.Location = new System.Drawing.Point(586, 509);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnPdf.Size = new System.Drawing.Size(79, 30);
            this.btnPdf.TabIndex = 456;
            this.btnPdf.Text = "Ticket";
            this.btnPdf.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // FrmServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 551);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.txtIdServicio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTarifa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDirDestino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDirOrigen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.txtFiltro);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmServicios";
            this.Text = "FrmServicios";
            this.Load += new System.EventHandler(this.FrmServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAsignarConductor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreCompletoConductor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAsignarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCompletoCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDirDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDirOrigen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtIdServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_conductor;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_direccion_origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_direccion_destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha_creacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id_cliente;
        private System.Windows.Forms.Button btnPdf;
    }
}