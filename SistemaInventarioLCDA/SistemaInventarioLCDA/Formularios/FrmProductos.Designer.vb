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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProductos))
        Me.PanSuperior = New System.Windows.Forms.Panel()
        Me.PibMaximizar = New System.Windows.Forms.PictureBox()
        Me.PibRetornar = New System.Windows.Forms.PictureBox()
        Me.PibMinimizar = New System.Windows.Forms.PictureBox()
        Me.PibCerrar = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PibActualizar = New System.Windows.Forms.PictureBox()
        Me.PibImprimir = New System.Windows.Forms.PictureBox()
        Me.PanelCentral = New System.Windows.Forms.Panel()
        Me.CmbFiltrarUsu = New System.Windows.Forms.ComboBox()
        Me.BtnBuscarProducto = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.DgvProductos = New System.Windows.Forms.DataGridView()
        Me.BtnEliminarP = New System.Windows.Forms.Button()
        Me.BtnAgregarP = New System.Windows.Forms.Button()
        Me.BtnEditarP = New System.Windows.Forms.Button()
        Me.BtnLimpiarP = New System.Windows.Forms.Button()
        Me.GbDatosProd = New System.Windows.Forms.GroupBox()
        Me.TxtCantidadDisp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtInventarioInit = New System.Windows.Forms.TextBox()
        Me.TxtPrecioU = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbMarca = New System.Windows.Forms.ComboBox()
        Me.PibProductos = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtIdProd = New System.Windows.Forms.TextBox()
        Me.TxtNombreProd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbCategoria = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.GbProductos = New System.Windows.Forms.GroupBox()
        Me.PanSuperior.SuspendLayout()
        CType(Me.PibMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibRetornar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibActualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCentral.SuspendLayout()
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbDatosProd.SuspendLayout()
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
        Me.PanSuperior.TabIndex = 1
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
        Me.PibMaximizar.TabIndex = 9
        Me.PibMaximizar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PibMaximizar, "Maximizar")
        '
        'PibRetornar
        '
        Me.PibRetornar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PibRetornar.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.BtnRegresar
        Me.PibRetornar.Location = New System.Drawing.Point(3, 4)
        Me.PibRetornar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PibRetornar.Name = "PibRetornar"
        Me.PibRetornar.Size = New System.Drawing.Size(43, 43)
        Me.PibRetornar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PibRetornar.TabIndex = 8
        Me.PibRetornar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PibRetornar, "Regresar")
        '
        'PibMinimizar
        '
        Me.PibMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PibMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PibMinimizar.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.minimizarBTN
        Me.PibMinimizar.Location = New System.Drawing.Point(1589, 4)
        Me.PibMinimizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PibMinimizar.Name = "PibMinimizar"
        Me.PibMinimizar.Size = New System.Drawing.Size(45, 46)
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
        Me.PibCerrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PibCerrar.Name = "PibCerrar"
        Me.PibCerrar.Size = New System.Drawing.Size(45, 46)
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
        Me.Label8.Location = New System.Drawing.Point(706, 6)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(318, 41)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Gestión de Productos"
        '
        'PibActualizar
        '
        Me.PibActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PibActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PibActualizar.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.recargar
        Me.PibActualizar.Location = New System.Drawing.Point(1640, 522)
        Me.PibActualizar.Name = "PibActualizar"
        Me.PibActualizar.Size = New System.Drawing.Size(55, 55)
        Me.PibActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PibActualizar.TabIndex = 52
        Me.PibActualizar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PibActualizar, "Actualizar Tabla")
        '
        'PibImprimir
        '
        Me.PibImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PibImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PibImprimir.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.impresion
        Me.PibImprimir.Location = New System.Drawing.Point(1567, 522)
        Me.PibImprimir.Name = "PibImprimir"
        Me.PibImprimir.Size = New System.Drawing.Size(55, 55)
        Me.PibImprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PibImprimir.TabIndex = 53
        Me.PibImprimir.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PibImprimir, "Imprimir Reporte")
        '
        'PanelCentral
        '
        Me.PanelCentral.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PanelCentral.Controls.Add(Me.PibImprimir)
        Me.PanelCentral.Controls.Add(Me.PibActualizar)
        Me.PanelCentral.Controls.Add(Me.CmbFiltrarUsu)
        Me.PanelCentral.Controls.Add(Me.BtnBuscarProducto)
        Me.PanelCentral.Controls.Add(Me.TxtBuscar)
        Me.PanelCentral.Controls.Add(Me.DgvProductos)
        Me.PanelCentral.Controls.Add(Me.BtnEliminarP)
        Me.PanelCentral.Controls.Add(Me.BtnAgregarP)
        Me.PanelCentral.Controls.Add(Me.BtnEditarP)
        Me.PanelCentral.Controls.Add(Me.BtnLimpiarP)
        Me.PanelCentral.Controls.Add(Me.GbDatosProd)
        Me.PanelCentral.Controls.Add(Me.GbProductos)
        Me.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCentral.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelCentral.Location = New System.Drawing.Point(0, 52)
        Me.PanelCentral.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelCentral.Name = "PanelCentral"
        Me.PanelCentral.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.PanelCentral.Size = New System.Drawing.Size(1733, 798)
        Me.PanelCentral.TabIndex = 17
        '
        'CmbFiltrarUsu
        '
        Me.CmbFiltrarUsu.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.CmbFiltrarUsu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmbFiltrarUsu.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CmbFiltrarUsu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.CmbFiltrarUsu.FormattingEnabled = True
        Me.CmbFiltrarUsu.Items.AddRange(New Object() {"Filtrar por código", "Filtrar por nombre", "Filtrar por marca", "Filtrar por categoría"})
        Me.CmbFiltrarUsu.Location = New System.Drawing.Point(41, 530)
        Me.CmbFiltrarUsu.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbFiltrarUsu.Name = "CmbFiltrarUsu"
        Me.CmbFiltrarUsu.Size = New System.Drawing.Size(309, 36)
        Me.CmbFiltrarUsu.TabIndex = 37
        Me.CmbFiltrarUsu.Text = "Filtrar productos"
        '
        'BtnBuscarProducto
        '
        Me.BtnBuscarProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnBuscarProducto.FlatAppearance.BorderSize = 0
        Me.BtnBuscarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnBuscarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarProducto.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnBuscarProducto.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgBuscar
        Me.BtnBuscarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarProducto.Location = New System.Drawing.Point(1399, 522)
        Me.BtnBuscarProducto.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnBuscarProducto.Name = "BtnBuscarProducto"
        Me.BtnBuscarProducto.Size = New System.Drawing.Size(149, 55)
        Me.BtnBuscarProducto.TabIndex = 48
        Me.BtnBuscarProducto.Text = "Buscar"
        Me.BtnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscarProducto.UseVisualStyleBackColor = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBuscar.Location = New System.Drawing.Point(357, 532)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(1036, 34)
        Me.TxtBuscar.TabIndex = 39
        '
        'DgvProductos
        '
        Me.DgvProductos.AllowUserToAddRows = False
        Me.DgvProductos.AllowUserToResizeColumns = False
        Me.DgvProductos.AllowUserToResizeRows = False
        Me.DgvProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.DgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProductos.EnableHeadersVisualStyles = False
        Me.DgvProductos.GridColor = System.Drawing.Color.SaddleBrown
        Me.DgvProductos.Location = New System.Drawing.Point(47, 622)
        Me.DgvProductos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DgvProductos.Name = "DgvProductos"
        Me.DgvProductos.ReadOnly = True
        Me.DgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvProductos.RowHeadersVisible = False
        Me.DgvProductos.RowHeadersWidth = 51
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(181, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Sienna
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DgvProductos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvProductos.RowTemplate.Height = 24
        Me.DgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvProductos.Size = New System.Drawing.Size(1642, 145)
        Me.DgvProductos.TabIndex = 17
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
        Me.BtnEliminarP.Location = New System.Drawing.Point(1128, 455)
        Me.BtnEliminarP.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnEliminarP.Name = "BtnEliminarP"
        Me.BtnEliminarP.Size = New System.Drawing.Size(191, 55)
        Me.BtnEliminarP.TabIndex = 15
        Me.BtnEliminarP.Text = "Eliminar"
        Me.BtnEliminarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminarP.UseVisualStyleBackColor = True
        '
        'BtnAgregarP
        '
        Me.BtnAgregarP.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnAgregarP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnAgregarP.FlatAppearance.BorderSize = 0
        Me.BtnAgregarP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnAgregarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnAgregarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarP.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnAgregarP.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgAgregar
        Me.BtnAgregarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregarP.Location = New System.Drawing.Point(357, 455)
        Me.BtnAgregarP.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnAgregarP.Name = "BtnAgregarP"
        Me.BtnAgregarP.Size = New System.Drawing.Size(183, 55)
        Me.BtnAgregarP.TabIndex = 12
        Me.BtnAgregarP.Text = "Agregar"
        Me.BtnAgregarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregarP.UseVisualStyleBackColor = True
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
        Me.BtnEditarP.Location = New System.Drawing.Point(893, 455)
        Me.BtnEditarP.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnEditarP.Name = "BtnEditarP"
        Me.BtnEditarP.Size = New System.Drawing.Size(157, 55)
        Me.BtnEditarP.TabIndex = 14
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
        Me.BtnLimpiarP.Location = New System.Drawing.Point(620, 455)
        Me.BtnLimpiarP.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnLimpiarP.Name = "BtnLimpiarP"
        Me.BtnLimpiarP.Size = New System.Drawing.Size(176, 55)
        Me.BtnLimpiarP.TabIndex = 13
        Me.BtnLimpiarP.Text = "Limpiar"
        Me.BtnLimpiarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiarP.UseVisualStyleBackColor = True
        '
        'GbDatosProd
        '
        Me.GbDatosProd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbDatosProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GbDatosProd.Controls.Add(Me.TxtCantidadDisp)
        Me.GbDatosProd.Controls.Add(Me.Label6)
        Me.GbDatosProd.Controls.Add(Me.TxtInventarioInit)
        Me.GbDatosProd.Controls.Add(Me.TxtPrecioU)
        Me.GbDatosProd.Controls.Add(Me.Label9)
        Me.GbDatosProd.Controls.Add(Me.Label7)
        Me.GbDatosProd.Controls.Add(Me.CbMarca)
        Me.GbDatosProd.Controls.Add(Me.PibProductos)
        Me.GbDatosProd.Controls.Add(Me.Label2)
        Me.GbDatosProd.Controls.Add(Me.Label1)
        Me.GbDatosProd.Controls.Add(Me.TxtIdProd)
        Me.GbDatosProd.Controls.Add(Me.TxtNombreProd)
        Me.GbDatosProd.Controls.Add(Me.Label3)
        Me.GbDatosProd.Controls.Add(Me.Label4)
        Me.GbDatosProd.Controls.Add(Me.CbCategoria)
        Me.GbDatosProd.Controls.Add(Me.Label5)
        Me.GbDatosProd.Controls.Add(Me.TxtDescripcion)
        Me.GbDatosProd.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbDatosProd.Location = New System.Drawing.Point(41, 37)
        Me.GbDatosProd.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.GbDatosProd.Name = "GbDatosProd"
        Me.GbDatosProd.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GbDatosProd.Size = New System.Drawing.Size(1654, 396)
        Me.GbDatosProd.TabIndex = 5
        Me.GbDatosProd.TabStop = False
        Me.GbDatosProd.Text = "Datos del Generales del Producto"
        '
        'TxtCantidadDisp
        '
        Me.TxtCantidadDisp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCantidadDisp.Enabled = False
        Me.TxtCantidadDisp.Location = New System.Drawing.Point(921, 322)
        Me.TxtCantidadDisp.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCantidadDisp.Name = "TxtCantidadDisp"
        Me.TxtCantidadDisp.Size = New System.Drawing.Size(130, 34)
        Me.TxtCantidadDisp.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(706, 324)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(194, 28)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Cantidad Disponible:"
        '
        'TxtInventarioInit
        '
        Me.TxtInventarioInit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtInventarioInit.Location = New System.Drawing.Point(921, 259)
        Me.TxtInventarioInit.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtInventarioInit.Name = "TxtInventarioInit"
        Me.TxtInventarioInit.Size = New System.Drawing.Size(130, 34)
        Me.TxtInventarioInit.TabIndex = 36
        '
        'TxtPrecioU
        '
        Me.TxtPrecioU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPrecioU.Location = New System.Drawing.Point(921, 197)
        Me.TxtPrecioU.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPrecioU.Name = "TxtPrecioU"
        Me.TxtPrecioU.Size = New System.Drawing.Size(130, 34)
        Me.TxtPrecioU.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(741, 261)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 28)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Inventario Inicial:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(754, 197)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 28)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Precio Unitario:"
        '
        'CbMarca
        '
        Me.CbMarca.FormattingEnabled = True
        Me.CbMarca.Location = New System.Drawing.Point(182, 210)
        Me.CbMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.CbMarca.Name = "CbMarca"
        Me.CbMarca.Size = New System.Drawing.Size(431, 36)
        Me.CbMarca.TabIndex = 30
        Me.CbMarca.Text = "Seleccione la marca..."
        '
        'PibProductos
        '
        Me.PibProductos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PibProductos.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgProductos
        Me.PibProductos.Location = New System.Drawing.Point(1303, 46)
        Me.PibProductos.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.PibProductos.Name = "PibProductos"
        Me.PibProductos.Size = New System.Drawing.Size(335, 310)
        Me.PibProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PibProductos.TabIndex = 29
        Me.PibProductos.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'TxtIdProd
        '
        Me.TxtIdProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIdProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtIdProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtIdProd.Location = New System.Drawing.Point(182, 80)
        Me.TxtIdProd.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtIdProd.Name = "TxtIdProd"
        Me.TxtIdProd.Size = New System.Drawing.Size(431, 34)
        Me.TxtIdProd.TabIndex = 1
        '
        'TxtNombreProd
        '
        Me.TxtNombreProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombreProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombreProd.Location = New System.Drawing.Point(182, 143)
        Me.TxtNombreProd.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtNombreProd.Name = "TxtNombreProd"
        Me.TxtNombreProd.Size = New System.Drawing.Size(431, 34)
        Me.TxtNombreProd.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Marca:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 28)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Categoría:"
        '
        'CbCategoria
        '
        Me.CbCategoria.FormattingEnabled = True
        Me.CbCategoria.Location = New System.Drawing.Point(182, 279)
        Me.CbCategoria.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.CbCategoria.Name = "CbCategoria"
        Me.CbCategoria.Size = New System.Drawing.Size(431, 36)
        Me.CbCategoria.TabIndex = 4
        Me.CbCategoria.Tag = ""
        Me.CbCategoria.Text = "Seleccione la categoría..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(774, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 28)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Descripción:"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescripcion.Location = New System.Drawing.Point(921, 78)
        Me.TxtDescripcion.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDescripcion.Size = New System.Drawing.Size(381, 91)
        Me.TxtDescripcion.TabIndex = 5
        '
        'GbProductos
        '
        Me.GbProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GbProductos.Location = New System.Drawing.Point(41, 590)
        Me.GbProductos.Name = "GbProductos"
        Me.GbProductos.Size = New System.Drawing.Size(1654, 182)
        Me.GbProductos.TabIndex = 41
        Me.GbProductos.TabStop = False
        Me.GbProductos.Text = "Productos Almacenados: 0"
        '
        'FrmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1733, 850)
        Me.Controls.Add(Me.PanelCentral)
        Me.Controls.Add(Me.PanSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Gestión de Productos"
        Me.PanSuperior.ResumeLayout(False)
        Me.PanSuperior.PerformLayout()
        CType(Me.PibMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibRetornar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibActualizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCentral.ResumeLayout(False)
        Me.PanelCentral.PerformLayout()
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbDatosProd.ResumeLayout(False)
        Me.GbDatosProd.PerformLayout()
        CType(Me.PibProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanSuperior As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents PibMinimizar As PictureBox
    Friend WithEvents PibCerrar As PictureBox
    Friend WithEvents PibRetornar As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PanelCentral As Panel
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents DgvProductos As DataGridView
    Friend WithEvents BtnEliminarP As Button
    Friend WithEvents BtnAgregarP As Button
    Friend WithEvents BtnEditarP As Button
    Friend WithEvents BtnLimpiarP As Button
    Friend WithEvents GbDatosProd As GroupBox
    Friend WithEvents TxtInventarioInit As TextBox
    Friend WithEvents TxtPrecioU As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CbMarca As ComboBox
    Friend WithEvents PibProductos As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtIdProd As TextBox
    Friend WithEvents TxtNombreProd As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CbCategoria As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents PibMaximizar As PictureBox
    Friend WithEvents GbProductos As GroupBox
    Friend WithEvents BtnBuscarProducto As Button
    Friend WithEvents CmbFiltrarUsu As ComboBox
    Friend WithEvents TxtCantidadDisp As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PibActualizar As PictureBox
    Friend WithEvents PibImprimir As PictureBox
End Class
