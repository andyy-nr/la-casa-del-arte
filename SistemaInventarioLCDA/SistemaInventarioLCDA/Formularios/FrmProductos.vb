Public Class FrmProductos
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



    'Ajustar tamaño del formulario a la pantalla.
    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Size = Screen.PrimaryScreen.WorkingArea.Size
        Location = Screen.PrimaryScreen.WorkingArea.Location
        LlenarTabla()
        LlenarComboxCatg()
        LlenarComboxMarca()
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

    'Datos
    'Función para rellenar el DataGripViewer de Productos
    Sub LlenarTabla()
        Dim productoDao As New Tbl_ProductosDAO
        DgvProductos.DataSource = productoDao.MostrarProductos().Tables(0)
        DgvProductos.Refresh()
        GbProductos.Text = "Productos Almacenados: " & DgvProductos.RowCount
    End Sub


    'Función para rellenar los campos del formulario
    Sub LlenarComboxCatg()
        Dim productoDao As New Tbl_ProductosDAO
        CbCategoria.DataSource = productoDao.CargarComboxCatg().Tables(0)
        CbCategoria.DisplayMember = "nombreCatg"
        CbCategoria.ValueMember = "id_categoria"
        CbCategoria.Text = "Seleccione la categoría..."
    End Sub

    Sub LlenarComboxMarca()
        Dim productoDao As New Tbl_ProductosDAO
        CbMarca.DataSource = productoDao.CargarComboxMarca().Tables(0)
        CbMarca.DisplayMember = "nombreMarca"
        CbMarca.ValueMember = "id_marca"
        CbMarca.Text = "Seleccione la marca..."
    End Sub


    Private Sub DgvProductos_MouseClick(sender As Object, e As MouseEventArgs) Handles DgvProductos.MouseClick
        Dim fila As Integer = DgvProductos.CurrentRow.Index

        TxtIdProd.Text = DgvProductos.Rows(fila).Cells(0).Value
        CbCategoria.Text = DgvProductos.Rows(fila).Cells(1).Value
        CbMarca.Text = DgvProductos.Rows(fila).Cells(2).Value
        TxtNombreProd.Text = DgvProductos.Rows(fila).Cells(3).Value
        TxtPrecioU.Text = DgvProductos.Rows(fila).Cells(4).Value
        TxtDescripcion.Text = DgvProductos.Rows(fila).Cells(5).Value
        TxtUnidadesProd.Text = DgvProductos.Rows(fila).Cells(6).Value


    End Sub


    'Botoenes CRUD
    Private Sub BtnAgregarP_Click(sender As Object, e As EventArgs) Handles BtnAgregarP.Click
        Try
            Dim producto = New Tbl_Productos() 'Entidad/Tabla de Productos
            Dim productoDao As New Tbl_ProductosDAO 'DAO de Productos

            producto.Id_producto = TxtIdProd.Text.Trim()
            producto.Id_categoria = CbCategoria.SelectedValue
            producto.Id_marca = CbMarca.SelectedValue
            producto.NombreProd = TxtNombreProd.Text.Trim()
            producto.Precio_unitario = TxtPrecioU.Text.Trim()
            producto.DescripcionProd = TxtDescripcion.Text.Trim()
            producto.UnidadesProd = TxtUnidadesProd.Text.Trim()

            Dim resp = productoDao.AgregarProducto(producto)
            If (resp) Then
                MsgBox("Registro guardado exitosamente.", MsgBoxStyle.Information, "Productos")
            Else
                MsgBox("Error al guardar el registro.", MsgBoxStyle.Critical, "Productos")
            End If
            TxtIdProd.Clear()
            TxtIdProd.Focus()
            CbCategoria.Text = "Seleccione la categoría..."
            CbMarca.Text = "Seleccione la marca..."
            TxtNombreProd.Clear()
            TxtPrecioU.Clear()
            TxtDescripcion.Clear()
            TxtUnidadesProd.Clear()

            LlenarTabla()

        Catch ex As Exception
            MsgBox("Error al intentar guardar el registro..." & ex.Message, MsgBoxStyle.Critical, "Productos")
        End Try
    End Sub

    Private Sub BtnLimpiarP_Click(sender As Object, e As EventArgs) Handles BtnLimpiarP.Click
        TxtIdProd.Clear()
        TxtIdProd.Focus()
        CbCategoria.Text = "Seleccione la categoría..."
        CbMarca.Text = "Seleccione la marca..."
        TxtNombreProd.Clear()
        TxtPrecioU.Clear()
        TxtDescripcion.Clear()
        TxtUnidadesProd.Clear()
    End Sub

    Private Sub BtnEliminarP_Click(sender As Object, e As EventArgs) Handles BtnEliminarP.Click
        Dim Id_prod As String = TxtIdProd.Text.Trim()
        Dim productosDao As New Tbl_ProductosDAO()
        Dim productos As New Tbl_Productos
        productos = productosDao.BuscarProducto(Id_prod)
        If productos.Id_producto Is Nothing Then
            MsgBox("El producto no existe. ", MsgBoxStyle.Exclamation, "Productos")
            Exit Sub
        End If
        Dim resp As VariantType
        resp = (MsgBox("Desea eliminar el producto: " & productos.NombreProd, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Productos"))
        If (resp = vbNo) Then
            MsgBox("Tarea cancelada", MsgBoxStyle.Information, "Productos")
            Exit Sub

        End If

        Dim eliminado = productosDao.EliminarProducto(productos.Id_producto)
        If (eliminado) Then
            MsgBox("Producto eliminado exitosamente.", MsgBoxStyle.Information, "Productos")

            LlenarTabla()
            Limpiar()

        Else
            MsgBox("Error al intentar eliminar el producto", MsgBoxStyle.Critical, "Productos")
        End If
    End Sub

    Private Sub BtnEditarP_Click(sender As Object, e As EventArgs) Handles BtnEditarP.Click
        Dim Tbl_ProductosDao As New Tbl_ProductosDAO()
        Dim productos As New Tbl_Productos

        productos.Id_producto = TxtIdProd.Text.Trim()
        productos.Id_categoria = CbCategoria.SelectedValue
        productos.Id_marca = CbMarca.SelectedValue
        productos.NombreProd = TxtNombreProd.Text.Trim()
        productos.Precio_unitario = TxtPrecioU.Text.Trim()
        productos.DescripcionProd = TxtDescripcion.Text.Trim()
        productos.UnidadesProd = TxtUnidadesProd.Text.Trim()
        Dim resp = Tbl_ProductosDao.editarProducto(productos)
        If (resp) Then
            MsgBox("Producto editado exitosamente.", MsgBoxStyle.Information, "Productos")
        Else
            MsgBox("Error al intentar editar el producto", MsgBoxStyle.Critical, "Productos")


        End If
        LlenarTabla()
        Limpiar()

    End Sub

    Private Sub Limpiar()
        TxtIdProd.Clear()
        TxtIdProd.Focus()
        CbCategoria.Text = "Seleccione la categoría..."
        CbMarca.Text = "Seleccione la marca..."
        TxtNombreProd.Clear()
        TxtPrecioU.Clear()
        TxtDescripcion.Clear()
        TxtUnidadesProd.Clear()
    End Sub

End Class