﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.PanSuperior = New System.Windows.Forms.Panel()
        Me.PibRetornar = New System.Windows.Forms.PictureBox()
        Me.PibMinimizar = New System.Windows.Forms.PictureBox()
        Me.PibCerrar = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PanelCentral = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnAgregarP = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.BtnEliminarP = New System.Windows.Forms.Button()
        Me.BtnEditarP = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnLimpiarP = New System.Windows.Forms.Button()
        Me.GobDatosProd = New System.Windows.Forms.GroupBox()
        Me.ChLstRol = New System.Windows.Forms.CheckedListBox()
        Me.PibProductos = New System.Windows.Forms.PictureBox()
        Me.TxtNombreProd = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtIdProd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanSuperior.SuspendLayout()
        CType(Me.PibRetornar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCentral.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GobDatosProd.SuspendLayout()
        CType(Me.PibProductos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelCentral.Controls.Add(Me.DataGridView1)
        Me.PanelCentral.Controls.Add(Me.PictureBox1)
        Me.PanelCentral.Controls.Add(Me.BtnAgregarP)
        Me.PanelCentral.Controls.Add(Me.TxtBuscar)
        Me.PanelCentral.Controls.Add(Me.BtnEliminarP)
        Me.PanelCentral.Controls.Add(Me.BtnEditarP)
        Me.PanelCentral.Controls.Add(Me.Label12)
        Me.PanelCentral.Controls.Add(Me.BtnLimpiarP)
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
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(41, 591)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1653, 170)
        Me.DataGridView1.TabIndex = 9
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
        Me.BtnAgregarP.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.agregarProd
        Me.BtnAgregarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregarP.Location = New System.Drawing.Point(386, 452)
        Me.BtnAgregarP.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnAgregarP.Name = "BtnAgregarP"
        Me.BtnAgregarP.Size = New System.Drawing.Size(183, 55)
        Me.BtnAgregarP.TabIndex = 4
        Me.BtnAgregarP.Text = "Agregar"
        Me.BtnAgregarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregarP.UseVisualStyleBackColor = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBuscar.Location = New System.Drawing.Point(181, 525)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(1513, 34)
        Me.TxtBuscar.TabIndex = 8
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
        Me.BtnEliminarP.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.eliminarProd
        Me.BtnEliminarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarP.Location = New System.Drawing.Point(1113, 452)
        Me.BtnEliminarP.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnEliminarP.Name = "BtnEliminarP"
        Me.BtnEliminarP.Size = New System.Drawing.Size(191, 55)
        Me.BtnEliminarP.TabIndex = 7
        Me.BtnEliminarP.Text = "Eliminar"
        Me.BtnEliminarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminarP.UseVisualStyleBackColor = True
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
        Me.BtnEditarP.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.editarProd
        Me.BtnEditarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditarP.Location = New System.Drawing.Point(893, 452)
        Me.BtnEditarP.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnEditarP.Name = "BtnEditarP"
        Me.BtnEditarP.Size = New System.Drawing.Size(157, 55)
        Me.BtnEditarP.TabIndex = 6
        Me.BtnEditarP.Text = "Editar"
        Me.BtnEditarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditarP.UseVisualStyleBackColor = True
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
        Me.BtnLimpiarP.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.limpiarCampos
        Me.BtnLimpiarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiarP.Location = New System.Drawing.Point(639, 452)
        Me.BtnLimpiarP.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnLimpiarP.Name = "BtnLimpiarP"
        Me.BtnLimpiarP.Size = New System.Drawing.Size(176, 55)
        Me.BtnLimpiarP.TabIndex = 5
        Me.BtnLimpiarP.Text = "Limpiar"
        Me.BtnLimpiarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiarP.UseVisualStyleBackColor = True
        '
        'GobDatosProd
        '
        Me.GobDatosProd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GobDatosProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GobDatosProd.Controls.Add(Me.ChLstRol)
        Me.GobDatosProd.Controls.Add(Me.PibProductos)
        Me.GobDatosProd.Controls.Add(Me.TxtNombreProd)
        Me.GobDatosProd.Controls.Add(Me.Label5)
        Me.GobDatosProd.Controls.Add(Me.TxtIdProd)
        Me.GobDatosProd.Controls.Add(Me.Label2)
        Me.GobDatosProd.Controls.Add(Me.Label1)
        Me.GobDatosProd.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GobDatosProd.Location = New System.Drawing.Point(41, 37)
        Me.GobDatosProd.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.GobDatosProd.Name = "GobDatosProd"
        Me.GobDatosProd.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GobDatosProd.Size = New System.Drawing.Size(1653, 396)
        Me.GobDatosProd.TabIndex = 5
        Me.GobDatosProd.TabStop = False
        Me.GobDatosProd.Text = "Datos generales del Rol de Usuario"
        '
        'ChLstRol
        '
        Me.ChLstRol.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.ChLstRol.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ChLstRol.CheckOnClick = True
        Me.ChLstRol.FormattingEnabled = True
        Me.ChLstRol.Items.AddRange(New Object() {"Gestionar Roles", "Gestionar Usuarios", "Gestionar Categorías", "Gestionar Productos"})
        Me.ChLstRol.Location = New System.Drawing.Point(730, 121)
        Me.ChLstRol.Name = "ChLstRol"
        Me.ChLstRol.Size = New System.Drawing.Size(279, 145)
        Me.ChLstRol.TabIndex = 3
        '
        'PibProductos
        '
        Me.PibProductos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PibProductos.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.usuariosRoles
        Me.PibProductos.Location = New System.Drawing.Point(1275, 30)
        Me.PibProductos.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.PibProductos.Name = "PibProductos"
        Me.PibProductos.Size = New System.Drawing.Size(335, 310)
        Me.PibProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PibProductos.TabIndex = 29
        Me.PibProductos.TabStop = False
        '
        'TxtNombreProd
        '
        Me.TxtNombreProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombreProd.Location = New System.Drawing.Point(163, 121)
        Me.TxtNombreProd.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtNombreProd.Multiline = True
        Me.TxtNombreProd.Name = "TxtNombreProd"
        Me.TxtNombreProd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtNombreProd.Size = New System.Drawing.Size(526, 185)
        Me.TxtNombreProd.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(725, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(338, 28)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Permisos con los que contará este rol:"
        '
        'TxtIdProd
        '
        Me.TxtIdProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIdProd.Location = New System.Drawing.Point(163, 66)
        Me.TxtIdProd.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtIdProd.Name = "TxtIdProd"
        Me.TxtIdProd.Size = New System.Drawing.Size(503, 34)
        Me.TxtIdProd.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 60)
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
        Me.Name = "FrmRoles"
        Me.Text = "FrmRoles"
        Me.PanSuperior.ResumeLayout(False)
        Me.PanSuperior.PerformLayout()
        CType(Me.PibRetornar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCentral.ResumeLayout(False)
        Me.PanelCentral.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GobDatosProd As GroupBox
    Friend WithEvents PibProductos As PictureBox
    Friend WithEvents BtnAgregarP As Button
    Friend WithEvents BtnEliminarP As Button
    Friend WithEvents BtnEditarP As Button
    Friend WithEvents BtnLimpiarP As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtIdProd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ChLstRol As CheckedListBox
    Friend WithEvents TxtNombreProd As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PibRetornar As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
