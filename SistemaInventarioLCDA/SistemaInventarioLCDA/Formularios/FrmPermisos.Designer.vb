<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPermiso
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
        Me.PanSuperior = New System.Windows.Forms.Panel()
        Me.PibMaximizar = New System.Windows.Forms.PictureBox()
        Me.PibRetornar = New System.Windows.Forms.PictureBox()
        Me.PibMinimizar = New System.Windows.Forms.PictureBox()
        Me.PibCerrar = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanelCentral = New System.Windows.Forms.Panel()
        Me.BtnBuscarPermiso = New System.Windows.Forms.Button()
        Me.DgvPermisos = New System.Windows.Forms.DataGridView()
        Me.GbPermisos = New System.Windows.Forms.GroupBox()
        Me.TxtBuscarPermiso = New System.Windows.Forms.TextBox()
        Me.BtnAgregarPermiso = New System.Windows.Forms.Button()
        Me.BtnEliminarPermiso = New System.Windows.Forms.Button()
        Me.BtnEditarPermiso = New System.Windows.Forms.Button()
        Me.BtnLimpiarPermiso = New System.Windows.Forms.Button()
        Me.GobDatosProd = New System.Windows.Forms.GroupBox()
        Me.TxtNomPermiso = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PibProductos = New System.Windows.Forms.PictureBox()
        Me.TxtDescPerm = New System.Windows.Forms.TextBox()
        Me.TxtIdPermiso = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DbLaCasaDelArteDataSet1 = New SistemaInventarioLCDA.DBLaCasaDelArteDataSet()
        Me.PanSuperior.SuspendLayout()
        CType(Me.PibMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibRetornar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCentral.SuspendLayout()
        CType(Me.DgvPermisos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GobDatosProd.SuspendLayout()
        CType(Me.PibProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbLaCasaDelArteDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanSuperior.TabIndex = 3
        '
        'PibMaximizar
        '
        Me.PibMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PibMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PibMaximizar.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.btnMaximizar
        Me.PibMaximizar.Location = New System.Drawing.Point(1640, 8)
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
        Me.PibRetornar.Location = New System.Drawing.Point(3, 3)
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
        Me.Label8.Location = New System.Drawing.Point(661, 6)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(427, 41)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Gestión de Permisos de Roles"
        '
        'PanelCentral
        '
        Me.PanelCentral.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PanelCentral.Controls.Add(Me.BtnBuscarPermiso)
        Me.PanelCentral.Controls.Add(Me.DgvPermisos)
        Me.PanelCentral.Controls.Add(Me.GbPermisos)
        Me.PanelCentral.Controls.Add(Me.TxtBuscarPermiso)
        Me.PanelCentral.Controls.Add(Me.BtnAgregarPermiso)
        Me.PanelCentral.Controls.Add(Me.BtnEliminarPermiso)
        Me.PanelCentral.Controls.Add(Me.BtnEditarPermiso)
        Me.PanelCentral.Controls.Add(Me.BtnLimpiarPermiso)
        Me.PanelCentral.Controls.Add(Me.GobDatosProd)
        Me.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCentral.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelCentral.Location = New System.Drawing.Point(0, 52)
        Me.PanelCentral.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelCentral.Name = "PanelCentral"
        Me.PanelCentral.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.PanelCentral.Size = New System.Drawing.Size(1733, 798)
        Me.PanelCentral.TabIndex = 19
        '
        'BtnBuscarPermiso
        '
        Me.BtnBuscarPermiso.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBuscarPermiso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscarPermiso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnBuscarPermiso.FlatAppearance.BorderSize = 0
        Me.BtnBuscarPermiso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnBuscarPermiso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnBuscarPermiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarPermiso.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarPermiso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnBuscarPermiso.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgBuscar
        Me.BtnBuscarPermiso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarPermiso.Location = New System.Drawing.Point(1512, 476)
        Me.BtnBuscarPermiso.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnBuscarPermiso.Name = "BtnBuscarPermiso"
        Me.BtnBuscarPermiso.Size = New System.Drawing.Size(183, 55)
        Me.BtnBuscarPermiso.TabIndex = 47
        Me.BtnBuscarPermiso.Text = "Buscar"
        Me.BtnBuscarPermiso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscarPermiso.UseVisualStyleBackColor = True
        '
        'DgvPermisos
        '
        Me.DgvPermisos.AllowUserToAddRows = False
        Me.DgvPermisos.AllowUserToResizeColumns = False
        Me.DgvPermisos.AllowUserToResizeRows = False
        Me.DgvPermisos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvPermisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPermisos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.DgvPermisos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvPermisos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvPermisos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPermisos.EnableHeadersVisualStyles = False
        Me.DgvPermisos.GridColor = System.Drawing.Color.SaddleBrown
        Me.DgvPermisos.Location = New System.Drawing.Point(47, 575)
        Me.DgvPermisos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DgvPermisos.Name = "DgvPermisos"
        Me.DgvPermisos.ReadOnly = True
        Me.DgvPermisos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvPermisos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvPermisos.RowHeadersVisible = False
        Me.DgvPermisos.RowHeadersWidth = 51
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(181, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Sienna
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DgvPermisos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvPermisos.RowTemplate.Height = 24
        Me.DgvPermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPermisos.Size = New System.Drawing.Size(1642, 188)
        Me.DgvPermisos.TabIndex = 9
        '
        'GbPermisos
        '
        Me.GbPermisos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbPermisos.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GbPermisos.Location = New System.Drawing.Point(41, 543)
        Me.GbPermisos.Name = "GbPermisos"
        Me.GbPermisos.Size = New System.Drawing.Size(1654, 225)
        Me.GbPermisos.TabIndex = 46
        Me.GbPermisos.TabStop = False
        Me.GbPermisos.Text = "Permisos Registrados: 0"
        '
        'TxtBuscarPermiso
        '
        Me.TxtBuscarPermiso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBuscarPermiso.Location = New System.Drawing.Point(41, 486)
        Me.TxtBuscarPermiso.Name = "TxtBuscarPermiso"
        Me.TxtBuscarPermiso.Size = New System.Drawing.Size(1422, 34)
        Me.TxtBuscarPermiso.TabIndex = 8
        '
        'BtnAgregarPermiso
        '
        Me.BtnAgregarPermiso.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnAgregarPermiso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarPermiso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnAgregarPermiso.FlatAppearance.BorderSize = 0
        Me.BtnAgregarPermiso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnAgregarPermiso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnAgregarPermiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarPermiso.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarPermiso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnAgregarPermiso.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgAgregar
        Me.BtnAgregarPermiso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregarPermiso.Location = New System.Drawing.Point(407, 410)
        Me.BtnAgregarPermiso.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnAgregarPermiso.Name = "BtnAgregarPermiso"
        Me.BtnAgregarPermiso.Size = New System.Drawing.Size(183, 55)
        Me.BtnAgregarPermiso.TabIndex = 3
        Me.BtnAgregarPermiso.Text = "Agregar"
        Me.BtnAgregarPermiso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregarPermiso.UseVisualStyleBackColor = True
        '
        'BtnEliminarPermiso
        '
        Me.BtnEliminarPermiso.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnEliminarPermiso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminarPermiso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnEliminarPermiso.FlatAppearance.BorderSize = 0
        Me.BtnEliminarPermiso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnEliminarPermiso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnEliminarPermiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarPermiso.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarPermiso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnEliminarPermiso.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgEliminar
        Me.BtnEliminarPermiso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarPermiso.Location = New System.Drawing.Point(1134, 410)
        Me.BtnEliminarPermiso.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnEliminarPermiso.Name = "BtnEliminarPermiso"
        Me.BtnEliminarPermiso.Size = New System.Drawing.Size(191, 55)
        Me.BtnEliminarPermiso.TabIndex = 6
        Me.BtnEliminarPermiso.Text = "Eliminar"
        Me.BtnEliminarPermiso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminarPermiso.UseVisualStyleBackColor = True
        '
        'BtnEditarPermiso
        '
        Me.BtnEditarPermiso.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnEditarPermiso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditarPermiso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnEditarPermiso.FlatAppearance.BorderSize = 0
        Me.BtnEditarPermiso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnEditarPermiso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnEditarPermiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditarPermiso.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditarPermiso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnEditarPermiso.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgEditar
        Me.BtnEditarPermiso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditarPermiso.Location = New System.Drawing.Point(914, 410)
        Me.BtnEditarPermiso.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnEditarPermiso.Name = "BtnEditarPermiso"
        Me.BtnEditarPermiso.Size = New System.Drawing.Size(157, 55)
        Me.BtnEditarPermiso.TabIndex = 5
        Me.BtnEditarPermiso.Text = "Editar"
        Me.BtnEditarPermiso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditarPermiso.UseVisualStyleBackColor = True
        '
        'BtnLimpiarPermiso
        '
        Me.BtnLimpiarPermiso.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnLimpiarPermiso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpiarPermiso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnLimpiarPermiso.FlatAppearance.BorderSize = 0
        Me.BtnLimpiarPermiso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnLimpiarPermiso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnLimpiarPermiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiarPermiso.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiarPermiso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnLimpiarPermiso.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgLimpiarCampos
        Me.BtnLimpiarPermiso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiarPermiso.Location = New System.Drawing.Point(660, 410)
        Me.BtnLimpiarPermiso.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnLimpiarPermiso.Name = "BtnLimpiarPermiso"
        Me.BtnLimpiarPermiso.Size = New System.Drawing.Size(176, 55)
        Me.BtnLimpiarPermiso.TabIndex = 4
        Me.BtnLimpiarPermiso.Text = "Limpiar"
        Me.BtnLimpiarPermiso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiarPermiso.UseVisualStyleBackColor = True
        '
        'GobDatosProd
        '
        Me.GobDatosProd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GobDatosProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GobDatosProd.Controls.Add(Me.TxtNomPermiso)
        Me.GobDatosProd.Controls.Add(Me.Label3)
        Me.GobDatosProd.Controls.Add(Me.PibProductos)
        Me.GobDatosProd.Controls.Add(Me.TxtDescPerm)
        Me.GobDatosProd.Controls.Add(Me.TxtIdPermiso)
        Me.GobDatosProd.Controls.Add(Me.Label2)
        Me.GobDatosProd.Controls.Add(Me.Label1)
        Me.GobDatosProd.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GobDatosProd.Location = New System.Drawing.Point(41, 37)
        Me.GobDatosProd.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.GobDatosProd.Name = "GobDatosProd"
        Me.GobDatosProd.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GobDatosProd.Size = New System.Drawing.Size(1653, 357)
        Me.GobDatosProd.TabIndex = 5
        Me.GobDatosProd.TabStop = False
        Me.GobDatosProd.Text = "Datos Generales del Permiso"
        '
        'TxtNomPermiso
        '
        Me.TxtNomPermiso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNomPermiso.Location = New System.Drawing.Point(159, 134)
        Me.TxtNomPermiso.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtNomPermiso.Name = "TxtNomPermiso"
        Me.TxtNomPermiso.Size = New System.Drawing.Size(247, 34)
        Me.TxtNomPermiso.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 28)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Permiso:"
        '
        'PibProductos
        '
        Me.PibProductos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PibProductos.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.PibPermiso
        Me.PibProductos.Location = New System.Drawing.Point(1221, 30)
        Me.PibProductos.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.PibProductos.Name = "PibProductos"
        Me.PibProductos.Size = New System.Drawing.Size(335, 310)
        Me.PibProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PibProductos.TabIndex = 29
        Me.PibProductos.TabStop = False
        '
        'TxtDescPerm
        '
        Me.TxtDescPerm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescPerm.Location = New System.Drawing.Point(64, 239)
        Me.TxtDescPerm.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtDescPerm.Multiline = True
        Me.TxtDescPerm.Name = "TxtDescPerm"
        Me.TxtDescPerm.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDescPerm.Size = New System.Drawing.Size(792, 85)
        Me.TxtDescPerm.TabIndex = 2
        '
        'TxtIdPermiso
        '
        Me.TxtIdPermiso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIdPermiso.Enabled = False
        Me.TxtIdPermiso.Location = New System.Drawing.Point(159, 58)
        Me.TxtIdPermiso.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtIdPermiso.Name = "TxtIdPermiso"
        Me.TxtIdPermiso.Size = New System.Drawing.Size(247, 34)
        Me.TxtIdPermiso.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción del Permiso:"
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
        'DbLaCasaDelArteDataSet1
        '
        Me.DbLaCasaDelArteDataSet1.DataSetName = "DBLaCasaDelArteDataSet"
        Me.DbLaCasaDelArteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FrmPermiso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1733, 850)
        Me.Controls.Add(Me.PanelCentral)
        Me.Controls.Add(Me.PanSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPermiso"
        Me.Text = "FrmOpciones"
        Me.PanSuperior.ResumeLayout(False)
        Me.PanSuperior.PerformLayout()
        CType(Me.PibMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibRetornar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCentral.ResumeLayout(False)
        Me.PanelCentral.PerformLayout()
        CType(Me.DgvPermisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GobDatosProd.ResumeLayout(False)
        Me.GobDatosProd.PerformLayout()
        CType(Me.PibProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbLaCasaDelArteDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanSuperior As Panel
    Friend WithEvents PibRetornar As PictureBox
    Friend WithEvents PibMinimizar As PictureBox
    Friend WithEvents PibCerrar As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PibMaximizar As PictureBox
    Friend WithEvents PanelCentral As Panel
    Friend WithEvents DgvPermisos As DataGridView
    Friend WithEvents GbPermisos As GroupBox
    Friend WithEvents TxtBuscarPermiso As TextBox
    Friend WithEvents BtnAgregarPermiso As Button
    Friend WithEvents BtnEliminarPermiso As Button
    Friend WithEvents BtnEditarPermiso As Button
    Friend WithEvents BtnLimpiarPermiso As Button
    Friend WithEvents GobDatosProd As GroupBox
    Friend WithEvents TxtNomPermiso As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PibProductos As PictureBox
    Friend WithEvents TxtDescPerm As TextBox
    Friend WithEvents TxtIdPermiso As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DbLaCasaDelArteDataSet1 As DBLaCasaDelArteDataSet
    Friend WithEvents BtnBuscarPermiso As Button
End Class
