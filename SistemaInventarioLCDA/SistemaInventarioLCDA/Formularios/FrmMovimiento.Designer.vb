<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanSuperior = New System.Windows.Forms.Panel()
        Me.PibMaximizar = New System.Windows.Forms.PictureBox()
        Me.PibRetornar = New System.Windows.Forms.PictureBox()
        Me.PibMinimizar = New System.Windows.Forms.PictureBox()
        Me.PibCerrar = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelCentral = New System.Windows.Forms.Panel()
        Me.DgvMovimientos = New System.Windows.Forms.DataGridView()
        Me.GbMovimientos = New System.Windows.Forms.GroupBox()
        Me.BtnLimpiarE = New System.Windows.Forms.Button()
        Me.BtnAgregarE = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GbMovimiento = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtCodigoMov = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtUsuarioMov = New System.Windows.Forms.TextBox()
        Me.TxtCantidadUP = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtDesMovimiento = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PibEntradas = New System.Windows.Forms.PictureBox()
        Me.DtpFechaMovimiento = New System.Windows.Forms.DateTimePicker()
        Me.GbDatosProd = New System.Windows.Forms.GroupBox()
        Me.TxtUnidadesProd = New System.Windows.Forms.TextBox()
        Me.TxtPrecioProd = New System.Windows.Forms.TextBox()
        Me.TxtUnidadesDe = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbProductos = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtMarcaProd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCategoriaProd = New System.Windows.Forms.TextBox()
        Me.TxtDescripcionProd = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PanSuperior.SuspendLayout()
        CType(Me.PibMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibRetornar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCentral.SuspendLayout()
        CType(Me.DgvMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbMovimiento.SuspendLayout()
        CType(Me.PibEntradas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbDatosProd.SuspendLayout()
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
        Me.PanSuperior.Margin = New System.Windows.Forms.Padding(4)
        Me.PanSuperior.Name = "PanSuperior"
        Me.PanSuperior.Size = New System.Drawing.Size(1733, 52)
        Me.PanSuperior.TabIndex = 2
        '
        'PibMaximizar
        '
        Me.PibMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PibMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PibMaximizar.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.btnMaximizar
        Me.PibMaximizar.Location = New System.Drawing.Point(1640, 9)
        Me.PibMaximizar.Name = "PibMaximizar"
        Me.PibMaximizar.Size = New System.Drawing.Size(39, 36)
        Me.PibMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PibMaximizar.TabIndex = 10
        Me.PibMaximizar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PibMaximizar, "Maximizar")
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
        Me.Label8.Location = New System.Drawing.Point(621, 6)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(554, 41)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Gestión de Movimientos de Productos"
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
        'PanelCentral
        '
        Me.PanelCentral.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PanelCentral.Controls.Add(Me.DgvMovimientos)
        Me.PanelCentral.Controls.Add(Me.GbMovimientos)
        Me.PanelCentral.Controls.Add(Me.BtnLimpiarE)
        Me.PanelCentral.Controls.Add(Me.BtnAgregarE)
        Me.PanelCentral.Controls.Add(Me.PictureBox2)
        Me.PanelCentral.Controls.Add(Me.PictureBox1)
        Me.PanelCentral.Controls.Add(Me.TxtBuscar)
        Me.PanelCentral.Controls.Add(Me.Label12)
        Me.PanelCentral.Controls.Add(Me.GbMovimiento)
        Me.PanelCentral.Controls.Add(Me.GbDatosProd)
        Me.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCentral.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelCentral.Location = New System.Drawing.Point(0, 52)
        Me.PanelCentral.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelCentral.Name = "PanelCentral"
        Me.PanelCentral.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.PanelCentral.Size = New System.Drawing.Size(1733, 829)
        Me.PanelCentral.TabIndex = 18
        '
        'DgvMovimientos
        '
        Me.DgvMovimientos.AllowUserToAddRows = False
        Me.DgvMovimientos.AllowUserToResizeColumns = False
        Me.DgvMovimientos.AllowUserToResizeRows = False
        Me.DgvMovimientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvMovimientos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.DgvMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvMovimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvMovimientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.DgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMovimientos.EnableHeadersVisualStyles = False
        Me.DgvMovimientos.GridColor = System.Drawing.Color.SaddleBrown
        Me.DgvMovimientos.Location = New System.Drawing.Point(46, 658)
        Me.DgvMovimientos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DgvMovimientos.Name = "DgvMovimientos"
        Me.DgvMovimientos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvMovimientos.RowHeadersDefaultCellStyle = DataGridViewCellStyle20
        Me.DgvMovimientos.RowHeadersVisible = False
        Me.DgvMovimientos.RowHeadersWidth = 51
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(181, Byte), Integer))
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Sienna
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White
        Me.DgvMovimientos.RowsDefaultCellStyle = DataGridViewCellStyle21
        Me.DgvMovimientos.RowTemplate.Height = 24
        Me.DgvMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvMovimientos.Size = New System.Drawing.Size(1642, 134)
        Me.DgvMovimientos.TabIndex = 42
        '
        'GbMovimientos
        '
        Me.GbMovimientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbMovimientos.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GbMovimientos.Location = New System.Drawing.Point(40, 626)
        Me.GbMovimientos.Name = "GbMovimientos"
        Me.GbMovimientos.Size = New System.Drawing.Size(1654, 171)
        Me.GbMovimientos.TabIndex = 43
        Me.GbMovimientos.TabStop = False
        Me.GbMovimientos.Text = "Movimientos Realizados: 0"
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
        Me.BtnLimpiarE.Location = New System.Drawing.Point(1246, 492)
        Me.BtnLimpiarE.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnLimpiarE.Name = "BtnLimpiarE"
        Me.BtnLimpiarE.Size = New System.Drawing.Size(176, 55)
        Me.BtnLimpiarE.TabIndex = 39
        Me.BtnLimpiarE.Text = "Limpiar"
        Me.BtnLimpiarE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiarE.UseVisualStyleBackColor = True
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
        Me.BtnAgregarE.Location = New System.Drawing.Point(930, 492)
        Me.BtnAgregarE.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnAgregarE.Name = "BtnAgregarE"
        Me.BtnAgregarE.Size = New System.Drawing.Size(183, 55)
        Me.BtnAgregarE.TabIndex = 38
        Me.BtnAgregarE.Text = "Agregar"
        Me.BtnAgregarE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregarE.UseVisualStyleBackColor = True
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
        'GbMovimiento
        '
        Me.GbMovimiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbMovimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GbMovimiento.Controls.Add(Me.ComboBox1)
        Me.GbMovimiento.Controls.Add(Me.Label16)
        Me.GbMovimiento.Controls.Add(Me.TxtCodigoMov)
        Me.GbMovimiento.Controls.Add(Me.Label15)
        Me.GbMovimiento.Controls.Add(Me.TxtUsuarioMov)
        Me.GbMovimiento.Controls.Add(Me.TxtCantidadUP)
        Me.GbMovimiento.Controls.Add(Me.Label14)
        Me.GbMovimiento.Controls.Add(Me.Label9)
        Me.GbMovimiento.Controls.Add(Me.TxtDesMovimiento)
        Me.GbMovimiento.Controls.Add(Me.Label13)
        Me.GbMovimiento.Controls.Add(Me.Label11)
        Me.GbMovimiento.Controls.Add(Me.PibEntradas)
        Me.GbMovimiento.Controls.Add(Me.DtpFechaMovimiento)
        Me.GbMovimiento.Location = New System.Drawing.Point(628, 37)
        Me.GbMovimiento.Name = "GbMovimiento"
        Me.GbMovimiento.Size = New System.Drawing.Size(1066, 441)
        Me.GbMovimiento.TabIndex = 33
        Me.GbMovimiento.TabStop = False
        Me.GbMovimiento.Text = "Datos del Movimiento"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(65, 142)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(194, 28)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Tipo de Movimiento:"
        '
        'TxtCodigoMov
        '
        Me.TxtCodigoMov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCodigoMov.Enabled = False
        Me.TxtCodigoMov.Location = New System.Drawing.Point(168, 34)
        Me.TxtCodigoMov.Name = "TxtCodigoMov"
        Me.TxtCodigoMov.Size = New System.Drawing.Size(160, 34)
        Me.TxtCodigoMov.TabIndex = 32
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(65, 35)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 28)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Código:"
        '
        'TxtUsuarioMov
        '
        Me.TxtUsuarioMov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUsuarioMov.Enabled = False
        Me.TxtUsuarioMov.Location = New System.Drawing.Point(168, 86)
        Me.TxtUsuarioMov.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtUsuarioMov.Name = "TxtUsuarioMov"
        Me.TxtUsuarioMov.Size = New System.Drawing.Size(413, 34)
        Me.TxtUsuarioMov.TabIndex = 9
        '
        'TxtCantidadUP
        '
        Me.TxtCantidadUP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCantidadUP.Location = New System.Drawing.Point(299, 263)
        Me.TxtCantidadUP.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCantidadUP.Name = "TxtCantidadUP"
        Me.TxtCantidadUP.Size = New System.Drawing.Size(130, 34)
        Me.TxtCantidadUP.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(65, 325)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(118, 28)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Descripción:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(65, 265)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(216, 28)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Unidades del Producto:"
        '
        'TxtDesMovimiento
        '
        Me.TxtDesMovimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDesMovimiento.Location = New System.Drawing.Point(203, 325)
        Me.TxtDesMovimiento.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtDesMovimiento.Multiline = True
        Me.TxtDesMovimiento.Name = "TxtDesMovimiento"
        Me.TxtDesMovimiento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDesMovimiento.Size = New System.Drawing.Size(401, 97)
        Me.TxtDesMovimiento.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(63, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 28)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Usuario:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(65, 204)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(210, 28)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Fecha del Movimiento:"
        '
        'PibEntradas
        '
        Me.PibEntradas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PibEntradas.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgEntrada
        Me.PibEntradas.Location = New System.Drawing.Point(676, 75)
        Me.PibEntradas.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.PibEntradas.Name = "PibEntradas"
        Me.PibEntradas.Size = New System.Drawing.Size(335, 310)
        Me.PibEntradas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PibEntradas.TabIndex = 29
        Me.PibEntradas.TabStop = False
        '
        'DtpFechaMovimiento
        '
        Me.DtpFechaMovimiento.Enabled = False
        Me.DtpFechaMovimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaMovimiento.Location = New System.Drawing.Point(297, 199)
        Me.DtpFechaMovimiento.Name = "DtpFechaMovimiento"
        Me.DtpFechaMovimiento.Size = New System.Drawing.Size(284, 34)
        Me.DtpFechaMovimiento.TabIndex = 10
        '
        'GbDatosProd
        '
        Me.GbDatosProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GbDatosProd.Controls.Add(Me.TxtUnidadesProd)
        Me.GbDatosProd.Controls.Add(Me.TxtPrecioProd)
        Me.GbDatosProd.Controls.Add(Me.TxtUnidadesDe)
        Me.GbDatosProd.Controls.Add(Me.Label6)
        Me.GbDatosProd.Controls.Add(Me.Label1)
        Me.GbDatosProd.Controls.Add(Me.CbProductos)
        Me.GbDatosProd.Controls.Add(Me.Label5)
        Me.GbDatosProd.Controls.Add(Me.Label3)
        Me.GbDatosProd.Controls.Add(Me.TxtMarcaProd)
        Me.GbDatosProd.Controls.Add(Me.Label4)
        Me.GbDatosProd.Controls.Add(Me.TxtCategoriaProd)
        Me.GbDatosProd.Controls.Add(Me.TxtDescripcionProd)
        Me.GbDatosProd.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbDatosProd.Location = New System.Drawing.Point(41, 37)
        Me.GbDatosProd.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.GbDatosProd.Name = "GbDatosProd"
        Me.GbDatosProd.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GbDatosProd.Size = New System.Drawing.Size(569, 506)
        Me.GbDatosProd.TabIndex = 32
        Me.GbDatosProd.TabStop = False
        Me.GbDatosProd.Text = "Datos del Producto"
        '
        'TxtUnidadesProd
        '
        Me.TxtUnidadesProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUnidadesProd.Enabled = False
        Me.TxtUnidadesProd.Location = New System.Drawing.Point(256, 426)
        Me.TxtUnidadesProd.Name = "TxtUnidadesProd"
        Me.TxtUnidadesProd.Size = New System.Drawing.Size(130, 34)
        Me.TxtUnidadesProd.TabIndex = 10
        '
        'TxtPrecioProd
        '
        Me.TxtPrecioProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPrecioProd.Enabled = False
        Me.TxtPrecioProd.Location = New System.Drawing.Point(256, 362)
        Me.TxtPrecioProd.Name = "TxtPrecioProd"
        Me.TxtPrecioProd.Size = New System.Drawing.Size(130, 34)
        Me.TxtPrecioProd.TabIndex = 9
        '
        'TxtUnidadesDe
        '
        Me.TxtUnidadesDe.AutoSize = True
        Me.TxtUnidadesDe.Location = New System.Drawing.Point(44, 429)
        Me.TxtUnidadesDe.Name = "TxtUnidadesDe"
        Me.TxtUnidadesDe.Size = New System.Drawing.Size(197, 28)
        Me.TxtUnidadesDe.TabIndex = 8
        Me.TxtUnidadesDe.Text = "Unidades Disponible:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(95, 362)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 28)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Precio Unitario:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Producto:"
        '
        'CbProductos
        '
        Me.CbProductos.FormattingEnabled = True
        Me.CbProductos.Items.AddRange(New Object() {"Producto 1", "Producto 2", "Producto 3"})
        Me.CbProductos.Location = New System.Drawing.Point(173, 65)
        Me.CbProductos.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.CbProductos.Name = "CbProductos"
        Me.CbProductos.Size = New System.Drawing.Size(340, 36)
        Me.CbProductos.TabIndex = 1
        Me.CbProductos.Tag = ""
        Me.CbProductos.Text = "Seleccione el producto..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 28)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Descripción:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Marca:"
        '
        'TxtMarcaProd
        '
        Me.TxtMarcaProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMarcaProd.Enabled = False
        Me.TxtMarcaProd.Location = New System.Drawing.Point(173, 127)
        Me.TxtMarcaProd.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtMarcaProd.Name = "TxtMarcaProd"
        Me.TxtMarcaProd.Size = New System.Drawing.Size(340, 34)
        Me.TxtMarcaProd.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 28)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Categoría:"
        '
        'TxtCategoriaProd
        '
        Me.TxtCategoriaProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCategoriaProd.Enabled = False
        Me.TxtCategoriaProd.Location = New System.Drawing.Point(173, 188)
        Me.TxtCategoriaProd.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtCategoriaProd.Name = "TxtCategoriaProd"
        Me.TxtCategoriaProd.Size = New System.Drawing.Size(340, 34)
        Me.TxtCategoriaProd.TabIndex = 4
        '
        'TxtDescripcionProd
        '
        Me.TxtDescripcionProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescripcionProd.Enabled = False
        Me.TxtDescripcionProd.Location = New System.Drawing.Point(173, 250)
        Me.TxtDescripcionProd.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtDescripcionProd.Multiline = True
        Me.TxtDescripcionProd.Name = "TxtDescripcionProd"
        Me.TxtDescripcionProd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDescripcionProd.Size = New System.Drawing.Size(360, 83)
        Me.TxtDescripcionProd.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Entrada", "Salida"})
        Me.ComboBox1.Location = New System.Drawing.Point(281, 139)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(300, 36)
        Me.ComboBox1.TabIndex = 34
        '
        'FrmMovimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1733, 881)
        Me.Controls.Add(Me.PanelCentral)
        Me.Controls.Add(Me.PanSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMovimiento"
        Me.Text = "FrmEntradas"
        Me.PanSuperior.ResumeLayout(False)
        Me.PanSuperior.PerformLayout()
        CType(Me.PibMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibRetornar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCentral.ResumeLayout(False)
        Me.PanelCentral.PerformLayout()
        CType(Me.DgvMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbMovimiento.ResumeLayout(False)
        Me.GbMovimiento.PerformLayout()
        CType(Me.PibEntradas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbDatosProd.ResumeLayout(False)
        Me.GbDatosProd.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanSuperior As Panel
    Friend WithEvents PibMinimizar As PictureBox
    Friend WithEvents PibCerrar As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PibRetornar As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PibMaximizar As PictureBox
    Friend WithEvents PanelCentral As Panel
    Friend WithEvents DgvMovimientos As DataGridView
    Friend WithEvents GbMovimientos As GroupBox
    Friend WithEvents BtnLimpiarE As Button
    Friend WithEvents BtnAgregarE As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GbMovimiento As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtCodigoMov As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtUsuarioMov As TextBox
    Friend WithEvents TxtCantidadUP As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtDesMovimiento As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PibEntradas As PictureBox
    Friend WithEvents DtpFechaMovimiento As DateTimePicker
    Friend WithEvents GbDatosProd As GroupBox
    Friend WithEvents TxtUnidadesProd As TextBox
    Friend WithEvents TxtPrecioProd As TextBox
    Friend WithEvents TxtUnidadesDe As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CbProductos As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtMarcaProd As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCategoriaProd As TextBox
    Friend WithEvents TxtDescripcionProd As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
