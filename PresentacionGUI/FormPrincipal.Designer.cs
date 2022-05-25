namespace PresentacionGUI
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.btnCientes = new System.Windows.Forms.Button();
            this.btnCuenta = new System.Windows.Forms.Button();
            this.PanelMenuCliente = new System.Windows.Forms.Panel();
            this.BtnModificarCliente = new System.Windows.Forms.Button();
            this.BtnConsultarCliente = new System.Windows.Forms.Button();
            this.BtnAgregarCliente = new System.Windows.Forms.Button();
            this.BtnEliminarCiente = new System.Windows.Forms.Button();
            this.panel_segundario = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.PictureBox();
            this.PanelMenuCuenta = new System.Windows.Forms.Panel();
            this.BtnConsignar = new System.Windows.Forms.Button();
            this.BtnConsultarCuenta = new System.Windows.Forms.Button();
            this.btnAgregarCuenta = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelMenuCliente.SuspendLayout();
            this.panel_segundario.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalir)).BeginInit();
            this.PanelMenuCuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCientes
            // 
            this.btnCientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCientes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCientes.Location = new System.Drawing.Point(15, 28);
            this.btnCientes.Name = "btnCientes";
            this.btnCientes.Size = new System.Drawing.Size(110, 31);
            this.btnCientes.TabIndex = 0;
            this.btnCientes.Text = "Gestion Clientes";
            this.btnCientes.UseVisualStyleBackColor = false;
            this.btnCientes.Click += new System.EventHandler(this.btnCientes_Click);
            // 
            // btnCuenta
            // 
            this.btnCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCuenta.ForeColor = System.Drawing.Color.Transparent;
            this.btnCuenta.Location = new System.Drawing.Point(187, 27);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Size = new System.Drawing.Size(110, 32);
            this.btnCuenta.TabIndex = 1;
            this.btnCuenta.Text = "Gestion Cuenta";
            this.btnCuenta.UseVisualStyleBackColor = false;
            this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);
            // 
            // PanelMenuCliente
            // 
            this.PanelMenuCliente.BackColor = System.Drawing.Color.Transparent;
            this.PanelMenuCliente.Controls.Add(this.BtnModificarCliente);
            this.PanelMenuCliente.Controls.Add(this.BtnConsultarCliente);
            this.PanelMenuCliente.Controls.Add(this.BtnAgregarCliente);
            this.PanelMenuCliente.Controls.Add(this.BtnEliminarCiente);
            this.PanelMenuCliente.Location = new System.Drawing.Point(22, 61);
            this.PanelMenuCliente.Name = "PanelMenuCliente";
            this.PanelMenuCliente.Size = new System.Drawing.Size(169, 165);
            this.PanelMenuCliente.TabIndex = 6;
            this.PanelMenuCliente.Visible = false;
            // 
            // BtnModificarCliente
            // 
            this.BtnModificarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnModificarCliente.FlatAppearance.BorderSize = 0;
            this.BtnModificarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModificarCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.BtnModificarCliente.ForeColor = System.Drawing.Color.Transparent;
            this.BtnModificarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnModificarCliente.Location = new System.Drawing.Point(13, 127);
            this.BtnModificarCliente.Name = "BtnModificarCliente";
            this.BtnModificarCliente.Size = new System.Drawing.Size(153, 33);
            this.BtnModificarCliente.TabIndex = 12;
            this.BtnModificarCliente.Text = "Modificar Cliente";
            this.BtnModificarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificarCliente.UseVisualStyleBackColor = false;
            this.BtnModificarCliente.Click += new System.EventHandler(this.BtnModificarCliente_Click);
            // 
            // BtnConsultarCliente
            // 
            this.BtnConsultarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnConsultarCliente.FlatAppearance.BorderSize = 0;
            this.BtnConsultarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnConsultarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConsultarCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.BtnConsultarCliente.ForeColor = System.Drawing.Color.Transparent;
            this.BtnConsultarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnConsultarCliente.Location = new System.Drawing.Point(15, 43);
            this.BtnConsultarCliente.Name = "BtnConsultarCliente";
            this.BtnConsultarCliente.Size = new System.Drawing.Size(152, 33);
            this.BtnConsultarCliente.TabIndex = 9;
            this.BtnConsultarCliente.Text = "Consultar Cliente";
            this.BtnConsultarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultarCliente.UseVisualStyleBackColor = false;
            this.BtnConsultarCliente.Click += new System.EventHandler(this.BtnConsultarCliente_Click);
            // 
            // BtnAgregarCliente
            // 
            this.BtnAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnAgregarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAgregarCliente.FlatAppearance.BorderSize = 0;
            this.BtnAgregarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregarCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.BtnAgregarCliente.ForeColor = System.Drawing.Color.Transparent;
            this.BtnAgregarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAgregarCliente.Location = new System.Drawing.Point(17, 3);
            this.BtnAgregarCliente.Name = "BtnAgregarCliente";
            this.BtnAgregarCliente.Size = new System.Drawing.Size(152, 36);
            this.BtnAgregarCliente.TabIndex = 10;
            this.BtnAgregarCliente.Text = "Agregar Cliente";
            this.BtnAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarCliente.UseVisualStyleBackColor = false;
            this.BtnAgregarCliente.Click += new System.EventHandler(this.BtnAgregarCliente_Click);
            // 
            // BtnEliminarCiente
            // 
            this.BtnEliminarCiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnEliminarCiente.FlatAppearance.BorderSize = 0;
            this.BtnEliminarCiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnEliminarCiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminarCiente.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.BtnEliminarCiente.ForeColor = System.Drawing.Color.Transparent;
            this.BtnEliminarCiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminarCiente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnEliminarCiente.Location = new System.Drawing.Point(15, 82);
            this.BtnEliminarCiente.Name = "BtnEliminarCiente";
            this.BtnEliminarCiente.Size = new System.Drawing.Size(152, 39);
            this.BtnEliminarCiente.TabIndex = 11;
            this.BtnEliminarCiente.Text = "EliminarCiente";
            this.BtnEliminarCiente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminarCiente.UseVisualStyleBackColor = false;
            this.BtnEliminarCiente.Click += new System.EventHandler(this.BtnEliminarCiente_Click);
            // 
            // panel_segundario
            // 
            this.panel_segundario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel_segundario.Controls.Add(this.label1);
            this.panel_segundario.Controls.Add(this.panel4);
            this.panel_segundario.Controls.Add(this.panel2);
            this.panel_segundario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_segundario.Location = new System.Drawing.Point(0, 0);
            this.panel_segundario.Name = "panel_segundario";
            this.panel_segundario.Size = new System.Drawing.Size(400, 282);
            this.panel_segundario.TabIndex = 10;
            this.panel_segundario.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_segundario_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "BancoOnGame";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Controls.Add(this.panel12);
            this.panel4.Controls.Add(this.PanelMenuCliente);
            this.panel4.Controls.Add(this.btnCuenta);
            this.panel4.Controls.Add(this.BtnSalir);
            this.panel4.Controls.Add(this.btnCientes);
            this.panel4.Controls.Add(this.PanelMenuCuenta);
            this.panel4.Location = new System.Drawing.Point(8, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(389, 244);
            this.panel4.TabIndex = 10;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel11.Location = new System.Drawing.Point(4, 31);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(5, 28);
            this.panel11.TabIndex = 18;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel12.Location = new System.Drawing.Point(174, 27);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(5, 28);
            this.panel12.TabIndex = 18;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(325, 0);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(55, 53);
            this.BtnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSalir.TabIndex = 17;
            this.BtnSalir.TabStop = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click_1);
            // 
            // PanelMenuCuenta
            // 
            this.PanelMenuCuenta.BackColor = System.Drawing.Color.Transparent;
            this.PanelMenuCuenta.Controls.Add(this.BtnConsignar);
            this.PanelMenuCuenta.Controls.Add(this.BtnConsultarCuenta);
            this.PanelMenuCuenta.Controls.Add(this.btnAgregarCuenta);
            this.PanelMenuCuenta.Controls.Add(this.btnRetirar);
            this.PanelMenuCuenta.Location = new System.Drawing.Point(205, 59);
            this.PanelMenuCuenta.Name = "PanelMenuCuenta";
            this.PanelMenuCuenta.Size = new System.Drawing.Size(184, 165);
            this.PanelMenuCuenta.TabIndex = 7;
            this.PanelMenuCuenta.Visible = false;
            this.PanelMenuCuenta.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMenuCuenta_Paint);
            // 
            // BtnConsignar
            // 
            this.BtnConsignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnConsignar.FlatAppearance.BorderSize = 0;
            this.BtnConsignar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnConsignar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConsignar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.BtnConsignar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnConsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsignar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnConsignar.Location = new System.Drawing.Point(11, 81);
            this.BtnConsignar.Name = "BtnConsignar";
            this.BtnConsignar.Size = new System.Drawing.Size(152, 33);
            this.BtnConsignar.TabIndex = 12;
            this.BtnConsignar.Text = "Consignar";
            this.BtnConsignar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsignar.UseVisualStyleBackColor = false;
            // 
            // BtnConsultarCuenta
            // 
            this.BtnConsultarCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnConsultarCuenta.FlatAppearance.BorderSize = 0;
            this.BtnConsultarCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnConsultarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConsultarCuenta.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.BtnConsultarCuenta.ForeColor = System.Drawing.Color.Transparent;
            this.BtnConsultarCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultarCuenta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnConsultarCuenta.Location = new System.Drawing.Point(11, 45);
            this.BtnConsultarCuenta.Name = "BtnConsultarCuenta";
            this.BtnConsultarCuenta.Size = new System.Drawing.Size(152, 33);
            this.BtnConsultarCuenta.TabIndex = 9;
            this.BtnConsultarCuenta.Text = "Consultar Cuenta";
            this.BtnConsultarCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultarCuenta.UseVisualStyleBackColor = false;
            // 
            // btnAgregarCuenta
            // 
            this.btnAgregarCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAgregarCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarCuenta.FlatAppearance.BorderSize = 0;
            this.btnAgregarCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAgregarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarCuenta.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnAgregarCuenta.ForeColor = System.Drawing.Color.Transparent;
            this.btnAgregarCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCuenta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAgregarCuenta.Location = new System.Drawing.Point(11, 6);
            this.btnAgregarCuenta.Name = "btnAgregarCuenta";
            this.btnAgregarCuenta.Size = new System.Drawing.Size(152, 36);
            this.btnAgregarCuenta.TabIndex = 10;
            this.btnAgregarCuenta.Text = "Agregar Cuenta";
            this.btnAgregarCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCuenta.UseVisualStyleBackColor = false;
            // 
            // btnRetirar
            // 
            this.btnRetirar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnRetirar.FlatAppearance.BorderSize = 0;
            this.btnRetirar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnRetirar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetirar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnRetirar.ForeColor = System.Drawing.Color.Transparent;
            this.btnRetirar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetirar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRetirar.Location = new System.Drawing.Point(11, 120);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(152, 33);
            this.btnRetirar.TabIndex = 11;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetirar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(8, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 71);
            this.panel2.TabIndex = 9;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(400, 282);
            this.Controls.Add(this.panel_segundario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.PanelMenuCliente.ResumeLayout(false);
            this.panel_segundario.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalir)).EndInit();
            this.PanelMenuCuenta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCientes;
        private System.Windows.Forms.Button btnCuenta;
        private System.Windows.Forms.Panel PanelMenuCliente;
        private System.Windows.Forms.Button BtnModificarCliente;
        private System.Windows.Forms.Button BtnEliminarCiente;
        private System.Windows.Forms.Button BtnConsultarCliente;
        private System.Windows.Forms.Button BtnAgregarCliente;
        private System.Windows.Forms.Panel PanelMenuCuenta;
        private System.Windows.Forms.Button BtnConsultarCuenta;
        private System.Windows.Forms.Button btnAgregarCuenta;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Panel panel_segundario;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox BtnSalir;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button BtnConsignar;
        private System.Windows.Forms.Label label1;
    }
}

