<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSalidas
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
        Me.PanSuperior = New System.Windows.Forms.Panel()
        Me.PibRetornar = New System.Windows.Forms.PictureBox()
        Me.PibMinimizar = New System.Windows.Forms.PictureBox()
        Me.PibCerrar = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PanelCentral = New System.Windows.Forms.Panel()
        Me.GopSalida = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TxtUsuarioSal = New System.Windows.Forms.TextBox()
        Me.TxtCantidadUP = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtDesSal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PibProductos = New System.Windows.Forms.PictureBox()
        Me.DtpFechaSalida = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GobDatosProdS = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CobProductosS = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtStockTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNombreS = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtMarcaS = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtStockBodega = New System.Windows.Forms.TextBox()
        Me.TxtStockTienda = New System.Windows.Forms.TextBox()
        Me.TxtCategoriaS = New System.Windows.Forms.TextBox()
        Me.TxtDescripcionS = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnLimpiarS = New System.Windows.Forms.Button()
        Me.BtnAgregarS = New System.Windows.Forms.Button()
        Me.PanSuperior.SuspendLayout()
        CType(Me.PibRetornar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCentral.SuspendLayout()
        Me.GopSalida.SuspendLayout()
        CType(Me.PibProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GobDatosProdS.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanSuperior
        '
        Me.PanSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanSuperior.Controls.Add(Me.PibRetornar)
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
        'PibRetornar
        '
        Me.PibRetornar.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.BtnRegresar
        Me.PibRetornar.Location = New System.Drawing.Point(3, 4)
        Me.PibRetornar.Name = "PibRetornar"
        Me.PibRetornar.Size = New System.Drawing.Size(43, 43)
        Me.PibRetornar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PibRetornar.TabIndex = 9
        Me.PibRetornar.TabStop = False
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
        Me.Label8.Location = New System.Drawing.Point(639, 6)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(455, 41)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Gestión de Salidas de Producto"
        '
        'PanelCentral
        '
        Me.PanelCentral.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PanelCentral.Controls.Add(Me.GopSalida)
        Me.PanelCentral.Controls.Add(Me.DataGridView1)
        Me.PanelCentral.Controls.Add(Me.PictureBox1)
        Me.PanelCentral.Controls.Add(Me.TxtBuscar)
        Me.PanelCentral.Controls.Add(Me.Label12)
        Me.PanelCentral.Controls.Add(Me.GobDatosProdS)
        Me.PanelCentral.Controls.Add(Me.BtnLimpiarS)
        Me.PanelCentral.Controls.Add(Me.BtnAgregarS)
        Me.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCentral.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelCentral.Location = New System.Drawing.Point(0, 52)
        Me.PanelCentral.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelCentral.Name = "PanelCentral"
        Me.PanelCentral.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.PanelCentral.Size = New System.Drawing.Size(1733, 808)
        Me.PanelCentral.TabIndex = 17
        '
        'GopSalida
        '
        Me.GopSalida.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GopSalida.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GopSalida.Controls.Add(Me.Label15)
        Me.GopSalida.Controls.Add(Me.TextBox1)
        Me.GopSalida.Controls.Add(Me.TxtUsuarioSal)
        Me.GopSalida.Controls.Add(Me.TxtCantidadUP)
        Me.GopSalida.Controls.Add(Me.Label14)
        Me.GopSalida.Controls.Add(Me.Label9)
        Me.GopSalida.Controls.Add(Me.TxtDesSal)
        Me.GopSalida.Controls.Add(Me.Label13)
        Me.GopSalida.Controls.Add(Me.Label11)
        Me.GopSalida.Controls.Add(Me.PibProductos)
        Me.GopSalida.Controls.Add(Me.DtpFechaSalida)
        Me.GopSalida.Location = New System.Drawing.Point(711, 37)
        Me.GopSalida.Name = "GopSalida"
        Me.GopSalida.Size = New System.Drawing.Size(983, 401)
        Me.GopSalida.TabIndex = 31
        Me.GopSalida.TabStop = False
        Me.GopSalida.Text = "Datos de la Salida"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(66, 336)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(318, 28)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Cantidad de Paquetes de Producto:"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(406, 336)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(109, 34)
        Me.TextBox1.TabIndex = 33
        '
        'TxtUsuarioSal
        '
        Me.TxtUsuarioSal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUsuarioSal.Location = New System.Drawing.Point(191, 53)
        Me.TxtUsuarioSal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtUsuarioSal.Name = "TxtUsuarioSal"
        Me.TxtUsuarioSal.Size = New System.Drawing.Size(409, 34)
        Me.TxtUsuarioSal.TabIndex = 32
        '
        'TxtCantidadUP
        '
        Me.TxtCantidadUP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCantidadUP.Location = New System.Drawing.Point(406, 274)
        Me.TxtCantidadUP.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCantidadUP.Name = "TxtCantidadUP"
        Me.TxtCantidadUP.Size = New System.Drawing.Size(109, 34)
        Me.TxtCantidadUP.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(53, 172)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(118, 28)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Descripción:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(66, 274)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(322, 28)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Cantidad de Unidades de Producto:"
        '
        'TxtDesSal
        '
        Me.TxtDesSal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtDesSal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDesSal.Location = New System.Drawing.Point(191, 172)
        Me.TxtDesSal.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtDesSal.Multiline = True
        Me.TxtDesSal.Name = "TxtDesSal"
        Me.TxtDesSal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDesSal.Size = New System.Drawing.Size(415, 83)
        Me.TxtDesSal.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(88, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 28)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Usuario:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(151, 28)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Fecha de Salida:"
        '
        'PibProductos
        '
        Me.PibProductos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PibProductos.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgSalida
        Me.PibProductos.Location = New System.Drawing.Point(627, 36)
        Me.PibProductos.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.PibProductos.Name = "PibProductos"
        Me.PibProductos.Size = New System.Drawing.Size(335, 310)
        Me.PibProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PibProductos.TabIndex = 29
        Me.PibProductos.TabStop = False
        '
        'DtpFechaSalida
        '
        Me.DtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaSalida.Location = New System.Drawing.Point(191, 106)
        Me.DtpFechaSalida.Name = "DtpFechaSalida"
        Me.DtpFechaSalida.Size = New System.Drawing.Size(409, 34)
        Me.DtpFechaSalida.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(41, 567)
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
        Me.GobDatosProdS.Controls.Add(Me.Label1)
        Me.GobDatosProdS.Controls.Add(Me.CobProductosS)
        Me.GobDatosProdS.Controls.Add(Me.Label5)
        Me.GobDatosProdS.Controls.Add(Me.TxtStockTotal)
        Me.GobDatosProdS.Controls.Add(Me.Label2)
        Me.GobDatosProdS.Controls.Add(Me.TxtNombreS)
        Me.GobDatosProdS.Controls.Add(Me.Label3)
        Me.GobDatosProdS.Controls.Add(Me.TxtMarcaS)
        Me.GobDatosProdS.Controls.Add(Me.Label10)
        Me.GobDatosProdS.Controls.Add(Me.Label4)
        Me.GobDatosProdS.Controls.Add(Me.TxtStockBodega)
        Me.GobDatosProdS.Controls.Add(Me.TxtStockTienda)
        Me.GobDatosProdS.Controls.Add(Me.TxtCategoriaS)
        Me.GobDatosProdS.Controls.Add(Me.TxtDescripcionS)
        Me.GobDatosProdS.Controls.Add(Me.Label6)
        Me.GobDatosProdS.Controls.Add(Me.Label7)
        Me.GobDatosProdS.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GobDatosProdS.Location = New System.Drawing.Point(41, 37)
        Me.GobDatosProdS.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.GobDatosProdS.Name = "GobDatosProdS"
        Me.GobDatosProdS.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GobDatosProdS.Size = New System.Drawing.Size(651, 401)
        Me.GobDatosProdS.TabIndex = 5
        Me.GobDatosProdS.TabStop = False
        Me.GobDatosProdS.Text = "Datos del Producto"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Producto:"
        '
        'CobProductosS
        '
        Me.CobProductosS.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CobProductosS.FormattingEnabled = True
        Me.CobProductosS.Items.AddRange(New Object() {"Producto 1", "Producto 2", "Producto 3"})
        Me.CobProductosS.Location = New System.Drawing.Point(175, 30)
        Me.CobProductosS.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.CobProductosS.Name = "CobProductosS"
        Me.CobProductosS.Size = New System.Drawing.Size(453, 36)
        Me.CobProductosS.TabIndex = 1
        Me.CobProductosS.Tag = ""
        Me.CobProductosS.Text = "Seleccione el producto..."
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 28)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Descripción:"
        '
        'TxtStockTotal
        '
        Me.TxtStockTotal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtStockTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStockTotal.Enabled = False
        Me.TxtStockTotal.Location = New System.Drawing.Point(442, 340)
        Me.TxtStockTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStockTotal.Name = "TxtStockTotal"
        Me.TxtStockTotal.Size = New System.Drawing.Size(109, 34)
        Me.TxtStockTotal.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'TxtNombreS
        '
        Me.TxtNombreS.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtNombreS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombreS.Enabled = False
        Me.TxtNombreS.Location = New System.Drawing.Point(175, 74)
        Me.TxtNombreS.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtNombreS.Name = "TxtNombreS"
        Me.TxtNombreS.Size = New System.Drawing.Size(453, 34)
        Me.TxtNombreS.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Marca:"
        '
        'TxtMarcaS
        '
        Me.TxtMarcaS.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtMarcaS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMarcaS.Enabled = False
        Me.TxtMarcaS.Location = New System.Drawing.Point(175, 123)
        Me.TxtMarcaS.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtMarcaS.Name = "TxtMarcaS"
        Me.TxtMarcaS.Size = New System.Drawing.Size(453, 34)
        Me.TxtMarcaS.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(314, 342)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 28)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Stock Total:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 28)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Categoría:"
        '
        'TxtStockBodega
        '
        Me.TxtStockBodega.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtStockBodega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStockBodega.Enabled = False
        Me.TxtStockBodega.Location = New System.Drawing.Point(175, 354)
        Me.TxtStockBodega.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStockBodega.Name = "TxtStockBodega"
        Me.TxtStockBodega.Size = New System.Drawing.Size(109, 34)
        Me.TxtStockBodega.TabIndex = 7
        '
        'TxtStockTienda
        '
        Me.TxtStockTienda.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtStockTienda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStockTienda.Enabled = False
        Me.TxtStockTienda.Location = New System.Drawing.Point(175, 312)
        Me.TxtStockTienda.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStockTienda.Name = "TxtStockTienda"
        Me.TxtStockTienda.Size = New System.Drawing.Size(109, 34)
        Me.TxtStockTienda.TabIndex = 6
        '
        'TxtCategoriaS
        '
        Me.TxtCategoriaS.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtCategoriaS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCategoriaS.Enabled = False
        Me.TxtCategoriaS.Location = New System.Drawing.Point(175, 172)
        Me.TxtCategoriaS.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtCategoriaS.Name = "TxtCategoriaS"
        Me.TxtCategoriaS.Size = New System.Drawing.Size(453, 34)
        Me.TxtCategoriaS.TabIndex = 1
        '
        'TxtDescripcionS
        '
        Me.TxtDescripcionS.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtDescripcionS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescripcionS.Enabled = False
        Me.TxtDescripcionS.Location = New System.Drawing.Point(175, 219)
        Me.TxtDescripcionS.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtDescripcionS.Multiline = True
        Me.TxtDescripcionS.Name = "TxtDescripcionS"
        Me.TxtDescripcionS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDescripcionS.Size = New System.Drawing.Size(476, 83)
        Me.TxtDescripcionS.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 28)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Stock Tienda:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(0, 346)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 28)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Stock Bodega:"
        '
        'BtnLimpiarS
        '
        Me.BtnLimpiarS.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnLimpiarS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpiarS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnLimpiarS.FlatAppearance.BorderSize = 0
        Me.BtnLimpiarS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnLimpiarS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnLimpiarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiarS.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiarS.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.limpiarCampos
        Me.BtnLimpiarS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiarS.Location = New System.Drawing.Point(898, 440)
        Me.BtnLimpiarS.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnLimpiarS.Name = "BtnLimpiarS"
        Me.BtnLimpiarS.Size = New System.Drawing.Size(176, 55)
        Me.BtnLimpiarS.TabIndex = 5
        Me.BtnLimpiarS.Text = "Limpiar"
        Me.BtnLimpiarS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiarS.UseVisualStyleBackColor = True
        '
        'BtnAgregarS
        '
        Me.BtnAgregarS.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnAgregarS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnAgregarS.FlatAppearance.BorderSize = 0
        Me.BtnAgregarS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnAgregarS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnAgregarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarS.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarS.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.agregarProd
        Me.BtnAgregarS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregarS.Location = New System.Drawing.Point(648, 440)
        Me.BtnAgregarS.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnAgregarS.Name = "BtnAgregarS"
        Me.BtnAgregarS.Size = New System.Drawing.Size(183, 55)
        Me.BtnAgregarS.TabIndex = 4
        Me.BtnAgregarS.Text = "Agregar"
        Me.BtnAgregarS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregarS.UseVisualStyleBackColor = True
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
        CType(Me.PibRetornar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCentral.ResumeLayout(False)
        Me.PanelCentral.PerformLayout()
        Me.GopSalida.ResumeLayout(False)
        Me.GopSalida.PerformLayout()
        CType(Me.PibProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GobDatosProdS.ResumeLayout(False)
        Me.GobDatosProdS.PerformLayout()
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
    Friend WithEvents TxtCantidadUP As TextBox
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
    Friend WithEvents PibRetornar As PictureBox
    Friend WithEvents GopSalida As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtDesSal As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TxtUsuarioSal As TextBox
End Class
