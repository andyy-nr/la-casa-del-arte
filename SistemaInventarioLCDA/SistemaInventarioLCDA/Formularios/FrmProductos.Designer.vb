﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.PanSuperior = New System.Windows.Forms.Panel()
        Me.PibMinimizar = New System.Windows.Forms.PictureBox()
        Me.PibCerrar = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GobDatosProd = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtIdProd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNombreProd = New System.Windows.Forms.TextBox()
        Me.TxtMarcaProd = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CobCategoria = New System.Windows.Forms.ComboBox()
        Me.BtnLimpiarP = New System.Windows.Forms.Button()
        Me.BtnEditarP = New System.Windows.Forms.Button()
        Me.BtnEliminarP = New System.Windows.Forms.Button()
        Me.BtnAgregarP = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtStockTienda = New System.Windows.Forms.TextBox()
        Me.TxtStockBodega = New System.Windows.Forms.TextBox()
        Me.TxtStockMin = New System.Windows.Forms.TextBox()
        Me.TxtStockMax = New System.Windows.Forms.TextBox()
        Me.TxtStockTotal = New System.Windows.Forms.TextBox()
        Me.PibProductos = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PanelCentral = New System.Windows.Forms.Panel()
        Me.PanSuperior.SuspendLayout()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GobDatosProd.SuspendLayout()
        CType(Me.PibProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCentral.SuspendLayout()
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
        Me.PanSuperior.TabIndex = 1
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
        Me.Label8.Location = New System.Drawing.Point(715, 6)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(303, 41)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Gestionar Productos"
        '
        'GobDatosProd
        '
        Me.GobDatosProd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GobDatosProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GobDatosProd.Controls.Add(Me.PibProductos)
        Me.GobDatosProd.Controls.Add(Me.TxtStockTotal)
        Me.GobDatosProd.Controls.Add(Me.TxtStockMax)
        Me.GobDatosProd.Controls.Add(Me.TxtStockMin)
        Me.GobDatosProd.Controls.Add(Me.TxtStockBodega)
        Me.GobDatosProd.Controls.Add(Me.TxtStockTienda)
        Me.GobDatosProd.Controls.Add(Me.Label11)
        Me.GobDatosProd.Controls.Add(Me.Label10)
        Me.GobDatosProd.Controls.Add(Me.Label9)
        Me.GobDatosProd.Controls.Add(Me.BtnAgregarP)
        Me.GobDatosProd.Controls.Add(Me.BtnEliminarP)
        Me.GobDatosProd.Controls.Add(Me.BtnEditarP)
        Me.GobDatosProd.Controls.Add(Me.BtnLimpiarP)
        Me.GobDatosProd.Controls.Add(Me.CobCategoria)
        Me.GobDatosProd.Controls.Add(Me.Label7)
        Me.GobDatosProd.Controls.Add(Me.TxtDescripcion)
        Me.GobDatosProd.Controls.Add(Me.TxtMarcaProd)
        Me.GobDatosProd.Controls.Add(Me.TxtNombreProd)
        Me.GobDatosProd.Controls.Add(Me.Label6)
        Me.GobDatosProd.Controls.Add(Me.Label5)
        Me.GobDatosProd.Controls.Add(Me.Label4)
        Me.GobDatosProd.Controls.Add(Me.TxtIdProd)
        Me.GobDatosProd.Controls.Add(Me.Label3)
        Me.GobDatosProd.Controls.Add(Me.Label2)
        Me.GobDatosProd.Controls.Add(Me.Label1)
        Me.GobDatosProd.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GobDatosProd.Location = New System.Drawing.Point(41, 37)
        Me.GobDatosProd.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.GobDatosProd.Name = "GobDatosProd"
        Me.GobDatosProd.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GobDatosProd.Size = New System.Drawing.Size(1653, 455)
        Me.GobDatosProd.TabIndex = 5
        Me.GobDatosProd.TabStop = False
        Me.GobDatosProd.Text = "Datos Generales del Producto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Marca:"
        '
        'TxtIdProd
        '
        Me.TxtIdProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIdProd.Location = New System.Drawing.Point(124, 58)
        Me.TxtIdProd.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtIdProd.Name = "TxtIdProd"
        Me.TxtIdProd.Size = New System.Drawing.Size(410, 34)
        Me.TxtIdProd.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 28)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Categoría:"
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(683, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 28)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Stock Tienda:"
        '
        'TxtNombreProd
        '
        Me.TxtNombreProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombreProd.Location = New System.Drawing.Point(124, 118)
        Me.TxtNombreProd.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtNombreProd.Name = "TxtNombreProd"
        Me.TxtNombreProd.Size = New System.Drawing.Size(410, 34)
        Me.TxtNombreProd.TabIndex = 2
        '
        'TxtMarcaProd
        '
        Me.TxtMarcaProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMarcaProd.Location = New System.Drawing.Point(124, 180)
        Me.TxtMarcaProd.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtMarcaProd.Name = "TxtMarcaProd"
        Me.TxtMarcaProd.Size = New System.Drawing.Size(410, 34)
        Me.TxtMarcaProd.TabIndex = 3
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescripcion.Location = New System.Drawing.Point(813, 58)
        Me.TxtDescripcion.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDescripcion.Size = New System.Drawing.Size(441, 98)
        Me.TxtDescripcion.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(683, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 28)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Stock Bodega:"
        '
        'CobCategoria
        '
        Me.CobCategoria.FormattingEnabled = True
        Me.CobCategoria.Items.AddRange(New Object() {"Manualidades", "Arte", "Escolar", "Profesional"})
        Me.CobCategoria.Location = New System.Drawing.Point(136, 245)
        Me.CobCategoria.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.CobCategoria.Name = "CobCategoria"
        Me.CobCategoria.Size = New System.Drawing.Size(397, 36)
        Me.CobCategoria.TabIndex = 4
        Me.CobCategoria.Tag = ""
        Me.CobCategoria.Text = "Seleccione la categoría..."
        '
        'BtnLimpiarP
        '
        Me.BtnLimpiarP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpiarP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnLimpiarP.FlatAppearance.BorderSize = 0
        Me.BtnLimpiarP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnLimpiarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnLimpiarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiarP.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiarP.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.limpiarCampos
        Me.BtnLimpiarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiarP.Location = New System.Drawing.Point(416, 374)
        Me.BtnLimpiarP.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnLimpiarP.Name = "BtnLimpiarP"
        Me.BtnLimpiarP.Size = New System.Drawing.Size(176, 55)
        Me.BtnLimpiarP.TabIndex = 11
        Me.BtnLimpiarP.Text = "Limpiar"
        Me.BtnLimpiarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiarP.UseVisualStyleBackColor = True
        '
        'BtnEditarP
        '
        Me.BtnEditarP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditarP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnEditarP.FlatAppearance.BorderSize = 0
        Me.BtnEditarP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnEditarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnEditarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditarP.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditarP.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.editarProd
        Me.BtnEditarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditarP.Location = New System.Drawing.Point(670, 374)
        Me.BtnEditarP.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnEditarP.Name = "BtnEditarP"
        Me.BtnEditarP.Size = New System.Drawing.Size(157, 55)
        Me.BtnEditarP.TabIndex = 12
        Me.BtnEditarP.Text = "Editar"
        Me.BtnEditarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditarP.UseVisualStyleBackColor = True
        '
        'BtnEliminarP
        '
        Me.BtnEliminarP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminarP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnEliminarP.FlatAppearance.BorderSize = 0
        Me.BtnEliminarP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnEliminarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnEliminarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarP.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarP.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.eliminarProd
        Me.BtnEliminarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarP.Location = New System.Drawing.Point(890, 374)
        Me.BtnEliminarP.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnEliminarP.Name = "BtnEliminarP"
        Me.BtnEliminarP.Size = New System.Drawing.Size(191, 55)
        Me.BtnEliminarP.TabIndex = 13
        Me.BtnEliminarP.Text = "Eliminar"
        Me.BtnEliminarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminarP.UseVisualStyleBackColor = True
        '
        'BtnAgregarP
        '
        Me.BtnAgregarP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnAgregarP.FlatAppearance.BorderSize = 0
        Me.BtnAgregarP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.BtnAgregarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnAgregarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarP.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarP.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.agregarProd
        Me.BtnAgregarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregarP.Location = New System.Drawing.Point(163, 374)
        Me.BtnAgregarP.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnAgregarP.Name = "BtnAgregarP"
        Me.BtnAgregarP.Size = New System.Drawing.Size(183, 55)
        Me.BtnAgregarP.TabIndex = 10
        Me.BtnAgregarP.Text = "Agregar"
        Me.BtnAgregarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregarP.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(992, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 28)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Stock Mínimo:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(992, 251)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 28)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Stock Máximo:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(873, 311)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 28)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Stock Total:"
        '
        'TxtStockTienda
        '
        Me.TxtStockTienda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStockTienda.Location = New System.Drawing.Point(831, 180)
        Me.TxtStockTienda.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStockTienda.Name = "TxtStockTienda"
        Me.TxtStockTienda.Size = New System.Drawing.Size(109, 34)
        Me.TxtStockTienda.TabIndex = 6
        '
        'TxtStockBodega
        '
        Me.TxtStockBodega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStockBodega.Location = New System.Drawing.Point(831, 245)
        Me.TxtStockBodega.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStockBodega.Name = "TxtStockBodega"
        Me.TxtStockBodega.Size = New System.Drawing.Size(109, 34)
        Me.TxtStockBodega.TabIndex = 7
        '
        'TxtStockMin
        '
        Me.TxtStockMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStockMin.Location = New System.Drawing.Point(1145, 178)
        Me.TxtStockMin.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStockMin.Name = "TxtStockMin"
        Me.TxtStockMin.Size = New System.Drawing.Size(109, 34)
        Me.TxtStockMin.TabIndex = 8
        '
        'TxtStockMax
        '
        Me.TxtStockMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStockMax.Location = New System.Drawing.Point(1145, 246)
        Me.TxtStockMax.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStockMax.Name = "TxtStockMax"
        Me.TxtStockMax.Size = New System.Drawing.Size(109, 34)
        Me.TxtStockMax.TabIndex = 9
        '
        'TxtStockTotal
        '
        Me.TxtStockTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStockTotal.Enabled = False
        Me.TxtStockTotal.Location = New System.Drawing.Point(995, 309)
        Me.TxtStockTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStockTotal.Name = "TxtStockTotal"
        Me.TxtStockTotal.Size = New System.Drawing.Size(109, 34)
        Me.TxtStockTotal.TabIndex = 28
        '
        'PibProductos
        '
        Me.PibProductos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PibProductos.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.lapiz
        Me.PibProductos.Location = New System.Drawing.Point(1288, 78)
        Me.PibProductos.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.PibProductos.Name = "PibProductos"
        Me.PibProductos.Size = New System.Drawing.Size(335, 310)
        Me.PibProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PibProductos.TabIndex = 29
        Me.PibProductos.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(102, 525)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 28)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Buscar:"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBuscar.Location = New System.Drawing.Point(181, 525)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(1513, 34)
        Me.TxtBuscar.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.lupa
        Me.PictureBox1.Location = New System.Drawing.Point(41, 516)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(41, 599)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1653, 170)
        Me.DataGridView1.TabIndex = 15
        '
        'PanelCentral
        '
        Me.PanelCentral.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PanelCentral.Controls.Add(Me.DataGridView1)
        Me.PanelCentral.Controls.Add(Me.PictureBox1)
        Me.PanelCentral.Controls.Add(Me.TxtBuscar)
        Me.PanelCentral.Controls.Add(Me.Label12)
        Me.PanelCentral.Controls.Add(Me.GobDatosProd)
        Me.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCentral.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelCentral.Location = New System.Drawing.Point(0, 52)
        Me.PanelCentral.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelCentral.Name = "PanelCentral"
        Me.PanelCentral.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.PanelCentral.Size = New System.Drawing.Size(1733, 798)
        Me.PanelCentral.TabIndex = 16
        '
        'FrmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1733, 850)
        Me.Controls.Add(Me.PanelCentral)
        Me.Controls.Add(Me.PanSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmProductos"
        Me.PanSuperior.ResumeLayout(False)
        Me.PanSuperior.PerformLayout()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GobDatosProd.ResumeLayout(False)
        Me.GobDatosProd.PerformLayout()
        CType(Me.PibProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCentral.ResumeLayout(False)
        Me.PanelCentral.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanSuperior As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents PibMinimizar As PictureBox
    Friend WithEvents PibCerrar As PictureBox
    Friend WithEvents GobDatosProd As GroupBox
    Friend WithEvents PibProductos As PictureBox
    Friend WithEvents TxtStockTotal As TextBox
    Friend WithEvents TxtStockMax As TextBox
    Friend WithEvents TxtStockMin As TextBox
    Friend WithEvents TxtStockBodega As TextBox
    Friend WithEvents TxtStockTienda As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnAgregarP As Button
    Friend WithEvents BtnEliminarP As Button
    Friend WithEvents BtnEditarP As Button
    Friend WithEvents BtnLimpiarP As Button
    Friend WithEvents CobCategoria As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents TxtMarcaProd As TextBox
    Friend WithEvents TxtNombreProd As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtIdProd As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PanelCentral As Panel
End Class