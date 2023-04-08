<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProductos))
        Me.PanSuperior = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MzButtonWindows3 = New BWCMM.MZButtonWindows()
        Me.MzButtonWindows2 = New BWCMM.MZButtonWindows()
        Me.MzButtonWindows1 = New BWCMM.MZButtonWindows()
        Me.PanelCentral = New System.Windows.Forms.Panel()
        Me.GobDatosProd = New System.Windows.Forms.GroupBox()
        Me.PibProductos = New System.Windows.Forms.PictureBox()
        Me.TxtStockTotal = New System.Windows.Forms.TextBox()
        Me.TxtStockMax = New System.Windows.Forms.TextBox()
        Me.TxtStockMin = New System.Windows.Forms.TextBox()
        Me.TxtStockBodega = New System.Windows.Forms.TextBox()
        Me.TxtStockTienda = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnAgregarP = New System.Windows.Forms.Button()
        Me.BtnEliminarP = New System.Windows.Forms.Button()
        Me.BtnEditarP = New System.Windows.Forms.Button()
        Me.BtnLimpiarP = New System.Windows.Forms.Button()
        Me.CobCategoria = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtMarcaProd = New System.Windows.Forms.TextBox()
        Me.TxtNombreProd = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtIdProd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanSuperior.SuspendLayout()
        Me.PanelCentral.SuspendLayout()
        Me.GobDatosProd.SuspendLayout()
        CType(Me.PibProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanSuperior
        '
        Me.PanSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanSuperior.Controls.Add(Me.MzButtonWindows3)
        Me.PanSuperior.Controls.Add(Me.MzButtonWindows2)
        Me.PanSuperior.Controls.Add(Me.MzButtonWindows1)
        Me.PanSuperior.Controls.Add(Me.Label8)
        Me.PanSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanSuperior.Margin = New System.Windows.Forms.Padding(4)
        Me.PanSuperior.Name = "PanSuperior"
        Me.PanSuperior.Size = New System.Drawing.Size(1733, 52)
        Me.PanSuperior.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Nirmala UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(715, 6)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(303, 41)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Gestionar Productos"
        '
        'MzButtonWindows3
        '
        Me.MzButtonWindows3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MzButtonWindows3.BackgroundImage = CType(resources.GetObject("MzButtonWindows3.BackgroundImage"), System.Drawing.Image)
        Me.MzButtonWindows3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MzButtonWindows3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MzButtonWindows3.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.MzButtonWindows3.Location = New System.Drawing.Point(1693, 0)
        Me.MzButtonWindows3.Margin = New System.Windows.Forms.Padding(4)
        Me.MzButtonWindows3.Name = "MzButtonWindows3"
        Me.MzButtonWindows3.ParentControl = Me
        Me.MzButtonWindows3.Size = New System.Drawing.Size(40, 24)
        Me.MzButtonWindows3.TabIndex = 3
        Me.MzButtonWindows3.TipoButton = BWCMM.MZButtonWindows.ModeButton.Close
        '
        'MzButtonWindows2
        '
        Me.MzButtonWindows2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MzButtonWindows2.BackgroundImage = CType(resources.GetObject("MzButtonWindows2.BackgroundImage"), System.Drawing.Image)
        Me.MzButtonWindows2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MzButtonWindows2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MzButtonWindows2.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.MzButtonWindows2.Location = New System.Drawing.Point(1613, 0)
        Me.MzButtonWindows2.Margin = New System.Windows.Forms.Padding(4)
        Me.MzButtonWindows2.Name = "MzButtonWindows2"
        Me.MzButtonWindows2.ParentControl = Me
        Me.MzButtonWindows2.Size = New System.Drawing.Size(40, 24)
        Me.MzButtonWindows2.TabIndex = 2
        Me.MzButtonWindows2.TipoButton = BWCMM.MZButtonWindows.ModeButton.Minimize
        '
        'MzButtonWindows1
        '
        Me.MzButtonWindows1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MzButtonWindows1.BackgroundImage = CType(resources.GetObject("MzButtonWindows1.BackgroundImage"), System.Drawing.Image)
        Me.MzButtonWindows1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MzButtonWindows1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MzButtonWindows1.Enabled = False
        Me.MzButtonWindows1.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.MzButtonWindows1.Location = New System.Drawing.Point(1653, 0)
        Me.MzButtonWindows1.Margin = New System.Windows.Forms.Padding(4)
        Me.MzButtonWindows1.Name = "MzButtonWindows1"
        Me.MzButtonWindows1.ParentControl = Me
        Me.MzButtonWindows1.Size = New System.Drawing.Size(40, 24)
        Me.MzButtonWindows1.TabIndex = 1
        Me.MzButtonWindows1.TipoButton = BWCMM.MZButtonWindows.ModeButton.Maximize
        '
        'PanelCentral
        '
        Me.PanelCentral.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PanelCentral.Controls.Add(Me.GobDatosProd)
        Me.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCentral.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelCentral.Location = New System.Drawing.Point(0, 52)
        Me.PanelCentral.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelCentral.Name = "PanelCentral"
        Me.PanelCentral.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.PanelCentral.Size = New System.Drawing.Size(1733, 578)
        Me.PanelCentral.TabIndex = 13
        '
        'GobDatosProd
        '
        Me.GobDatosProd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GobDatosProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GobDatosProd.Controls.Add(Me.PibProductos)
        Me.GobDatosProd.Controls.Add(Me.TxtStockTotal)
        Me.GobDatosProd.Controls.Add(Me.TxtStockMax)
        Me.GobDatosProd.Controls.Add(Me.TxtStockMin)
        Me.GobDatosProd.Controls.Add(Me.TxtStockBodega)
        Me.GobDatosProd.Controls.Add(Me.TxtStockTienda)
        Me.GobDatosProd.Controls.Add(Me.Label11)
        Me.GobDatosProd.Controls.Add(Me.Label10)
        Me.GobDatosProd.Controls.Add(Me.Label9)
        Me.GobDatosProd.Controls.Add(Me.BtnAgregarP)
        Me.GobDatosProd.Controls.Add(Me.BtnEliminarP)
        Me.GobDatosProd.Controls.Add(Me.BtnEditarP)
        Me.GobDatosProd.Controls.Add(Me.BtnLimpiarP)
        Me.GobDatosProd.Controls.Add(Me.CobCategoria)
        Me.GobDatosProd.Controls.Add(Me.Label7)
        Me.GobDatosProd.Controls.Add(Me.TxtDescripcion)
        Me.GobDatosProd.Controls.Add(Me.TxtMarcaProd)
        Me.GobDatosProd.Controls.Add(Me.TxtNombreProd)
        Me.GobDatosProd.Controls.Add(Me.Label6)
        Me.GobDatosProd.Controls.Add(Me.Label5)
        Me.GobDatosProd.Controls.Add(Me.Label4)
        Me.GobDatosProd.Controls.Add(Me.TxtIdProd)
        Me.GobDatosProd.Controls.Add(Me.Label3)
        Me.GobDatosProd.Controls.Add(Me.Label2)
        Me.GobDatosProd.Controls.Add(Me.Label1)
        Me.GobDatosProd.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GobDatosProd.Location = New System.Drawing.Point(40, 48)
        Me.GobDatosProd.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.GobDatosProd.Name = "GobDatosProd"
        Me.GobDatosProd.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GobDatosProd.Size = New System.Drawing.Size(1653, 481)
        Me.GobDatosProd.TabIndex = 5
        Me.GobDatosProd.TabStop = False
        Me.GobDatosProd.Text = "Datos Generales del Producto"
        '
        'PibProductos
        '
        Me.PibProductos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PibProductos.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.lapiz
        Me.PibProductos.Location = New System.Drawing.Point(1288, 91)
        Me.PibProductos.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.PibProductos.Name = "PibProductos"
        Me.PibProductos.Size = New System.Drawing.Size(335, 310)
        Me.PibProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PibProductos.TabIndex = 29
        Me.PibProductos.TabStop = False
        '
        'TxtStockTotal
        '
        Me.TxtStockTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStockTotal.Enabled = False
        Me.TxtStockTotal.Location = New System.Drawing.Point(995, 309)
        Me.TxtStockTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStockTotal.Name = "TxtStockTotal"
        Me.TxtStockTotal.Size = New System.Drawing.Size(109, 34)
        Me.TxtStockTotal.TabIndex = 28
        '
        'TxtStockMax
        '
        Me.TxtStockMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStockMax.Location = New System.Drawing.Point(1145, 246)
        Me.TxtStockMax.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStockMax.Name = "TxtStockMax"
        Me.TxtStockMax.Size = New System.Drawing.Size(109, 34)
        Me.TxtStockMax.TabIndex = 27
        '
        'TxtStockMin
        '
        Me.TxtStockMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStockMin.Location = New System.Drawing.Point(1145, 178)
        Me.TxtStockMin.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStockMin.Name = "TxtStockMin"
        Me.TxtStockMin.Size = New System.Drawing.Size(109, 34)
        Me.TxtStockMin.TabIndex = 26
        '
        'TxtStockBodega
        '
        Me.TxtStockBodega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStockBodega.Location = New System.Drawing.Point(831, 245)
        Me.TxtStockBodega.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStockBodega.Name = "TxtStockBodega"
        Me.TxtStockBodega.Size = New System.Drawing.Size(109, 34)
        Me.TxtStockBodega.TabIndex = 25
        '
        'TxtStockTienda
        '
        Me.TxtStockTienda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStockTienda.Location = New System.Drawing.Point(831, 180)
        Me.TxtStockTienda.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStockTienda.Name = "TxtStockTienda"
        Me.TxtStockTienda.Size = New System.Drawing.Size(109, 34)
        Me.TxtStockTienda.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(873, 311)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 28)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Stock Total:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(992, 251)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 28)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Stock Máximo:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(992, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 28)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Stock Mínimo:"
        '
        'BtnAgregarP
        '
        Me.BtnAgregarP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnAgregarP.FlatAppearance.BorderSize = 0
        Me.BtnAgregarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarP.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarP.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.agregarProd
        Me.BtnAgregarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregarP.Location = New System.Drawing.Point(164, 385)
        Me.BtnAgregarP.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnAgregarP.Name = "BtnAgregarP"
        Me.BtnAgregarP.Size = New System.Drawing.Size(183, 55)
        Me.BtnAgregarP.TabIndex = 20
        Me.BtnAgregarP.Text = "Agregar"
        Me.BtnAgregarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregarP.UseVisualStyleBackColor = True
        '
        'BtnEliminarP
        '
        Me.BtnEliminarP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminarP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnEliminarP.FlatAppearance.BorderSize = 0
        Me.BtnEliminarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarP.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarP.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.eliminarProd
        Me.BtnEliminarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarP.Location = New System.Drawing.Point(891, 385)
        Me.BtnEliminarP.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnEliminarP.Name = "BtnEliminarP"
        Me.BtnEliminarP.Size = New System.Drawing.Size(191, 55)
        Me.BtnEliminarP.TabIndex = 18
        Me.BtnEliminarP.Text = "Eliminar"
        Me.BtnEliminarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminarP.UseVisualStyleBackColor = True
        '
        'BtnEditarP
        '
        Me.BtnEditarP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditarP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnEditarP.FlatAppearance.BorderSize = 0
        Me.BtnEditarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditarP.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditarP.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.editarProd
        Me.BtnEditarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditarP.Location = New System.Drawing.Point(671, 385)
        Me.BtnEditarP.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnEditarP.Name = "BtnEditarP"
        Me.BtnEditarP.Size = New System.Drawing.Size(157, 55)
        Me.BtnEditarP.TabIndex = 17
        Me.BtnEditarP.Text = "Editar"
        Me.BtnEditarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditarP.UseVisualStyleBackColor = True
        '
        'BtnLimpiarP
        '
        Me.BtnLimpiarP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpiarP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnLimpiarP.FlatAppearance.BorderSize = 0
        Me.BtnLimpiarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiarP.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiarP.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.limpiarCampos
        Me.BtnLimpiarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiarP.Location = New System.Drawing.Point(417, 385)
        Me.BtnLimpiarP.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnLimpiarP.Name = "BtnLimpiarP"
        Me.BtnLimpiarP.Size = New System.Drawing.Size(176, 55)
        Me.BtnLimpiarP.TabIndex = 16
        Me.BtnLimpiarP.Text = "Limpiar"
        Me.BtnLimpiarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiarP.UseVisualStyleBackColor = True
        '
        'CobCategoria
        '
        Me.CobCategoria.FormattingEnabled = True
        Me.CobCategoria.Items.AddRange(New Object() {"Manualidades", "Arte", "Escolar", "Profesional"})
        Me.CobCategoria.Location = New System.Drawing.Point(136, 245)
        Me.CobCategoria.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.CobCategoria.Name = "CobCategoria"
        Me.CobCategoria.Size = New System.Drawing.Size(397, 36)
        Me.CobCategoria.TabIndex = 13
        Me.CobCategoria.Text = "Seleccione la categoría..."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(683, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 28)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Stock Bodega:"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescripcion.Location = New System.Drawing.Point(813, 58)
        Me.TxtDescripcion.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDescripcion.Size = New System.Drawing.Size(441, 98)
        Me.TxtDescripcion.TabIndex = 9
        '
        'TxtMarcaProd
        '
        Me.TxtMarcaProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMarcaProd.Location = New System.Drawing.Point(124, 180)
        Me.TxtMarcaProd.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtMarcaProd.Name = "TxtMarcaProd"
        Me.TxtMarcaProd.Size = New System.Drawing.Size(410, 34)
        Me.TxtMarcaProd.TabIndex = 8
        '
        'TxtNombreProd
        '
        Me.TxtNombreProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombreProd.Location = New System.Drawing.Point(124, 118)
        Me.TxtNombreProd.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtNombreProd.Name = "TxtNombreProd"
        Me.TxtNombreProd.Size = New System.Drawing.Size(410, 34)
        Me.TxtNombreProd.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(683, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 28)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Stock Tienda:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(683, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 28)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Descripción:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 28)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Categoría:"
        '
        'TxtIdProd
        '
        Me.TxtIdProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIdProd.Location = New System.Drawing.Point(124, 58)
        Me.TxtIdProd.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtIdProd.Name = "TxtIdProd"
        Me.TxtIdProd.Size = New System.Drawing.Size(410, 34)
        Me.TxtIdProd.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Marca:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'FrmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1733, 630)
        Me.Controls.Add(Me.PanelCentral)
        Me.Controls.Add(Me.PanSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmProductos"
        Me.PanSuperior.ResumeLayout(False)
        Me.PanSuperior.PerformLayout()
        Me.PanelCentral.ResumeLayout(False)
        Me.GobDatosProd.ResumeLayout(False)
        Me.GobDatosProd.PerformLayout()
        CType(Me.PibProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanSuperior As Panel
    Friend WithEvents MzButtonWindows3 As BWCMM.MZButtonWindows
    Friend WithEvents MzButtonWindows2 As BWCMM.MZButtonWindows
    Friend WithEvents MzButtonWindows1 As BWCMM.MZButtonWindows
    Friend WithEvents Label8 As Label
    Friend WithEvents PanelCentral As Panel
    Friend WithEvents GobDatosProd As GroupBox
    Friend WithEvents PibProductos As PictureBox
    Friend WithEvents TxtStockTotal As TextBox
    Friend WithEvents TxtStockMax As TextBox
    Friend WithEvents TxtStockMin As TextBox
    Friend WithEvents TxtStockBodega As TextBox
    Friend WithEvents TxtStockTienda As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnAgregarP As Button
    Friend WithEvents BtnEliminarP As Button
    Friend WithEvents BtnEditarP As Button
    Friend WithEvents BtnLimpiarP As Button
    Friend WithEvents CobCategoria As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents TxtMarcaProd As TextBox
    Friend WithEvents TxtNombreProd As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtIdProd As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
