<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuarios))
        Me.PanSuperior = New System.Windows.Forms.Panel()
        Me.PibMaximizar = New System.Windows.Forms.PictureBox()
        Me.PibRetornar = New System.Windows.Forms.PictureBox()
        Me.PibMinimizar = New System.Windows.Forms.PictureBox()
        Me.PibCerrar = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelCentral = New System.Windows.Forms.Panel()
        Me.BtnBuscarUsuario = New System.Windows.Forms.Button()
        Me.CmbFiltrarUsuarios = New System.Windows.Forms.ComboBox()
        Me.DgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.GbUsuarios = New System.Windows.Forms.GroupBox()
        Me.TxtBuscarUsuario = New System.Windows.Forms.TextBox()
        Me.GobUsuario = New System.Windows.Forms.GroupBox()
        Me.LblPwdActual = New System.Windows.Forms.Label()
        Me.CebMostrarPwdNew = New System.Windows.Forms.CheckBox()
        Me.TxtPwdNew = New System.Windows.Forms.TextBox()
        Me.LblPwdNew = New System.Windows.Forms.Label()
        Me.TxtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.TxtCodUser = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblPwd = New System.Windows.Forms.Label()
        Me.TxtPwd = New System.Windows.Forms.TextBox()
        Me.CebMostrarPwd = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbRoles = New System.Windows.Forms.ComboBox()
        Me.PibPerfil = New System.Windows.Forms.PictureBox()
        Me.BtnAgregarU = New System.Windows.Forms.Button()
        Me.BtnEliminarU = New System.Windows.Forms.Button()
        Me.BtnEditarU = New System.Windows.Forms.Button()
        Me.BtnLimpiarU = New System.Windows.Forms.Button()
        Me.GobDatosUser = New System.Windows.Forms.GroupBox()
        Me.TxtApellido2 = New System.Windows.Forms.TextBox()
        Me.TxtNombre2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNombre1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtApellido1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.PanSuperior.SuspendLayout()
        CType(Me.PibMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibRetornar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCentral.SuspendLayout()
        CType(Me.DgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GobUsuario.SuspendLayout()
        CType(Me.PibPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GobDatosUser.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanSuperior
        '
        Me.PanSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanSuperior.Controls.Add(Me.PibMaximizar)
        Me.PanSuperior.Controls.Add(Me.PibRetornar)
        Me.PanSuperior.Controls.Add(Me.PibMinimizar)
        Me.PanSuperior.Controls.Add(Me.PibCerrar)
        Me.PanSuperior.Controls.Add(Me.Label8)
        Me.PanSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanSuperior.Name = "PanSuperior"
        Me.PanSuperior.Size = New System.Drawing.Size(1733, 52)
        Me.PanSuperior.TabIndex = 1
        '
        'PibMaximizar
        '
        Me.PibMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PibMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PibMaximizar.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.btnMaximizar
        Me.PibMaximizar.Location = New System.Drawing.Point(1640, 8)
        Me.PibMaximizar.Name = "PibMaximizar"
        Me.PibMaximizar.Size = New System.Drawing.Size(39, 36)
        Me.PibMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PibMaximizar.TabIndex = 11
        Me.PibMaximizar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PibMaximizar, "Maximizar")
        '
        'PibRetornar
        '
        Me.PibRetornar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PibRetornar.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.BtnRegresar
        Me.PibRetornar.Location = New System.Drawing.Point(3, 3)
        Me.PibRetornar.Name = "PibRetornar"
        Me.PibRetornar.Size = New System.Drawing.Size(43, 43)
        Me.PibRetornar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PibRetornar.TabIndex = 10
        Me.PibRetornar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PibRetornar, "Regresar")
        '
        'PibMinimizar
        '
        Me.PibMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PibMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PibMinimizar.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.minimizarBTN
        Me.PibMinimizar.Location = New System.Drawing.Point(1589, 4)
        Me.PibMinimizar.Name = "PibMinimizar"
        Me.PibMinimizar.Size = New System.Drawing.Size(45, 45)
        Me.PibMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PibMinimizar.TabIndex = 7
        Me.PibMinimizar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PibMinimizar, "Minimizar")
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
        Me.ToolTip1.SetToolTip(Me.PibCerrar, "Cerrar")
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Nirmala UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(725, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(297, 41)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Gestión de Usuarios"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.recargar
        Me.PictureBox1.Location = New System.Drawing.Point(1639, 474)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Actualizar Tabla")
        '
        'PanelCentral
        '
        Me.PanelCentral.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PanelCentral.Controls.Add(Me.PictureBox1)
        Me.PanelCentral.Controls.Add(Me.BtnBuscarUsuario)
        Me.PanelCentral.Controls.Add(Me.CmbFiltrarUsuarios)
        Me.PanelCentral.Controls.Add(Me.DgvUsuarios)
        Me.PanelCentral.Controls.Add(Me.GbUsuarios)
        Me.PanelCentral.Controls.Add(Me.TxtBuscarUsuario)
        Me.PanelCentral.Controls.Add(Me.GobUsuario)
        Me.PanelCentral.Controls.Add(Me.BtnAgregarU)
        Me.PanelCentral.Controls.Add(Me.BtnEliminarU)
        Me.PanelCentral.Controls.Add(Me.BtnEditarU)
        Me.PanelCentral.Controls.Add(Me.BtnLimpiarU)
        Me.PanelCentral.Controls.Add(Me.GobDatosUser)
        Me.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCentral.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelCentral.Location = New System.Drawing.Point(0, 52)
        Me.PanelCentral.Name = "PanelCentral"
        Me.PanelCentral.Padding = New System.Windows.Forms.Padding(10)
        Me.PanelCentral.Size = New System.Drawing.Size(1733, 798)
        Me.PanelCentral.TabIndex = 18
        '
        'BtnBuscarUsuario
        '
        Me.BtnBuscarUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBuscarUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnBuscarUsuario.FlatAppearance.BorderSize = 0
        Me.BtnBuscarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnBuscarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarUsuario.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnBuscarUsuario.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgBuscar
        Me.BtnBuscarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarUsuario.Location = New System.Drawing.Point(1484, 474)
        Me.BtnBuscarUsuario.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnBuscarUsuario.Name = "BtnBuscarUsuario"
        Me.BtnBuscarUsuario.Size = New System.Drawing.Size(149, 55)
        Me.BtnBuscarUsuario.TabIndex = 49
        Me.BtnBuscarUsuario.Text = "Buscar"
        Me.BtnBuscarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscarUsuario.UseVisualStyleBackColor = True
        '
        'CmbFiltrarUsuarios
        '
        Me.CmbFiltrarUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.CmbFiltrarUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmbFiltrarUsuarios.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CmbFiltrarUsuarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.CmbFiltrarUsuarios.FormattingEnabled = True
        Me.CmbFiltrarUsuarios.Items.AddRange(New Object() {"Filtrar por nombre completo", "Filtrar por nombre", "Filtrar por apellido", "Filtrar por nombre de usuario", "Filtrar por rol"})
        Me.CmbFiltrarUsuarios.Location = New System.Drawing.Point(47, 482)
        Me.CmbFiltrarUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbFiltrarUsuarios.Name = "CmbFiltrarUsuarios"
        Me.CmbFiltrarUsuarios.Size = New System.Drawing.Size(309, 36)
        Me.CmbFiltrarUsuarios.TabIndex = 38
        Me.CmbFiltrarUsuarios.Text = "Filtrar usuarios"
        '
        'DgvUsuarios
        '
        Me.DgvUsuarios.AllowUserToAddRows = False
        Me.DgvUsuarios.AllowUserToResizeColumns = False
        Me.DgvUsuarios.AllowUserToResizeRows = False
        Me.DgvUsuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.DgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvUsuarios.EnableHeadersVisualStyles = False
        Me.DgvUsuarios.GridColor = System.Drawing.Color.SaddleBrown
        Me.DgvUsuarios.Location = New System.Drawing.Point(47, 573)
        Me.DgvUsuarios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DgvUsuarios.Name = "DgvUsuarios"
        Me.DgvUsuarios.ReadOnly = True
        Me.DgvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvUsuarios.RowHeadersVisible = False
        Me.DgvUsuarios.RowHeadersWidth = 51
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(181, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Sienna
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DgvUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvUsuarios.RowTemplate.Height = 24
        Me.DgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvUsuarios.Size = New System.Drawing.Size(1642, 184)
        Me.DgvUsuarios.TabIndex = 42
        '
        'GbUsuarios
        '
        Me.GbUsuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GbUsuarios.Location = New System.Drawing.Point(41, 541)
        Me.GbUsuarios.Name = "GbUsuarios"
        Me.GbUsuarios.Size = New System.Drawing.Size(1654, 221)
        Me.GbUsuarios.TabIndex = 43
        Me.GbUsuarios.TabStop = False
        Me.GbUsuarios.Text = "Usuarios Registrados: 0"
        '
        'TxtBuscarUsuario
        '
        Me.TxtBuscarUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBuscarUsuario.Location = New System.Drawing.Point(376, 484)
        Me.TxtBuscarUsuario.Name = "TxtBuscarUsuario"
        Me.TxtBuscarUsuario.Size = New System.Drawing.Size(1102, 34)
        Me.TxtBuscarUsuario.TabIndex = 35
        '
        'GobUsuario
        '
        Me.GobUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GobUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GobUsuario.Controls.Add(Me.LblPwdActual)
        Me.GobUsuario.Controls.Add(Me.CebMostrarPwdNew)
        Me.GobUsuario.Controls.Add(Me.TxtPwdNew)
        Me.GobUsuario.Controls.Add(Me.LblPwdNew)
        Me.GobUsuario.Controls.Add(Me.TxtNombreUsuario)
        Me.GobUsuario.Controls.Add(Me.TxtCodUser)
        Me.GobUsuario.Controls.Add(Me.Label10)
        Me.GobUsuario.Controls.Add(Me.Label9)
        Me.GobUsuario.Controls.Add(Me.LblPwd)
        Me.GobUsuario.Controls.Add(Me.TxtPwd)
        Me.GobUsuario.Controls.Add(Me.CebMostrarPwd)
        Me.GobUsuario.Controls.Add(Me.Label7)
        Me.GobUsuario.Controls.Add(Me.CbRoles)
        Me.GobUsuario.Controls.Add(Me.PibPerfil)
        Me.GobUsuario.Location = New System.Drawing.Point(732, 41)
        Me.GobUsuario.Name = "GobUsuario"
        Me.GobUsuario.Size = New System.Drawing.Size(962, 369)
        Me.GobUsuario.TabIndex = 15
        Me.GobUsuario.TabStop = False
        Me.GobUsuario.Text = "Datos Generale del Usuario"
        '
        'LblPwdActual
        '
        Me.LblPwdActual.AutoSize = True
        Me.LblPwdActual.Location = New System.Drawing.Point(40, 221)
        Me.LblPwdActual.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPwdActual.Name = "LblPwdActual"
        Me.LblPwdActual.Size = New System.Drawing.Size(174, 28)
        Me.LblPwdActual.TabIndex = 23
        Me.LblPwdActual.Text = "Contraseña Actual:"
        Me.LblPwdActual.Visible = False
        '
        'CebMostrarPwdNew
        '
        Me.CebMostrarPwdNew.AutoSize = True
        Me.CebMostrarPwdNew.Location = New System.Drawing.Point(231, 332)
        Me.CebMostrarPwdNew.Name = "CebMostrarPwdNew"
        Me.CebMostrarPwdNew.Size = New System.Drawing.Size(203, 32)
        Me.CebMostrarPwdNew.TabIndex = 22
        Me.CebMostrarPwdNew.Text = "Mostrar contraseña"
        Me.CebMostrarPwdNew.UseVisualStyleBackColor = True
        Me.CebMostrarPwdNew.Visible = False
        '
        'TxtPwdNew
        '
        Me.TxtPwdNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPwdNew.Location = New System.Drawing.Point(231, 294)
        Me.TxtPwdNew.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TxtPwdNew.Name = "TxtPwdNew"
        Me.TxtPwdNew.Size = New System.Drawing.Size(331, 34)
        Me.TxtPwdNew.TabIndex = 21
        Me.TxtPwdNew.UseSystemPasswordChar = True
        Me.TxtPwdNew.Visible = False
        '
        'LblPwdNew
        '
        Me.LblPwdNew.AutoSize = True
        Me.LblPwdNew.Location = New System.Drawing.Point(40, 296)
        Me.LblPwdNew.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPwdNew.Name = "LblPwdNew"
        Me.LblPwdNew.Size = New System.Drawing.Size(175, 28)
        Me.LblPwdNew.TabIndex = 20
        Me.LblPwdNew.Text = "Contraseña Nueva:"
        Me.LblPwdNew.Visible = False
        '
        'TxtNombreUsuario
        '
        Me.TxtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombreUsuario.Location = New System.Drawing.Point(231, 98)
        Me.TxtNombreUsuario.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TxtNombreUsuario.Name = "TxtNombreUsuario"
        Me.TxtNombreUsuario.Size = New System.Drawing.Size(331, 34)
        Me.TxtNombreUsuario.TabIndex = 19
        '
        'TxtCodUser
        '
        Me.TxtCodUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCodUser.Enabled = False
        Me.TxtCodUser.Location = New System.Drawing.Point(231, 41)
        Me.TxtCodUser.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TxtCodUser.Name = "TxtCodUser"
        Me.TxtCodUser.Size = New System.Drawing.Size(331, 34)
        Me.TxtCodUser.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(134, 41)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 28)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Código:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 98)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(188, 28)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Nombre de Usuario:"
        '
        'LblPwd
        '
        Me.LblPwd.AutoSize = True
        Me.LblPwd.Location = New System.Drawing.Point(101, 222)
        Me.LblPwd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPwd.Name = "LblPwd"
        Me.LblPwd.Size = New System.Drawing.Size(114, 28)
        Me.LblPwd.TabIndex = 6
        Me.LblPwd.Text = "Contraseña:"
        '
        'TxtPwd
        '
        Me.TxtPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPwd.Location = New System.Drawing.Point(231, 219)
        Me.TxtPwd.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TxtPwd.Name = "TxtPwd"
        Me.TxtPwd.Size = New System.Drawing.Size(331, 34)
        Me.TxtPwd.TabIndex = 10
        Me.TxtPwd.UseSystemPasswordChar = True
        '
        'CebMostrarPwd
        '
        Me.CebMostrarPwd.AutoSize = True
        Me.CebMostrarPwd.Location = New System.Drawing.Point(231, 257)
        Me.CebMostrarPwd.Name = "CebMostrarPwd"
        Me.CebMostrarPwd.Size = New System.Drawing.Size(203, 32)
        Me.CebMostrarPwd.TabIndex = 11
        Me.CebMostrarPwd.Text = "Mostrar contraseña"
        Me.CebMostrarPwd.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(171, 160)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 28)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Rol:"
        '
        'CbRoles
        '
        Me.CbRoles.FormattingEnabled = True
        Me.CbRoles.Items.AddRange(New Object() {"Administrador", "Digitador", "Bodeguero", "Vendedor", "etc..."})
        Me.CbRoles.Location = New System.Drawing.Point(231, 157)
        Me.CbRoles.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.CbRoles.Name = "CbRoles"
        Me.CbRoles.Size = New System.Drawing.Size(331, 36)
        Me.CbRoles.TabIndex = 9
        Me.CbRoles.Text = "Seleccione el rol.."
        '
        'PibPerfil
        '
        Me.PibPerfil.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PibPerfil.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgUsuarios
        Me.PibPerfil.Location = New System.Drawing.Point(594, 34)
        Me.PibPerfil.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.PibPerfil.Name = "PibPerfil"
        Me.PibPerfil.Size = New System.Drawing.Size(335, 310)
        Me.PibPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PibPerfil.TabIndex = 14
        Me.PibPerfil.TabStop = False
        '
        'BtnAgregarU
        '
        Me.BtnAgregarU.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnAgregarU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnAgregarU.FlatAppearance.BorderSize = 0
        Me.BtnAgregarU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnAgregarU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnAgregarU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarU.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarU.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnAgregarU.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgAgregarUser
        Me.BtnAgregarU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregarU.Location = New System.Drawing.Point(407, 420)
        Me.BtnAgregarU.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BtnAgregarU.Name = "BtnAgregarU"
        Me.BtnAgregarU.Size = New System.Drawing.Size(183, 55)
        Me.BtnAgregarU.TabIndex = 12
        Me.BtnAgregarU.Text = "Agregar"
        Me.BtnAgregarU.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregarU.UseVisualStyleBackColor = True
        '
        'BtnEliminarU
        '
        Me.BtnEliminarU.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnEliminarU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminarU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnEliminarU.FlatAppearance.BorderSize = 0
        Me.BtnEliminarU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnEliminarU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnEliminarU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarU.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarU.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnEliminarU.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgEliminarUser
        Me.BtnEliminarU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarU.Location = New System.Drawing.Point(1102, 420)
        Me.BtnEliminarU.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BtnEliminarU.Name = "BtnEliminarU"
        Me.BtnEliminarU.Size = New System.Drawing.Size(191, 55)
        Me.BtnEliminarU.TabIndex = 15
        Me.BtnEliminarU.Text = "Eliminar"
        Me.BtnEliminarU.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminarU.UseVisualStyleBackColor = True
        '
        'BtnEditarU
        '
        Me.BtnEditarU.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnEditarU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditarU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnEditarU.FlatAppearance.BorderSize = 0
        Me.BtnEditarU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnEditarU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnEditarU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditarU.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditarU.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnEditarU.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgEditarUser
        Me.BtnEditarU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditarU.Location = New System.Drawing.Point(889, 420)
        Me.BtnEditarU.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BtnEditarU.Name = "BtnEditarU"
        Me.BtnEditarU.Size = New System.Drawing.Size(157, 55)
        Me.BtnEditarU.TabIndex = 14
        Me.BtnEditarU.Text = "Editar"
        Me.BtnEditarU.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditarU.UseVisualStyleBackColor = True
        '
        'BtnLimpiarU
        '
        Me.BtnLimpiarU.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnLimpiarU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpiarU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnLimpiarU.FlatAppearance.BorderSize = 0
        Me.BtnLimpiarU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnLimpiarU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnLimpiarU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiarU.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiarU.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnLimpiarU.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgLimpiarCampos1
        Me.BtnLimpiarU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiarU.Location = New System.Drawing.Point(650, 420)
        Me.BtnLimpiarU.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BtnLimpiarU.Name = "BtnLimpiarU"
        Me.BtnLimpiarU.Size = New System.Drawing.Size(176, 55)
        Me.BtnLimpiarU.TabIndex = 13
        Me.BtnLimpiarU.Text = "Limpiar"
        Me.BtnLimpiarU.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiarU.UseVisualStyleBackColor = True
        '
        'GobDatosUser
        '
        Me.GobDatosUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GobDatosUser.Controls.Add(Me.TxtApellido2)
        Me.GobDatosUser.Controls.Add(Me.TxtNombre2)
        Me.GobDatosUser.Controls.Add(Me.Label1)
        Me.GobDatosUser.Controls.Add(Me.TxtNombre1)
        Me.GobDatosUser.Controls.Add(Me.Label2)
        Me.GobDatosUser.Controls.Add(Me.TxtApellido1)
        Me.GobDatosUser.Controls.Add(Me.Label4)
        Me.GobDatosUser.Controls.Add(Me.DtpFechaNac)
        Me.GobDatosUser.Controls.Add(Me.Label3)
        Me.GobDatosUser.Controls.Add(Me.TxtTelefono)
        Me.GobDatosUser.Controls.Add(Me.Label5)
        Me.GobDatosUser.Controls.Add(Me.TxtCedula)
        Me.GobDatosUser.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GobDatosUser.Location = New System.Drawing.Point(41, 41)
        Me.GobDatosUser.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.GobDatosUser.Name = "GobDatosUser"
        Me.GobDatosUser.Padding = New System.Windows.Forms.Padding(2)
        Me.GobDatosUser.Size = New System.Drawing.Size(663, 369)
        Me.GobDatosUser.TabIndex = 4
        Me.GobDatosUser.TabStop = False
        Me.GobDatosUser.Text = "Datos Personales"
        '
        'TxtApellido2
        '
        Me.TxtApellido2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtApellido2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtApellido2.Location = New System.Drawing.Point(423, 106)
        Me.TxtApellido2.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TxtApellido2.Name = "TxtApellido2"
        Me.TxtApellido2.Size = New System.Drawing.Size(220, 34)
        Me.TxtApellido2.TabIndex = 4
        '
        'TxtNombre2
        '
        Me.TxtNombre2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtNombre2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombre2.Location = New System.Drawing.Point(423, 47)
        Me.TxtNombre2.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TxtNombre2.Name = "TxtNombre2"
        Me.TxtNombre2.Size = New System.Drawing.Size(220, 34)
        Me.TxtNombre2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombres:"
        '
        'TxtNombre1
        '
        Me.TxtNombre1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtNombre1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombre1.Location = New System.Drawing.Point(166, 45)
        Me.TxtNombre1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TxtNombre1.Name = "TxtNombre1"
        Me.TxtNombre1.Size = New System.Drawing.Size(220, 34)
        Me.TxtNombre1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellidos:"
        '
        'TxtApellido1
        '
        Me.TxtApellido1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtApellido1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtApellido1.Location = New System.Drawing.Point(166, 106)
        Me.TxtApellido1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TxtApellido1.Name = "TxtApellido1"
        Me.TxtApellido1.Size = New System.Drawing.Size(220, 34)
        Me.TxtApellido1.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 174)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 28)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fecha de nacimiento:"
        '
        'DtpFechaNac
        '
        Me.DtpFechaNac.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaNac.Location = New System.Drawing.Point(258, 171)
        Me.DtpFechaNac.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.DtpFechaNac.Name = "DtpFechaNac"
        Me.DtpFechaNac.Size = New System.Drawing.Size(385, 34)
        Me.DtpFechaNac.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 238)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Número de teléfono:"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTelefono.Location = New System.Drawing.Point(258, 236)
        Me.TxtTelefono.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(385, 34)
        Me.TxtTelefono.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(156, 300)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 28)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Cédula:"
        '
        'TxtCedula
        '
        Me.TxtCedula.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCedula.Location = New System.Drawing.Point(258, 298)
        Me.TxtCedula.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(385, 34)
        Me.TxtCedula.TabIndex = 7
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1733, 850)
        Me.Controls.Add(Me.PanelCentral)
        Me.Controls.Add(Me.PanSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUsuarios"
        Me.Text = "Gestión de Usuarios"
        Me.PanSuperior.ResumeLayout(False)
        Me.PanSuperior.PerformLayout()
        CType(Me.PibMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibRetornar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCentral.ResumeLayout(False)
        Me.PanelCentral.PerformLayout()
        CType(Me.DgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GobUsuario.ResumeLayout(False)
        Me.GobUsuario.PerformLayout()
        CType(Me.PibPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GobDatosUser.ResumeLayout(False)
        Me.GobDatosUser.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanSuperior As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents PibMinimizar As PictureBox
    Friend WithEvents PibCerrar As PictureBox
    Friend WithEvents PibRetornar As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PibMaximizar As PictureBox
    Friend WithEvents PanelCentral As Panel
    Friend WithEvents DgvUsuarios As DataGridView
    Friend WithEvents GbUsuarios As GroupBox
    Friend WithEvents TxtBuscarUsuario As TextBox
    Friend WithEvents GobUsuario As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LblPwd As Label
    Friend WithEvents TxtPwd As TextBox
    Friend WithEvents CebMostrarPwd As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CbRoles As ComboBox
    Friend WithEvents PibPerfil As PictureBox
    Friend WithEvents BtnAgregarU As Button
    Friend WithEvents BtnEliminarU As Button
    Friend WithEvents BtnEditarU As Button
    Friend WithEvents BtnLimpiarU As Button
    Friend WithEvents GobDatosUser As GroupBox
    Friend WithEvents TxtApellido2 As TextBox
    Friend WithEvents TxtNombre2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNombre1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtApellido1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DtpFechaNac As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents TxtNombreUsuario As TextBox
    Friend WithEvents TxtCodUser As TextBox
    Friend WithEvents LblPwdNew As Label
    Friend WithEvents TxtPwdNew As TextBox
    Friend WithEvents CebMostrarPwdNew As CheckBox
    Friend WithEvents LblPwdActual As Label
    Friend WithEvents CmbFiltrarUsuarios As ComboBox
    Friend WithEvents BtnBuscarUsuario As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
