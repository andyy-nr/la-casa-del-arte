<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCategoria
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
        Me.BtnLimpiarC = New System.Windows.Forms.Button()
        Me.BtnEditarC = New System.Windows.Forms.Button()
        Me.GobDatosProd = New System.Windows.Forms.GroupBox()
        Me.TxtNombreCat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PibProductos = New System.Windows.Forms.PictureBox()
        Me.TxtDescCat = New System.Windows.Forms.TextBox()
        Me.TxtIdCat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnEliminarC = New System.Windows.Forms.Button()
        Me.BtnAgregarC = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.PanelCentral = New System.Windows.Forms.Panel()
        Me.BtnBuscaCategoria = New System.Windows.Forms.Button()
        Me.GbCategorias = New System.Windows.Forms.GroupBox()
        Me.DgvCategorias = New System.Windows.Forms.DataGridView()
        Me.PanSuperior.SuspendLayout()
        CType(Me.PibMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibRetornar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GobDatosProd.SuspendLayout()
        CType(Me.PibProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCentral.SuspendLayout()
        Me.GbCategorias.SuspendLayout()
        CType(Me.DgvCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanSuperior.Name = "PanSuperior"
        Me.PanSuperior.Size = New System.Drawing.Size(1040, 42)
        Me.PanSuperior.TabIndex = 3
        '
        'PibMaximizar
        '
        Me.PibMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PibMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PibMaximizar.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.btnMaximizar
        Me.PibMaximizar.Location = New System.Drawing.Point(970, 7)
        Me.PibMaximizar.Margin = New System.Windows.Forms.Padding(2)
        Me.PibMaximizar.Name = "PibMaximizar"
        Me.PibMaximizar.Size = New System.Drawing.Size(29, 29)
        Me.PibMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PibMaximizar.TabIndex = 11
        Me.PibMaximizar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PibMaximizar, "Maximizar")
        '
        'PibRetornar
        '
        Me.PibRetornar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PibRetornar.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.BtnRegresar
        Me.PibRetornar.Location = New System.Drawing.Point(2, 4)
        Me.PibRetornar.Margin = New System.Windows.Forms.Padding(2)
        Me.PibRetornar.Name = "PibRetornar"
        Me.PibRetornar.Size = New System.Drawing.Size(32, 35)
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
        Me.PibMinimizar.Location = New System.Drawing.Point(932, 3)
        Me.PibMinimizar.Margin = New System.Windows.Forms.Padding(2)
        Me.PibMinimizar.Name = "PibMinimizar"
        Me.PibMinimizar.Size = New System.Drawing.Size(34, 37)
        Me.PibMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PibMinimizar.TabIndex = 7
        Me.PibMinimizar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PibMinimizar, "Minimmizar")
        '
        'PibCerrar
        '
        Me.PibCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PibCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PibCerrar.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.cerrarBTN
        Me.PibCerrar.Location = New System.Drawing.Point(1004, 3)
        Me.PibCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.PibCerrar.Name = "PibCerrar"
        Me.PibCerrar.Size = New System.Drawing.Size(34, 37)
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
        Me.Label8.Location = New System.Drawing.Point(403, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(264, 32)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Gestión de Categorías"
        '
        'BtnLimpiarC
        '
        Me.BtnLimpiarC.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnLimpiarC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpiarC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnLimpiarC.FlatAppearance.BorderSize = 0
        Me.BtnLimpiarC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnLimpiarC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnLimpiarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiarC.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiarC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnLimpiarC.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgLimpiarCampos
        Me.BtnLimpiarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiarC.Location = New System.Drawing.Point(365, 333)
        Me.BtnLimpiarC.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BtnLimpiarC.Name = "BtnLimpiarC"
        Me.BtnLimpiarC.Size = New System.Drawing.Size(132, 45)
        Me.BtnLimpiarC.TabIndex = 5
        Me.BtnLimpiarC.Text = "Limpiar"
        Me.BtnLimpiarC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiarC.UseVisualStyleBackColor = True
        '
        'BtnEditarC
        '
        Me.BtnEditarC.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnEditarC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditarC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnEditarC.FlatAppearance.BorderSize = 0
        Me.BtnEditarC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnEditarC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnEditarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditarC.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditarC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnEditarC.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgEditar
        Me.BtnEditarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditarC.Location = New System.Drawing.Point(556, 333)
        Me.BtnEditarC.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BtnEditarC.Name = "BtnEditarC"
        Me.BtnEditarC.Size = New System.Drawing.Size(118, 45)
        Me.BtnEditarC.TabIndex = 6
        Me.BtnEditarC.Text = "Editar"
        Me.BtnEditarC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditarC.UseVisualStyleBackColor = True
        '
        'GobDatosProd
        '
        Me.GobDatosProd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GobDatosProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GobDatosProd.Controls.Add(Me.TxtNombreCat)
        Me.GobDatosProd.Controls.Add(Me.Label3)
        Me.GobDatosProd.Controls.Add(Me.PibProductos)
        Me.GobDatosProd.Controls.Add(Me.TxtDescCat)
        Me.GobDatosProd.Controls.Add(Me.TxtIdCat)
        Me.GobDatosProd.Controls.Add(Me.Label2)
        Me.GobDatosProd.Controls.Add(Me.Label1)
        Me.GobDatosProd.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GobDatosProd.Location = New System.Drawing.Point(31, 30)
        Me.GobDatosProd.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.GobDatosProd.Name = "GobDatosProd"
        Me.GobDatosProd.Padding = New System.Windows.Forms.Padding(2)
        Me.GobDatosProd.Size = New System.Drawing.Size(980, 290)
        Me.GobDatosProd.TabIndex = 5
        Me.GobDatosProd.TabStop = False
        Me.GobDatosProd.Text = "Datos Generales de la Categoria"
        '
        'TxtNombreCat
        '
        Me.TxtNombreCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombreCat.Location = New System.Drawing.Point(128, 99)
        Me.TxtNombreCat.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TxtNombreCat.Name = "TxtNombreCat"
        Me.TxtNombreCat.Size = New System.Drawing.Size(323, 29)
        Me.TxtNombreCat.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 99)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 21)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Nombre:"
        '
        'PibProductos
        '
        Me.PibProductos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PibProductos.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgCategoria
        Me.PibProductos.Location = New System.Drawing.Point(786, 24)
        Me.PibProductos.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.PibProductos.Name = "PibProductos"
        Me.PibProductos.Size = New System.Drawing.Size(251, 252)
        Me.PibProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PibProductos.TabIndex = 30
        Me.PibProductos.TabStop = False
        '
        'TxtDescCat
        '
        Me.TxtDescCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescCat.Location = New System.Drawing.Point(128, 150)
        Me.TxtDescCat.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TxtDescCat.Multiline = True
        Me.TxtDescCat.Name = "TxtDescCat"
        Me.TxtDescCat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDescCat.Size = New System.Drawing.Size(652, 114)
        Me.TxtDescCat.TabIndex = 3
        '
        'TxtIdCat
        '
        Me.TxtIdCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIdCat.Enabled = False
        Me.TxtIdCat.Location = New System.Drawing.Point(128, 49)
        Me.TxtIdCat.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TxtIdCat.Name = "TxtIdCat"
        Me.TxtIdCat.Size = New System.Drawing.Size(109, 29)
        Me.TxtIdCat.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 150)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'BtnEliminarC
        '
        Me.BtnEliminarC.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnEliminarC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminarC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnEliminarC.FlatAppearance.BorderSize = 0
        Me.BtnEliminarC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnEliminarC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnEliminarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarC.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnEliminarC.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgEliminar
        Me.BtnEliminarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarC.Location = New System.Drawing.Point(720, 333)
        Me.BtnEliminarC.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BtnEliminarC.Name = "BtnEliminarC"
        Me.BtnEliminarC.Size = New System.Drawing.Size(143, 45)
        Me.BtnEliminarC.TabIndex = 7
        Me.BtnEliminarC.Text = "Eliminar"
        Me.BtnEliminarC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminarC.UseVisualStyleBackColor = True
        '
        'BtnAgregarC
        '
        Me.BtnAgregarC.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnAgregarC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnAgregarC.FlatAppearance.BorderSize = 0
        Me.BtnAgregarC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnAgregarC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnAgregarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarC.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnAgregarC.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgAgregar
        Me.BtnAgregarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregarC.Location = New System.Drawing.Point(175, 333)
        Me.BtnAgregarC.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BtnAgregarC.Name = "BtnAgregarC"
        Me.BtnAgregarC.Size = New System.Drawing.Size(137, 45)
        Me.BtnAgregarC.TabIndex = 4
        Me.BtnAgregarC.Text = "Agregar"
        Me.BtnAgregarC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregarC.UseVisualStyleBackColor = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBuscar.Location = New System.Drawing.Point(31, 396)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(808, 29)
        Me.TxtBuscar.TabIndex = 8
        '
        'PanelCentral
        '
        Me.PanelCentral.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PanelCentral.Controls.Add(Me.BtnBuscaCategoria)
        Me.PanelCentral.Controls.Add(Me.GbCategorias)
        Me.PanelCentral.Controls.Add(Me.TxtBuscar)
        Me.PanelCentral.Controls.Add(Me.BtnAgregarC)
        Me.PanelCentral.Controls.Add(Me.BtnEliminarC)
        Me.PanelCentral.Controls.Add(Me.GobDatosProd)
        Me.PanelCentral.Controls.Add(Me.BtnEditarC)
        Me.PanelCentral.Controls.Add(Me.BtnLimpiarC)
        Me.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCentral.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelCentral.Location = New System.Drawing.Point(0, 42)
        Me.PanelCentral.Name = "PanelCentral"
        Me.PanelCentral.Padding = New System.Windows.Forms.Padding(10)
        Me.PanelCentral.Size = New System.Drawing.Size(1040, 598)
        Me.PanelCentral.TabIndex = 18
        '
        'BtnBuscaCategoria
        '
        Me.BtnBuscaCategoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBuscaCategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscaCategoria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnBuscaCategoria.FlatAppearance.BorderSize = 0
        Me.BtnBuscaCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnBuscaCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnBuscaCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscaCategoria.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscaCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnBuscaCategoria.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgBuscar
        Me.BtnBuscaCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscaCategoria.Location = New System.Drawing.Point(873, 388)
        Me.BtnBuscaCategoria.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BtnBuscaCategoria.Name = "BtnBuscaCategoria"
        Me.BtnBuscaCategoria.Size = New System.Drawing.Size(137, 45)
        Me.BtnBuscaCategoria.TabIndex = 52
        Me.BtnBuscaCategoria.Text = "Buscar"
        Me.BtnBuscaCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscaCategoria.UseVisualStyleBackColor = True
        '
        'GbCategorias
        '
        Me.GbCategorias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbCategorias.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GbCategorias.Controls.Add(Me.DgvCategorias)
        Me.GbCategorias.Location = New System.Drawing.Point(31, 436)
        Me.GbCategorias.Margin = New System.Windows.Forms.Padding(2)
        Me.GbCategorias.Name = "GbCategorias"
        Me.GbCategorias.Padding = New System.Windows.Forms.Padding(2)
        Me.GbCategorias.Size = New System.Drawing.Size(980, 127)
        Me.GbCategorias.TabIndex = 51
        Me.GbCategorias.TabStop = False
        Me.GbCategorias.Text = "Categorías Registradas: 0"
        '
        'DgvCategorias
        '
        Me.DgvCategorias.AllowUserToAddRows = False
        Me.DgvCategorias.AllowUserToResizeColumns = False
        Me.DgvCategorias.AllowUserToResizeRows = False
        Me.DgvCategorias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCategorias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.DgvCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCategorias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCategorias.EnableHeadersVisualStyles = False
        Me.DgvCategorias.GridColor = System.Drawing.Color.SaddleBrown
        Me.DgvCategorias.Location = New System.Drawing.Point(4, 26)
        Me.DgvCategorias.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvCategorias.Name = "DgvCategorias"
        Me.DgvCategorias.ReadOnly = True
        Me.DgvCategorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCategorias.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvCategorias.RowHeadersVisible = False
        Me.DgvCategorias.RowHeadersWidth = 51
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(181, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Sienna
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DgvCategorias.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvCategorias.RowTemplate.Height = 24
        Me.DgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCategorias.Size = New System.Drawing.Size(972, 97)
        Me.DgvCategorias.TabIndex = 49
        '
        'FrmCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 640)
        Me.Controls.Add(Me.PanelCentral)
        Me.Controls.Add(Me.PanSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmCategoria"
        Me.Text = "FrmCategoria"
        Me.PanSuperior.ResumeLayout(False)
        Me.PanSuperior.PerformLayout()
        CType(Me.PibMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibRetornar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GobDatosProd.ResumeLayout(False)
        Me.GobDatosProd.PerformLayout()
        CType(Me.PibProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCentral.ResumeLayout(False)
        Me.PanelCentral.PerformLayout()
        Me.GbCategorias.ResumeLayout(False)
        CType(Me.DgvCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanSuperior As Panel
    Friend WithEvents PibMinimizar As PictureBox
    Friend WithEvents PibCerrar As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PibRetornar As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnLimpiarC As Button
    Friend WithEvents BtnEditarC As Button
    Friend WithEvents GobDatosProd As GroupBox
    Friend WithEvents TxtNombreCat As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PibProductos As PictureBox
    Friend WithEvents TxtDescCat As TextBox
    Friend WithEvents TxtIdCat As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEliminarC As Button
    Friend WithEvents BtnAgregarC As Button
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents PanelCentral As Panel
    Friend WithEvents PibMaximizar As PictureBox
    Friend WithEvents GbCategorias As GroupBox
    Friend WithEvents DgvCategorias As DataGridView
    Friend WithEvents BtnBuscaCategoria As Button
End Class
