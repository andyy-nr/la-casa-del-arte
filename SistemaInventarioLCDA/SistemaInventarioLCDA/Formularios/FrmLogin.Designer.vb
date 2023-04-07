<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.PanSuperiorL = New System.Windows.Forms.Panel()
        Me.MzButtonWindows3 = New BWCMM.MZButtonWindows()
        Me.MzButtonWindows2 = New BWCMM.MZButtonWindows()
        Me.MzButtonWindows1 = New BWCMM.MZButtonWindows()
        Me.TxtUserL = New System.Windows.Forms.TextBox()
        Me.TxtPwdL = New System.Windows.Forms.TextBox()
        Me.PanCentral = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnEntrar = New System.Windows.Forms.Button()
        Me.CebMostrarPwdL = New System.Windows.Forms.CheckBox()
        Me.PibLogoL = New System.Windows.Forms.PictureBox()
        Me.PanSuperiorL.SuspendLayout()
        Me.PanCentral.SuspendLayout()
        CType(Me.PibLogoL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanSuperiorL
        '
        Me.PanSuperiorL.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanSuperiorL.Controls.Add(Me.MzButtonWindows3)
        Me.PanSuperiorL.Controls.Add(Me.MzButtonWindows2)
        Me.PanSuperiorL.Controls.Add(Me.MzButtonWindows1)
        Me.PanSuperiorL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSuperiorL.Location = New System.Drawing.Point(0, 0)
        Me.PanSuperiorL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanSuperiorL.Name = "PanSuperiorL"
        Me.PanSuperiorL.Size = New System.Drawing.Size(467, 30)
        Me.PanSuperiorL.TabIndex = 0
        '
        'MzButtonWindows3
        '
        Me.MzButtonWindows3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MzButtonWindows3.BackgroundImage = CType(resources.GetObject("MzButtonWindows3.BackgroundImage"), System.Drawing.Image)
        Me.MzButtonWindows3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MzButtonWindows3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MzButtonWindows3.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.MzButtonWindows3.Location = New System.Drawing.Point(347, 0)
        Me.MzButtonWindows3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MzButtonWindows3.Name = "MzButtonWindows3"
        Me.MzButtonWindows3.ParentControl = Me
        Me.MzButtonWindows3.Size = New System.Drawing.Size(40, 24)
        Me.MzButtonWindows3.TabIndex = 2
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
        Me.MzButtonWindows2.Location = New System.Drawing.Point(387, 0)
        Me.MzButtonWindows2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MzButtonWindows2.Name = "MzButtonWindows2"
        Me.MzButtonWindows2.ParentControl = Me
        Me.MzButtonWindows2.Size = New System.Drawing.Size(40, 24)
        Me.MzButtonWindows2.TabIndex = 1
        Me.MzButtonWindows2.TipoButton = BWCMM.MZButtonWindows.ModeButton.Maximize
        '
        'MzButtonWindows1
        '
        Me.MzButtonWindows1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MzButtonWindows1.BackgroundImage = CType(resources.GetObject("MzButtonWindows1.BackgroundImage"), System.Drawing.Image)
        Me.MzButtonWindows1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MzButtonWindows1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MzButtonWindows1.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.MzButtonWindows1.Location = New System.Drawing.Point(427, 0)
        Me.MzButtonWindows1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MzButtonWindows1.Name = "MzButtonWindows1"
        Me.MzButtonWindows1.ParentControl = Me
        Me.MzButtonWindows1.Size = New System.Drawing.Size(40, 24)
        Me.MzButtonWindows1.TabIndex = 0
        Me.MzButtonWindows1.TipoButton = BWCMM.MZButtonWindows.ModeButton.Close
        '
        'TxtUserL
        '
        Me.TxtUserL.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUserL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtUserL.Location = New System.Drawing.Point(60, 341)
        Me.TxtUserL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtUserL.Name = "TxtUserL"
        Me.TxtUserL.Size = New System.Drawing.Size(332, 34)
        Me.TxtUserL.TabIndex = 2
        '
        'TxtPwdL
        '
        Me.TxtPwdL.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPwdL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtPwdL.Location = New System.Drawing.Point(60, 417)
        Me.TxtPwdL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtPwdL.Name = "TxtPwdL"
        Me.TxtPwdL.Size = New System.Drawing.Size(332, 34)
        Me.TxtPwdL.TabIndex = 3
        Me.TxtPwdL.UseSystemPasswordChar = True
        '
        'PanCentral
        '
        Me.PanCentral.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.PanCentral.Controls.Add(Me.Label2)
        Me.PanCentral.Controls.Add(Me.Label1)
        Me.PanCentral.Controls.Add(Me.BtnEntrar)
        Me.PanCentral.Controls.Add(Me.CebMostrarPwdL)
        Me.PanCentral.Controls.Add(Me.TxtPwdL)
        Me.PanCentral.Controls.Add(Me.TxtUserL)
        Me.PanCentral.Controls.Add(Me.PibLogoL)
        Me.PanCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanCentral.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PanCentral.Location = New System.Drawing.Point(0, 30)
        Me.PanCentral.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanCentral.Name = "PanCentral"
        Me.PanCentral.Size = New System.Drawing.Size(467, 585)
        Me.PanCentral.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(60, 388)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 28)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(60, 311)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 28)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Usuario"
        '
        'BtnEntrar
        '
        Me.BtnEntrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnEntrar.FlatAppearance.BorderSize = 0
        Me.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEntrar.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEntrar.ForeColor = System.Drawing.Color.Black
        Me.BtnEntrar.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.ingresar
        Me.BtnEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEntrar.Location = New System.Drawing.Point(160, 506)
        Me.BtnEntrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEntrar.Name = "BtnEntrar"
        Me.BtnEntrar.Size = New System.Drawing.Size(153, 65)
        Me.BtnEntrar.TabIndex = 21
        Me.BtnEntrar.Text = "Entrar"
        Me.BtnEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEntrar.UseVisualStyleBackColor = True
        '
        'CebMostrarPwdL
        '
        Me.CebMostrarPwdL.AutoSize = True
        Me.CebMostrarPwdL.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CebMostrarPwdL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.CebMostrarPwdL.Location = New System.Drawing.Point(60, 460)
        Me.CebMostrarPwdL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CebMostrarPwdL.Name = "CebMostrarPwdL"
        Me.CebMostrarPwdL.Size = New System.Drawing.Size(151, 23)
        Me.CebMostrarPwdL.TabIndex = 20
        Me.CebMostrarPwdL.Text = "Mostrar contraseña"
        Me.CebMostrarPwdL.UseVisualStyleBackColor = True
        '
        'PibLogoL
        '
        Me.PibLogoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PibLogoL.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.logoNuevo
        Me.PibLogoL.Location = New System.Drawing.Point(65, 0)
        Me.PibLogoL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PibLogoL.Name = "PibLogoL"
        Me.PibLogoL.Size = New System.Drawing.Size(333, 308)
        Me.PibLogoL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PibLogoL.TabIndex = 1
        Me.PibLogoL.TabStop = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 615)
        Me.Controls.Add(Me.PanCentral)
        Me.Controls.Add(Me.PanSuperiorL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmLogin"
        Me.PanSuperiorL.ResumeLayout(False)
        Me.PanCentral.ResumeLayout(False)
        Me.PanCentral.PerformLayout()
        CType(Me.PibLogoL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanSuperiorL As Panel
    Friend WithEvents MzButtonWindows3 As BWCMM.MZButtonWindows
    Friend WithEvents MzButtonWindows2 As BWCMM.MZButtonWindows
    Friend WithEvents MzButtonWindows1 As BWCMM.MZButtonWindows
    Friend WithEvents PanCentral As Panel
    Friend WithEvents TxtPwdL As TextBox
    Friend WithEvents TxtUserL As TextBox
    Friend WithEvents PibLogoL As PictureBox
    Friend WithEvents CebMostrarPwdL As CheckBox
    Friend WithEvents BtnEntrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
