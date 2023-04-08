<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEntradas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEntradas))
        Me.PanCentral = New System.Windows.Forms.Panel()
        Me.GobEntrada = New System.Windows.Forms.GroupBox()
        Me.DtpFechaE = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnEliminarE = New System.Windows.Forms.Button()
        Me.BtnEditarE = New System.Windows.Forms.Button()
        Me.BtnLimpiarE = New System.Windows.Forms.Button()
        Me.BtnAgregarE = New System.Windows.Forms.Button()
        Me.TxtStockTotal = New System.Windows.Forms.TextBox()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.TxtStockTienda = New System.Windows.Forms.TextBox()
        Me.TxtStockBodega = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.TxtCategoria = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CobProductos = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanSuperiorE = New System.Windows.Forms.Panel()
        Me.MzButtonWindows3 = New BWCMM.MZButtonWindows()
        Me.MzButtonWindows1 = New BWCMM.MZButtonWindows()
        Me.MzButtonWindows2 = New BWCMM.MZButtonWindows()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanCentral.SuspendLayout()
        Me.GobEntrada.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanSuperiorE.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanCentral
        '
        Me.PanCentral.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PanCentral.Controls.Add(Me.GobEntrada)
        Me.PanCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanCentral.Location = New System.Drawing.Point(0, 54)
        Me.PanCentral.Name = "PanCentral"
        Me.PanCentral.Size = New System.Drawing.Size(1733, 506)
        Me.PanCentral.TabIndex = 5
        '
        'GobEntrada
        '
        Me.GobEntrada.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GobEntrada.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GobEntrada.Controls.Add(Me.DtpFechaE)
        Me.GobEntrada.Controls.Add(Me.PictureBox1)
        Me.GobEntrada.Controls.Add(Me.BtnEliminarE)
        Me.GobEntrada.Controls.Add(Me.BtnEditarE)
        Me.GobEntrada.Controls.Add(Me.BtnLimpiarE)
        Me.GobEntrada.Controls.Add(Me.BtnAgregarE)
        Me.GobEntrada.Controls.Add(Me.TxtStockTotal)
        Me.GobEntrada.Controls.Add(Me.TxtCantidad)
        Me.GobEntrada.Controls.Add(Me.TxtStockTienda)
        Me.GobEntrada.Controls.Add(Me.TxtStockBodega)
        Me.GobEntrada.Controls.Add(Me.TxtDescripcion)
        Me.GobEntrada.Controls.Add(Me.TxtMarca)
        Me.GobEntrada.Controls.Add(Me.TxtCategoria)
        Me.GobEntrada.Controls.Add(Me.Label10)
        Me.GobEntrada.Controls.Add(Me.Label8)
        Me.GobEntrada.Controls.Add(Me.Label7)
        Me.GobEntrada.Controls.Add(Me.Label9)
        Me.GobEntrada.Controls.Add(Me.CobProductos)
        Me.GobEntrada.Controls.Add(Me.Label6)
        Me.GobEntrada.Controls.Add(Me.Label5)
        Me.GobEntrada.Controls.Add(Me.Label4)
        Me.GobEntrada.Controls.Add(Me.Label3)
        Me.GobEntrada.Controls.Add(Me.Label2)
        Me.GobEntrada.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GobEntrada.Location = New System.Drawing.Point(42, 39)
        Me.GobEntrada.Name = "GobEntrada"
        Me.GobEntrada.Size = New System.Drawing.Size(1653, 423)
        Me.GobEntrada.TabIndex = 0
        Me.GobEntrada.TabStop = False
        Me.GobEntrada.Text = "Datos Generales de Entrada"
        '
        'DtpFechaE
        '
        Me.DtpFechaE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaE.Location = New System.Drawing.Point(192, 231)
        Me.DtpFechaE.Name = "DtpFechaE"
        Me.DtpFechaE.Size = New System.Drawing.Size(249, 34)
        Me.DtpFechaE.TabIndex = 26
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgEntrada
        Me.PictureBox1.Location = New System.Drawing.Point(1276, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(335, 310)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'BtnEliminarE
        '
        Me.BtnEliminarE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminarE.FlatAppearance.BorderSize = 0
        Me.BtnEliminarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarE.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarE.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.eliminarProd
        Me.BtnEliminarE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarE.Location = New System.Drawing.Point(669, 335)
        Me.BtnEliminarE.Name = "BtnEliminarE"
        Me.BtnEliminarE.Size = New System.Drawing.Size(191, 55)
        Me.BtnEliminarE.TabIndex = 24
        Me.BtnEliminarE.Text = "Eliminar"
        Me.BtnEliminarE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminarE.UseVisualStyleBackColor = True
        '
        'BtnEditarE
        '
        Me.BtnEditarE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditarE.FlatAppearance.BorderSize = 0
        Me.BtnEditarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditarE.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditarE.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.editarProd
        Me.BtnEditarE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditarE.Location = New System.Drawing.Point(475, 335)
        Me.BtnEditarE.Name = "BtnEditarE"
        Me.BtnEditarE.Size = New System.Drawing.Size(157, 55)
        Me.BtnEditarE.TabIndex = 23
        Me.BtnEditarE.Text = "Editar"
        Me.BtnEditarE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditarE.UseVisualStyleBackColor = True
        '
        'BtnLimpiarE
        '
        Me.BtnLimpiarE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpiarE.FlatAppearance.BorderSize = 0
        Me.BtnLimpiarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiarE.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiarE.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.limpiarCampos
        Me.BtnLimpiarE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiarE.Location = New System.Drawing.Point(257, 335)
        Me.BtnLimpiarE.Name = "BtnLimpiarE"
        Me.BtnLimpiarE.Size = New System.Drawing.Size(176, 55)
        Me.BtnLimpiarE.TabIndex = 22
        Me.BtnLimpiarE.Text = "Limpiar"
        Me.BtnLimpiarE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiarE.UseVisualStyleBackColor = True
        '
        'BtnAgregarE
        '
        Me.BtnAgregarE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarE.FlatAppearance.BorderSize = 0
        Me.BtnAgregarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarE.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarE.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.agregarProd
        Me.BtnAgregarE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregarE.Location = New System.Drawing.Point(30, 335)
        Me.BtnAgregarE.Name = "BtnAgregarE"
        Me.BtnAgregarE.Size = New System.Drawing.Size(183, 55)
        Me.BtnAgregarE.TabIndex = 21
        Me.BtnAgregarE.Text = "Agregar"
        Me.BtnAgregarE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregarE.UseVisualStyleBackColor = True
        '
        'TxtStockTotal
        '
        Me.TxtStockTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStockTotal.Enabled = False
        Me.TxtStockTotal.Location = New System.Drawing.Point(1096, 229)
        Me.TxtStockTotal.Name = "TxtStockTotal"
        Me.TxtStockTotal.Size = New System.Drawing.Size(112, 34)
        Me.TxtStockTotal.TabIndex = 20
        '
        'TxtCantidad
        '
        Me.TxtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCantidad.Location = New System.Drawing.Point(809, 175)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(112, 34)
        Me.TxtCantidad.TabIndex = 19
        '
        'TxtStockTienda
        '
        Me.TxtStockTienda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStockTienda.Enabled = False
        Me.TxtStockTienda.Location = New System.Drawing.Point(1096, 177)
        Me.TxtStockTienda.Name = "TxtStockTienda"
        Me.TxtStockTienda.Size = New System.Drawing.Size(112, 34)
        Me.TxtStockTienda.TabIndex = 18
        '
        'TxtStockBodega
        '
        Me.TxtStockBodega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStockBodega.Enabled = False
        Me.TxtStockBodega.Location = New System.Drawing.Point(809, 229)
        Me.TxtStockBodega.Name = "TxtStockBodega"
        Me.TxtStockBodega.Size = New System.Drawing.Size(112, 34)
        Me.TxtStockBodega.TabIndex = 17
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescripcion.Enabled = False
        Me.TxtDescripcion.Location = New System.Drawing.Point(776, 53)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDescripcion.Size = New System.Drawing.Size(441, 98)
        Me.TxtDescripcion.TabIndex = 16
        '
        'TxtMarca
        '
        Me.TxtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMarca.Enabled = False
        Me.TxtMarca.Location = New System.Drawing.Point(104, 117)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(337, 34)
        Me.TxtMarca.TabIndex = 14
        '
        'TxtCategoria
        '
        Me.TxtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCategoria.Enabled = False
        Me.TxtCategoria.Location = New System.Drawing.Point(133, 175)
        Me.TxtCategoria.Name = "TxtCategoria"
        Me.TxtCategoria.Size = New System.Drawing.Size(308, 34)
        Me.TxtCategoria.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(937, 231)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 28)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Stock Total:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(637, 231)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 28)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Stock en Bodega:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(937, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 28)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Stock en Tienda:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 231)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(165, 28)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Fecha de Entrada:"
        '
        'CobProductos
        '
        Me.CobProductos.FormattingEnabled = True
        Me.CobProductos.Location = New System.Drawing.Point(137, 61)
        Me.CobProductos.Name = "CobProductos"
        Me.CobProductos.Size = New System.Drawing.Size(304, 36)
        Me.CobProductos.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 28)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Marca:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(637, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 28)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Cantidad Entrada:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(637, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 28)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Descripción:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 28)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Categoria :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Productos :"
        '
        'PanSuperiorE
        '
        Me.PanSuperiorE.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanSuperiorE.Controls.Add(Me.MzButtonWindows3)
        Me.PanSuperiorE.Controls.Add(Me.MzButtonWindows1)
        Me.PanSuperiorE.Controls.Add(Me.MzButtonWindows2)
        Me.PanSuperiorE.Controls.Add(Me.Label1)
        Me.PanSuperiorE.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSuperiorE.Location = New System.Drawing.Point(0, 0)
        Me.PanSuperiorE.Name = "PanSuperiorE"
        Me.PanSuperiorE.Size = New System.Drawing.Size(1733, 54)
        Me.PanSuperiorE.TabIndex = 4
        '
        'MzButtonWindows3
        '
        Me.MzButtonWindows3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MzButtonWindows3.BackgroundImage = CType(resources.GetObject("MzButtonWindows3.BackgroundImage"), System.Drawing.Image)
        Me.MzButtonWindows3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MzButtonWindows3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MzButtonWindows3.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.MzButtonWindows3.Location = New System.Drawing.Point(1613, 0)
        Me.MzButtonWindows3.Name = "MzButtonWindows3"
        Me.MzButtonWindows3.ParentControl = Me
        Me.MzButtonWindows3.Size = New System.Drawing.Size(40, 24)
        Me.MzButtonWindows3.TabIndex = 22
        Me.MzButtonWindows3.TipoButton = BWCMM.MZButtonWindows.ModeButton.Minimize
        '
        'MzButtonWindows1
        '
        Me.MzButtonWindows1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MzButtonWindows1.BackgroundImage = CType(resources.GetObject("MzButtonWindows1.BackgroundImage"), System.Drawing.Image)
        Me.MzButtonWindows1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MzButtonWindows1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MzButtonWindows1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MzButtonWindows1.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.MzButtonWindows1.Location = New System.Drawing.Point(1693, 0)
        Me.MzButtonWindows1.Name = "MzButtonWindows1"
        Me.MzButtonWindows1.ParentControl = Me
        Me.MzButtonWindows1.Size = New System.Drawing.Size(40, 24)
        Me.MzButtonWindows1.TabIndex = 21
        Me.MzButtonWindows1.TipoButton = BWCMM.MZButtonWindows.ModeButton.Close
        '
        'MzButtonWindows2
        '
        Me.MzButtonWindows2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MzButtonWindows2.BackgroundImage = CType(resources.GetObject("MzButtonWindows2.BackgroundImage"), System.Drawing.Image)
        Me.MzButtonWindows2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MzButtonWindows2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MzButtonWindows2.Enabled = False
        Me.MzButtonWindows2.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.MzButtonWindows2.Location = New System.Drawing.Point(1653, 0)
        Me.MzButtonWindows2.Name = "MzButtonWindows2"
        Me.MzButtonWindows2.ParentControl = Me
        Me.MzButtonWindows2.Size = New System.Drawing.Size(40, 24)
        Me.MzButtonWindows2.TabIndex = 21
        Me.MzButtonWindows2.TipoButton = BWCMM.MZButtonWindows.ModeButton.Maximize
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(725, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Gestionar Entradas"
        '
        'FrmEntradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1733, 560)
        Me.Controls.Add(Me.PanCentral)
        Me.Controls.Add(Me.PanSuperiorE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEntradas"
        Me.PanCentral.ResumeLayout(False)
        Me.GobEntrada.ResumeLayout(False)
        Me.GobEntrada.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanSuperiorE.ResumeLayout(False)
        Me.PanSuperiorE.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanCentral As Panel
    Friend WithEvents GobEntrada As GroupBox
    Friend WithEvents TxtStockTotal As TextBox
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents TxtStockTienda As TextBox
    Friend WithEvents TxtStockBodega As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents TxtMarca As TextBox
    Friend WithEvents TxtCategoria As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CobProductos As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PanSuperiorE As Panel
    Friend WithEvents MzButtonWindows3 As BWCMM.MZButtonWindows
    Friend WithEvents MzButtonWindows1 As BWCMM.MZButtonWindows
    Friend WithEvents MzButtonWindows2 As BWCMM.MZButtonWindows
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEliminarE As Button
    Friend WithEvents BtnEditarE As Button
    Friend WithEvents BtnLimpiarE As Button
    Friend WithEvents BtnAgregarE As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DtpFechaE As DateTimePicker
End Class
