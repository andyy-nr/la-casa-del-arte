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


    'Botones

    'Botón para cerrar el formulario 
    Private Sub PibCerrar_Click(sender As Object, e As EventArgs) Handles PibCerrar.Click
        Dim Respuesta = MsgBox("¿Esta seguro de que desea regresar? Cualquier información no guardada se perderá", MsgBoxStyle.OkCancel, "Cerrar")
        If Respuesta = vbOK Then
            Me.Close()
            FrmPrincipal.Visible = True
        End If
    End Sub

    'Botón para regresar al menú principal
    Private Sub PibRetornar_Click(sender As Object, e As EventArgs) Handles PibRetornar.Click
        Dim Respuesta = MsgBox("¿Esta seguro de que desea regresar? Cualquier información no guardada se perdera", MsgBoxStyle.OkCancel, "Cerrar")
        If Respuesta = vbOK Then
            Me.Close()
            FrmPrincipal.Visible = True
        End If
    End Sub

    'Botón para maximizar el formulario 
    Private Sub PibMaximizar_Click(sender As Object, e As EventArgs) Handles PibMaximizar.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    'Botón para minimizar el formulario 
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

    'Función para rellenar el ComboBox de Categoría
    Dim categoria As New Tbl_CategoriasDAO
    Sub LlenarComboxCatg()
        Dim ds As New DataSet
        ds = categoria.MostrarCategorias()
        CbCategoria.DataSource = ds.Tables(0)
        CbCategoria.DisplayMember = "CATEGORÍA" 'Nombre del alias
        CbCategoria.ValueMember = "CÓDIGO" 'Nombre del alias
        CbCategoria.Text = "Seleccione la categoría..."
    End Sub

    'Función para rellenar el ComboBox de Marca
    Dim marca As New Tbl_MarcasDAO
    Sub LlenarComboxMarca()
        Dim ds As New DataSet
        ds = marca.MostrarMarcas()
        CbMarca.DataSource = ds.Tables(0)
        CbMarca.DisplayMember = "MARCA" 'Nombre del alias
        CbMarca.ValueMember = "CÓDIGO" 'Nombre del alias
        CbMarca.Text = "Seleccione la marca..."
    End Sub

    'Función para limpiar los campos del formulario
    Private Sub Limpiar()
        TxtIdProd.Clear()
        TxtIdProd.Enabled = True
        TxtIdProd.Focus()
        CbCategoria.Text = "Seleccione la categoría..."
        CbMarca.Text = "Seleccione la marca..."
        TxtNombreProd.Clear()
        TxtPrecioU.Clear()
        TxtDescripcion.Clear()
        TxtUnidadesProd.Clear()
        BtnAgregarP.Enabled = True
    End Sub

    'Función para cargar la información del formulario
    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Ajustar tamaño del formulario a la pantalla.
        Size = Screen.PrimaryScreen.WorkingArea.Size
        Location = Screen.PrimaryScreen.WorkingArea.Location

        LlenarTabla()
        LlenarComboxCatg()
        LlenarComboxMarca()
    End Sub

    'Función para rellenar los campos del formulario al seleccionar una fila del DataGripViewer
    Private Sub DgvProductos_MouseClick(sender As Object, e As MouseEventArgs) Handles DgvProductos.MouseClick


        If (validarRegistros()) Then
            Dim fila As Integer = DgvProductos.CurrentRow.Index
            TxtIdProd.Enabled = False
            TxtIdProd.Text = DgvProductos.Rows(fila).Cells(0).Value
            CbCategoria.Text = DgvProductos.Rows(fila).Cells(1).Value
            CbMarca.Text = DgvProductos.Rows(fila).Cells(2).Value
            TxtNombreProd.Text = DgvProductos.Rows(fila).Cells(3).Value
            TxtPrecioU.Text = DgvProductos.Rows(fila).Cells(4).Value
            TxtDescripcion.Text = DgvProductos.Rows(fila).Cells(5).Value.ToString()
            TxtUnidadesProd.Text = DgvProductos.Rows(fila).Cells(6).Value
            BtnAgregarP.Enabled = False
        End If

    End Sub


    'Validaciones

    'Función que valida los campos obligatorios del formulario
    Private Function validarCampos() As Boolean
        Dim camposLlenados = False

        If (TxtIdProd.Text <> "" And TxtNombreProd.Text <> "" And CbCategoria.Text <> "Seleccione la categoría..." And CbMarca.Text <> "Seleccione la marca..." And TxtPrecioU.Text <> "" And TxtUnidadesProd.Text <> "") Then
            camposLlenados = True
        End If

        Return camposLlenados
    End Function

    'Función para validar los campos no obligatorios del formulario
    Private Function validarCamposNull(ByVal campo As String, txt As TextBox) As String
        If String.IsNullOrEmpty(txt.Text.ToString().Trim) = True Then
            campo = Nothing
        Else
            campo = txt.Text
        End If
        Return campo
    End Function

    'Función para validar si el inventario es un valor correcto, es decir, mayor o igual a 0
    Private Function validarCantidad(ByVal txtbox As TextBox) As Boolean
        Dim cantidad As Integer

        If Integer.TryParse(txtbox.Text, cantidad) AndAlso cantidad >= 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    'Validar que el DataGridView tenga datos
    Private Function validarRegistros() As Boolean
        Dim resp = False
        If (DgvProductos.Rows.Count = 0) Then
            MsgBox("No hay registros guardados, porfavor agregue registros", MsgBoxStyle.Exclamation, "Advertencia")
            TxtIdProd.Focus()
            Return False
            Exit Function
        Else
            resp = True
        End If
        Return True
    End Function


    'Botones CRUD (Create, Read, Update, Delete)

    'Botón para agregar un producto
    Private Sub BtnAgregarP_Click(sender As Object, e As EventArgs) Handles BtnAgregarP.Click
        Try
            If Not validarCampos() Then
                MsgBox("Datos obligatorios del producto incompletos.", MsgBoxStyle.Exclamation, "Advertencia")
                Exit Sub
            End If

            Dim producto = New Tbl_Productos() 'Entidad/Tabla de Productos
            Dim productoDao As New Tbl_ProductosDAO 'DAO de Productos

            producto.Id_producto = TxtIdProd.Text.Trim()
            producto.Id_categoria = CbCategoria.SelectedValue
            producto.Id_marca = CbMarca.SelectedValue
            producto.NombreProd = TxtNombreProd.Text.Trim()
            producto.DescripcionProd = validarCamposNull(producto.DescripcionProd, TxtDescripcion)

            If validarCantidad(TxtPrecioU) Then
                producto.Precio_unitario = TxtPrecioU.Text.Trim()
            Else
                MsgBox("El valor ingresado es incorrecto.", MsgBoxStyle.Exclamation, "Advertencia")
                TxtPrecioU.Clear()
                TxtPrecioU.Focus()
                Exit Sub
            End If

            If validarCantidad(TxtUnidadesProd) Then
                producto.UnidadesProd = TxtUnidadesProd.Text.Trim()
            Else
                MsgBox("El valor ingresado es incorrecto.", MsgBoxStyle.Exclamation, "Advertencia")
                TxtUnidadesProd.Clear()
                TxtUnidadesProd.Focus()
                Exit Sub
            End If

            If productoDao.validarProducto(producto) Then
                MsgBox("El producto ingresado ya existe.", MsgBoxStyle.Exclamation, "Advertencia")
                Exit Sub
            End If

            Dim resp = productoDao.AgregarProducto(producto)
            If (resp) Then
                MsgBox("Registro guardado exitosamente.", MsgBoxStyle.Information, "Productos")
            Else
                MsgBox("Error al guardar el registro.", MsgBoxStyle.Critical, "Productos")
            End If

            Limpiar()
            LlenarTabla()

        Catch ex As Exception
            MsgBox("Error al intentar guardar el registro..." & ex.Message, MsgBoxStyle.Critical, "Productos")
        End Try
    End Sub


    'Botón para limpiar los campos del formulario
    Private Sub BtnLimpiarP_Click(sender As Object, e As EventArgs) Handles BtnLimpiarP.Click
        Limpiar()
    End Sub


    'Botón para eliminar un producto 
    Private Sub BtnEliminarP_Click(sender As Object, e As EventArgs) Handles BtnEliminarP.Click
        Try
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

                Limpiar()
                LlenarTabla()

            Else
                MsgBox("Error al intentar eliminar el producto", MsgBoxStyle.Critical, "Productos")
            End If
        Catch ex As Exception
            MsgBox("Error al intentar eliminar el registro..." & ex.Message, MsgBoxStyle.Critical, "Productos")
        End Try
    End Sub

    'Botón para editar un producto
    Private Sub BtnEditarP_Click(sender As Object, e As EventArgs) Handles BtnEditarP.Click
        Try
            If Not validarCampos() Then
                MsgBox("Datos obligatorios del producto incompletos.", MsgBoxStyle.Exclamation, "Advertencia")
                Exit Sub
            End If

            Dim productoDao As New Tbl_ProductosDAO()
            Dim producto As New Tbl_Productos

            producto.Id_producto = TxtIdProd.Text.Trim()
            producto.Id_categoria = CbCategoria.SelectedValue
            producto.Id_marca = CbMarca.SelectedValue
            producto.NombreProd = TxtNombreProd.Text.Trim()
            producto.DescripcionProd = validarCamposNull(producto.DescripcionProd, TxtDescripcion)

            If validarCantidad(TxtPrecioU) Then
                producto.Precio_unitario = TxtPrecioU.Text.Trim()
            Else
                MsgBox("El valor ingresado es incorrecto.", MsgBoxStyle.Exclamation, "Advertencia")
                TxtPrecioU.Clear()
                TxtPrecioU.Focus()
                Exit Sub
            End If

            If validarCantidad(TxtUnidadesProd) Then
                producto.UnidadesProd = TxtUnidadesProd.Text.Trim()
            Else
                MsgBox("El valor ingresado es incorrecto.", MsgBoxStyle.Exclamation, "Advertencia")
                TxtUnidadesProd.Clear()
                TxtUnidadesProd.Focus()

                Exit Sub
            End If

            Dim resp = productoDao.EditarProducto(producto)
            If (resp) Then
                MsgBox("Producto editado exitosamente.", MsgBoxStyle.Information, "Productos")
            Else
                MsgBox("Error al intentar editar el producto", MsgBoxStyle.Critical, "Productos")
            End If

            Limpiar()
            LlenarTabla()
        Catch ex As Exception
            MsgBox("Error al intentar editar el registro..." & ex.Message, MsgBoxStyle.Critical, "Productos")
        End Try
    End Sub



    'Botón para buscar por nombre de producto
    Private Sub BtnBuscarProducto_Click(sender As Object, e As EventArgs) Handles BtnBuscarProducto.Click
        Dim ds As New DataSet
        Dim dao As New Tbl_ProductosDAO

        ds = dao.BuscarXNombre(TxtBuscar.Text.Trim)
        DgvProductos.DataSource = ds.Tables(0)
        DgvProductos.Refresh()

        If TxtBuscar.Text = "" Then
            LlenarTabla()
        End If
    End Sub


End Class