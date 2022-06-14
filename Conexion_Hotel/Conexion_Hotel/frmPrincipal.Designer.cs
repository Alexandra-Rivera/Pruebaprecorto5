namespace Conexion_Hotel
{
    partial class frmPrincipal
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
            this.grpSinParámetros = new System.Windows.Forms.GroupBox();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.dgvMostrarTodo = new System.Windows.Forms.DataGridView();
            this.grpConParametros = new System.Windows.Forms.GroupBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtDirección = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            this.grpSinParámetros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvMostrarTodo)).BeginInit();
            this.grpConParametros.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSinParámetros
            // 
            this.grpSinParámetros.Controls.Add(this.btnMostrarTodo);
            this.grpSinParámetros.Controls.Add(this.dgvMostrarTodo);
            this.grpSinParámetros.Location = new System.Drawing.Point(12, 14);
            this.grpSinParámetros.Name = "grpSinParámetros";
            this.grpSinParámetros.Size = new System.Drawing.Size(452, 179);
            this.grpSinParámetros.TabIndex = 0;
            this.grpSinParámetros.TabStop = false;
            this.grpSinParámetros.Text = "Sin parámetros";
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(284, 27);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(135, 26);
            this.btnMostrarTodo.TabIndex = 1;
            this.btnMostrarTodo.Text = "Mostrar todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // dgvMostrarTodo
            // 
            this.dgvMostrarTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarTodo.Location = new System.Drawing.Point(6, 69);
            this.dgvMostrarTodo.Name = "dgvMostrarTodo";
            this.dgvMostrarTodo.Size = new System.Drawing.Size(440, 104);
            this.dgvMostrarTodo.TabIndex = 0;
            // 
            // grpConParametros
            // 
            this.grpConParametros.Controls.Add(this.txtProducto);
            this.grpConParametros.Controls.Add(this.txtDirección);
            this.grpConParametros.Controls.Add(this.txtNombre);
            this.grpConParametros.Controls.Add(this.lblProducto);
            this.grpConParametros.Controls.Add(this.lblDireccion);
            this.grpConParametros.Controls.Add(this.lblNombre);
            this.grpConParametros.Controls.Add(this.txtID);
            this.grpConParametros.Controls.Add(this.lblID);
            this.grpConParametros.Controls.Add(this.btnAgregarVenta);
            this.grpConParametros.Location = new System.Drawing.Point(12, 207);
            this.grpConParametros.Name = "grpConParametros";
            this.grpConParametros.Size = new System.Drawing.Size(452, 180);
            this.grpConParametros.TabIndex = 1;
            this.grpConParametros.TabStop = false;
            this.grpConParametros.Text = "Con parámetros";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(143, 132);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(100, 20);
            this.txtProducto.TabIndex = 8;
            // 
            // txtDirección
            // 
            this.txtDirección.Location = new System.Drawing.Point(143, 98);
            this.txtDirección.Name = "txtDirección";
            this.txtDirección.Size = new System.Drawing.Size(100, 20);
            this.txtDirección.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(143, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // lblProducto
            // 
            this.lblProducto.Location = new System.Drawing.Point(82, 132);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(55, 17);
            this.lblProducto.TabIndex = 5;
            this.lblProducto.Text = "Producto:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.Location = new System.Drawing.Point(82, 101);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(56, 15);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(82, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(49, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(143, 39);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(88, 42);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(19, 15);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Id: ";
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.Location = new System.Drawing.Point(291, 128);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(128, 27);
            this.btnAgregarVenta.TabIndex = 0;
            this.btnAgregarVenta.Text = "Agregar venta";
            this.btnAgregarVenta.UseVisualStyleBackColor = true;
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.grpConParametros);
            this.Controls.Add(this.grpSinParámetros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPrincipal";
            this.Text = "Conexión a sql";
            this.grpSinParámetros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvMostrarTodo)).EndInit();
            this.grpConParametros.ResumeLayout(false);
            this.grpConParametros.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDirección;
        private System.Windows.Forms.TextBox txtProducto;

        private System.Windows.Forms.GroupBox grpConParametros;

        private System.Windows.Forms.Button btnMostrarTodo;

        private System.Windows.Forms.DataGridView dgvMostrarTodo;

        private System.Windows.Forms.GroupBox grpSinParámetros;

        #endregion
    }
}