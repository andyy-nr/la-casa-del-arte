﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMovimiento
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GobDatosProdE = New System.Windows.Forms.GroupBox()
        Me.TxtUnidadesDe = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CobProductosE = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNombreE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtMarcaE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCategoriaE = New System.Windows.Forms.TextBox()
        Me.TxtDescripcionE = New System.Windows.Forms.TextBox()
        Me.GopEntrada = New System.Windows.Forms.GroupBox()
        Me.TxtUsuarioEnt = New System.Windows.Forms.TextBox()
        Me.TxtCantidadUP = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtDesEnt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PibEntradas = New System.Windows.Forms.PictureBox()
        Me.DtpFechaEntrada = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.BtnAgregarE = New System.Windows.Forms.Button()
        Me.BtnLimpiarE = New System.Windows.Forms.Button()
        Me.PanelCentral = New System.Windows.Forms.Panel()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DtpFechaVen = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtCodigoEntrada = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.RBtnEntrada = New System.Windows.Forms.RadioButton()
        Me.RBtnSalida = New System.Windows.Forms.RadioButton()
        Me.PanSuperior.SuspendLayout()
        CType(Me.PibRetornar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GobDatosProdE.SuspendLayout()
        Me.GopEntrada.SuspendLayout()
        CType(Me.PibEntradas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCentral.SuspendLayout()
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
        Me.Label8.Size = New System.Drawing.Size(554, 41)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Gestión de Movimientos de Productos"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgFiltrar
        Me.PictureBox1.Location = New System.Drawing.Point(41, 558)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Filtrar")
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgBuscar
        Me.PictureBox2.Location = New System.Drawing.Point(111, 558)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 45)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox2, "Buscar")
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(41, 625)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1653, 154)
        Me.DataGridView1.TabIndex = 7
        '
        'GobDatosProdE
        '
        Me.GobDatosProdE.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GobDatosProdE.Controls.Add(Me.DtpFechaVen)
        Me.GobDatosProdE.Controls.Add(Me.TextBox2)
        Me.GobDatosProdE.Controls.Add(Me.TxtPrecio)
        Me.GobDatosProdE.Controls.Add(Me.TxtUnidadesDe)
        Me.GobDatosProdE.Controls.Add(Me.Label7)
        Me.GobDatosProdE.Controls.Add(Me.Label6)
        Me.GobDatosProdE.Controls.Add(Me.Label1)
        Me.GobDatosProdE.Controls.Add(Me.CobProductosE)
        Me.GobDatosProdE.Controls.Add(Me.Label5)
        Me.GobDatosProdE.Controls.Add(Me.Label2)
        Me.GobDatosProdE.Controls.Add(Me.TxtNombreE)
        Me.GobDatosProdE.Controls.Add(Me.Label3)
        Me.GobDatosProdE.Controls.Add(Me.TxtMarcaE)
        Me.GobDatosProdE.Controls.Add(Me.Label4)
        Me.GobDatosProdE.Controls.Add(Me.TxtCategoriaE)
        Me.GobDatosProdE.Controls.Add(Me.TxtDescripcionE)
        Me.GobDatosProdE.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GobDatosProdE.Location = New System.Drawing.Point(41, 37)
        Me.GobDatosProdE.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.GobDatosProdE.Name = "GobDatosProdE"
        Me.GobDatosProdE.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GobDatosProdE.Size = New System.Drawing.Size(651, 506)
        Me.GobDatosProdE.TabIndex = 32
        Me.GobDatosProdE.TabStop = False
        Me.GobDatosProdE.Text = "Datos del Producto"
        '
        'TxtUnidadesDe
        '
        Me.TxtUnidadesDe.AutoSize = True
        Me.TxtUnidadesDe.Location = New System.Drawing.Point(14, 456)
        Me.TxtUnidadesDe.Name = "TxtUnidadesDe"
        Me.TxtUnidadesDe.Size = New System.Drawing.Size(197, 28)
        Me.TxtUnidadesDe.TabIndex = 8
        Me.TxtUnidadesDe.Text = "Unidades Disponible:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 361)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(206, 28)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Fecha de Vencimiento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(62, 407)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 28)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Precio Unitario:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Producto:"
        '
        'CobProductosE
        '
        Me.CobProductosE.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CobProductosE.FormattingEnabled = True
        Me.CobProductosE.Items.AddRange(New Object() {"Producto 1", "Producto 2", "Producto 3"})
        Me.CobProductosE.Location = New System.Drawing.Point(171, 35)
        Me.CobProductosE.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.CobProductosE.Name = "CobProductosE"
        Me.CobProductosE.Size = New System.Drawing.Size(429, 36)
        Me.CobProductosE.TabIndex = 1
        Me.CobProductosE.Tag = ""
        Me.CobProductosE.Text = "Seleccione el producto..."
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 28)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Descripción:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'TxtNombreE
        '
        Me.TxtNombreE.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtNombreE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombreE.Enabled = False
        Me.TxtNombreE.Location = New System.Drawing.Point(171, 88)
        Me.TxtNombreE.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtNombreE.Name = "TxtNombreE"
        Me.TxtNombreE.Size = New System.Drawing.Size(429, 34)
        Me.TxtNombreE.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Marca:"
        '
        'TxtMarcaE
        '
        Me.TxtMarcaE.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtMarcaE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMarcaE.Enabled = False
        Me.TxtMarcaE.Location = New System.Drawing.Point(171, 142)
        Me.TxtMarcaE.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtMarcaE.Name = "TxtMarcaE"
        Me.TxtMarcaE.Size = New System.Drawing.Size(429, 34)
        Me.TxtMarcaE.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 28)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Categoría:"
        '
        'TxtCategoriaE
        '
        Me.TxtCategoriaE.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtCategoriaE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCategoriaE.Enabled = False
        Me.TxtCategoriaE.Location = New System.Drawing.Point(171, 197)
        Me.TxtCategoriaE.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtCategoriaE.Name = "TxtCategoriaE"
        Me.TxtCategoriaE.Size = New System.Drawing.Size(429, 34)
        Me.TxtCategoriaE.TabIndex = 4
        '
        'TxtDescripcionE
        '
        Me.TxtDescripcionE.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtDescripcionE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescripcionE.Enabled = False
        Me.TxtDescripcionE.Location = New System.Drawing.Point(171, 253)
        Me.TxtDescripcionE.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtDescripcionE.Multiline = True
        Me.TxtDescripcionE.Name = "TxtDescripcionE"
        Me.TxtDescripcionE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDescripcionE.Size = New System.Drawing.Size(451, 83)
        Me.TxtDescripcionE.TabIndex = 5
        '
        'GopEntrada
        '
        Me.GopEntrada.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GopEntrada.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GopEntrada.Controls.Add(Me.RBtnSalida)
        Me.GopEntrada.Controls.Add(Me.RBtnEntrada)
        Me.GopEntrada.Controls.Add(Me.Label16)
        Me.GopEntrada.Controls.Add(Me.TxtCodigoEntrada)
        Me.GopEntrada.Controls.Add(Me.Label15)
        Me.GopEntrada.Controls.Add(Me.TxtUsuarioEnt)
        Me.GopEntrada.Controls.Add(Me.TxtCantidadUP)
        Me.GopEntrada.Controls.Add(Me.Label14)
        Me.GopEntrada.Controls.Add(Me.Label9)
        Me.GopEntrada.Controls.Add(Me.TxtDesEnt)
        Me.GopEntrada.Controls.Add(Me.Label13)
        Me.GopEntrada.Controls.Add(Me.Label11)
        Me.GopEntrada.Controls.Add(Me.PibEntradas)
        Me.GopEntrada.Controls.Add(Me.DtpFechaEntrada)
        Me.GopEntrada.Location = New System.Drawing.Point(711, 37)
        Me.GopEntrada.Name = "GopEntrada"
        Me.GopEntrada.Size = New System.Drawing.Size(983, 441)
        Me.GopEntrada.TabIndex = 33
        Me.GopEntrada.TabStop = False
        Me.GopEntrada.Text = "Datos de la Entrada"
        '
        'TxtUsuarioEnt
        '
        Me.TxtUsuarioEnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUsuarioEnt.Enabled = False
        Me.TxtUsuarioEnt.Location = New System.Drawing.Point(203, 90)
        Me.TxtUsuarioEnt.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtUsuarioEnt.Name = "TxtUsuarioEnt"
        Me.TxtUsuarioEnt.Size = New System.Drawing.Size(391, 34)
        Me.TxtUsuarioEnt.TabIndex = 9
        '
        'TxtCantidadUP
        '
        Me.TxtCantidadUP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCantidadUP.Location = New System.Drawing.Point(307, 349)
        Me.TxtCantidadUP.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCantidadUP.Name = "TxtCantidadUP"
        Me.TxtCantidadUP.Size = New System.Drawing.Size(109, 34)
        Me.TxtCantidadUP.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(65, 244)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(118, 28)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Descripción:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(52, 351)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(222, 28)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Unudades del Producto:"
        '
        'TxtDesEnt
        '
        Me.TxtDesEnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDesEnt.Location = New System.Drawing.Point(203, 233)
        Me.TxtDesEnt.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtDesEnt.Multiline = True
        Me.TxtDesEnt.Name = "TxtDesEnt"
        Me.TxtDesEnt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDesEnt.Size = New System.Drawing.Size(415, 83)
        Me.TxtDesEnt.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(100, 96)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 28)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Usuario:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 187)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(165, 28)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Fecha de Entrada:"
        '
        'PibEntradas
        '
        Me.PibEntradas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PibEntradas.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgEntrada
        Me.PibEntradas.Location = New System.Drawing.Point(633, 69)
        Me.PibEntradas.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.PibEntradas.Name = "PibEntradas"
        Me.PibEntradas.Size = New System.Drawing.Size(335, 310)
        Me.PibEntradas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PibEntradas.TabIndex = 29
        Me.PibEntradas.TabStop = False
        '
        'DtpFechaEntrada
        '
        Me.DtpFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaEntrada.Location = New System.Drawing.Point(203, 182)
        Me.DtpFechaEntrada.Name = "DtpFechaEntrada"
        Me.DtpFechaEntrada.Size = New System.Drawing.Size(391, 34)
        Me.DtpFechaEntrada.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(171, 565)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 28)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Buscar:"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBuscar.Location = New System.Drawing.Point(272, 565)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(1422, 34)
        Me.TxtBuscar.TabIndex = 36
        '
        'BtnAgregarE
        '
        Me.BtnAgregarE.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnAgregarE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnAgregarE.FlatAppearance.BorderSize = 0
        Me.BtnAgregarE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnAgregarE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnAgregarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarE.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnAgregarE.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgAgregar
        Me.BtnAgregarE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregarE.Location = New System.Drawing.Point(823, 493)
        Me.BtnAgregarE.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnAgregarE.Name = "BtnAgregarE"
        Me.BtnAgregarE.Size = New System.Drawing.Size(183, 55)
        Me.BtnAgregarE.TabIndex = 38
        Me.BtnAgregarE.Text = "Agregar"
        Me.BtnAgregarE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregarE.UseVisualStyleBackColor = True
        '
        'BtnLimpiarE
        '
        Me.BtnLimpiarE.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnLimpiarE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpiarE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnLimpiarE.FlatAppearance.BorderSize = 0
        Me.BtnLimpiarE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnLimpiarE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnLimpiarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiarE.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiarE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnLimpiarE.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgLimpiarCampos
        Me.BtnLimpiarE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiarE.Location = New System.Drawing.Point(1139, 493)
        Me.BtnLimpiarE.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnLimpiarE.Name = "BtnLimpiarE"
        Me.BtnLimpiarE.Size = New System.Drawing.Size(176, 55)
        Me.BtnLimpiarE.TabIndex = 39
        Me.BtnLimpiarE.Text = "Limpiar"
        Me.BtnLimpiarE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiarE.UseVisualStyleBackColor = True
        '
        'PanelCentral
        '
        Me.PanelCentral.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PanelCentral.Controls.Add(Me.BtnLimpiarE)
        Me.PanelCentral.Controls.Add(Me.BtnAgregarE)
        Me.PanelCentral.Controls.Add(Me.PictureBox2)
        Me.PanelCentral.Controls.Add(Me.PictureBox1)
        Me.PanelCentral.Controls.Add(Me.TxtBuscar)
        Me.PanelCentral.Controls.Add(Me.Label12)
        Me.PanelCentral.Controls.Add(Me.GopEntrada)
        Me.PanelCentral.Controls.Add(Me.GobDatosProdE)
        Me.PanelCentral.Controls.Add(Me.DataGridView1)
        Me.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCentral.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelCentral.Location = New System.Drawing.Point(0, 52)
        Me.PanelCentral.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelCentral.Name = "PanelCentral"
        Me.PanelCentral.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.PanelCentral.Size = New System.Drawing.Size(1733, 808)
        Me.PanelCentral.TabIndex = 17
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(239, 407)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(186, 34)
        Me.TxtPrecio.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(239, 456)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(186, 34)
        Me.TextBox2.TabIndex = 10
        '
        'DtpFechaVen
        '
        Me.DtpFechaVen.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaVen.Location = New System.Drawing.Point(239, 361)
        Me.DtpFechaVen.Name = "DtpFechaVen"
        Me.DtpFechaVen.Size = New System.Drawing.Size(334, 34)
        Me.DtpFechaVen.TabIndex = 11
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(100, 38)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 28)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Código:"
        '
        'TxtCodigoEntrada
        '
        Me.TxtCodigoEntrada.Enabled = False
        Me.TxtCodigoEntrada.Location = New System.Drawing.Point(203, 43)
        Me.TxtCodigoEntrada.Name = "TxtCodigoEntrada"
        Me.TxtCodigoEntrada.Size = New System.Drawing.Size(391, 34)
        Me.TxtCodigoEntrada.TabIndex = 32
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 142)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(194, 28)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Tipo de Movimiento:"
        '
        'RBtnEntrada
        '
        Me.RBtnEntrada.AutoSize = True
        Me.RBtnEntrada.Location = New System.Drawing.Point(225, 140)
        Me.RBtnEntrada.Name = "RBtnEntrada"
        Me.RBtnEntrada.Size = New System.Drawing.Size(100, 32)
        Me.RBtnEntrada.TabIndex = 34
        Me.RBtnEntrada.TabStop = True
        Me.RBtnEntrada.Text = "Entrada"
        Me.RBtnEntrada.UseVisualStyleBackColor = True
        '
        'RBtnSalida
        '
        Me.RBtnSalida.AutoSize = True
        Me.RBtnSalida.Location = New System.Drawing.Point(428, 144)
        Me.RBtnSalida.Name = "RBtnSalida"
        Me.RBtnSalida.Size = New System.Drawing.Size(86, 32)
        Me.RBtnSalida.TabIndex = 35
        Me.RBtnSalida.TabStop = True
        Me.RBtnSalida.Text = "Salida"
        Me.RBtnSalida.UseVisualStyleBackColor = True
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GobDatosProdE.ResumeLayout(False)
        Me.GobDatosProdE.PerformLayout()
        Me.GopEntrada.ResumeLayout(False)
        Me.GopEntrada.PerformLayout()
        CType(Me.PibEntradas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCentral.ResumeLayout(False)
        Me.PanelCentral.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanSuperior As Panel
    Friend WithEvents PibMinimizar As PictureBox
    Friend WithEvents PibCerrar As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PibRetornar As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GobDatosProdE As GroupBox
    Friend WithEvents TxtUnidadesDe As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CobProductosE As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNombreE As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtMarcaE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCategoriaE As TextBox
    Friend WithEvents TxtDescripcionE As TextBox
    Friend WithEvents GopEntrada As GroupBox
    Friend WithEvents TxtUsuarioEnt As TextBox
    Friend WithEvents TxtCantidadUP As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtDesEnt As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PibEntradas As PictureBox
    Friend WithEvents DtpFechaEntrada As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnAgregarE As Button
    Friend WithEvents BtnLimpiarE As Button
    Friend WithEvents PanelCentral As Panel
    Friend WithEvents DtpFechaVen As DateTimePicker
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents RBtnSalida As RadioButton
    Friend WithEvents RBtnEntrada As RadioButton
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtCodigoEntrada As TextBox
    Friend WithEvents Label15 As Label
End Class