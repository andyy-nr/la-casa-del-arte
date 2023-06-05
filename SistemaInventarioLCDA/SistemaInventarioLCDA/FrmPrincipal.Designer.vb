<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
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
        Me.PanSuperior = New System.Windows.Forms.Panel()
        Me.PibMaximizar = New System.Windows.Forms.PictureBox()
        Me.PibMinimizar = New System.Windows.Forms.PictureBox()
        Me.PibCerrar = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanMenu = New System.Windows.Forms.Panel()
        Me.BtnMarca = New System.Windows.Forms.Button()
        Me.BtnCerrarSesion = New System.Windows.Forms.Button()
        Me.BtnReportes = New System.Windows.Forms.Button()
        Me.BtnMovimientos = New System.Windows.Forms.Button()
        Me.BtnProductos = New System.Windows.Forms.Button()
        Me.BtnCategorias = New System.Windows.Forms.Button()
        Me.BtnUsuarios = New System.Windows.Forms.Button()
        Me.BtnRoles = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lbl_nombreUser = New System.Windows.Forms.Label()
        Me.Lbl_rolUsuario = New System.Windows.Forms.Label()
        Me.PibMenu = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TmrOcultar = New System.Windows.Forms.Timer(Me.components)
        Me.TmrMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.TmrHoraFecha = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanPrincipal = New System.Windows.Forms.Panel()
        Me.PanReportes = New System.Windows.Forms.Panel()
        Me.BtnReporteMarcasProd = New System.Windows.Forms.Button()
        Me.BtnRepoMov = New System.Windows.Forms.Button()
        Me.BtnRepoProd = New System.Windows.Forms.Button()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.LblHora = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BtnRptMarcasMinProd = New System.Windows.Forms.Button()
        Me.PanSuperior.SuspendLayout()
        CType(Me.PibMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PibMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanPrincipal.SuspendLayout()
        Me.PanReportes.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanSuperior
        '
        Me.PanSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanSuperior.Controls.Add(Me.PibMaximizar)
        Me.PanSuperior.Controls.Add(Me.PibMinimizar)
        Me.PanSuperior.Controls.Add(Me.PibCerrar)
        Me.PanSuperior.Controls.Add(Me.Label2)
        Me.PanSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanSuperior.Name = "PanSuperior"
        Me.PanSuperior.Size = New System.Drawing.Size(1016, 42)
        Me.PanSuperior.TabIndex = 0
        '
        'PibMaximizar
        '
        Me.PibMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PibMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PibMaximizar.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.btnMaximizar
        Me.PibMaximizar.Location = New System.Drawing.Point(946, 6)
        Me.PibMaximizar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PibMaximizar.Name = "PibMaximizar"
        Me.PibMaximizar.Size = New System.Drawing.Size(29, 29)
        Me.PibMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PibMaximizar.TabIndex = 6
        Me.PibMaximizar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PibMaximizar, "Maximizar")
        '
        'PibMinimizar
        '
        Me.PibMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PibMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PibMinimizar.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.minimizarBTN
        Me.PibMinimizar.Location = New System.Drawing.Point(908, 3)
        Me.PibMinimizar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PibMinimizar.Name = "PibMinimizar"
        Me.PibMinimizar.Size = New System.Drawing.Size(34, 37)
        Me.PibMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PibMinimizar.TabIndex = 5
        Me.PibMinimizar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PibMinimizar, "Minimizar")
        '
        'PibCerrar
        '
        Me.PibCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PibCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PibCerrar.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.cerrarBTN
        Me.PibCerrar.Location = New System.Drawing.Point(980, 2)
        Me.PibCerrar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PibCerrar.Name = "PibCerrar"
        Me.PibCerrar.Size = New System.Drawing.Size(34, 37)
        Me.PibCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PibCerrar.TabIndex = 4
        Me.PibCerrar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PibCerrar, "Cerrar")
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(316, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(389, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sistema de Inventario La Casa del Arte"
        '
        'PanMenu
        '
        Me.PanMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PanMenu.Controls.Add(Me.BtnMarca)
        Me.PanMenu.Controls.Add(Me.BtnCerrarSesion)
        Me.PanMenu.Controls.Add(Me.BtnReportes)
        Me.PanMenu.Controls.Add(Me.BtnMovimientos)
        Me.PanMenu.Controls.Add(Me.BtnProductos)
        Me.PanMenu.Controls.Add(Me.BtnCategorias)
        Me.PanMenu.Controls.Add(Me.BtnUsuarios)
        Me.PanMenu.Controls.Add(Me.BtnRoles)
        Me.PanMenu.Controls.Add(Me.Panel1)
        Me.PanMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanMenu.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanMenu.ForeColor = System.Drawing.Color.Black
        Me.PanMenu.Location = New System.Drawing.Point(0, 42)
        Me.PanMenu.Name = "PanMenu"
        Me.PanMenu.Size = New System.Drawing.Size(220, 598)
        Me.PanMenu.TabIndex = 1
        '
        'BtnMarca
        '
        Me.BtnMarca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMarca.Enabled = False
        Me.BtnMarca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnMarca.FlatAppearance.BorderSize = 0
        Me.BtnMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BtnMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMarca.ForeColor = System.Drawing.Color.Black
        Me.BtnMarca.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.BtnMarcas
        Me.BtnMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMarca.Location = New System.Drawing.Point(0, 305)
        Me.BtnMarca.Name = "BtnMarca"
        Me.BtnMarca.Size = New System.Drawing.Size(220, 50)
        Me.BtnMarca.TabIndex = 11
        Me.BtnMarca.Text = "Marcas"
        Me.BtnMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnMarca.UseVisualStyleBackColor = True
        '
        'BtnCerrarSesion
        '
        Me.BtnCerrarSesion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BtnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnCerrarSesion.FlatAppearance.BorderSize = 0
        Me.BtnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BtnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrarSesion.ForeColor = System.Drawing.Color.Black
        Me.BtnCerrarSesion.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.logout
        Me.BtnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrarSesion.Location = New System.Drawing.Point(0, 548)
        Me.BtnCerrarSesion.Name = "BtnCerrarSesion"
        Me.BtnCerrarSesion.Size = New System.Drawing.Size(220, 50)
        Me.BtnCerrarSesion.TabIndex = 9
        Me.BtnCerrarSesion.Text = "Cerrar Sesión"
        Me.BtnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCerrarSesion.UseVisualStyleBackColor = False
        '
        'BtnReportes
        '
        Me.BtnReportes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReportes.Enabled = False
        Me.BtnReportes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnReportes.FlatAppearance.BorderSize = 0
        Me.BtnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BtnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReportes.ForeColor = System.Drawing.Color.Black
        Me.BtnReportes.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.reportesMov
        Me.BtnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReportes.Location = New System.Drawing.Point(0, 532)
        Me.BtnReportes.Name = "BtnReportes"
        Me.BtnReportes.Size = New System.Drawing.Size(220, 50)
        Me.BtnReportes.TabIndex = 8
        Me.BtnReportes.Text = "Reportes"
        Me.BtnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnReportes.UseVisualStyleBackColor = True
        '
        'BtnMovimientos
        '
        Me.BtnMovimientos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMovimientos.Enabled = False
        Me.BtnMovimientos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnMovimientos.FlatAppearance.BorderSize = 0
        Me.BtnMovimientos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BtnMovimientos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMovimientos.ForeColor = System.Drawing.Color.Black
        Me.BtnMovimientos.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.movimientos
        Me.BtnMovimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMovimientos.Location = New System.Drawing.Point(2, 475)
        Me.BtnMovimientos.Name = "BtnMovimientos"
        Me.BtnMovimientos.Size = New System.Drawing.Size(220, 50)
        Me.BtnMovimientos.TabIndex = 7
        Me.BtnMovimientos.Text = "Movimientos"
        Me.BtnMovimientos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnMovimientos.UseVisualStyleBackColor = True
        '
        'BtnProductos
        '
        Me.BtnProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProductos.Enabled = False
        Me.BtnProductos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnProductos.FlatAppearance.BorderSize = 0
        Me.BtnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BtnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProductos.ForeColor = System.Drawing.Color.Black
        Me.BtnProductos.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.productosman
        Me.BtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProductos.Location = New System.Drawing.Point(0, 418)
        Me.BtnProductos.Name = "BtnProductos"
        Me.BtnProductos.Size = New System.Drawing.Size(220, 50)
        Me.BtnProductos.TabIndex = 6
        Me.BtnProductos.Text = "Productos"
        Me.BtnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnProductos.UseVisualStyleBackColor = True
        '
        'BtnCategorias
        '
        Me.BtnCategorias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCategorias.Enabled = False
        Me.BtnCategorias.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnCategorias.FlatAppearance.BorderSize = 0
        Me.BtnCategorias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BtnCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCategorias.ForeColor = System.Drawing.Color.Black
        Me.BtnCategorias.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.categoriaprod
        Me.BtnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCategorias.Location = New System.Drawing.Point(0, 362)
        Me.BtnCategorias.Name = "BtnCategorias"
        Me.BtnCategorias.Size = New System.Drawing.Size(220, 50)
        Me.BtnCategorias.TabIndex = 5
        Me.BtnCategorias.Text = "Categorías"
        Me.BtnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCategorias.UseVisualStyleBackColor = True
        '
        'BtnUsuarios
        '
        Me.BtnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUsuarios.Enabled = False
        Me.BtnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnUsuarios.FlatAppearance.BorderSize = 0
        Me.BtnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BtnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUsuarios.ForeColor = System.Drawing.Color.Black
        Me.BtnUsuarios.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.usuarios
        Me.BtnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUsuarios.Location = New System.Drawing.Point(0, 248)
        Me.BtnUsuarios.Name = "BtnUsuarios"
        Me.BtnUsuarios.Size = New System.Drawing.Size(220, 50)
        Me.BtnUsuarios.TabIndex = 4
        Me.BtnUsuarios.Text = "Usuarios"
        Me.BtnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUsuarios.UseVisualStyleBackColor = True
        '
        'BtnRoles
        '
        Me.BtnRoles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRoles.Enabled = False
        Me.BtnRoles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnRoles.FlatAppearance.BorderSize = 0
        Me.BtnRoles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BtnRoles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRoles.ForeColor = System.Drawing.Color.Black
        Me.BtnRoles.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.admin
        Me.BtnRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRoles.Location = New System.Drawing.Point(0, 191)
        Me.BtnRoles.Name = "BtnRoles"
        Me.BtnRoles.Size = New System.Drawing.Size(220, 50)
        Me.BtnRoles.TabIndex = 3
        Me.BtnRoles.Text = "Roles"
        Me.BtnRoles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRoles.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Lbl_nombreUser)
        Me.Panel1.Controls.Add(Me.Lbl_rolUsuario)
        Me.Panel1.Controls.Add(Me.PibMenu)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(220, 144)
        Me.Panel1.TabIndex = 10
        '
        'Lbl_nombreUser
        '
        Me.Lbl_nombreUser.AutoSize = True
        Me.Lbl_nombreUser.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_nombreUser.Location = New System.Drawing.Point(64, 98)
        Me.Lbl_nombreUser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_nombreUser.Name = "Lbl_nombreUser"
        Me.Lbl_nombreUser.Size = New System.Drawing.Size(157, 19)
        Me.Lbl_nombreUser.TabIndex = 3
        Me.Lbl_nombreUser.Text = "*Nombre del Usuario*"
        '
        'Lbl_rolUsuario
        '
        Me.Lbl_rolUsuario.AutoSize = True
        Me.Lbl_rolUsuario.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_rolUsuario.Location = New System.Drawing.Point(64, 68)
        Me.Lbl_rolUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_rolUsuario.Name = "Lbl_rolUsuario"
        Me.Lbl_rolUsuario.Size = New System.Drawing.Size(123, 19)
        Me.Lbl_rolUsuario.TabIndex = 2
        Me.Lbl_rolUsuario.Text = "*Rol del Usuario*"
        '
        'PibMenu
        '
        Me.PibMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PibMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PibMenu.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.menu
        Me.PibMenu.Location = New System.Drawing.Point(170, 6)
        Me.PibMenu.Name = "PibMenu"
        Me.PibMenu.Size = New System.Drawing.Size(41, 45)
        Me.PibMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PibMenu.TabIndex = 0
        Me.PibMenu.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.usuario_de_perfil1
        Me.PictureBox2.Location = New System.Drawing.Point(2, 68)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 57)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'TmrOcultar
        '
        '
        'TmrMostrar
        '
        '
        'TmrHoraFecha
        '
        Me.TmrHoraFecha.Enabled = True
        '
        'PanPrincipal
        '
        Me.PanPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.PanPrincipal.Controls.Add(Me.PanReportes)
        Me.PanPrincipal.Controls.Add(Me.LblFecha)
        Me.PanPrincipal.Controls.Add(Me.LblHora)
        Me.PanPrincipal.Controls.Add(Me.PictureBox3)
        Me.PanPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanPrincipal.Location = New System.Drawing.Point(220, 42)
        Me.PanPrincipal.Name = "PanPrincipal"
        Me.PanPrincipal.Size = New System.Drawing.Size(796, 598)
        Me.PanPrincipal.TabIndex = 7
        '
        'PanReportes
        '
        Me.PanReportes.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PanReportes.Controls.Add(Me.BtnRptMarcasMinProd)
        Me.PanReportes.Controls.Add(Me.BtnReporteMarcasProd)
        Me.PanReportes.Controls.Add(Me.BtnRepoMov)
        Me.PanReportes.Controls.Add(Me.BtnRepoProd)
        Me.PanReportes.Location = New System.Drawing.Point(2, 354)
        Me.PanReportes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanReportes.Name = "PanReportes"
        Me.PanReportes.Size = New System.Drawing.Size(394, 264)
        Me.PanReportes.TabIndex = 4
        Me.PanReportes.Visible = False
        '
        'BtnReporteMarcasProd
        '
        Me.BtnReporteMarcasProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReporteMarcasProd.Enabled = False
        Me.BtnReporteMarcasProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnReporteMarcasProd.FlatAppearance.BorderSize = 0
        Me.BtnReporteMarcasProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BtnReporteMarcasProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnReporteMarcasProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReporteMarcasProd.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnReporteMarcasProd.ForeColor = System.Drawing.Color.Black
        Me.BtnReporteMarcasProd.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.reportesMov
        Me.BtnReporteMarcasProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReporteMarcasProd.Location = New System.Drawing.Point(3, 136)
        Me.BtnReporteMarcasProd.Name = "BtnReporteMarcasProd"
        Me.BtnReporteMarcasProd.Size = New System.Drawing.Size(388, 50)
        Me.BtnReporteMarcasProd.TabIndex = 11
        Me.BtnReporteMarcasProd.Text = "Reportes de Marcas con más Productos"
        Me.BtnReporteMarcasProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnReporteMarcasProd.UseVisualStyleBackColor = True
        '
        'BtnRepoMov
        '
        Me.BtnRepoMov.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRepoMov.Enabled = False
        Me.BtnRepoMov.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnRepoMov.FlatAppearance.BorderSize = 0
        Me.BtnRepoMov.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BtnRepoMov.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnRepoMov.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRepoMov.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnRepoMov.ForeColor = System.Drawing.Color.Black
        Me.BtnRepoMov.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.reportesMov
        Me.BtnRepoMov.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRepoMov.Location = New System.Drawing.Point(3, 68)
        Me.BtnRepoMov.Name = "BtnRepoMov"
        Me.BtnRepoMov.Size = New System.Drawing.Size(388, 50)
        Me.BtnRepoMov.TabIndex = 10
        Me.BtnRepoMov.Text = "Reportes de Movimientos"
        Me.BtnRepoMov.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRepoMov.UseVisualStyleBackColor = True
        '
        'BtnRepoProd
        '
        Me.BtnRepoProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRepoProd.Enabled = False
        Me.BtnRepoProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnRepoProd.FlatAppearance.BorderSize = 0
        Me.BtnRepoProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BtnRepoProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnRepoProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRepoProd.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnRepoProd.ForeColor = System.Drawing.Color.Black
        Me.BtnRepoProd.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.reportesMov
        Me.BtnRepoProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRepoProd.Location = New System.Drawing.Point(3, 3)
        Me.BtnRepoProd.Name = "BtnRepoProd"
        Me.BtnRepoProd.Size = New System.Drawing.Size(388, 50)
        Me.BtnRepoProd.TabIndex = 9
        Me.BtnRepoProd.Text = "Reportes de Productos"
        Me.BtnRepoProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRepoProd.UseVisualStyleBackColor = True
        '
        'LblFecha
        '
        Me.LblFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.Location = New System.Drawing.Point(685, 562)
        Me.LblFecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(110, 21)
        Me.LblFecha.TabIndex = 3
        Me.LblFecha.Text = "dd/MM/yyyy"
        Me.LblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblHora
        '
        Me.LblHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblHora.AutoSize = True
        Me.LblHora.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHora.Location = New System.Drawing.Point(714, 539)
        Me.LblHora.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(50, 21)
        Me.LblHora.TabIndex = 2
        Me.LblHora.Text = "00:00"
        Me.LblHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox3.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.logoNuevo
        Me.PictureBox3.Location = New System.Drawing.Point(211, 23)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(500, 500)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'BtnRptMarcasMinProd
        '
        Me.BtnRptMarcasMinProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRptMarcasMinProd.Enabled = False
        Me.BtnRptMarcasMinProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnRptMarcasMinProd.FlatAppearance.BorderSize = 0
        Me.BtnRptMarcasMinProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BtnRptMarcasMinProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnRptMarcasMinProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRptMarcasMinProd.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnRptMarcasMinProd.ForeColor = System.Drawing.Color.Black
        Me.BtnRptMarcasMinProd.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.reportesMov
        Me.BtnRptMarcasMinProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRptMarcasMinProd.Location = New System.Drawing.Point(3, 185)
        Me.BtnRptMarcasMinProd.Name = "BtnRptMarcasMinProd"
        Me.BtnRptMarcasMinProd.Size = New System.Drawing.Size(388, 50)
        Me.BtnRptMarcasMinProd.TabIndex = 12
        Me.BtnRptMarcasMinProd.Text = "Reportes de Marcas con menos Productos"
        Me.BtnRptMarcasMinProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRptMarcasMinProd.UseVisualStyleBackColor = True
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 640)
        Me.Controls.Add(Me.PanPrincipal)
        Me.Controls.Add(Me.PanMenu)
        Me.Controls.Add(Me.PanSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Inventario La Casa del Arte"
        Me.PanSuperior.ResumeLayout(False)
        Me.PanSuperior.PerformLayout()
        CType(Me.PibMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanMenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PibMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanPrincipal.ResumeLayout(False)
        Me.PanPrincipal.PerformLayout()
        Me.PanReportes.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanSuperior As Panel
    Friend WithEvents PanMenu As Panel
    Friend WithEvents PibMenu As PictureBox
    Friend WithEvents BtnRoles As Button
    Friend WithEvents BtnProductos As Button
    Friend WithEvents BtnCategorias As Button
    Friend WithEvents BtnUsuarios As Button
    Friend WithEvents BtnReportes As Button
    Friend WithEvents BtnMovimientos As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TmrOcultar As Timer
    Friend WithEvents TmrMostrar As Timer
    Friend WithEvents PibMinimizar As PictureBox
    Friend WithEvents PibCerrar As PictureBox
    Friend WithEvents BtnCerrarSesion As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lbl_nombreUser As Label
    Friend WithEvents Lbl_rolUsuario As Label
    Friend WithEvents TmrHoraFecha As Timer
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnMarca As Button
    Friend WithEvents PanPrincipal As Panel
    Friend WithEvents LblFecha As Label
    Friend WithEvents LblHora As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PibMaximizar As PictureBox
    Friend WithEvents PanReportes As Panel
    Friend WithEvents BtnRepoMov As Button
    Friend WithEvents BtnRepoProd As Button
    Friend WithEvents BtnReporteMarcasProd As Button
    Friend WithEvents BtnRptMarcasMinProd As Button
End Class
