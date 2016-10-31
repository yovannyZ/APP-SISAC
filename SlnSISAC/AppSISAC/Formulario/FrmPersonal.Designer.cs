namespace AppSISAC.Formulario
{
    partial class FrmPersonal
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
            this.tcUsuarios = new System.Windows.Forms.TabControl();
            this.tpListado = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtFlitro = new System.Windows.Forms.TextBox();
            this.rbtUsuario = new System.Windows.Forms.RadioButton();
            this.rbtDni = new System.Windows.Forms.RadioButton();
            this.rbtNombreApellido = new System.Windows.Forms.RadioButton();
            this.rbtCodigo = new System.Windows.Forms.RadioButton();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direcccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioGrabo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.Button();
            this.tpRegistro = new System.Windows.Forms.TabPage();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chkMostrarContraseña = new System.Windows.Forms.CheckBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboDistrito = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApMaterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtApPaterno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tcUsuarios.SuspendLayout();
            this.tpListado.SuspendLayout();
            this.gbFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.tpRegistro.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcUsuarios
            // 
            this.tcUsuarios.Controls.Add(this.tpListado);
            this.tcUsuarios.Controls.Add(this.tpRegistro);
            this.tcUsuarios.Location = new System.Drawing.Point(1, 52);
            this.tcUsuarios.Name = "tcUsuarios";
            this.tcUsuarios.SelectedIndex = 0;
            this.tcUsuarios.Size = new System.Drawing.Size(706, 352);
            this.tcUsuarios.TabIndex = 0;
            // 
            // tpListado
            // 
            this.tpListado.BackColor = System.Drawing.Color.White;
            this.tpListado.Controls.Add(this.button2);
            this.tpListado.Controls.Add(this.gbFiltro);
            this.tpListado.Controls.Add(this.btnNuevo);
            this.tpListado.Controls.Add(this.btnEliminar);
            this.tpListado.Controls.Add(this.dgvListado);
            this.tpListado.Controls.Add(this.btnEditar);
            this.tpListado.Location = new System.Drawing.Point(4, 22);
            this.tpListado.Name = "tpListado";
            this.tpListado.Padding = new System.Windows.Forms.Padding(3);
            this.tpListado.Size = new System.Drawing.Size(698, 326);
            this.tpListado.TabIndex = 0;
            this.tpListado.Text = "Listado";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::AppSISAC.Properties.Resources.cancelar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(7, 282);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(98, 38);
            this.button2.TabIndex = 58;
            this.button2.Text = "   Salir";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.btnBuscar);
            this.gbFiltro.Controls.Add(this.txtFlitro);
            this.gbFiltro.Controls.Add(this.rbtUsuario);
            this.gbFiltro.Controls.Add(this.rbtDni);
            this.gbFiltro.Controls.Add(this.rbtNombreApellido);
            this.gbFiltro.Controls.Add(this.rbtCodigo);
            this.gbFiltro.Location = new System.Drawing.Point(7, 6);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(682, 54);
            this.gbFiltro.TabIndex = 48;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtro";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Enabled = false;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnBuscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::AppSISAC.Properties.Resources.buscar;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(553, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnBuscar.Size = new System.Drawing.Size(98, 38);
            this.btnBuscar.TabIndex = 49;
            this.btnBuscar.Text = "     Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFlitro
            // 
            this.txtFlitro.Enabled = false;
            this.txtFlitro.Location = new System.Drawing.Point(369, 21);
            this.txtFlitro.Name = "txtFlitro";
            this.txtFlitro.Size = new System.Drawing.Size(166, 20);
            this.txtFlitro.TabIndex = 4;
            this.txtFlitro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFlitro_KeyPress);
            // 
            // rbtUsuario
            // 
            this.rbtUsuario.AutoSize = true;
            this.rbtUsuario.Location = new System.Drawing.Point(267, 22);
            this.rbtUsuario.Name = "rbtUsuario";
            this.rbtUsuario.Size = new System.Drawing.Size(61, 17);
            this.rbtUsuario.TabIndex = 3;
            this.rbtUsuario.TabStop = true;
            this.rbtUsuario.Text = "Usuario";
            this.rbtUsuario.UseVisualStyleBackColor = true;
            this.rbtUsuario.CheckedChanged += new System.EventHandler(this.rbtUsuario_CheckedChanged);
            // 
            // rbtDni
            // 
            this.rbtDni.AutoSize = true;
            this.rbtDni.Location = new System.Drawing.Point(208, 22);
            this.rbtDni.Name = "rbtDni";
            this.rbtDni.Size = new System.Drawing.Size(44, 17);
            this.rbtDni.TabIndex = 2;
            this.rbtDni.TabStop = true;
            this.rbtDni.Text = "DNI";
            this.rbtDni.UseVisualStyleBackColor = true;
            this.rbtDni.CheckedChanged += new System.EventHandler(this.rbtDni_CheckedChanged);
            // 
            // rbtNombreApellido
            // 
            this.rbtNombreApellido.AutoSize = true;
            this.rbtNombreApellido.Location = new System.Drawing.Point(86, 22);
            this.rbtNombreApellido.Name = "rbtNombreApellido";
            this.rbtNombreApellido.Size = new System.Drawing.Size(104, 17);
            this.rbtNombreApellido.TabIndex = 1;
            this.rbtNombreApellido.TabStop = true;
            this.rbtNombreApellido.Text = "Nombre/Apellido";
            this.rbtNombreApellido.UseVisualStyleBackColor = true;
            this.rbtNombreApellido.CheckedChanged += new System.EventHandler(this.rbtNombreApellido_CheckedChanged);
            // 
            // rbtCodigo
            // 
            this.rbtCodigo.AutoSize = true;
            this.rbtCodigo.Location = new System.Drawing.Point(15, 22);
            this.rbtCodigo.Name = "rbtCodigo";
            this.rbtCodigo.Size = new System.Drawing.Size(58, 17);
            this.rbtCodigo.TabIndex = 0;
            this.rbtCodigo.TabStop = true;
            this.rbtCodigo.Text = "Codigo";
            this.rbtCodigo.UseVisualStyleBackColor = true;
            this.rbtCodigo.CheckedChanged += new System.EventHandler(this.rbtCodigo_CheckedChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.White;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnNuevo.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Image = global::AppSISAC.Properties.Resources._new;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(390, 281);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnNuevo.Size = new System.Drawing.Size(98, 38);
            this.btnNuevo.TabIndex = 47;
            this.btnNuevo.Text = "     Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::AppSISAC.Properties.Resources.cancelar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(596, 281);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnEliminar.Size = new System.Drawing.Size(98, 38);
            this.btnEliminar.TabIndex = 46;
            this.btnEliminar.Text = "    Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombres,
            this.Column1,
            this.Direcccion,
            this.UserName,
            this.Fecha,
            this.UsuarioGrabo});
            this.dgvListado.Location = new System.Drawing.Point(7, 66);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(682, 209);
            this.dgvListado.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Id";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 50;
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "NombreCompleto";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Dni";
            this.Column1.HeaderText = "Dni";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Direcccion
            // 
            this.Direcccion.DataPropertyName = "Direccion";
            this.Direcccion.HeaderText = "Dirección";
            this.Direcccion.Name = "Direcccion";
            this.Direcccion.ReadOnly = true;
            this.Direcccion.Width = 150;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "Usuario";
            this.UserName.HeaderText = "Usuario";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 80;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "UsuFecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 80;
            // 
            // UsuarioGrabo
            // 
            this.UsuarioGrabo.DataPropertyName = "UsuLogin";
            this.UsuarioGrabo.HeaderText = "Usuario registro";
            this.UsuarioGrabo.Name = "UsuarioGrabo";
            this.UsuarioGrabo.ReadOnly = true;
            this.UsuarioGrabo.Width = 130;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnEditar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = global::AppSISAC.Properties.Resources.editar;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(494, 281);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnEditar.Size = new System.Drawing.Size(98, 38);
            this.btnEditar.TabIndex = 45;
            this.btnEditar.Text = "     Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // tpRegistro
            // 
            this.tpRegistro.BackColor = System.Drawing.Color.White;
            this.tpRegistro.Controls.Add(this.btnGuardar);
            this.tpRegistro.Controls.Add(this.button1);
            this.tpRegistro.Controls.Add(this.chkMostrarContraseña);
            this.tpRegistro.Controls.Add(this.txtContrasena);
            this.tpRegistro.Controls.Add(this.label12);
            this.tpRegistro.Controls.Add(this.txtUsuario);
            this.tpRegistro.Controls.Add(this.label5);
            this.tpRegistro.Controls.Add(this.label10);
            this.tpRegistro.Controls.Add(this.cboDepartamento);
            this.tpRegistro.Controls.Add(this.label9);
            this.tpRegistro.Controls.Add(this.cboProvincia);
            this.tpRegistro.Controls.Add(this.label8);
            this.tpRegistro.Controls.Add(this.cboDistrito);
            this.tpRegistro.Controls.Add(this.txtDireccion);
            this.tpRegistro.Controls.Add(this.label6);
            this.tpRegistro.Controls.Add(this.txtDNI);
            this.tpRegistro.Controls.Add(this.label7);
            this.tpRegistro.Controls.Add(this.txtNombres);
            this.tpRegistro.Controls.Add(this.label4);
            this.tpRegistro.Controls.Add(this.txtApMaterno);
            this.tpRegistro.Controls.Add(this.label3);
            this.tpRegistro.Controls.Add(this.TxtApPaterno);
            this.tpRegistro.Controls.Add(this.label2);
            this.tpRegistro.Controls.Add(this.txtId);
            this.tpRegistro.Controls.Add(this.label1);
            this.tpRegistro.Location = new System.Drawing.Point(4, 22);
            this.tpRegistro.Name = "tpRegistro";
            this.tpRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegistro.Size = new System.Drawing.Size(698, 326);
            this.tpRegistro.TabIndex = 1;
            this.tpRegistro.Text = "Mantenimiento";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnGuardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::AppSISAC.Properties.Resources.Save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(244, 186);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnGuardar.Size = new System.Drawing.Size(98, 38);
            this.btnGuardar.TabIndex = 58;
            this.btnGuardar.Text = "      Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::AppSISAC.Properties.Resources.cancelar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(357, 186);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(98, 38);
            this.button1.TabIndex = 57;
            this.button1.Text = "   Salir";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // chkMostrarContraseña
            // 
            this.chkMostrarContraseña.AutoSize = true;
            this.chkMostrarContraseña.Location = new System.Drawing.Point(474, 124);
            this.chkMostrarContraseña.Name = "chkMostrarContraseña";
            this.chkMostrarContraseña.Size = new System.Drawing.Size(121, 17);
            this.chkMostrarContraseña.TabIndex = 56;
            this.chkMostrarContraseña.Text = "Mostrar Contraseña:";
            this.chkMostrarContraseña.UseVisualStyleBackColor = true;
            this.chkMostrarContraseña.CheckedChanged += new System.EventHandler(this.chkMostrarContraseña_CheckedChanged);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(321, 121);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(129, 20);
            this.txtContrasena.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(257, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(111, 121);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(129, 20);
            this.txtUsuario.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Usuario:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(471, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Distrito:";
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(111, 94);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(129, 21);
            this.cboDepartamento.TabIndex = 46;
            this.cboDepartamento.SelectedValueChanged += new System.EventHandler(this.cboDepartamento_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(266, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Provincia:";
            // 
            // cboProvincia
            // 
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(321, 94);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(144, 21);
            this.cboProvincia.TabIndex = 47;
            this.cboProvincia.SelectedValueChanged += new System.EventHandler(this.cboProvincia_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Departamento:";
            // 
            // cboDistrito
            // 
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Location = new System.Drawing.Point(516, 94);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(155, 21);
            this.cboDistrito.TabIndex = 48;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(321, 68);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(350, 20);
            this.txtDireccion.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Direccion:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(111, 68);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(129, 20);
            this.txtDNI.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "DNI:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(516, 42);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(155, 20);
            this.txtNombres.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombres:";
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.Location = new System.Drawing.Point(321, 42);
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Size = new System.Drawing.Size(129, 20);
            this.txtApMaterno.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ap. Materno:";
            // 
            // TxtApPaterno
            // 
            this.TxtApPaterno.Location = new System.Drawing.Point(111, 42);
            this.TxtApPaterno.Name = "TxtApPaterno";
            this.TxtApPaterno.Size = new System.Drawing.Size(129, 20);
            this.TxtApPaterno.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ap. Paterno:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(111, 16);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(47, 20);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(251, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Registro de Usuarios";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 53);
            this.panel1.TabIndex = 25;
            // 
            // FrmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 403);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tcUsuarios);
            this.Name = "FrmPersonal";
            this.Text = "Cliente";
            this.tcUsuarios.ResumeLayout(false);
            this.tpListado.ResumeLayout(false);
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.tpRegistro.ResumeLayout(false);
            this.tpRegistro.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcUsuarios;
        private System.Windows.Forms.TabPage tpListado;
        private System.Windows.Forms.TabPage tpRegistro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.RadioButton rbtCodigo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtFlitro;
        private System.Windows.Forms.RadioButton rbtUsuario;
        private System.Windows.Forms.RadioButton rbtDni;
        private System.Windows.Forms.RadioButton rbtNombreApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direcccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioGrabo;
        private System.Windows.Forms.TextBox TxtApPaterno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApMaterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboDistrito;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkMostrarContraseña;
        private System.Windows.Forms.ComboBox cboProvincia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGuardar;

    }
}