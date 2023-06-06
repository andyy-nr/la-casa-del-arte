Public Class FrmCategoria
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
        Dim Respuesta = MsgBox("¿Esta seguro de que desea salir? Cualquier información no guardada se perderá", MsgBoxStyle.OkCancel, "Cerrar")
        If Respuesta = vbOK Then
            Me.Close()
            FrmPrincipal.Visible = True
        End If
    End Sub

    'Botón para regresar al formulario principal
    Private Sub PibRetornar_Click(sender As Object, e As EventArgs) Handles PibRetornar.Click
        Dim Respuesta = MsgBox("¿Esta seguro de que desea regresar? Cualquier información no guardada se perderá", MsgBoxStyle.OkCancel, "Cerrar")
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

    'Función para rellenar el DataGripViewer de Categorías
    Sub LlenarTabla()
        Dim categoriaDAO As New Tbl_CategoriasDAO
        DgvCategorias.DataSource = categoriaDAO.MostrarCategorias().Tables(0)
        DgvCategorias.Refresh()
        GbCategorias.Text = "Categorías Registradas: " & DgvCategorias.RowCount
    End Sub

    Sub Limpiar()
        TxtIdCat.Clear()
        TxtNombreCat.Clear()
        TxtDescCat.Clear()
        TxtNombreCat.Focus()
        BtnAgregarC.Enabled = True
    End Sub

    'Función para rellenar los campos del formulario al seleccionar una fila del DataGripViewer
    Private Sub DgvCategorias_MouseClick_1(sender As Object, e As MouseEventArgs) Handles DgvCategorias.MouseClick
        If (validarRegistros()) Then
            Dim fila As Integer = DgvCategorias.CurrentRow.Index
            TxtIdCat.Text = DgvCategorias.Rows(fila).Cells(0).Value
            TxtNombreCat.Text = DgvCategorias.Rows(fila).Cells(1).Value
            TxtDescCat.Text = DgvCategorias.Rows(fila).Cells(2).Value
            BtnAgregarC.Enabled = False
        End If
    End Sub



    'Función para rellenar la tabla una vez se haya hecho una busqueda
    Private Sub TxtBuscar_TextChanged_1(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        If TxtBuscar.Text = "" Then
            LlenarTabla()
        End If
    End Sub

    'Validaciones

    'Función que valida los campos obligatorios del formulario
    Private Function validarCampos() As Boolean
        Dim camposLlenados = False

        If (TxtNombreCat.Text <> "") Then
            camposLlenados = True
        End If

        Return camposLlenados
    End Function

    'Función que valida los campos obligatorios del formulario
    Private Function validarCamposEditar() As Boolean
        Dim camposLlenados = False

        If (TxtIdCat.Text <> "" And TxtNombreCat.Text <> "") Then
            camposLlenados = True
        End If

        Return camposLlenados
    End Function

    'Función para validar los campos no obligatorios del formulario
    Private Function validarCamposNull(ByVal campo As String, txt As TextBox) As String
        If String.IsNullOrEmpty(txt.Text.Trim) Then
            campo = ""
        Else
            campo = txt.Text
        End If
        Return campo
    End Function


    'Función para validar que el DataGridView tenga datos
    Private Function validarRegistros() As Boolean
        Dim resp = False
        If (DgvCategorias.Rows.Count = 0) Then
            MsgBox("No hay registros guardados, porfavor agregue registros", MsgBoxStyle.Exclamation, "Advertencia")
            TxtNombreCat.Focus()
            Return False
            Exit Function
        Else
            resp = True
        End If
        Return True
    End Function

    'crud
    'Botón para agregar un nuevo registro al formulario
    Private Sub BtnAgregarC_Click_1(sender As Object, e As EventArgs) Handles BtnAgregarC.Click

        If Not validarCampos() Then
            MsgBox("Datos obligatorios de la marca incompletos.", MsgBoxStyle.Exclamation, "Advertencia")
            Exit Sub
        End If

        Dim categoriaDAO As New Tbl_CategoriasDAO()
        Dim categoria As New Tbl_Categorias

        categoria.NombreCatg = TxtNombreCat.Text.Trim()
        categoria.DescripcionCatg = validarCamposNull(categoria.DescripcionCatg, TxtDescCat)

        If categoriaDAO.validarCategoria(categoria) Then
            MsgBox("La categoría ingresada ya existe.", MsgBoxStyle.Exclamation, "Advertencia")
            Exit Sub
        End If

        Dim resp = categoriaDAO.AgregarCategoria(categoria)
        If (resp) Then
            MsgBox("Registro guardado exitosamente.", MsgBoxStyle.Information, "Categorías")
        Else
            MsgBox("Error al guardar el registro.", MsgBoxStyle.Critical, "Categorías")
        End If

        Limpiar()
        LlenarTabla()
    End Sub


    'Botón para editar un registro en el formulario
    Private Sub BtnEditarC_Click_1(sender As Object, e As EventArgs) Handles BtnEditarC.Click
        Try
            If Not validarCamposEditar() Then
                MsgBox("No ha seleccionado ningún registro", MsgBoxStyle.Exclamation, "Advertencia")
                Limpiar()
                Exit Sub
            End If

            Dim categoriaDAO As New Tbl_CategoriasDAO()
            Dim categoria As New Tbl_Categorias

            categoria.Id_categoria = TxtIdCat.Text.Trim()
            categoria.NombreCatg = TxtNombreCat.Text.Trim()
            categoria.DescripcionCatg = validarCamposNull(categoria.DescripcionCatg, TxtDescCat)

            If categoriaDAO.validarCategoria(categoria) Then
                MsgBox("La categoría ingresada ya existe.", MsgBoxStyle.Exclamation, "Advertencia")
                Limpiar()
                Exit Sub
            End If

            Dim resp = categoriaDAO.EditarCategoria(categoria)
            If (resp) Then
                MsgBox("Categoría editada exitosamente.", MsgBoxStyle.Information, "Categorías")
            Else
                MsgBox("Error al intentar editar la categoría", MsgBoxStyle.Critical, "Categorías")
            End If

            Limpiar()
            LlenarTabla()
        Catch ex As Exception
            MsgBox("Error al intentar editar el registro..." & ex.Message, MsgBoxStyle.Critical, "Categorías")
        End Try
    End Sub

    'Botón para eliminar un registro del formulario
    Private Sub BtnEliminarC_Click_1(sender As Object, e As EventArgs) Handles BtnEliminarC.Click
        Try
            If Not validarCamposEditar() Then
                MsgBox("No ha seleccionado nigún registro", MsgBoxStyle.Exclamation, "Advertencia")
                Exit Sub
            End If

            Dim CodCatg As Integer = Integer.Parse(TxtIdCat.Text.Trim())
            Dim categoriaDAO As New Tbl_CategoriasDAO()
            Dim categoria As New Tbl_Categorias
            categoria = categoriaDAO.BuscarCategoria(CodCatg)

            If (categoria.Id_categoria = 0) Then
                MsgBox("La categoría no existe. ", MsgBoxStyle.Exclamation, "Categorías")
                Exit Sub
            End If

            Dim resp As VariantType
            resp = (MsgBox("Desea eliminar la categoría: " & categoria.NombreCatg, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Categoría"))
            If (resp = vbNo) Then
                MsgBox("Tarea cancelada", MsgBoxStyle.Information, "Categoría")
                Limpiar()
                Exit Sub
            End If

            Dim eliminado = categoriaDAO.EliminarCategoria(categoria.Id_categoria)
            If (eliminado) Then
                MsgBox("Categoría eliminada exitosamente", MsgBoxStyle.Information, "Categorías")
                LlenarTabla()
                Limpiar()
            Else
                Limpiar()
            End If

        Catch ex As Exception
            MsgBox("Error al intentar eliminar el registro... " & ex.Message, MsgBoxStyle.Critical, "Categorías")
        End Try
    End Sub

    Private Sub BtnLimpiarC_Click(sender As Object, e As EventArgs) Handles BtnLimpiarC.Click
        Limpiar()
    End Sub

    'Botón para buscar un formulario por categoría
    Private Sub BtnBuscaCategoria_Click_1(sender As Object, e As EventArgs) Handles BtnBuscaCategoria.Click
        Dim ds As New DataSet
        Dim dao As New Tbl_CategoriasDAO

        ds = dao.BuscarXNombreC(TxtBuscar.Text.Trim)
        DgvCategorias.DataSource = ds.Tables(0)
        DgvCategorias.Refresh()

        If TxtBuscar.Text = "" Then
            MsgBox("No hay registros que buscar.", MsgBoxStyle.Information, "Categorias")
            LlenarTabla()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        LlenarTabla()
    End Sub


    'Función para cargar la información del formulario
    Private Sub FrmCategoria_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Ajustar tamaño del formulario a la pantalla.
        Size = Screen.PrimaryScreen.WorkingArea.Size
        Location = Screen.PrimaryScreen.WorkingArea.Location
        LlenarTabla()
    End Sub

End Class