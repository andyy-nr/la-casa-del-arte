Public Class FrmMovimiento
    'Movimiento de Ventana
    Dim ex As Integer, ey As Integer
    Dim Arrastre As Boolean
    Private Sub PanSuperior_MouseDown(sender As Object, e As MouseEventArgs) Handles PanSuperior.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub PanSuperior_MouseMove(sender As Object, e As MouseEventArgs) Handles PanSuperior.MouseMove
        If Arrastre Then
            Me.Location = Me.PointToScreen(New Point(MousePosition.X - Me.Location.X - ex, MousePosition.Y - Me.Location.Y - ey))
        End If
    End Sub

    Private Sub PanSuperior_MouseUp(sender As Object, e As MouseEventArgs) Handles PanSuperior.MouseUp
        Arrastre = False
    End Sub


    'Botones
    Private Sub PibCerrar_Click(sender As Object, e As EventArgs) Handles PibCerrar.Click
        Dim Respuesta = MsgBox("¿Esta seguro de que desea regresar? Cualquier información no guardada se perderá", MsgBoxStyle.OkCancel, "Cerrar")
        If Respuesta = vbOK Then
            Me.Close()
            FrmPrincipal.Visible = True
        End If
    End Sub

    Private Sub PibRetornar_Click(sender As Object, e As EventArgs) Handles PibRetornar.Click
        Dim Respuesta = MsgBox("¿Esta seguro de que desea regresar? Cualquier información no guardada se perdera", MsgBoxStyle.OkCancel, "Cerrar")
        If Respuesta = vbOK Then
            Me.Close()
            FrmPrincipal.Visible = True
        End If
    End Sub

    Private Sub PibMaximizar_Click(sender As Object, e As EventArgs) Handles PibMaximizar.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PibMinimizar_Click(sender As Object, e As EventArgs) Handles PibMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Dim producto As New Tbl_ProductosDAO

    Sub LlenarComboxProd()
        Dim ds As New DataSet
        ds = producto.MostrarProductos()
        CbProductos.DataSource = ds.Tables(0)
        CbProductos.DisplayMember = "PRODUCTO" 'Nombre del alias
        CbProductos.ValueMember = "CÓDIGO" 'Nombre del alias
        CbProductos.Text = "Seleccione el producto..."
    End Sub

    'Función para cargar la información del formulario
    Private Sub FrmMovimiento_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Ajustar tamaño del formulario a la pantalla.
        Size = Screen.PrimaryScreen.WorkingArea.Size
        Location = Screen.PrimaryScreen.WorkingArea.Location
        LlenarComboxProd()
    End Sub

    'Función para llenar los datos del producto en los campos del formulario 
    Dim prod As New Tbl_MovimientosDAO


    Private Sub CbProductos_TextChanged(sender As Object, e As EventArgs) Handles CbProductos.TextChanged
        If CbProductos.Text <> "Seleccione el producto..." Then
            Dim Id_prod As String = CbProductos.SelectedValue.ToString()

            Dim dt As New DataTable
            dt = prod.CargarProducto(Id_prod)
            For Each row As DataRow In dt.Rows
                TxtCategoriaProd.Text = row("nombreCatg").ToString()
                TxtMarcaProd.Text = row("nombreMarca").ToString()
                TxtDescripcionProd.Text = row("descripcionProd").ToString()
                TxtPrecioProd.Text = row("precio_unitario").ToString()
                TxtUnidadesProd.Text = row("unidadesProd").ToString()
            Next
        End If
    End Sub

End Class