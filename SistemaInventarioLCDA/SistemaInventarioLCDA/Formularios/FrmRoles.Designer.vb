<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRoles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRoles))
        Me.PanSuperior = New System.Windows.Forms.Panel()
        Me.BtnInicio = New System.Windows.Forms.Button()
        Me.MzButtonWindows3 = New BWCMM.MZButtonWindows()
        Me.MzButtonWindows2 = New BWCMM.MZButtonWindows()
        Me.MzButtonWindows1 = New BWCMM.MZButtonWindows()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GobDatos = New System.Windows.Forms.GroupBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ClbPermisos = New System.Windows.Forms.CheckedListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanSuperior.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GobDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanSuperior
        '
        Me.PanSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanSuperior.Controls.Add(Me.BtnInicio)
        Me.PanSuperior.Controls.Add(Me.MzButtonWindows3)
        Me.PanSuperior.Controls.Add(Me.MzButtonWindows2)
        Me.PanSuperior.Controls.Add(Me.MzButtonWindows1)
        Me.PanSuperior.Controls.Add(Me.Label1)
        Me.PanSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanSuperior.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanSuperior.Name = "PanSuperior"
        Me.PanSuperior.Size = New System.Drawing.Size(880, 52)
        Me.PanSuperior.TabIndex = 0
        '
        'BtnInicio
        '
        Me.BtnInicio.Location = New System.Drawing.Point(16, 6)
        Me.BtnInicio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnInicio.Name = "BtnInicio"
        Me.BtnInicio.Size = New System.Drawing.Size(100, 28)
        Me.BtnInicio.TabIndex = 4
        Me.BtnInicio.Text = "Button1"
        Me.BtnInicio.UseVisualStyleBackColor = True
        '
        'MzButtonWindows3
        '
        Me.MzButtonWindows3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MzButtonWindows3.BackgroundImage = CType(resources.GetObject("MzButtonWindows3.BackgroundImage"), System.Drawing.Image)
        Me.MzButtonWindows3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MzButtonWindows3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MzButtonWindows3.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.MzButtonWindows3.Location = New System.Drawing.Point(760, 0)
        Me.MzButtonWindows3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MzButtonWindows3.Name = "MzButtonWindows3"
        Me.MzButtonWindows3.ParentControl = Me
        Me.MzButtonWindows3.Size = New System.Drawing.Size(40, 24)
        Me.MzButtonWindows3.TabIndex = 3
        Me.MzButtonWindows3.TipoButton = BWCMM.MZButtonWindows.ModeButton.Minimize
        '
        'MzButtonWindows2
        '
        Me.MzButtonWindows2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MzButtonWindows2.BackgroundImage = CType(resources.GetObject("MzButtonWindows2.BackgroundImage"), System.Drawing.Image)
        Me.MzButtonWindows2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MzButtonWindows2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MzButtonWindows2.Enabled = False
        Me.MzButtonWindows2.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.MzButtonWindows2.Location = New System.Drawing.Point(800, 0)
        Me.MzButtonWindows2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MzButtonWindows2.Name = "MzButtonWindows2"
        Me.MzButtonWindows2.ParentControl = Me
        Me.MzButtonWindows2.Size = New System.Drawing.Size(40, 24)
        Me.MzButtonWindows2.TabIndex = 2
        Me.MzButtonWindows2.TipoButton = BWCMM.MZButtonWindows.ModeButton.Maximize
        '
        'MzButtonWindows1
        '
        Me.MzButtonWindows1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MzButtonWindows1.BackgroundImage = CType(resources.GetObject("MzButtonWindows1.BackgroundImage"), System.Drawing.Image)
        Me.MzButtonWindows1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MzButtonWindows1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MzButtonWindows1.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.MzButtonWindows1.Location = New System.Drawing.Point(840, 0)
        Me.MzButtonWindows1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MzButtonWindows1.Name = "MzButtonWindows1"
        Me.MzButtonWindows1.ParentControl = Me
        Me.MzButtonWindows1.Size = New System.Drawing.Size(40, 24)
        Me.MzButtonWindows1.TabIndex = 1
        Me.MzButtonWindows1.TipoButton = BWCMM.MZButtonWindows.ModeButton.Close
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(307, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gestionar Roles"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GobDatos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 52)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(880, 732)
        Me.Panel1.TabIndex = 9
        '
        'GobDatos
        '
        Me.GobDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GobDatos.Controls.Add(Me.BtnEliminar)
        Me.GobDatos.Controls.Add(Me.BtnModificar)
        Me.GobDatos.Controls.Add(Me.BtnLimpiar)
        Me.GobDatos.Controls.Add(Me.BtnAgregar)
        Me.GobDatos.Controls.Add(Me.TextBox2)
        Me.GobDatos.Controls.Add(Me.TextBox1)
        Me.GobDatos.Controls.Add(Me.ClbPermisos)
        Me.GobDatos.Controls.Add(Me.Label4)
        Me.GobDatos.Controls.Add(Me.Label3)
        Me.GobDatos.Controls.Add(Me.Label2)
        Me.GobDatos.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GobDatos.Location = New System.Drawing.Point(36, 34)
        Me.GobDatos.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.GobDatos.Name = "GobDatos"
        Me.GobDatos.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GobDatos.Size = New System.Drawing.Size(809, 663)
        Me.GobDatos.TabIndex = 5
        Me.GobDatos.TabStop = False
        Me.GobDatos.Text = "Datos del rol"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.eliminarUser
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(596, 574)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(176, 55)
        Me.BtnEliminar.TabIndex = 24
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnModificar.FlatAppearance.BorderSize = 0
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.modificarUser
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.Location = New System.Drawing.Point(397, 574)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(193, 55)
        Me.BtnModificar.TabIndex = 23
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnLimpiar.FlatAppearance.BorderSize = 0
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.limpiarCampos
        Me.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiar.Location = New System.Drawing.Point(216, 574)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(176, 55)
        Me.BtnLimpiar.TabIndex = 22
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnAgregar.FlatAppearance.BorderSize = 0
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.agregarUser
        Me.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregar.Location = New System.Drawing.Point(35, 574)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(176, 55)
        Me.BtnAgregar.TabIndex = 21
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(163, 111)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(608, 69)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(163, 62)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(607, 34)
        Me.TextBox1.TabIndex = 4
        '
        'ClbPermisos
        '
        Me.ClbPermisos.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.ClbPermisos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ClbPermisos.FormattingEnabled = True
        Me.ClbPermisos.Items.AddRange(New Object() {"Crear rol", "Editar rol", "Eliminar rol", "Asignar rol", "Crear usuario", "Actualizar usuario", "Crear categoría de producto", "Asignar catergoría a producto", "Registrar producto", "Actualizar producto", "Asignar stock maximo", "Asignar stock minimo"})
        Me.ClbPermisos.Location = New System.Drawing.Point(163, 203)
        Me.ClbPermisos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ClbPermisos.Name = "ClbPermisos"
        Me.ClbPermisos.Size = New System.Drawing.Size(607, 348)
        Me.ClbPermisos.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 203)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 28)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Permisos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 111)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 28)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Descripción:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        '
        'FrmRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(880, 784)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmRoles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmRoles"
        Me.PanSuperior.ResumeLayout(False)
        Me.PanSuperior.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GobDatos.ResumeLayout(False)
        Me.GobDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanSuperior As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MzButtonWindows3 As BWCMM.MZButtonWindows
    Friend WithEvents MzButtonWindows2 As BWCMM.MZButtonWindows
    Friend WithEvents MzButtonWindows1 As BWCMM.MZButtonWindows
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GobDatos As GroupBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ClbPermisos As CheckedListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnInicio As Button
End Class
