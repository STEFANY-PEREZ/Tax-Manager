namespace Presentacion.Formularios
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.panelLateral = new System.Windows.Forms.Panel();
            this.usuarios = new System.Windows.Forms.Button();
            this.vehiculos = new System.Windows.Forms.Button();
            this.conductores = new System.Windows.Forms.Button();
            this.servicios = new System.Windows.Forms.Button();
            this.clientes = new System.Windows.Forms.Button();
            this.panelBase = new System.Windows.Forms.Panel();
            this.encomienda = new System.Windows.Forms.Button();
            this.panelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.Orange;
            this.panelLateral.Controls.Add(this.encomienda);
            this.panelLateral.Controls.Add(this.usuarios);
            this.panelLateral.Controls.Add(this.vehiculos);
            this.panelLateral.Controls.Add(this.conductores);
            this.panelLateral.Controls.Add(this.servicios);
            this.panelLateral.Controls.Add(this.clientes);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(108, 618);
            this.panelLateral.TabIndex = 2;
            // 
            // usuarios
            // 
            this.usuarios.BackColor = System.Drawing.Color.Orange;
            this.usuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.usuarios.FlatAppearance.BorderSize = 0;
            this.usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usuarios.Font = new System.Drawing.Font("Arial", 8F);
            this.usuarios.ForeColor = System.Drawing.Color.Black;
            this.usuarios.Image = global::Presentacion.Properties.Resources.usuario;
            this.usuarios.Location = new System.Drawing.Point(0, 300);
            this.usuarios.Name = "usuarios";
            this.usuarios.Size = new System.Drawing.Size(108, 75);
            this.usuarios.TabIndex = 5;
            this.usuarios.Text = "Usuarios";
            this.usuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.usuarios.UseVisualStyleBackColor = false;
            this.usuarios.Click += new System.EventHandler(this.usuarios_Click);
            // 
            // vehiculos
            // 
            this.vehiculos.BackColor = System.Drawing.Color.Orange;
            this.vehiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vehiculos.Dock = System.Windows.Forms.DockStyle.Top;
            this.vehiculos.FlatAppearance.BorderSize = 0;
            this.vehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehiculos.Font = new System.Drawing.Font("Arial", 8F);
            this.vehiculos.ForeColor = System.Drawing.Color.Black;
            this.vehiculos.Image = global::Presentacion.Properties.Resources.taxi;
            this.vehiculos.Location = new System.Drawing.Point(0, 225);
            this.vehiculos.Name = "vehiculos";
            this.vehiculos.Size = new System.Drawing.Size(108, 75);
            this.vehiculos.TabIndex = 3;
            this.vehiculos.Text = "Vehiculos";
            this.vehiculos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.vehiculos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.vehiculos.UseVisualStyleBackColor = false;
            this.vehiculos.Click += new System.EventHandler(this.vehiculos_Click);
            // 
            // conductores
            // 
            this.conductores.BackColor = System.Drawing.Color.Orange;
            this.conductores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.conductores.Dock = System.Windows.Forms.DockStyle.Top;
            this.conductores.FlatAppearance.BorderSize = 0;
            this.conductores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conductores.Font = new System.Drawing.Font("Arial", 8F);
            this.conductores.ForeColor = System.Drawing.Color.Black;
            this.conductores.Image = global::Presentacion.Properties.Resources.conductor;
            this.conductores.Location = new System.Drawing.Point(0, 150);
            this.conductores.Name = "conductores";
            this.conductores.Size = new System.Drawing.Size(108, 75);
            this.conductores.TabIndex = 2;
            this.conductores.Text = "Conductores";
            this.conductores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.conductores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.conductores.UseVisualStyleBackColor = false;
            this.conductores.Click += new System.EventHandler(this.conductores_Click);
            // 
            // servicios
            // 
            this.servicios.BackColor = System.Drawing.Color.Orange;
            this.servicios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.servicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.servicios.FlatAppearance.BorderSize = 0;
            this.servicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servicios.Font = new System.Drawing.Font("Arial", 8F);
            this.servicios.ForeColor = System.Drawing.Color.Black;
            this.servicios.Image = global::Presentacion.Properties.Resources.servicio;
            this.servicios.Location = new System.Drawing.Point(0, 75);
            this.servicios.Name = "servicios";
            this.servicios.Size = new System.Drawing.Size(108, 75);
            this.servicios.TabIndex = 1;
            this.servicios.Text = "Servicios";
            this.servicios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.servicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.servicios.UseVisualStyleBackColor = false;
            this.servicios.Click += new System.EventHandler(this.servicios_Click);
            // 
            // clientes
            // 
            this.clientes.BackColor = System.Drawing.Color.Orange;
            this.clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientes.FlatAppearance.BorderSize = 0;
            this.clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientes.Font = new System.Drawing.Font("Arial", 8F);
            this.clientes.ForeColor = System.Drawing.Color.Black;
            this.clientes.Image = global::Presentacion.Properties.Resources.cliente;
            this.clientes.Location = new System.Drawing.Point(0, 0);
            this.clientes.Name = "clientes";
            this.clientes.Size = new System.Drawing.Size(108, 75);
            this.clientes.TabIndex = 4;
            this.clientes.Text = "Cliente";
            this.clientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.clientes.UseVisualStyleBackColor = false;
            this.clientes.Click += new System.EventHandler(this.clientes_Click);
            // 
            // panelBase
            // 
            this.panelBase.BackColor = System.Drawing.Color.White;
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase.Location = new System.Drawing.Point(0, 0);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(1025, 618);
            this.panelBase.TabIndex = 4;
            // 
            // encomienda
            // 
            this.encomienda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encomienda.Dock = System.Windows.Forms.DockStyle.Top;
            this.encomienda.FlatAppearance.BorderSize = 0;
            this.encomienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encomienda.Font = new System.Drawing.Font("Arial", 8F);
            this.encomienda.ForeColor = System.Drawing.Color.Black;
            this.encomienda.Image = global::Presentacion.Properties.Resources.repartidor__1_;
            this.encomienda.Location = new System.Drawing.Point(0, 375);
            this.encomienda.Name = "encomienda";
            this.encomienda.Size = new System.Drawing.Size(108, 75);
            this.encomienda.TabIndex = 8;
            this.encomienda.Text = "Encomienda";
            this.encomienda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.encomienda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.encomienda.UseVisualStyleBackColor = false;
            this.encomienda.Click += new System.EventHandler(this.encomienda_Click_1);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 618);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panelBase);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 650);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.panelLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button usuarios;
        private System.Windows.Forms.Button vehiculos;
        private System.Windows.Forms.Button conductores;
        private System.Windows.Forms.Button servicios;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.Button clientes;
        private System.Windows.Forms.Button encomienda;
    }
}