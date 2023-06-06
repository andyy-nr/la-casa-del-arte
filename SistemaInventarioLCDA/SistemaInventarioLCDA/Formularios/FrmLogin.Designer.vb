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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.PanSuperiorL = New System.Windows.Forms.Panel()
        Me.PibMinimizar = New System.Windows.Forms.PictureBox()
        Me.PibCerrar = New System.Windows.Forms.PictureBox()
        Me.PanIzquierdo = New System.Windows.Forms.Panel()
        Me.PibLogoL = New System.Windows.Forms.PictureBox()
        Me.PanCentral = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnEntrar = New System.Windows.Forms.Button()
        Me.TxtPwdL = New System.Windows.Forms.TextBox()
        Me.CebMostrarPwdL = New System.Windows.Forms.CheckBox()
        Me.TxtUserL = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanSuperiorL.SuspendLayout()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanIzquierdo.SuspendLayout()
        CType(Me.PibLogoL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanCentral.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanSuperiorL
        '
        Me.PanSuperiorL.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanSuperiorL.Controls.Add(Me.PibMinimizar)
        Me.PanSuperiorL.Controls.Add(Me.PibCerrar)
        Me.PanSuperiorL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSuperiorL.Location = New System.Drawing.Point(0, 0)
        Me.PanSuperiorL.Margin = New System.Windows.Forms.Padding(4)
        Me.PanSuperiorL.Name = "PanSuperiorL"
        Me.PanSuperiorL.Size = New System.Drawing.Size(1076, 52)
        Me.PanSuperiorL.TabIndex = 0
        '
        'PibMinimizar
        '
        Me.PibMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PibMinimizar.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.minimizarBTN
        Me.PibMinimizar.Location = New System.Drawing.Point(977, 3)
        Me.PibMinimizar.Name = "PibMinimizar"
        Me.PibMinimizar.Size = New System.Drawing.Size(45, 45)
        Me.PibMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PibMinimizar.TabIndex = 1
        Me.PibMinimizar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PibMinimizar, "Minimizar")
        '
        'PibCerrar
        '
        Me.PibCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PibCerrar.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.cerrarBTN
        Me.PibCerrar.Location = New System.Drawing.Point(1028, 4)
        Me.PibCerrar.Name = "PibCerrar"
        Me.PibCerrar.Size = New System.Drawing.Size(45, 45)
        Me.PibCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PibCerrar.TabIndex = 0
        Me.PibCerrar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PibCerrar, "Cerrar")
        '
        'PanIzquierdo
        '
        Me.PanIzquierdo.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.PanIzquierdo.Controls.Add(Me.PibLogoL)
        Me.PanIzquierdo.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanIzquierdo.Location = New System.Drawing.Point(0, 52)
        Me.PanIzquierdo.Name = "PanIzquierdo"
        Me.PanIzquierdo.Size = New System.Drawing.Size(333, 400)
        Me.PanIzquierdo.TabIndex = 3
        '
        'PibLogoL
        '
        Me.PibLogoL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PibLogoL.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.logoNuevo
        Me.PibLogoL.Location = New System.Drawing.Point(10, 39)
        Me.PibLogoL.Margin = New System.Windows.Forms.Padding(4)
        Me.PibLogoL.Name = "PibLogoL"
        Me.PibLogoL.Size = New System.Drawing.Size(315, 310)
        Me.PibLogoL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PibLogoL.TabIndex = 1
        Me.PibLogoL.TabStop = False
        '
        'PanCentral
        '
        Me.PanCentral.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PanCentral.Controls.Add(Me.BtnCancelar)
        Me.PanCentral.Controls.Add(Me.Label1)
        Me.PanCentral.Controls.Add(Me.BtnEntrar)
        Me.PanCentral.Controls.Add(Me.TxtPwdL)
        Me.PanCentral.Controls.Add(Me.CebMostrarPwdL)
        Me.PanCentral.Controls.Add(Me.TxtUserL)
        Me.PanCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanCentral.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PanCentral.Location = New System.Drawing.Point(333, 52)
        Me.PanCentral.Margin = New System.Windows.Forms.Padding(4)
        Me.PanCentral.Name = "PanCentral"
        Me.PanCentral.Size = New System.Drawing.Size(743, 400)
        Me.PanCentral.TabIndex = 5
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Location = New System.Drawing.Point(402, 294)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(270, 55)
        Me.BtnCancelar.TabIndex = 25
        Me.BtnCancelar.Text = "CANCELAR"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(209, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 54)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "INICIAR SESIÓN"
        '
        'BtnEntrar
        '
        Me.BtnEntrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnEntrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEntrar.FlatAppearance.BorderSize = 0
        Me.BtnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BtnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEntrar.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEntrar.ForeColor = System.Drawing.Color.White
        Me.BtnEntrar.Location = New System.Drawing.Point(71, 294)
        Me.BtnEntrar.Name = "BtnEntrar"
        Me.BtnEntrar.Size = New System.Drawing.Size(270, 55)
        Me.BtnEntrar.TabIndex = 4
        Me.BtnEntrar.Text = "ACCEDER"
        Me.BtnEntrar.UseVisualStyleBackColor = False
        '
        'TxtPwdL
        '
        Me.TxtPwdL.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtPwdL.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPwdL.ForeColor = System.Drawing.Color.DimGray
        Me.TxtPwdL.Location = New System.Drawing.Point(71, 182)
        Me.TxtPwdL.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPwdL.Name = "TxtPwdL"
        Me.TxtPwdL.Size = New System.Drawing.Size(601, 34)
        Me.TxtPwdL.TabIndex = 2
        Me.TxtPwdL.Text = "CONTRASEÑA"
        '
        'CebMostrarPwdL
        '
        Me.CebMostrarPwdL.AutoSize = True
        Me.CebMostrarPwdL.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CebMostrarPwdL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.CebMostrarPwdL.Location = New System.Drawing.Point(71, 224)
        Me.CebMostrarPwdL.Margin = New System.Windows.Forms.Padding(4)
        Me.CebMostrarPwdL.Name = "CebMostrarPwdL"
        Me.CebMostrarPwdL.Size = New System.Drawing.Size(151, 23)
        Me.CebMostrarPwdL.TabIndex = 3
        Me.CebMostrarPwdL.Text = "Mostrar contraseña"
        Me.CebMostrarPwdL.UseVisualStyleBackColor = True
        '
        'TxtUserL
        '
        Me.TxtUserL.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtUserL.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUserL.ForeColor = System.Drawing.Color.DimGray
        Me.TxtUserL.Location = New System.Drawing.Point(71, 111)
        Me.TxtUserL.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtUserL.Name = "TxtUserL"
        Me.TxtUserL.Size = New System.Drawing.Size(601, 34)
        Me.TxtUserL.TabIndex = 1
        Me.TxtUserL.Text = "USUARIO"
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 452)
        Me.Controls.Add(Me.PanCentral)
        Me.Controls.Add(Me.PanIzquierdo)
        Me.Controls.Add(Me.PanSuperiorL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Inicio de Sesión"
        Me.PanSuperiorL.ResumeLayout(False)
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanIzquierdo.ResumeLayout(False)
        CType(Me.PibLogoL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanCentral.ResumeLayout(False)
        Me.PanCentral.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanSuperiorL As Panel
    Friend WithEvents PanIzquierdo As Panel
    Friend WithEvents PibLogoL As PictureBox
    Friend WithEvents PanCentral As Panel
    Friend WithEvents TxtPwdL As TextBox
    Friend WithEvents CebMostrarPwdL As CheckBox
    Friend WithEvents TxtUserL As TextBox
    Friend WithEvents BtnEntrar As Button
    Friend WithEvents PibMinimizar As PictureBox
    Friend WithEvents PibCerrar As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnCancelar As Button
End Class
