<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSalidas
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GobDatosProdS = New System.Windows.Forms.GroupBox()
        Me.DtpFechaSalida = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PibProductos = New System.Windows.Forms.PictureBox()
        Me.TxtStockTotal = New System.Windows.Forms.TextBox()
        Me.TxtCantidadS = New System.Windows.Forms.TextBox()
        Me.TxtStockBodega = New System.Windows.Forms.TextBox()
        Me.TxtStockTienda = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnAgregarS = New System.Windows.Forms.Button()
        Me.BtnLimpiarS = New System.Windows.Forms.Button()
        Me.CobProductosS = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtDescripcionS = New System.Windows.Forms.TextBox()
        Me.TxtMarcaS = New System.Windows.Forms.TextBox()
        Me.TxtNombreS = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCategoriaS = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanSuperior.SuspendLayout()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCentral.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GobDatosProdS.SuspendLayout()
        CType(Me.PibProductos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanSuperior.Margin = New System.Windows.Forms.Padding(4)
        Me.PanSuperior.Name = "PanSuperior"
        Me.PanSuperior.Size = New System.Drawing.Size(1733, 52)
        Me.PanSuperior.TabIndex = 2
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
        Me.Label8.Location = New System.Drawing.Point(736, 6)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(260, 41)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Gestionar Salidas"
        '
        'PanelCentral
        '
        Me.PanelCentral.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PanelCentral.Controls.Add(Me.DataGridView1)
        Me.PanelCentral.Controls.Add(Me.PictureBox1)
        Me.PanelCentral.Controls.Add(Me.TxtBuscar)
        Me.PanelCentral.Controls.Add(Me.Label12)
        Me.PanelCentral.Controls.Add(Me.GobDatosProdS)
        Me.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCentral.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelCentral.Location = New System.Drawing.Point(0, 52)
        Me.PanelCentral.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelCentral.Name = "PanelCentral"
        Me.PanelCentral.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.PanelCentral.Size = New System.Drawing.Size(1733, 808)
        Me.PanelCentral.TabIndex = 17
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(41, 569)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1653, 210)
        Me.DataGridView1.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.lupa
        Me.PictureBox1.Location = New System.Drawing.Point(41, 490)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBuscar.Location = New System.Drawing.Point(181, 499)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(1513, 34)
        Me.TxtBuscar.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(102, 499)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 28)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Buscar:"
        '
        'GobDatosProdS
        '
        Me.GobDatosProdS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GobDatosProdS.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GobDatosProdS.Controls.Add(Me.DtpFechaSalida)
        Me.GobDatosProdS.Controls.Add(Me.Label11)
        Me.GobDatosProdS.Controls.Add(Me.PibProductos)
        Me.GobDatosProdS.Controls.Add(Me.TxtStockTotal)
        Me.GobDatosProdS.Controls.Add(Me.TxtCantidadS)
        Me.GobDatosProdS.Controls.Add(Me.TxtStockBodega)
        Me.GobDatosProdS.Controls.Add(Me.TxtStockTienda)
        Me.GobDatosProdS.Controls.Add(Me.Label10)
        Me.GobDatosProdS.Controls.Add(Me.Label9)
        Me.GobDatosProdS.Controls.Add(Me.BtnAgregarS)
        Me.GobDatosProdS.Controls.Add(Me.BtnLimpiarS)
        Me.GobDatosProdS.Controls.Add(Me.CobProductosS)
        Me.GobDatosProdS.Controls.Add(Me.Label7)
        Me.GobDatosProdS.Controls.Add(Me.TxtDescripcionS)
        Me.GobDatosProdS.Controls.Add(Me.TxtMarcaS)
        Me.GobDatosProdS.Controls.Add(Me.TxtNombreS)
        Me.GobDatosProdS.Controls.Add(Me.Label6)
        Me.GobDatosProdS.Controls.Add(Me.Label5)
        Me.GobDatosProdS.Controls.Add(Me.Label4)
        Me.GobDatosProdS.Controls.Add(Me.TxtCategoriaS)
        Me.GobDatosProdS.Controls.Add(Me.Label3)
        Me.GobDatosProdS.Controls.Add(Me.Label2)
        Me.GobDatosProdS.Controls.Add(Me.Label1)
        Me.GobDatosProdS.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GobDatosProdS.Location = New System.Drawing.Point(41, 37)
        Me.GobDatosProdS.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.GobDatosProdS.Name = "GobDatosProdS"
        Me.GobDatosProdS.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GobDatosProdS.Size = New System.Drawing.Size(1653, 430)
        Me.GobDatosProdS.TabIndex = 5
        Me.GobDatosProdS.TabStop = False
        Me.GobDatosProdS.Text = "Datos de Salida"
        '
        'DtpFechaSalida
        '
        Me.DtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaSalida.Location = New System.Drawing.Point(183, 313)
        Me.DtpFechaSalida.Name = "DtpFechaSalida"
        Me.DtpFechaSalida.Size = New System.Drawing.Size(365, 34)
        Me.DtpFechaSalida.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 313)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(151, 28)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Fecha de Salida:"
        '
        'PibProductos
        '
        Me.PibProductos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PibProductos.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgSalida
        Me.PibProductos.Location = New System.Drawing.Point(1288, 65)
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
        Me.TxtStockTotal.Location = New System.Drawing.Point(847, 247)
        Me.TxtStockTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStockTotal.Name = "TxtStockTotal"
        Me.TxtStockTotal.Size = New System.Drawing.Size(109, 34)
        Me.TxtStockTotal.TabIndex = 9
        '
        'TxtCantidadS
        '
        Me.TxtCantidadS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCantidadS.Location = New System.Drawing.Point(847, 180)
        Me.TxtCantidadS.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCantidadS.Name = "TxtCantidadS"
        Me.TxtCantidadS.Size = New System.Drawing.Size(109, 34)
        Me.TxtCantidadS.TabIndex = 3
        '
        'TxtStockBodega
        '
        Me.TxtStockBodega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStockBodega.Enabled = False
        Me.TxtStockBodega.Location = New System.Drawing.Point(1145, 245)
        Me.TxtStockBodega.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStockBodega.Name = "TxtStockBodega"
        Me.TxtStockBodega.Size = New System.Drawing.Size(109, 34)
        Me.TxtStockBodega.TabIndex = 7
        '
        'TxtStockTienda
        '
        Me.TxtStockTienda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStockTienda.Enabled = False
        Me.TxtStockTienda.Location = New System.Drawing.Point(1145, 180)
        Me.TxtStockTienda.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStockTienda.Name = "TxtStockTienda"
        Me.TxtStockTienda.Size = New System.Drawing.Size(109, 34)
        Me.TxtStockTienda.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(724, 249)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 28)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Stock Total:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(682, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 28)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Cantidad Salida:"
        '
        'BtnAgregarS
        '
        Me.BtnAgregarS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnAgregarS.FlatAppearance.BorderSize = 0
        Me.BtnAgregarS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnAgregarS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnAgregarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarS.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarS.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.agregarProd
        Me.BtnAgregarS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregarS.Location = New System.Drawing.Point(793, 320)
        Me.BtnAgregarS.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnAgregarS.Name = "BtnAgregarS"
        Me.BtnAgregarS.Size = New System.Drawing.Size(183, 55)
        Me.BtnAgregarS.TabIndex = 4
        Me.BtnAgregarS.Text = "Agregar"
        Me.BtnAgregarS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregarS.UseVisualStyleBackColor = True
        '
        'BtnLimpiarS
        '
        Me.BtnLimpiarS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpiarS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnLimpiarS.FlatAppearance.BorderSize = 0
        Me.BtnLimpiarS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnLimpiarS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnLimpiarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiarS.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiarS.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.limpiarCampos
        Me.BtnLimpiarS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiarS.Location = New System.Drawing.Point(1046, 320)
        Me.BtnLimpiarS.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnLimpiarS.Name = "BtnLimpiarS"
        Me.BtnLimpiarS.Size = New System.Drawing.Size(176, 55)
        Me.BtnLimpiarS.TabIndex = 5
        Me.BtnLimpiarS.Text = "Limpiar"
        Me.BtnLimpiarS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiarS.UseVisualStyleBackColor = True
        '
        'CobProductosS
        '
        Me.CobProductosS.FormattingEnabled = True
        Me.CobProductosS.Items.AddRange(New Object() {"Producto 1", "Producto 2", "Producto 3"})
        Me.CobProductosS.Location = New System.Drawing.Point(149, 57)
        Me.CobProductosS.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.CobProductosS.Name = "CobProductosS"
        Me.CobProductosS.Size = New System.Drawing.Size(399, 36)
        Me.CobProductosS.TabIndex = 1
        Me.CobProductosS.Tag = ""
        Me.CobProductosS.Text = "Seleccione el producto..."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(997, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 28)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Stock Bodega:"
        '
        'TxtDescripcionS
        '
        Me.TxtDescripcionS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescripcionS.Enabled = False
        Me.TxtDescripcionS.Location = New System.Drawing.Point(813, 58)
        Me.TxtDescripcionS.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtDescripcionS.Multiline = True
        Me.TxtDescripcionS.Name = "TxtDescripcionS"
        Me.TxtDescripcionS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDescripcionS.Size = New System.Drawing.Size(441, 98)
        Me.TxtDescripcionS.TabIndex = 5
        '
        'TxtMarcaS
        '
        Me.TxtMarcaS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMarcaS.Enabled = False
        Me.TxtMarcaS.Location = New System.Drawing.Point(138, 180)
        Me.TxtMarcaS.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtMarcaS.Name = "TxtMarcaS"
        Me.TxtMarcaS.Size = New System.Drawing.Size(410, 34)
        Me.TxtMarcaS.TabIndex = 3
        '
        'TxtNombreS
        '
        Me.TxtNombreS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombreS.Enabled = False
        Me.TxtNombreS.Location = New System.Drawing.Point(138, 118)
        Me.TxtNombreS.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtNombreS.Name = "TxtNombreS"
        Me.TxtNombreS.Size = New System.Drawing.Size(410, 34)
        Me.TxtNombreS.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1006, 182)
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
        Me.Label4.Location = New System.Drawing.Point(26, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 28)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Categoría:"
        '
        'TxtCategoriaS
        '
        Me.TxtCategoriaS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCategoriaS.Enabled = False
        Me.TxtCategoriaS.Location = New System.Drawing.Point(138, 247)
        Me.TxtCategoriaS.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtCategoriaS.Name = "TxtCategoriaS"
        Me.TxtCategoriaS.Size = New System.Drawing.Size(410, 34)
        Me.TxtCategoriaS.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Marca:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Productos:"
        '
        'FrmSalidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1733, 860)
        Me.Controls.Add(Me.PanelCentral)
        Me.Controls.Add(Me.PanSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSalidas"
        Me.Text = "FrmSalidas"
        Me.PanSuperior.ResumeLayout(False)
        Me.PanSuperior.PerformLayout()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCentral.ResumeLayout(False)
        Me.PanelCentral.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GobDatosProdS.ResumeLayout(False)
        Me.GobDatosProdS.PerformLayout()
        CType(Me.PibProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanSuperior As Panel
    Friend WithEvents PibMinimizar As PictureBox
    Friend WithEvents PibCerrar As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PanelCentral As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GobDatosProdS As GroupBox
    Friend WithEvents PibProductos As PictureBox
    Friend WithEvents TxtStockTotal As TextBox
    Friend WithEvents TxtCantidadS As TextBox
    Friend WithEvents TxtStockBodega As TextBox
    Friend WithEvents TxtStockTienda As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnAgregarS As Button
    Friend WithEvents BtnLimpiarS As Button
    Friend WithEvents CobProductosS As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtDescripcionS As TextBox
    Friend WithEvents TxtMarcaS As TextBox
    Friend WithEvents TxtNombreS As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCategoriaS As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents DtpFechaSalida As DateTimePicker
End Class
