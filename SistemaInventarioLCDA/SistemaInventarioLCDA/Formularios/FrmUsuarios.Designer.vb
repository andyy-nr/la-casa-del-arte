<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanSuperior = New System.Windows.Forms.Panel()
        Me.PibMinimizar = New System.Windows.Forms.PictureBox()
        Me.PibCerrar = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PanelCentral = New System.Windows.Forms.Panel()
        Me.GobDatosUser = New System.Windows.Forms.GroupBox()
        Me.BtnAgregarU = New System.Windows.Forms.Button()
        Me.CebMostrarPwd = New System.Windows.Forms.CheckBox()
        Me.BtnEliminarU = New System.Windows.Forms.Button()
        Me.BtnEditarU = New System.Windows.Forms.Button()
        Me.BtnLimpiarU = New System.Windows.Forms.Button()
        Me.PibPerfil = New System.Windows.Forms.PictureBox()
        Me.CobRoles = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.TxtPwd = New System.Windows.Forms.TextBox()
        Me.TxtCelular = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNombres = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PanSuperior.SuspendLayout()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCentral.SuspendLayout()
        Me.GobDatosUser.SuspendLayout()
        CType(Me.PibPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanSuperior
        '
        Me.PanSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanSuperior.Controls.Add(Me.PibMinimizar)
        Me.PanSuperior.Controls.Add(Me.PibCerrar)
        Me.PanSuperior.Controls.Add(Me.Label8)
        Me.PanSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanSuperior.Name = "PanSuperior"
        Me.PanSuperior.Size = New System.Drawing.Size(1733, 52)
        Me.PanSuperior.TabIndex = 1
        '
        'PibMinimizar
        '
        Me.PibMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PibMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PibMinimizar.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.minimizarBTN
        Me.PibMinimizar.Location = New System.Drawing.Point(1634, 3)
        Me.PibMinimizar.Name = "PibMinimizar"
        Me.PibMinimizar.Size = New System.Drawing.Size(45, 45)
        Me.PibMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PibMinimizar.TabIndex = 7
        Me.PibMinimizar.TabStop = False
        '
        'PibCerrar
        '
        Me.PibCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PibCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PibCerrar.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.cerrarBTN
        Me.PibCerrar.Location = New System.Drawing.Point(1685, 4)
        Me.PibCerrar.Name = "PibCerrar"
        Me.PibCerrar.Size = New System.Drawing.Size(45, 45)
        Me.PibCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PibCerrar.TabIndex = 6
        Me.PibCerrar.TabStop = False
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Nirmala UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(725, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(282, 41)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Gestionar Usuarios"
        '
        'PanelCentral
        '
        Me.PanelCentral.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PanelCentral.Controls.Add(Me.DataGridView1)
        Me.PanelCentral.Controls.Add(Me.PictureBox1)
        Me.PanelCentral.Controls.Add(Me.TxtBuscar)
        Me.PanelCentral.Controls.Add(Me.Label12)
        Me.PanelCentral.Controls.Add(Me.GobDatosUser)
        Me.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCentral.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelCentral.Location = New System.Drawing.Point(0, 52)
        Me.PanelCentral.Name = "PanelCentral"
        Me.PanelCentral.Padding = New System.Windows.Forms.Padding(10)
        Me.PanelCentral.Size = New System.Drawing.Size(1733, 798)
        Me.PanelCentral.TabIndex = 17
        '
        'GobDatosUser
        '
        Me.GobDatosUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GobDatosUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GobDatosUser.Controls.Add(Me.BtnAgregarU)
        Me.GobDatosUser.Controls.Add(Me.CebMostrarPwd)
        Me.GobDatosUser.Controls.Add(Me.BtnEliminarU)
        Me.GobDatosUser.Controls.Add(Me.BtnEditarU)
        Me.GobDatosUser.Controls.Add(Me.BtnLimpiarU)
        Me.GobDatosUser.Controls.Add(Me.PibPerfil)
        Me.GobDatosUser.Controls.Add(Me.CobRoles)
        Me.GobDatosUser.Controls.Add(Me.Label7)
        Me.GobDatosUser.Controls.Add(Me.DtpFechaNac)
        Me.GobDatosUser.Controls.Add(Me.TxtPwd)
        Me.GobDatosUser.Controls.Add(Me.TxtCelular)
        Me.GobDatosUser.Controls.Add(Me.TxtTelefono)
        Me.GobDatosUser.Controls.Add(Me.TxtApellidos)
        Me.GobDatosUser.Controls.Add(Me.Label6)
        Me.GobDatosUser.Controls.Add(Me.Label5)
        Me.GobDatosUser.Controls.Add(Me.Label4)
        Me.GobDatosUser.Controls.Add(Me.TxtNombres)
        Me.GobDatosUser.Controls.Add(Me.Label3)
        Me.GobDatosUser.Controls.Add(Me.Label2)
        Me.GobDatosUser.Controls.Add(Me.Label1)
        Me.GobDatosUser.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GobDatosUser.Location = New System.Drawing.Point(41, 41)
        Me.GobDatosUser.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.GobDatosUser.Name = "GobDatosUser"
        Me.GobDatosUser.Padding = New System.Windows.Forms.Padding(2)
        Me.GobDatosUser.Size = New System.Drawing.Size(1653, 404)
        Me.GobDatosUser.TabIndex = 4
        Me.GobDatosUser.TabStop = False
        Me.GobDatosUser.Text = "Datos Generales del Usuario"
        '
        'BtnAgregarU
        '
        Me.BtnAgregarU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnAgregarU.FlatAppearance.BorderSize = 0
        Me.BtnAgregarU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnAgregarU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnAgregarU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarU.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarU.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.agregarUser
        Me.BtnAgregarU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregarU.Location = New System.Drawing.Point(162, 309)
        Me.BtnAgregarU.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BtnAgregarU.Name = "BtnAgregarU"
        Me.BtnAgregarU.Size = New System.Drawing.Size(183, 55)
        Me.BtnAgregarU.TabIndex = 9
        Me.BtnAgregarU.Text = "Agregar"
        Me.BtnAgregarU.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregarU.UseVisualStyleBackColor = True
        '
        'CebMostrarPwd
        '
        Me.CebMostrarPwd.AutoSize = True
        Me.CebMostrarPwd.Location = New System.Drawing.Point(820, 146)
        Me.CebMostrarPwd.Name = "CebMostrarPwd"
        Me.CebMostrarPwd.Size = New System.Drawing.Size(203, 32)
        Me.CebMostrarPwd.TabIndex = 7
        Me.CebMostrarPwd.Text = "Mostrar contraseña"
        Me.CebMostrarPwd.UseVisualStyleBackColor = True
        '
        'BtnEliminarU
        '
        Me.BtnEliminarU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminarU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnEliminarU.FlatAppearance.BorderSize = 0
        Me.BtnEliminarU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnEliminarU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnEliminarU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarU.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarU.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.eliminarUser
        Me.BtnEliminarU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarU.Location = New System.Drawing.Point(906, 309)
        Me.BtnEliminarU.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BtnEliminarU.Name = "BtnEliminarU"
        Me.BtnEliminarU.Size = New System.Drawing.Size(191, 55)
        Me.BtnEliminarU.TabIndex = 12
        Me.BtnEliminarU.Text = "Eliminar"
        Me.BtnEliminarU.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminarU.UseVisualStyleBackColor = True
        '
        'BtnEditarU
        '
        Me.BtnEditarU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditarU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnEditarU.FlatAppearance.BorderSize = 0
        Me.BtnEditarU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnEditarU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnEditarU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditarU.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditarU.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.editarUser
        Me.BtnEditarU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditarU.Location = New System.Drawing.Point(661, 309)
        Me.BtnEditarU.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BtnEditarU.Name = "BtnEditarU"
        Me.BtnEditarU.Size = New System.Drawing.Size(157, 55)
        Me.BtnEditarU.TabIndex = 11
        Me.BtnEditarU.Text = "Editar"
        Me.BtnEditarU.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditarU.UseVisualStyleBackColor = True
        '
        'BtnLimpiarU
        '
        Me.BtnLimpiarU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpiarU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnLimpiarU.FlatAppearance.BorderSize = 0
        Me.BtnLimpiarU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnLimpiarU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnLimpiarU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiarU.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiarU.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.limpiarCampos
        Me.BtnLimpiarU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiarU.Location = New System.Drawing.Point(407, 309)
        Me.BtnLimpiarU.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BtnLimpiarU.Name = "BtnLimpiarU"
        Me.BtnLimpiarU.Size = New System.Drawing.Size(176, 55)
        Me.BtnLimpiarU.TabIndex = 10
        Me.BtnLimpiarU.Text = "Limpiar"
        Me.BtnLimpiarU.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiarU.UseVisualStyleBackColor = True
        '
        'PibPerfil
        '
        Me.PibPerfil.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PibPerfil.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.usuario
        Me.PibPerfil.Location = New System.Drawing.Point(1287, 54)
        Me.PibPerfil.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.PibPerfil.Name = "PibPerfil"
        Me.PibPerfil.Size = New System.Drawing.Size(335, 310)
        Me.PibPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PibPerfil.TabIndex = 14
        Me.PibPerfil.TabStop = False
        '
        'CobRoles
        '
        Me.CobRoles.FormattingEnabled = True
        Me.CobRoles.Items.AddRange(New Object() {"Administrador", "Digitador", "Bodeguero", "Vendedor", "etc..."})
        Me.CobRoles.Location = New System.Drawing.Point(765, 196)
        Me.CobRoles.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.CobRoles.Name = "CobRoles"
        Me.CobRoles.Size = New System.Drawing.Size(328, 36)
        Me.CobRoles.TabIndex = 8
        Me.CobRoles.Text = "Seleccione el rol.."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(689, 199)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 28)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Roles:"
        '
        'DtpFechaNac
        '
        Me.DtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaNac.Location = New System.Drawing.Point(901, 48)
        Me.DtpFechaNac.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.DtpFechaNac.Name = "DtpFechaNac"
        Me.DtpFechaNac.Size = New System.Drawing.Size(354, 34)
        Me.DtpFechaNac.TabIndex = 5
        '
        'TxtPwd
        '
        Me.TxtPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPwd.Location = New System.Drawing.Point(820, 108)
        Me.TxtPwd.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TxtPwd.Name = "TxtPwd"
        Me.TxtPwd.Size = New System.Drawing.Size(435, 34)
        Me.TxtPwd.TabIndex = 6
        Me.TxtPwd.UseSystemPasswordChar = True
        '
        'TxtCelular
        '
        Me.TxtCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCelular.Location = New System.Drawing.Point(128, 233)
        Me.TxtCelular.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TxtCelular.Name = "TxtCelular"
        Me.TxtCelular.Size = New System.Drawing.Size(410, 34)
        Me.TxtCelular.TabIndex = 4
        '
        'TxtTelefono
        '
        Me.TxtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTelefono.Location = New System.Drawing.Point(128, 170)
        Me.TxtTelefono.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(410, 34)
        Me.TxtTelefono.TabIndex = 3
        '
        'TxtApellidos
        '
        Me.TxtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtApellidos.Location = New System.Drawing.Point(128, 107)
        Me.TxtApellidos.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(410, 34)
        Me.TxtApellidos.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(689, 110)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 28)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Contraseña:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 234)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 28)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Cédula:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(688, 47)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 28)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fecha de nacimiento:"
        '
        'TxtNombres
        '
        Me.TxtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombres.Location = New System.Drawing.Point(128, 48)
        Me.TxtNombres.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TxtNombres.Name = "TxtNombres"
        Me.TxtNombres.Size = New System.Drawing.Size(410, 34)
        Me.TxtNombres.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 170)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Teléfono:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 110)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellidos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombres:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.lupa
        Me.PictureBox1.Location = New System.Drawing.Point(41, 468)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBuscar.Location = New System.Drawing.Point(181, 477)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(1513, 34)
        Me.TxtBuscar.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(102, 477)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 28)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Buscar:"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(41, 547)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1653, 223)
        Me.DataGridView1.TabIndex = 14
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1733, 850)
        Me.Controls.Add(Me.PanelCentral)
        Me.Controls.Add(Me.PanSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmUsuarios"
        Me.Text = "FrmUsuarios"
        Me.PanSuperior.ResumeLayout(False)
        Me.PanSuperior.PerformLayout()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCentral.ResumeLayout(False)
        Me.PanelCentral.PerformLayout()
        Me.GobDatosUser.ResumeLayout(False)
        Me.GobDatosUser.PerformLayout()
        CType(Me.PibPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanSuperior As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents PibMinimizar As PictureBox
    Friend WithEvents PibCerrar As PictureBox
    Friend WithEvents PanelCentral As Panel
    Friend WithEvents GobDatosUser As GroupBox
    Friend WithEvents BtnAgregarU As Button
    Friend WithEvents CebMostrarPwd As CheckBox
    Friend WithEvents BtnEliminarU As Button
    Friend WithEvents BtnEditarU As Button
    Friend WithEvents BtnLimpiarU As Button
    Friend WithEvents PibPerfil As PictureBox
    Friend WithEvents CobRoles As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DtpFechaNac As DateTimePicker
    Friend WithEvents TxtPwd As TextBox
    Friend WithEvents TxtCelular As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNombres As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
