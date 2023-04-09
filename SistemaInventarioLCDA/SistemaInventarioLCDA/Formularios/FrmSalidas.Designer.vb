<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSalidas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSalidas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnLimpiarS = New System.Windows.Forms.Button()
        Me.BtnAgregarS = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MzButtonWindows1 = New BWCMM.MZButtonWindows()
        Me.MzButtonWindows2 = New BWCMM.MZButtonWindows()
        Me.MzButtonWindows3 = New BWCMM.MZButtonWindows()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MzButtonWindows3)
        Me.Panel1.Controls.Add(Me.MzButtonWindows2)
        Me.Panel1.Controls.Add(Me.MzButtonWindows1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 52)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(580, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Gestionar Salidas"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1370, 469)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.BtnLimpiarS)
        Me.GroupBox1.Controls.Add(Me.BtnAgregarS)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1313, 400)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales de Salida"
        '
        'TextBox8
        '
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.Enabled = False
        Me.TextBox8.Location = New System.Drawing.Point(560, 198)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 29)
        Me.TextBox8.TabIndex = 17
        '
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(710, 153)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 29)
        Me.TextBox7.TabIndex = 16
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(476, 153)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 29)
        Me.TextBox6.TabIndex = 15
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Location = New System.Drawing.Point(476, 108)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 29)
        Me.TextBox5.TabIndex = 14
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(476, 43)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox4.Size = New System.Drawing.Size(200, 50)
        Me.TextBox4.TabIndex = 13
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Location = New System.Drawing.Point(155, 187)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(163, 29)
        Me.TextBox3.TabIndex = 12
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(118, 141)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 29)
        Me.TextBox2.TabIndex = 11
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(118, 96)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 29)
        Me.TextBox1.TabIndex = 10
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(118, 51)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 29)
        Me.ComboBox1.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(472, 206)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 21)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Stock Total:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(598, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 21)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Stock Bodega:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(376, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 21)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Stock Tienda:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 21)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Fecha de salida:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(376, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 21)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Cantidad:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(376, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 21)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Descripcion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Marca:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Categoria:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Producto:"
        '
        'BtnLimpiarS
        '
        Me.BtnLimpiarS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpiarS.FlatAppearance.BorderSize = 0
        Me.BtnLimpiarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiarS.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiarS.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.limpiarCampos
        Me.BtnLimpiarS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiarS.Location = New System.Drawing.Point(425, 319)
        Me.BtnLimpiarS.Name = "BtnLimpiarS"
        Me.BtnLimpiarS.Size = New System.Drawing.Size(176, 55)
        Me.BtnLimpiarS.TabIndex = 20
        Me.BtnLimpiarS.Text = "Limpiar"
        Me.BtnLimpiarS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiarS.UseVisualStyleBackColor = True
        '
        'BtnAgregarS
        '
        Me.BtnAgregarS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarS.FlatAppearance.BorderSize = 0
        Me.BtnAgregarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarS.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarS.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.agregarProd
        Me.BtnAgregarS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregarS.Location = New System.Drawing.Point(155, 319)
        Me.BtnAgregarS.Name = "BtnAgregarS"
        Me.BtnAgregarS.Size = New System.Drawing.Size(183, 55)
        Me.BtnAgregarS.TabIndex = 19
        Me.BtnAgregarS.Text = "Agregar"
        Me.BtnAgregarS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregarS.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.imgSalida
        Me.PictureBox1.Location = New System.Drawing.Point(888, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(335, 310)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'MzButtonWindows1
        '
        Me.MzButtonWindows1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MzButtonWindows1.BackgroundImage = CType(resources.GetObject("MzButtonWindows1.BackgroundImage"), System.Drawing.Image)
        Me.MzButtonWindows1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MzButtonWindows1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MzButtonWindows1.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.MzButtonWindows1.Location = New System.Drawing.Point(1250, 0)
        Me.MzButtonWindows1.Name = "MzButtonWindows1"
        Me.MzButtonWindows1.ParentControl = Me
        Me.MzButtonWindows1.Size = New System.Drawing.Size(40, 24)
        Me.MzButtonWindows1.TabIndex = 2
        Me.MzButtonWindows1.TipoButton = BWCMM.MZButtonWindows.ModeButton.Minimize
        '
        'MzButtonWindows2
        '
        Me.MzButtonWindows2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MzButtonWindows2.BackgroundImage = CType(resources.GetObject("MzButtonWindows2.BackgroundImage"), System.Drawing.Image)
        Me.MzButtonWindows2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MzButtonWindows2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MzButtonWindows2.Enabled = False
        Me.MzButtonWindows2.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.MzButtonWindows2.Location = New System.Drawing.Point(1290, 0)
        Me.MzButtonWindows2.Name = "MzButtonWindows2"
        Me.MzButtonWindows2.ParentControl = Me
        Me.MzButtonWindows2.Size = New System.Drawing.Size(40, 24)
        Me.MzButtonWindows2.TabIndex = 3
        Me.MzButtonWindows2.TipoButton = BWCMM.MZButtonWindows.ModeButton.Maximize
        '
        'MzButtonWindows3
        '
        Me.MzButtonWindows3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MzButtonWindows3.BackgroundImage = CType(resources.GetObject("MzButtonWindows3.BackgroundImage"), System.Drawing.Image)
        Me.MzButtonWindows3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MzButtonWindows3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MzButtonWindows3.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.MzButtonWindows3.Location = New System.Drawing.Point(1330, 0)
        Me.MzButtonWindows3.Name = "MzButtonWindows3"
        Me.MzButtonWindows3.ParentControl = Me
        Me.MzButtonWindows3.Size = New System.Drawing.Size(40, 24)
        Me.MzButtonWindows3.TabIndex = 4
        Me.MzButtonWindows3.TipoButton = BWCMM.MZButtonWindows.ModeButton.Close
        '
        'FrmSalidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 521)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSalidas"
        Me.Text = "FrmSalidas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnLimpiarS As Button
    Friend WithEvents BtnAgregarS As Button
    Friend WithEvents MzButtonWindows3 As BWCMM.MZButtonWindows
    Friend WithEvents MzButtonWindows2 As BWCMM.MZButtonWindows
    Friend WithEvents MzButtonWindows1 As BWCMM.MZButtonWindows
End Class
