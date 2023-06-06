<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMarcas
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMarcas))
        Me.PanSuperior = New System.Windows.Forms.Panel()
        Me.PibMaximizar = New System.Windows.Forms.PictureBox()
        Me.PibRetornar = New System.Windows.Forms.PictureBox()
        Me.PibMinimizar = New System.Windows.Forms.PictureBox()
        Me.PibCerrar = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PanelCentral = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnBuscarMarcas = New System.Windows.Forms.Button()
        Me.GbMarcas = New System.Windows.Forms.GroupBox()
        Me.DgvMarcas = New System.Windows.Forms.DataGridView()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.BtnAgregarM = New System.Windows.Forms.Button()
        Me.BtnEliminarP = New System.Windows.Forms.Button()
        Me.GobDatosMarca = New System.Windows.Forms.GroupBox()
        Me.TxtNomMarca = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PibProductos = New System.Windows.Forms.PictureBox()
        Me.TxtDescMarca = New System.Windows.Forms.TextBox()
        Me.TxtCodMarca = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnEditarP = New System.Windows.Forms.Button()
        Me.BtnLimpiarP = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanSuperior.SuspendLayout()
        CType(Me.PibMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibRetornar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCentral.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbMarcas.SuspendLayout()
        CType(Me.DgvMarcas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GobDatosMarca.SuspendLayout()
        CType(Me.PibProductos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanSuperior.TabIndex = 4
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
        Me.PibMaximizar.TabIndex = 11
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
        Me.PibRetornar.TabIndex = 10
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
        Me.Label8.Location = New System.Drawing.Point(711, 6)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(276, 41)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Gestión de Marcas"
        '
        'PanelCentral
        '
        Me.PanelCentral.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PanelCentral.Controls.Add(Me.PictureBox1)
        Me.PanelCentral.Controls.Add(Me.BtnBuscarMarcas)
        Me.PanelCentral.Controls.Add(Me.GbMarcas)
        Me.PanelCentral.Controls.Add(Me.TxtBuscar)
        Me.PanelCentral.Controls.Add(Me.BtnAgregarM)
        Me.PanelCentral.Controls.Add(Me.BtnEliminarP)
        Me.PanelCentral.Controls.Add(Me.GobDatosMarca)
        Me.PanelCentral.Controls.Add(Me.BtnEditarP)
        Me.PanelCentral.Controls.Add(Me.BtnLimpiarP)
        Me.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCentral.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelCentral.Location = New System.Drawing.Point(0, 52)
        Me.PanelCentral.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelCentral.Name = "PanelCentral"
        Me.PanelCentral.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.PanelCentral.Size = New System.Drawing.Size(1733, 798)
        Me.PanelCentral.TabIndex = 19
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.recargar
        Me.PictureBox1.Location = New System.Drawing.Point(1639, 477)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Actualizar Tabla")
        '
        'BtnBuscarMarcas
        '
        Me.BtnBuscarMarcas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBuscarMarcas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscarMarcas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnBuscarMarcas.FlatAppearance.BorderSize = 0
        Me.BtnBuscarMarcas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnBuscarMarcas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnBuscarMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarMarcas.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarMarcas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnBuscarMarcas.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgBuscar
        Me.BtnBuscarMarcas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarMarcas.Location = New System.Drawing.Point(1450, 477)
        Me.BtnBuscarMarcas.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnBuscarMarcas.Name = "BtnBuscarMarcas"
        Me.BtnBuscarMarcas.Size = New System.Drawing.Size(183, 55)
        Me.BtnBuscarMarcas.TabIndex = 51
        Me.BtnBuscarMarcas.Text = "Buscar"
        Me.BtnBuscarMarcas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscarMarcas.UseVisualStyleBackColor = True
        '
        'GbMarcas
        '
        Me.GbMarcas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbMarcas.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GbMarcas.Controls.Add(Me.DgvMarcas)
        Me.GbMarcas.Location = New System.Drawing.Point(41, 537)
        Me.GbMarcas.Name = "GbMarcas"
        Me.GbMarcas.Size = New System.Drawing.Size(1653, 218)
        Me.GbMarcas.TabIndex = 50
        Me.GbMarcas.TabStop = False
        Me.GbMarcas.Text = "Marcas Registradas: 0"
        '
        'DgvMarcas
        '
        Me.DgvMarcas.AllowUserToAddRows = False
        Me.DgvMarcas.AllowUserToResizeColumns = False
        Me.DgvMarcas.AllowUserToResizeRows = False
        Me.DgvMarcas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvMarcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvMarcas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.DgvMarcas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvMarcas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvMarcas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMarcas.EnableHeadersVisualStyles = False
        Me.DgvMarcas.GridColor = System.Drawing.Color.SaddleBrown
        Me.DgvMarcas.Location = New System.Drawing.Point(5, 32)
        Me.DgvMarcas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DgvMarcas.Name = "DgvMarcas"
        Me.DgvMarcas.ReadOnly = True
        Me.DgvMarcas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvMarcas.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvMarcas.RowHeadersVisible = False
        Me.DgvMarcas.RowHeadersWidth = 51
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(181, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Sienna
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DgvMarcas.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvMarcas.RowTemplate.Height = 24
        Me.DgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvMarcas.Size = New System.Drawing.Size(1642, 181)
        Me.DgvMarcas.TabIndex = 49
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBuscar.Location = New System.Drawing.Point(41, 487)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(1403, 34)
        Me.TxtBuscar.TabIndex = 47
        '
        'BtnAgregarM
        '
        Me.BtnAgregarM.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnAgregarM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnAgregarM.FlatAppearance.BorderSize = 0
        Me.BtnAgregarM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnAgregarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnAgregarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarM.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnAgregarM.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgAgregar
        Me.BtnAgregarM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregarM.Location = New System.Drawing.Point(407, 410)
        Me.BtnAgregarM.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnAgregarM.Name = "BtnAgregarM"
        Me.BtnAgregarM.Size = New System.Drawing.Size(183, 55)
        Me.BtnAgregarM.TabIndex = 4
        Me.BtnAgregarM.Text = "Agregar"
        Me.BtnAgregarM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregarM.UseVisualStyleBackColor = True
        '
        'BtnEliminarP
        '
        Me.BtnEliminarP.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnEliminarP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminarP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnEliminarP.FlatAppearance.BorderSize = 0
        Me.BtnEliminarP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnEliminarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnEliminarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarP.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnEliminarP.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgEliminar
        Me.BtnEliminarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarP.Location = New System.Drawing.Point(1134, 410)
        Me.BtnEliminarP.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnEliminarP.Name = "BtnEliminarP"
        Me.BtnEliminarP.Size = New System.Drawing.Size(191, 55)
        Me.BtnEliminarP.TabIndex = 7
        Me.BtnEliminarP.Text = "Eliminar"
        Me.BtnEliminarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminarP.UseVisualStyleBackColor = True
        '
        'GobDatosMarca
        '
        Me.GobDatosMarca.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GobDatosMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GobDatosMarca.Controls.Add(Me.TxtNomMarca)
        Me.GobDatosMarca.Controls.Add(Me.Label3)
        Me.GobDatosMarca.Controls.Add(Me.PibProductos)
        Me.GobDatosMarca.Controls.Add(Me.TxtDescMarca)
        Me.GobDatosMarca.Controls.Add(Me.TxtCodMarca)
        Me.GobDatosMarca.Controls.Add(Me.Label2)
        Me.GobDatosMarca.Controls.Add(Me.Label1)
        Me.GobDatosMarca.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GobDatosMarca.Location = New System.Drawing.Point(41, 37)
        Me.GobDatosMarca.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.GobDatosMarca.Name = "GobDatosMarca"
        Me.GobDatosMarca.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GobDatosMarca.Size = New System.Drawing.Size(1653, 357)
        Me.GobDatosMarca.TabIndex = 5
        Me.GobDatosMarca.TabStop = False
        Me.GobDatosMarca.Text = "Datos Generales de la Marca"
        '
        'TxtNomMarca
        '
        Me.TxtNomMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNomMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNomMarca.Location = New System.Drawing.Point(171, 122)
        Me.TxtNomMarca.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtNomMarca.Name = "TxtNomMarca"
        Me.TxtNomMarca.Size = New System.Drawing.Size(430, 34)
        Me.TxtNomMarca.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 28)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Nombre:"
        '
        'PibProductos
        '
        Me.PibProductos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PibProductos.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.pibMarcas
        Me.PibProductos.Location = New System.Drawing.Point(1221, 30)
        Me.PibProductos.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.PibProductos.Name = "PibProductos"
        Me.PibProductos.Size = New System.Drawing.Size(335, 310)
        Me.PibProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PibProductos.TabIndex = 30
        Me.PibProductos.TabStop = False
        '
        'TxtDescMarca
        '
        Me.TxtDescMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescMarca.Location = New System.Drawing.Point(171, 185)
        Me.TxtDescMarca.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtDescMarca.Multiline = True
        Me.TxtDescMarca.Name = "TxtDescMarca"
        Me.TxtDescMarca.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDescMarca.Size = New System.Drawing.Size(868, 140)
        Me.TxtDescMarca.TabIndex = 3
        '
        'TxtCodMarca
        '
        Me.TxtCodMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCodMarca.Enabled = False
        Me.TxtCodMarca.Location = New System.Drawing.Point(171, 60)
        Me.TxtCodMarca.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtCodMarca.Name = "TxtCodMarca"
        Me.TxtCodMarca.Size = New System.Drawing.Size(145, 34)
        Me.TxtCodMarca.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'BtnEditarP
        '
        Me.BtnEditarP.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnEditarP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditarP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnEditarP.FlatAppearance.BorderSize = 0
        Me.BtnEditarP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnEditarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnEditarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditarP.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditarP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnEditarP.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgEditar
        Me.BtnEditarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditarP.Location = New System.Drawing.Point(914, 410)
        Me.BtnEditarP.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnEditarP.Name = "BtnEditarP"
        Me.BtnEditarP.Size = New System.Drawing.Size(157, 55)
        Me.BtnEditarP.TabIndex = 6
        Me.BtnEditarP.Text = "Editar"
        Me.BtnEditarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditarP.UseVisualStyleBackColor = True
        '
        'BtnLimpiarP
        '
        Me.BtnLimpiarP.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnLimpiarP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpiarP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnLimpiarP.FlatAppearance.BorderSize = 0
        Me.BtnLimpiarP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnLimpiarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnLimpiarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiarP.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiarP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnLimpiarP.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgLimpiarCampos
        Me.BtnLimpiarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiarP.Location = New System.Drawing.Point(660, 410)
        Me.BtnLimpiarP.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnLimpiarP.Name = "BtnLimpiarP"
        Me.BtnLimpiarP.Size = New System.Drawing.Size(176, 55)
        Me.BtnLimpiarP.TabIndex = 5
        Me.BtnLimpiarP.Text = "Limpiar"
        Me.BtnLimpiarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiarP.UseVisualStyleBackColor = True
        '
        'FrmMarcas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1733, 850)
        Me.Controls.Add(Me.PanelCentral)
        Me.Controls.Add(Me.PanSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMarcas"
        Me.Text = "Gestión de Marcas"
        Me.PanSuperior.ResumeLayout(False)
        Me.PanSuperior.PerformLayout()
        CType(Me.PibMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibRetornar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCentral.ResumeLayout(False)
        Me.PanelCentral.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbMarcas.ResumeLayout(False)
        CType(Me.DgvMarcas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GobDatosMarca.ResumeLayout(False)
        Me.GobDatosMarca.PerformLayout()
        CType(Me.PibProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanSuperior As Panel
    Friend WithEvents PibRetornar As PictureBox
    Friend WithEvents PibMinimizar As PictureBox
    Friend WithEvents PibCerrar As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PanelCentral As Panel
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents BtnAgregarM As Button
    Friend WithEvents BtnEliminarP As Button
    Friend WithEvents GobDatosMarca As GroupBox
    Friend WithEvents TxtNomMarca As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PibProductos As PictureBox
    Friend WithEvents TxtDescMarca As TextBox
    Friend WithEvents TxtCodMarca As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEditarP As Button
    Friend WithEvents BtnLimpiarP As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PibMaximizar As PictureBox
    Friend WithEvents GbMarcas As GroupBox
    Friend WithEvents DgvMarcas As DataGridView
    Friend WithEvents BtnBuscarMarcas As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
