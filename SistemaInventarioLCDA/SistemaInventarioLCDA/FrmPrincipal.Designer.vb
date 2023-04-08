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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.PanSuperior = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MzButtonWindows3 = New BWCMM.MZButtonWindows()
        Me.MzButtonWindows2 = New BWCMM.MZButtonWindows()
        Me.MzButtonWindows1 = New BWCMM.MZButtonWindows()
        Me.PanMenu = New System.Windows.Forms.Panel()
        Me.BtnReportes = New System.Windows.Forms.Button()
        Me.BtnMovimientos = New System.Windows.Forms.Button()
        Me.BtnProductos = New System.Windows.Forms.Button()
        Me.BtnCategorias = New System.Windows.Forms.Button()
        Me.BtnUsuarios = New System.Windows.Forms.Button()
        Me.BtnRoles = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PibMenu = New System.Windows.Forms.PictureBox()
        Me.PanMovimientos = New System.Windows.Forms.Panel()
        Me.BtnSalidas = New System.Windows.Forms.Button()
        Me.BtnEntradas = New System.Windows.Forms.Button()
        Me.PanPrincipal = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TmrOcultar = New System.Windows.Forms.Timer(Me.components)
        Me.TmrMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.PanSuperior.SuspendLayout()
        Me.PanMenu.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanMovimientos.SuspendLayout()
        Me.PanPrincipal.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanSuperior
        '
        Me.PanSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanSuperior.Controls.Add(Me.Label2)
        Me.PanSuperior.Controls.Add(Me.MzButtonWindows3)
        Me.PanSuperior.Controls.Add(Me.MzButtonWindows2)
        Me.PanSuperior.Controls.Add(Me.MzButtonWindows1)
        Me.PanSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanSuperior.Margin = New System.Windows.Forms.Padding(4)
        Me.PanSuperior.Name = "PanSuperior"
        Me.PanSuperior.Size = New System.Drawing.Size(1243, 52)
        Me.PanSuperior.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(363, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(510, 37)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sistema de Inventario La Casa del Arte"
        '
        'MzButtonWindows3
        '
        Me.MzButtonWindows3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MzButtonWindows3.BackgroundImage = CType(resources.GetObject("MzButtonWindows3.BackgroundImage"), System.Drawing.Image)
        Me.MzButtonWindows3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MzButtonWindows3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MzButtonWindows3.Enabled = False
        Me.MzButtonWindows3.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.MzButtonWindows3.Location = New System.Drawing.Point(1163, 0)
        Me.MzButtonWindows3.Margin = New System.Windows.Forms.Padding(4)
        Me.MzButtonWindows3.Name = "MzButtonWindows3"
        Me.MzButtonWindows3.ParentControl = Me
        Me.MzButtonWindows3.Size = New System.Drawing.Size(40, 24)
        Me.MzButtonWindows3.TabIndex = 2
        Me.MzButtonWindows3.TipoButton = BWCMM.MZButtonWindows.ModeButton.Maximize
        '
        'MzButtonWindows2
        '
        Me.MzButtonWindows2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MzButtonWindows2.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MzButtonWindows2.BackgroundImage = CType(resources.GetObject("MzButtonWindows2.BackgroundImage"), System.Drawing.Image)
        Me.MzButtonWindows2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MzButtonWindows2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MzButtonWindows2.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.MzButtonWindows2.Location = New System.Drawing.Point(1123, 0)
        Me.MzButtonWindows2.Margin = New System.Windows.Forms.Padding(4)
        Me.MzButtonWindows2.Name = "MzButtonWindows2"
        Me.MzButtonWindows2.ParentControl = Me
        Me.MzButtonWindows2.Size = New System.Drawing.Size(40, 24)
        Me.MzButtonWindows2.TabIndex = 1
        Me.MzButtonWindows2.TipoButton = BWCMM.MZButtonWindows.ModeButton.Minimize
        '
        'MzButtonWindows1
        '
        Me.MzButtonWindows1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MzButtonWindows1.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MzButtonWindows1.BackgroundImage = CType(resources.GetObject("MzButtonWindows1.BackgroundImage"), System.Drawing.Image)
        Me.MzButtonWindows1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MzButtonWindows1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MzButtonWindows1.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.MzButtonWindows1.Location = New System.Drawing.Point(1203, 0)
        Me.MzButtonWindows1.Margin = New System.Windows.Forms.Padding(4)
        Me.MzButtonWindows1.Name = "MzButtonWindows1"
        Me.MzButtonWindows1.ParentControl = Me
        Me.MzButtonWindows1.Size = New System.Drawing.Size(40, 24)
        Me.MzButtonWindows1.TabIndex = 0
        Me.MzButtonWindows1.TipoButton = BWCMM.MZButtonWindows.ModeButton.Close
        '
        'PanMenu
        '
        Me.PanMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PanMenu.Controls.Add(Me.BtnReportes)
        Me.PanMenu.Controls.Add(Me.BtnMovimientos)
        Me.PanMenu.Controls.Add(Me.BtnProductos)
        Me.PanMenu.Controls.Add(Me.BtnCategorias)
        Me.PanMenu.Controls.Add(Me.BtnUsuarios)
        Me.PanMenu.Controls.Add(Me.BtnRoles)
        Me.PanMenu.Controls.Add(Me.Label1)
        Me.PanMenu.Controls.Add(Me.PictureBox2)
        Me.PanMenu.Controls.Add(Me.PibMenu)
        Me.PanMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanMenu.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanMenu.ForeColor = System.Drawing.Color.Black
        Me.PanMenu.Location = New System.Drawing.Point(0, 52)
        Me.PanMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.PanMenu.Name = "PanMenu"
        Me.PanMenu.Size = New System.Drawing.Size(293, 613)
        Me.PanMenu.TabIndex = 1
        '
        'BtnReportes
        '
        Me.BtnReportes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReportes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnReportes.FlatAppearance.BorderSize = 2
        Me.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReportes.ForeColor = System.Drawing.Color.Black
        Me.BtnReportes.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.reportesMov
        Me.BtnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReportes.Location = New System.Drawing.Point(0, 510)
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
        Me.BtnMovimientos.FlatAppearance.BorderSize = 2
        Me.BtnMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMovimientos.ForeColor = System.Drawing.Color.Black
        Me.BtnMovimientos.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.movimientos
        Me.BtnMovimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMovimientos.Location = New System.Drawing.Point(0, 441)
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
        Me.BtnProductos.FlatAppearance.BorderSize = 2
        Me.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProductos.ForeColor = System.Drawing.Color.Black
        Me.BtnProductos.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.productosman
        Me.BtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProductos.Location = New System.Drawing.Point(0, 372)
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
        Me.BtnCategorias.FlatAppearance.BorderSize = 2
        Me.BtnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCategorias.ForeColor = System.Drawing.Color.Black
        Me.BtnCategorias.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.categoriaprod
        Me.BtnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCategorias.Location = New System.Drawing.Point(0, 303)
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
        Me.BtnUsuarios.FlatAppearance.BorderSize = 2
        Me.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUsuarios.ForeColor = System.Drawing.Color.Black
        Me.BtnUsuarios.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.usuarios
        Me.BtnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUsuarios.Location = New System.Drawing.Point(0, 234)
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
        Me.BtnRoles.FlatAppearance.BorderSize = 2
        Me.BtnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRoles.ForeColor = System.Drawing.Color.Black
        Me.BtnRoles.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.admin
        Me.BtnRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRoles.Location = New System.Drawing.Point(0, 165)
        Me.BtnRoles.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRoles.Name = "BtnRoles"
        Me.BtnRoles.Size = New System.Drawing.Size(293, 62)
        Me.BtnRoles.TabIndex = 3
        Me.BtnRoles.Text = "Roles"
        Me.BtnRoles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRoles.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(136, 94)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Inicio"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.boton_de_inicio
        Me.PictureBox2.Location = New System.Drawing.Point(0, 73)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 74)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PibMenu
        '
        Me.PibMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PibMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PibMenu.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.menu
        Me.PibMenu.Location = New System.Drawing.Point(219, 7)
        Me.PibMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.PibMenu.Name = "PibMenu"
        Me.PibMenu.Size = New System.Drawing.Size(67, 62)
        Me.PibMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PibMenu.TabIndex = 0
        Me.PibMenu.TabStop = False
        '
        'PanMovimientos
        '
        Me.PanMovimientos.Controls.Add(Me.BtnSalidas)
        Me.PanMovimientos.Controls.Add(Me.BtnEntradas)
        Me.PanMovimientos.Location = New System.Drawing.Point(8, 407)
        Me.PanMovimientos.Margin = New System.Windows.Forms.Padding(4)
        Me.PanMovimientos.Name = "PanMovimientos"
        Me.PanMovimientos.Size = New System.Drawing.Size(293, 130)
        Me.PanMovimientos.TabIndex = 1
        Me.PanMovimientos.Visible = False
        '
        'BtnSalidas
        '
        Me.BtnSalidas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalidas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnSalidas.FlatAppearance.BorderSize = 2
        Me.BtnSalidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalidas.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalidas.ForeColor = System.Drawing.Color.Black
        Me.BtnSalidas.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.movimientos
        Me.BtnSalidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalidas.Location = New System.Drawing.Point(0, 69)
        Me.BtnSalidas.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalidas.Name = "BtnSalidas"
        Me.BtnSalidas.Size = New System.Drawing.Size(293, 62)
        Me.BtnSalidas.TabIndex = 9
        Me.BtnSalidas.Text = "Salidas"
        Me.BtnSalidas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalidas.UseVisualStyleBackColor = True
        '
        'BtnEntradas
        '
        Me.BtnEntradas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEntradas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnEntradas.FlatAppearance.BorderSize = 2
        Me.BtnEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEntradas.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEntradas.ForeColor = System.Drawing.Color.Black
        Me.BtnEntradas.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.movimientos
        Me.BtnEntradas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEntradas.Location = New System.Drawing.Point(0, 0)
        Me.BtnEntradas.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEntradas.Name = "BtnEntradas"
        Me.BtnEntradas.Size = New System.Drawing.Size(293, 62)
        Me.BtnEntradas.TabIndex = 8
        Me.BtnEntradas.Text = "Entradas"
        Me.BtnEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEntradas.UseVisualStyleBackColor = True
        '
        'PanPrincipal
        '
        Me.PanPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.PanPrincipal.Controls.Add(Me.PanMovimientos)
        Me.PanPrincipal.Controls.Add(Me.PictureBox3)
        Me.PanPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanPrincipal.Location = New System.Drawing.Point(293, 52)
        Me.PanPrincipal.Margin = New System.Windows.Forms.Padding(4)
        Me.PanPrincipal.Name = "PanPrincipal"
        Me.PanPrincipal.Size = New System.Drawing.Size(950, 613)
        Me.PanPrincipal.TabIndex = 3
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox3.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.logoNuevo
        Me.PictureBox3.Location = New System.Drawing.Point(144, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(500, 500)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'TmrOcultar
        '
        '
        'TmrMostrar
        '
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 665)
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
        Me.PanMenu.ResumeLayout(False)
        Me.PanMenu.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanMovimientos.ResumeLayout(False)
        Me.PanPrincipal.ResumeLayout(False)
        Me.PanPrincipal.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanSuperior As Panel
    Friend WithEvents PanMenu As Panel
    Friend WithEvents PibMenu As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnRoles As Button
    Friend WithEvents BtnProductos As Button
    Friend WithEvents BtnCategorias As Button
    Friend WithEvents BtnUsuarios As Button
    Friend WithEvents BtnReportes As Button
    Friend WithEvents BtnMovimientos As Button
    Friend WithEvents MzButtonWindows2 As BWCMM.MZButtonWindows
    Friend WithEvents MzButtonWindows1 As BWCMM.MZButtonWindows
    Friend WithEvents MzButtonWindows3 As BWCMM.MZButtonWindows
    Friend WithEvents Label2 As Label
    Friend WithEvents PanPrincipal As Panel
    Friend WithEvents PanMovimientos As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TmrOcultar As Timer
    Friend WithEvents TmrMostrar As Timer
    Friend WithEvents BtnSalidas As Button
    Friend WithEvents BtnEntradas As Button
End Class
