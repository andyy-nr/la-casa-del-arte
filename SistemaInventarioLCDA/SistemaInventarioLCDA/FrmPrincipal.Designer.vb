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
        Me.BtnPermisos = New System.Windows.Forms.Button()
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
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.LblHora = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PanSuperior.SuspendLayout()
        CType(Me.PibMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PibMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanPrincipal.SuspendLayout()
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
        Me.PanSuperior.Margin = New System.Windows.Forms.Padding(4)
        Me.PanSuperior.Name = "PanSuperior"
        Me.PanSuperior.Size = New System.Drawing.Size(1355, 52)
        Me.PanSuperior.TabIndex = 0
        '
        'PibMaximizar
        '
        Me.PibMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PibMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PibMaximizar.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.btnMaximizar
        Me.PibMaximizar.Location = New System.Drawing.Point(1262, 7)
        Me.PibMaximizar.Name = "PibMaximizar"
        Me.PibMaximizar.Size = New System.Drawing.Size(39, 36)
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
        Me.PibMinimizar.Location = New System.Drawing.Point(1211, 4)
        Me.PibMinimizar.Name = "PibMinimizar"
        Me.PibMinimizar.Size = New System.Drawing.Size(45, 45)
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
        Me.PibCerrar.Location = New System.Drawing.Point(1307, 3)
        Me.PibCerrar.Name = "PibCerrar"
        Me.PibCerrar.Size = New System.Drawing.Size(45, 45)
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
        Me.Label2.Location = New System.Drawing.Point(422, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(510, 37)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sistema de Inventario La Casa del Arte"
        '
        'PanMenu
        '
        Me.PanMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PanMenu.Controls.Add(Me.BtnPermisos)
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
        Me.PanMenu.Location = New System.Drawing.Point(0, 52)
        Me.PanMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.PanMenu.Name = "PanMenu"
        Me.PanMenu.Size = New System.Drawing.Size(293, 848)
        Me.PanMenu.TabIndex = 1
        '
        'BtnPermisos
        '
        Me.BtnPermisos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPermisos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnPermisos.FlatAppearance.BorderSize = 0
        Me.BtnPermisos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BtnPermisos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPermisos.ForeColor = System.Drawing.Color.Black
        Me.BtnPermisos.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.BtnPermiso
        Me.BtnPermisos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPermisos.Location = New System.Drawing.Point(0, 220)
        Me.BtnPermisos.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPermisos.Name = "BtnPermisos"
        Me.BtnPermisos.Size = New System.Drawing.Size(293, 62)
        Me.BtnPermisos.TabIndex = 12
        Me.BtnPermisos.Text = "Permisos"
        Me.BtnPermisos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPermisos.UseVisualStyleBackColor = True
        '
        'BtnMarca
        '
        Me.BtnMarca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMarca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnMarca.FlatAppearance.BorderSize = 0
        Me.BtnMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BtnMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMarca.ForeColor = System.Drawing.Color.Black
        Me.BtnMarca.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.BtnMarcas
        Me.BtnMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMarca.Location = New System.Drawing.Point(0, 427)
        Me.BtnMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnMarca.Name = "BtnMarca"
        Me.BtnMarca.Size = New System.Drawing.Size(293, 62)
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
        Me.BtnCerrarSesion.Location = New System.Drawing.Point(0, 787)
        Me.BtnCerrarSesion.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCerrarSesion.Name = "BtnCerrarSesion"
        Me.BtnCerrarSesion.Size = New System.Drawing.Size(293, 62)
        Me.BtnCerrarSesion.TabIndex = 9
        Me.BtnCerrarSesion.Text = "Cerrar Sesión"
        Me.BtnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCerrarSesion.UseVisualStyleBackColor = False
        '
        'BtnReportes
        '
        Me.BtnReportes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReportes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnReportes.FlatAppearance.BorderSize = 0
        Me.BtnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BtnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReportes.ForeColor = System.Drawing.Color.Black
        Me.BtnReportes.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.reportesMov
        Me.BtnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReportes.Location = New System.Drawing.Point(0, 708)
        Me.BtnReportes.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnReportes.Name = "BtnReportes"
        Me.BtnReportes.Size = New System.Drawing.Size(293, 62)
        Me.BtnReportes.TabIndex = 8
        Me.BtnReportes.Text = "Reportes"
        Me.BtnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnReportes.UseVisualStyleBackColor = True
        '
        'BtnMovimientos
        '
        Me.BtnMovimientos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMovimientos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnMovimientos.FlatAppearance.BorderSize = 0
        Me.BtnMovimientos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BtnMovimientos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMovimientos.ForeColor = System.Drawing.Color.Black
        Me.BtnMovimientos.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.movimientos
        Me.BtnMovimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMovimientos.Location = New System.Drawing.Point(0, 639)
        Me.BtnMovimientos.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnMovimientos.Name = "BtnMovimientos"
        Me.BtnMovimientos.Size = New System.Drawing.Size(293, 62)
        Me.BtnMovimientos.TabIndex = 7
        Me.BtnMovimientos.Text = "Movimientos"
        Me.BtnMovimientos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnMovimientos.UseVisualStyleBackColor = True
        '
        'BtnProductos
        '
        Me.BtnProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProductos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnProductos.FlatAppearance.BorderSize = 0
        Me.BtnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BtnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProductos.ForeColor = System.Drawing.Color.Black
        Me.BtnProductos.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.productosman
        Me.BtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProductos.Location = New System.Drawing.Point(0, 570)
        Me.BtnProductos.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnProductos.Name = "BtnProductos"
        Me.BtnProductos.Size = New System.Drawing.Size(293, 62)
        Me.BtnProductos.TabIndex = 6
        Me.BtnProductos.Text = "Productos"
        Me.BtnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnProductos.UseVisualStyleBackColor = True
        '
        'BtnCategorias
        '
        Me.BtnCategorias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCategorias.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnCategorias.FlatAppearance.BorderSize = 0
        Me.BtnCategorias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BtnCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCategorias.ForeColor = System.Drawing.Color.Black
        Me.BtnCategorias.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.categoriaprod
        Me.BtnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCategorias.Location = New System.Drawing.Point(0, 501)
        Me.BtnCategorias.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCategorias.Name = "BtnCategorias"
        Me.BtnCategorias.Size = New System.Drawing.Size(293, 62)
        Me.BtnCategorias.TabIndex = 5
        Me.BtnCategorias.Text = "Categorías"
        Me.BtnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCategorias.UseVisualStyleBackColor = True
        '
        'BtnUsuarios
        '
        Me.BtnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnUsuarios.FlatAppearance.BorderSize = 0
        Me.BtnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BtnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUsuarios.ForeColor = System.Drawing.Color.Black
        Me.BtnUsuarios.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.usuarios
        Me.BtnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUsuarios.Location = New System.Drawing.Point(0, 359)
        Me.BtnUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnUsuarios.Name = "BtnUsuarios"
        Me.BtnUsuarios.Size = New System.Drawing.Size(293, 62)
        Me.BtnUsuarios.TabIndex = 4
        Me.BtnUsuarios.Text = "Usuarios"
        Me.BtnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUsuarios.UseVisualStyleBackColor = True
        '
        'BtnRoles
        '
        Me.BtnRoles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRoles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnRoles.FlatAppearance.BorderSize = 0
        Me.BtnRoles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BtnRoles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRoles.ForeColor = System.Drawing.Color.Black
        Me.BtnRoles.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.admin
        Me.BtnRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRoles.Location = New System.Drawing.Point(0, 290)
        Me.BtnRoles.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRoles.Name = "BtnRoles"
        Me.BtnRoles.Size = New System.Drawing.Size(293, 62)
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
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(293, 177)
        Me.Panel1.TabIndex = 10
        '
        'Lbl_nombreUser
        '
        Me.Lbl_nombreUser.AutoSize = True
        Me.Lbl_nombreUser.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_nombreUser.Location = New System.Drawing.Point(85, 121)
        Me.Lbl_nombreUser.Name = "Lbl_nombreUser"
        Me.Lbl_nombreUser.Size = New System.Drawing.Size(187, 23)
        Me.Lbl_nombreUser.TabIndex = 3
        Me.Lbl_nombreUser.Text = "*Nombre del Usuario*"
        '
        'Lbl_rolUsuario
        '
        Me.Lbl_rolUsuario.AutoSize = True
        Me.Lbl_rolUsuario.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_rolUsuario.Location = New System.Drawing.Point(85, 84)
        Me.Lbl_rolUsuario.Name = "Lbl_rolUsuario"
        Me.Lbl_rolUsuario.Size = New System.Drawing.Size(147, 23)
        Me.Lbl_rolUsuario.TabIndex = 2
        Me.Lbl_rolUsuario.Text = "*Rol del Usuario*"
        '
        'PibMenu
        '
        Me.PibMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PibMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PibMenu.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.menu
        Me.PibMenu.Location = New System.Drawing.Point(227, 8)
        Me.PibMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.PibMenu.Name = "PibMenu"
        Me.PibMenu.Size = New System.Drawing.Size(55, 55)
        Me.PibMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PibMenu.TabIndex = 0
        Me.PibMenu.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.usuario_de_perfil1
        Me.PictureBox2.Location = New System.Drawing.Point(3, 84)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 70)
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
        Me.PanPrincipal.Controls.Add(Me.LblFecha)
        Me.PanPrincipal.Controls.Add(Me.LblHora)
        Me.PanPrincipal.Controls.Add(Me.PictureBox3)
        Me.PanPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanPrincipal.Location = New System.Drawing.Point(293, 52)
        Me.PanPrincipal.Margin = New System.Windows.Forms.Padding(4)
        Me.PanPrincipal.Name = "PanPrincipal"
        Me.PanPrincipal.Size = New System.Drawing.Size(1062, 848)
        Me.PanPrincipal.TabIndex = 7
        '
        'LblFecha
        '
        Me.LblFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.Location = New System.Drawing.Point(944, 809)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(106, 23)
        Me.LblFecha.TabIndex = 3
        Me.LblFecha.Text = "dd/MM/yyyy"
        '
        'LblHora
        '
        Me.LblHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblHora.AutoSize = True
        Me.LblHora.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHora.Location = New System.Drawing.Point(972, 784)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(50, 23)
        Me.LblHora.TabIndex = 2
        Me.LblHora.Text = "00:00"
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox3.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.logoNuevo
        Me.PictureBox3.Location = New System.Drawing.Point(281, 84)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(500, 500)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1355, 900)
        Me.Controls.Add(Me.PanPrincipal)
        Me.Controls.Add(Me.PanMenu)
        Me.Controls.Add(Me.PanSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
    Friend WithEvents BtnPermisos As Button
    Friend WithEvents PibMaximizar As PictureBox
End Class
