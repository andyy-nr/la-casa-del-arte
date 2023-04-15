<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEntradas
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
        Me.PibRetornar = New System.Windows.Forms.PictureBox()
        Me.PibMinimizar = New System.Windows.Forms.PictureBox()
        Me.PibCerrar = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PanelCentral = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GopEntrada = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtCantPaqProdEnt = New System.Windows.Forms.TextBox()
        Me.TxtUsuEnt = New System.Windows.Forms.TextBox()
        Me.TxtCntUnidadProdEnt = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtDesEnt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DtpFechaEnt = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GobDatosProdS = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CobProductosEnt = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtStockTotalEnt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNombreEnt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtMarcaEnt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtStockBodegaEnt = New System.Windows.Forms.TextBox()
        Me.TxtStockTiendaEnt = New System.Windows.Forms.TextBox()
        Me.TxtCategoriaEnt = New System.Windows.Forms.TextBox()
        Me.TxtDescripcionEnt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnLimpiarEnt = New System.Windows.Forms.Button()
        Me.BtnAgregarEnt = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PibProductos = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanSuperior.SuspendLayout()
        CType(Me.PibRetornar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCentral.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GopEntrada.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GobDatosProdS.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PibRetornar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PibRetornar.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.BtnRegresar
        Me.PibRetornar.Location = New System.Drawing.Point(3, 4)
        Me.PibRetornar.Name = "PibRetornar"
        Me.PibRetornar.Size = New System.Drawing.Size(43, 43)
        Me.PibRetornar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PibRetornar.TabIndex = 9
        Me.PibRetornar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PibRetornar, "Regresar")
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
        Me.Label8.Location = New System.Drawing.Point(621, 6)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(478, 41)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Gestión de Entradas de Producto"
        '
        'PanelCentral
        '
        Me.PanelCentral.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PanelCentral.Controls.Add(Me.Panel1)
        Me.PanelCentral.Controls.Add(Me.DataGridView1)
        Me.PanelCentral.Controls.Add(Me.PibProductos)
        Me.PanelCentral.Controls.Add(Me.PictureBox1)
        Me.PanelCentral.Controls.Add(Me.TxtBuscar)
        Me.PanelCentral.Controls.Add(Me.Label12)
        Me.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCentral.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelCentral.Location = New System.Drawing.Point(0, 52)
        Me.PanelCentral.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelCentral.Name = "PanelCentral"
        Me.PanelCentral.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.PanelCentral.Size = New System.Drawing.Size(1733, 808)
        Me.PanelCentral.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GopEntrada)
        Me.Panel1.Controls.Add(Me.DataGridView2)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.GobDatosProdS)
        Me.Panel1.Controls.Add(Me.BtnLimpiarEnt)
        Me.Panel1.Controls.Add(Me.BtnAgregarEnt)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(13, 12)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.Panel1.Size = New System.Drawing.Size(1707, 784)
        Me.Panel1.TabIndex = 30
        '
        'GopEntrada
        '
        Me.GopEntrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GopEntrada.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GopEntrada.Controls.Add(Me.Label15)
        Me.GopEntrada.Controls.Add(Me.TxtCantPaqProdEnt)
        Me.GopEntrada.Controls.Add(Me.TxtUsuEnt)
        Me.GopEntrada.Controls.Add(Me.TxtCntUnidadProdEnt)
        Me.GopEntrada.Controls.Add(Me.Label14)
        Me.GopEntrada.Controls.Add(Me.Label9)
        Me.GopEntrada.Controls.Add(Me.TxtDesEnt)
        Me.GopEntrada.Controls.Add(Me.Label13)
        Me.GopEntrada.Controls.Add(Me.Label11)
        Me.GopEntrada.Controls.Add(Me.PictureBox2)
        Me.GopEntrada.Controls.Add(Me.DtpFechaEnt)
        Me.GopEntrada.Location = New System.Drawing.Point(696, 35)
        Me.GopEntrada.Name = "GopEntrada"
        Me.GopEntrada.Size = New System.Drawing.Size(985, 401)
        Me.GopEntrada.TabIndex = 31
        Me.GopEntrada.TabStop = False
        Me.GopEntrada.Text = "Datos de la Entrada"
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
        'TxtCantPaqProdEnt
        '
        Me.TxtCantPaqProdEnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCantPaqProdEnt.Location = New System.Drawing.Point(406, 336)
        Me.TxtCantPaqProdEnt.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCantPaqProdEnt.Name = "TxtCantPaqProdEnt"
        Me.TxtCantPaqProdEnt.Size = New System.Drawing.Size(109, 34)
        Me.TxtCantPaqProdEnt.TabIndex = 13
        '
        'TxtUsuEnt
        '
        Me.TxtUsuEnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUsuEnt.Location = New System.Drawing.Point(189, 53)
        Me.TxtUsuEnt.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtUsuEnt.Name = "TxtUsuEnt"
        Me.TxtUsuEnt.Size = New System.Drawing.Size(411, 34)
        Me.TxtUsuEnt.TabIndex = 9
        '
        'TxtCntUnidadProdEnt
        '
        Me.TxtCntUnidadProdEnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCntUnidadProdEnt.Location = New System.Drawing.Point(406, 274)
        Me.TxtCntUnidadProdEnt.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCntUnidadProdEnt.Name = "TxtCntUnidadProdEnt"
        Me.TxtCntUnidadProdEnt.Size = New System.Drawing.Size(109, 34)
        Me.TxtCntUnidadProdEnt.TabIndex = 12
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
        'TxtDesEnt
        '
        Me.TxtDesEnt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtDesEnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDesEnt.Location = New System.Drawing.Point(189, 172)
        Me.TxtDesEnt.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtDesEnt.Multiline = True
        Me.TxtDesEnt.Name = "TxtDesEnt"
        Me.TxtDesEnt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDesEnt.Size = New System.Drawing.Size(418, 83)
        Me.TxtDesEnt.TabIndex = 11
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
        Me.Label11.Location = New System.Drawing.Point(6, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(165, 28)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Fecha de Entrada:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgEntrada
        Me.PictureBox2.Location = New System.Drawing.Point(628, 36)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(335, 310)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'DtpFechaEnt
        '
        Me.DtpFechaEnt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaEnt.Location = New System.Drawing.Point(189, 106)
        Me.DtpFechaEnt.Name = "DtpFechaEnt"
        Me.DtpFechaEnt.Size = New System.Drawing.Size(411, 34)
        Me.DtpFechaEnt.TabIndex = 10
        '
        'DataGridView2
        '
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(41, 567)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(1627, 186)
        Me.DataGridView2.TabIndex = 17
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.lupa
        Me.PictureBox3.Location = New System.Drawing.Point(41, 490)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(55, 55)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(181, 499)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(1487, 34)
        Me.TextBox2.TabIndex = 16
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(102, 499)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 28)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Buscar:"
        '
        'GobDatosProdS
        '
        Me.GobDatosProdS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GobDatosProdS.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GobDatosProdS.Controls.Add(Me.Label1)
        Me.GobDatosProdS.Controls.Add(Me.CobProductosEnt)
        Me.GobDatosProdS.Controls.Add(Me.Label5)
        Me.GobDatosProdS.Controls.Add(Me.TxtStockTotalEnt)
        Me.GobDatosProdS.Controls.Add(Me.Label2)
        Me.GobDatosProdS.Controls.Add(Me.TxtNombreEnt)
        Me.GobDatosProdS.Controls.Add(Me.Label3)
        Me.GobDatosProdS.Controls.Add(Me.TxtMarcaEnt)
        Me.GobDatosProdS.Controls.Add(Me.Label10)
        Me.GobDatosProdS.Controls.Add(Me.Label4)
        Me.GobDatosProdS.Controls.Add(Me.TxtStockBodegaEnt)
        Me.GobDatosProdS.Controls.Add(Me.TxtStockTiendaEnt)
        Me.GobDatosProdS.Controls.Add(Me.TxtCategoriaEnt)
        Me.GobDatosProdS.Controls.Add(Me.TxtDescripcionEnt)
        Me.GobDatosProdS.Controls.Add(Me.Label6)
        Me.GobDatosProdS.Controls.Add(Me.Label7)
        Me.GobDatosProdS.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GobDatosProdS.Location = New System.Drawing.Point(41, 35)
        Me.GobDatosProdS.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.GobDatosProdS.Name = "GobDatosProdS"
        Me.GobDatosProdS.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GobDatosProdS.Size = New System.Drawing.Size(646, 401)
        Me.GobDatosProdS.TabIndex = 5
        Me.GobDatosProdS.TabStop = False
        Me.GobDatosProdS.Text = "Datos del Producto"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Producto:"
        '
        'CobProductosEnt
        '
        Me.CobProductosEnt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CobProductosEnt.FormattingEnabled = True
        Me.CobProductosEnt.Items.AddRange(New Object() {"Producto 1", "Producto 2", "Producto 3"})
        Me.CobProductosEnt.Location = New System.Drawing.Point(173, 30)
        Me.CobProductosEnt.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.CobProductosEnt.Name = "CobProductosEnt"
        Me.CobProductosEnt.Size = New System.Drawing.Size(453, 36)
        Me.CobProductosEnt.TabIndex = 1
        Me.CobProductosEnt.Tag = ""
        Me.CobProductosEnt.Text = "Seleccione el producto..."
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 28)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Descripción:"
        '
        'TxtStockTotalEnt
        '
        Me.TxtStockTotalEnt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtStockTotalEnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStockTotalEnt.Enabled = False
        Me.TxtStockTotalEnt.Location = New System.Drawing.Point(440, 340)
        Me.TxtStockTotalEnt.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStockTotalEnt.Name = "TxtStockTotalEnt"
        Me.TxtStockTotalEnt.Size = New System.Drawing.Size(109, 34)
        Me.TxtStockTotalEnt.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'TxtNombreEnt
        '
        Me.TxtNombreEnt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtNombreEnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombreEnt.Enabled = False
        Me.TxtNombreEnt.Location = New System.Drawing.Point(173, 74)
        Me.TxtNombreEnt.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtNombreEnt.Name = "TxtNombreEnt"
        Me.TxtNombreEnt.Size = New System.Drawing.Size(453, 34)
        Me.TxtNombreEnt.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Marca:"
        '
        'TxtMarcaEnt
        '
        Me.TxtMarcaEnt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtMarcaEnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMarcaEnt.Enabled = False
        Me.TxtMarcaEnt.Location = New System.Drawing.Point(173, 123)
        Me.TxtMarcaEnt.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtMarcaEnt.Name = "TxtMarcaEnt"
        Me.TxtMarcaEnt.Size = New System.Drawing.Size(453, 34)
        Me.TxtMarcaEnt.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(312, 342)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 28)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Stock Total:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 28)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Categoría:"
        '
        'TxtStockBodegaEnt
        '
        Me.TxtStockBodegaEnt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtStockBodegaEnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStockBodegaEnt.Enabled = False
        Me.TxtStockBodegaEnt.Location = New System.Drawing.Point(173, 354)
        Me.TxtStockBodegaEnt.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStockBodegaEnt.Name = "TxtStockBodegaEnt"
        Me.TxtStockBodegaEnt.Size = New System.Drawing.Size(109, 34)
        Me.TxtStockBodegaEnt.TabIndex = 7
        '
        'TxtStockTiendaEnt
        '
        Me.TxtStockTiendaEnt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtStockTiendaEnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStockTiendaEnt.Enabled = False
        Me.TxtStockTiendaEnt.Location = New System.Drawing.Point(173, 312)
        Me.TxtStockTiendaEnt.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStockTiendaEnt.Name = "TxtStockTiendaEnt"
        Me.TxtStockTiendaEnt.Size = New System.Drawing.Size(109, 34)
        Me.TxtStockTiendaEnt.TabIndex = 6
        '
        'TxtCategoriaEnt
        '
        Me.TxtCategoriaEnt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtCategoriaEnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCategoriaEnt.Enabled = False
        Me.TxtCategoriaEnt.Location = New System.Drawing.Point(173, 172)
        Me.TxtCategoriaEnt.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtCategoriaEnt.Name = "TxtCategoriaEnt"
        Me.TxtCategoriaEnt.Size = New System.Drawing.Size(453, 34)
        Me.TxtCategoriaEnt.TabIndex = 4
        '
        'TxtDescripcionEnt
        '
        Me.TxtDescripcionEnt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtDescripcionEnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescripcionEnt.Enabled = False
        Me.TxtDescripcionEnt.Location = New System.Drawing.Point(173, 219)
        Me.TxtDescripcionEnt.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtDescripcionEnt.Multiline = True
        Me.TxtDescripcionEnt.Name = "TxtDescripcionEnt"
        Me.TxtDescripcionEnt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDescripcionEnt.Size = New System.Drawing.Size(476, 83)
        Me.TxtDescripcionEnt.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 28)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Stock Tienda:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(-3, 354)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 28)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Stock Bodega:"
        '
        'BtnLimpiarEnt
        '
        Me.BtnLimpiarEnt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnLimpiarEnt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpiarEnt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnLimpiarEnt.FlatAppearance.BorderSize = 0
        Me.BtnLimpiarEnt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnLimpiarEnt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnLimpiarEnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiarEnt.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiarEnt.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.limpiarCampos
        Me.BtnLimpiarEnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiarEnt.Location = New System.Drawing.Point(885, 440)
        Me.BtnLimpiarEnt.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnLimpiarEnt.Name = "BtnLimpiarEnt"
        Me.BtnLimpiarEnt.Size = New System.Drawing.Size(176, 55)
        Me.BtnLimpiarEnt.TabIndex = 15
        Me.BtnLimpiarEnt.Text = "Limpiar"
        Me.BtnLimpiarEnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiarEnt.UseVisualStyleBackColor = True
        '
        'BtnAgregarEnt
        '
        Me.BtnAgregarEnt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnAgregarEnt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarEnt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnAgregarEnt.FlatAppearance.BorderSize = 0
        Me.BtnAgregarEnt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnAgregarEnt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnAgregarEnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarEnt.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarEnt.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.agregarProd
        Me.BtnAgregarEnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregarEnt.Location = New System.Drawing.Point(635, 440)
        Me.BtnAgregarEnt.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnAgregarEnt.Name = "BtnAgregarEnt"
        Me.BtnAgregarEnt.Size = New System.Drawing.Size(183, 55)
        Me.BtnAgregarEnt.TabIndex = 14
        Me.BtnAgregarEnt.Text = "Agregar"
        Me.BtnAgregarEnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregarEnt.UseVisualStyleBackColor = True
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
        Me.DataGridView1.Size = New System.Drawing.Size(1653, 180)
        Me.DataGridView1.TabIndex = 7
        '
        'PibProductos
        '
        Me.PibProductos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PibProductos.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgEntrada
        Me.PibProductos.Location = New System.Drawing.Point(1324, 460)
        Me.PibProductos.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.PibProductos.Name = "PibProductos"
        Me.PibProductos.Size = New System.Drawing.Size(335, 310)
        Me.PibProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PibProductos.TabIndex = 29
        Me.PibProductos.TabStop = False
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
        'FrmEntradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1733, 860)
        Me.Controls.Add(Me.PanelCentral)
        Me.Controls.Add(Me.PanSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEntradas"
        Me.Text = "FrmEntradas"
        Me.PanSuperior.ResumeLayout(False)
        Me.PanSuperior.PerformLayout()
        CType(Me.PibRetornar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCentral.ResumeLayout(False)
        Me.PanelCentral.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GopEntrada.ResumeLayout(False)
        Me.GopEntrada.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GobDatosProdS.ResumeLayout(False)
        Me.GobDatosProdS.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PibProductos As PictureBox
    Friend WithEvents PibRetornar As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GopEntrada As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtCantPaqProdEnt As TextBox
    Friend WithEvents TxtUsuEnt As TextBox
    Friend WithEvents TxtCntUnidadProdEnt As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtDesEnt As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DtpFechaEnt As DateTimePicker
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents GobDatosProdS As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CobProductosEnt As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtStockTotalEnt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNombreEnt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtMarcaEnt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtStockBodegaEnt As TextBox
    Friend WithEvents TxtStockTiendaEnt As TextBox
    Friend WithEvents TxtCategoriaEnt As TextBox
    Friend WithEvents TxtDescripcionEnt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnLimpiarEnt As Button
    Friend WithEvents BtnAgregarEnt As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
