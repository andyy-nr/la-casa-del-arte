<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRoles
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRoles))
        Me.PanSuperior = New System.Windows.Forms.Panel()
        Me.PibMaximizar = New System.Windows.Forms.PictureBox()
        Me.PibRetornar = New System.Windows.Forms.PictureBox()
        Me.PibMinimizar = New System.Windows.Forms.PictureBox()
        Me.PibCerrar = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PanelCentral = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnBuscarRol = New System.Windows.Forms.Button()
        Me.DgvRoles = New System.Windows.Forms.DataGridView()
        Me.GbRoles = New System.Windows.Forms.GroupBox()
        Me.TxtBuscarRol = New System.Windows.Forms.TextBox()
        Me.BtnAgregarRol = New System.Windows.Forms.Button()
        Me.BtnEliminarRol = New System.Windows.Forms.Button()
        Me.BtnEditarRol = New System.Windows.Forms.Button()
        Me.BtnLimpiarRol = New System.Windows.Forms.Button()
        Me.GobDatosProd = New System.Windows.Forms.GroupBox()
        Me.ClbPermisos = New System.Windows.Forms.CheckedListBox()
        Me.TxtIdRol = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PibProductos = New System.Windows.Forms.PictureBox()
        Me.TxtDescRol = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNomRol = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanSuperior.SuspendLayout()
        CType(Me.PibMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibRetornar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCentral.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GobDatosProd.SuspendLayout()
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
        Me.PanSuperior.TabIndex = 2
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
        Me.Label8.Size = New System.Drawing.Size(410, 41)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Gestión de Roles de Usuario"
        '
        'PanelCentral
        '
        Me.PanelCentral.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PanelCentral.Controls.Add(Me.PictureBox1)
        Me.PanelCentral.Controls.Add(Me.BtnBuscarRol)
        Me.PanelCentral.Controls.Add(Me.DgvRoles)
        Me.PanelCentral.Controls.Add(Me.GbRoles)
        Me.PanelCentral.Controls.Add(Me.TxtBuscarRol)
        Me.PanelCentral.Controls.Add(Me.BtnAgregarRol)
        Me.PanelCentral.Controls.Add(Me.BtnEliminarRol)
        Me.PanelCentral.Controls.Add(Me.BtnEditarRol)
        Me.PanelCentral.Controls.Add(Me.BtnLimpiarRol)
        Me.PanelCentral.Controls.Add(Me.GobDatosProd)
        Me.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCentral.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelCentral.Location = New System.Drawing.Point(0, 52)
        Me.PanelCentral.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelCentral.Name = "PanelCentral"
        Me.PanelCentral.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.PanelCentral.Size = New System.Drawing.Size(1733, 798)
        Me.PanelCentral.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.recargar
        Me.PictureBox1.Location = New System.Drawing.Point(1639, 479)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Actualizar Tabla")
        '
        'BtnBuscarRol
        '
        Me.BtnBuscarRol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBuscarRol.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscarRol.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnBuscarRol.FlatAppearance.BorderSize = 0
        Me.BtnBuscarRol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnBuscarRol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnBuscarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarRol.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarRol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnBuscarRol.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgBuscar
        Me.BtnBuscarRol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarRol.Location = New System.Drawing.Point(1451, 479)
        Me.BtnBuscarRol.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnBuscarRol.Name = "BtnBuscarRol"
        Me.BtnBuscarRol.Size = New System.Drawing.Size(183, 55)
        Me.BtnBuscarRol.TabIndex = 48
        Me.BtnBuscarRol.Text = "Buscar"
        Me.BtnBuscarRol.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscarRol.UseVisualStyleBackColor = True
        '
        'DgvRoles
        '
        Me.DgvRoles.AllowUserToAddRows = False
        Me.DgvRoles.AllowUserToResizeColumns = False
        Me.DgvRoles.AllowUserToResizeRows = False
        Me.DgvRoles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvRoles.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.DgvRoles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvRoles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvRoles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRoles.EnableHeadersVisualStyles = False
        Me.DgvRoles.GridColor = System.Drawing.Color.SaddleBrown
        Me.DgvRoles.Location = New System.Drawing.Point(47, 575)
        Me.DgvRoles.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DgvRoles.Name = "DgvRoles"
        Me.DgvRoles.ReadOnly = True
        Me.DgvRoles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvRoles.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvRoles.RowHeadersVisible = False
        Me.DgvRoles.RowHeadersWidth = 51
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(181, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Sienna
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DgvRoles.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvRoles.RowTemplate.Height = 24
        Me.DgvRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvRoles.Size = New System.Drawing.Size(1642, 187)
        Me.DgvRoles.TabIndex = 45
        '
        'GbRoles
        '
        Me.GbRoles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbRoles.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GbRoles.Location = New System.Drawing.Point(41, 543)
        Me.GbRoles.Name = "GbRoles"
        Me.GbRoles.Size = New System.Drawing.Size(1654, 224)
        Me.GbRoles.TabIndex = 46
        Me.GbRoles.TabStop = False
        Me.GbRoles.Text = "Roles Registrados: 0"
        '
        'TxtBuscarRol
        '
        Me.TxtBuscarRol.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBuscarRol.Location = New System.Drawing.Point(41, 489)
        Me.TxtBuscarRol.Name = "TxtBuscarRol"
        Me.TxtBuscarRol.Size = New System.Drawing.Size(1404, 34)
        Me.TxtBuscarRol.TabIndex = 43
        '
        'BtnAgregarRol
        '
        Me.BtnAgregarRol.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnAgregarRol.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarRol.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnAgregarRol.FlatAppearance.BorderSize = 0
        Me.BtnAgregarRol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnAgregarRol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnAgregarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarRol.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarRol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnAgregarRol.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgAgregar
        Me.BtnAgregarRol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregarRol.Location = New System.Drawing.Point(407, 410)
        Me.BtnAgregarRol.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnAgregarRol.Name = "BtnAgregarRol"
        Me.BtnAgregarRol.Size = New System.Drawing.Size(183, 55)
        Me.BtnAgregarRol.TabIndex = 4
        Me.BtnAgregarRol.Text = "Agregar"
        Me.BtnAgregarRol.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregarRol.UseVisualStyleBackColor = True
        '
        'BtnEliminarRol
        '
        Me.BtnEliminarRol.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnEliminarRol.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminarRol.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnEliminarRol.FlatAppearance.BorderSize = 0
        Me.BtnEliminarRol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnEliminarRol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnEliminarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarRol.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarRol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnEliminarRol.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgEliminar
        Me.BtnEliminarRol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarRol.Location = New System.Drawing.Point(1134, 410)
        Me.BtnEliminarRol.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnEliminarRol.Name = "BtnEliminarRol"
        Me.BtnEliminarRol.Size = New System.Drawing.Size(191, 55)
        Me.BtnEliminarRol.TabIndex = 7
        Me.BtnEliminarRol.Text = "Eliminar"
        Me.BtnEliminarRol.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminarRol.UseVisualStyleBackColor = True
        '
        'BtnEditarRol
        '
        Me.BtnEditarRol.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnEditarRol.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditarRol.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnEditarRol.FlatAppearance.BorderSize = 0
        Me.BtnEditarRol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnEditarRol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnEditarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditarRol.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditarRol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnEditarRol.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgEditar
        Me.BtnEditarRol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditarRol.Location = New System.Drawing.Point(914, 410)
        Me.BtnEditarRol.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnEditarRol.Name = "BtnEditarRol"
        Me.BtnEditarRol.Size = New System.Drawing.Size(157, 55)
        Me.BtnEditarRol.TabIndex = 6
        Me.BtnEditarRol.Text = "Editar"
        Me.BtnEditarRol.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditarRol.UseVisualStyleBackColor = True
        '
        'BtnLimpiarRol
        '
        Me.BtnLimpiarRol.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnLimpiarRol.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpiarRol.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnLimpiarRol.FlatAppearance.BorderSize = 0
        Me.BtnLimpiarRol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnLimpiarRol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnLimpiarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiarRol.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiarRol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnLimpiarRol.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgLimpiarCampos
        Me.BtnLimpiarRol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiarRol.Location = New System.Drawing.Point(660, 410)
        Me.BtnLimpiarRol.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnLimpiarRol.Name = "BtnLimpiarRol"
        Me.BtnLimpiarRol.Size = New System.Drawing.Size(176, 55)
        Me.BtnLimpiarRol.TabIndex = 5
        Me.BtnLimpiarRol.Text = "Limpiar"
        Me.BtnLimpiarRol.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiarRol.UseVisualStyleBackColor = True
        '
        'GobDatosProd
        '
        Me.GobDatosProd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GobDatosProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GobDatosProd.Controls.Add(Me.ClbPermisos)
        Me.GobDatosProd.Controls.Add(Me.TxtIdRol)
        Me.GobDatosProd.Controls.Add(Me.Label3)
        Me.GobDatosProd.Controls.Add(Me.PibProductos)
        Me.GobDatosProd.Controls.Add(Me.TxtDescRol)
        Me.GobDatosProd.Controls.Add(Me.Label5)
        Me.GobDatosProd.Controls.Add(Me.TxtNomRol)
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
        Me.GobDatosProd.Text = "Datos Generales del Rol de Usuario"
        '
        'ClbPermisos
        '
        Me.ClbPermisos.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.ClbPermisos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ClbPermisos.CheckOnClick = True
        Me.ClbPermisos.FormattingEnabled = True
        Me.ClbPermisos.Location = New System.Drawing.Point(766, 99)
        Me.ClbPermisos.Name = "ClbPermisos"
        Me.ClbPermisos.Size = New System.Drawing.Size(340, 232)
        Me.ClbPermisos.TabIndex = 34
        '
        'TxtIdRol
        '
        Me.TxtIdRol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIdRol.Enabled = False
        Me.TxtIdRol.Location = New System.Drawing.Point(175, 41)
        Me.TxtIdRol.Name = "TxtIdRol"
        Me.TxtIdRol.Size = New System.Drawing.Size(235, 34)
        Me.TxtIdRol.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 28)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Código:"
        '
        'PibProductos
        '
        Me.PibProductos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PibProductos.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgRoles
        Me.PibProductos.Location = New System.Drawing.Point(1221, 30)
        Me.PibProductos.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.PibProductos.Name = "PibProductos"
        Me.PibProductos.Size = New System.Drawing.Size(335, 310)
        Me.PibProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PibProductos.TabIndex = 29
        Me.PibProductos.TabStop = False
        '
        'TxtDescRol
        '
        Me.TxtDescRol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescRol.Location = New System.Drawing.Point(175, 155)
        Me.TxtDescRol.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtDescRol.Multiline = True
        Me.TxtDescRol.Name = "TxtDescRol"
        Me.TxtDescRol.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDescRol.Size = New System.Drawing.Size(513, 185)
        Me.TxtDescRol.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(761, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 28)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Permisos:"
        '
        'TxtNomRol
        '
        Me.TxtNomRol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNomRol.Location = New System.Drawing.Point(175, 99)
        Me.TxtNomRol.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtNomRol.Name = "TxtNomRol"
        Me.TxtNomRol.Size = New System.Drawing.Size(490, 34)
        Me.TxtNomRol.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'FrmRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1733, 850)
        Me.Controls.Add(Me.PanelCentral)
        Me.Controls.Add(Me.PanSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRoles"
        Me.Text = "Gestión de Roles de Usuario"
        Me.PanSuperior.ResumeLayout(False)
        Me.PanSuperior.PerformLayout()
        CType(Me.PibMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibRetornar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCentral.ResumeLayout(False)
        Me.PanelCentral.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvRoles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GobDatosProd.ResumeLayout(False)
        Me.GobDatosProd.PerformLayout()
        CType(Me.PibProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanSuperior As Panel
    Friend WithEvents PibMinimizar As PictureBox
    Friend WithEvents PibCerrar As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PanelCentral As Panel
    Friend WithEvents GobDatosProd As GroupBox
    Friend WithEvents PibProductos As PictureBox
    Friend WithEvents BtnAgregarRol As Button
    Friend WithEvents BtnEliminarRol As Button
    Friend WithEvents BtnEditarRol As Button
    Friend WithEvents BtnLimpiarRol As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtNomRol As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDescRol As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PibRetornar As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TxtBuscarRol As TextBox
    Friend WithEvents TxtIdRol As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ClbPermisos As CheckedListBox
    Friend WithEvents PibMaximizar As PictureBox
    Friend WithEvents DgvRoles As DataGridView
    Friend WithEvents GbRoles As GroupBox
    Friend WithEvents BtnBuscarRol As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
