﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReportes
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.PanSuperior.SuspendLayout()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanSuperior
        '
        Me.PanSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanSuperior.Controls.Add(Me.BtnRegresar)
        Me.PanSuperior.Controls.Add(Me.PibMinimizar)
        Me.PanSuperior.Controls.Add(Me.PibCerrar)
        Me.PanSuperior.Controls.Add(Me.Label2)
        Me.PanSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanSuperior.Margin = New System.Windows.Forms.Padding(4)
        Me.PanSuperior.Name = "PanSuperior"
        Me.PanSuperior.Size = New System.Drawing.Size(1067, 52)
        Me.PanSuperior.TabIndex = 1
        '
        'PibMinimizar
        '
        Me.PibMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PibMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PibMinimizar.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.minimizarBTN
        Me.PibMinimizar.Location = New System.Drawing.Point(968, 2)
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
        Me.PibCerrar.Location = New System.Drawing.Point(1019, 3)
        Me.PibCerrar.Name = "PibCerrar"
        Me.PibCerrar.Size = New System.Drawing.Size(45, 45)
        Me.PibCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PibCerrar.TabIndex = 6
        Me.PibCerrar.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(350, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(367, 37)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Reportes Entradas / Salidas"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 52)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1067, 675)
        Me.ReportViewer1.TabIndex = 3
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Image = Global.SistemaInventarioLCDA.My.Resources.Resources.ingresar1
        Me.BtnRegresar.Location = New System.Drawing.Point(9, 2)
        Me.BtnRegresar.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(45, 49)
        Me.BtnRegresar.TabIndex = 10
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'FrmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 727)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.PanSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmReportes"
        Me.PanSuperior.ResumeLayout(False)
        Me.PanSuperior.PerformLayout()
        CType(Me.PibMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PibCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanSuperior As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PibMinimizar As PictureBox
    Friend WithEvents PibCerrar As PictureBox
    Friend WithEvents BtnRegresar As Button
End Class
