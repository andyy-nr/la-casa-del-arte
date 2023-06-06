Public Class FrmMarcas
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

    'Botón para regresar al formulario principal
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

    'Función para rellenar el DataGripViewer de Categorías
    Sub LlenarTabla()
        Dim marcaDAO As New Tbl_MarcasDAO

        DgvMarcas.DataSource = marcaDAO.MostrarMarcas().Tables(0)
        DgvMarcas.Refresh()
        GbMarcas.Text = "Marcas Registradas: " & DgvMarcas.RowCount
    End Sub

    Sub Limpiar()
        TxtCodMarca.Clear()
        TxtNomMarca.Clear()
        TxtDescMarca.Clear()
        TxtNomMarca.Focus()
        BtnAgregarM.Enabled = True
    End Sub

    'Función para rellenar los campos del formulario al seleccionar una fila del DataGripViewer
    Private Sub DgvMarcas_MouseClick(sender As Object, e As MouseEventArgs) Handles DgvMarcas.MouseClick

        If (validarRegistros()) Then
            Dim fila As Integer = DgvMarcas.CurrentRow.Index
            TxtCodMarca.Text = DgvMarcas.Rows(fila).Cells(0).Value
            TxtNomMarca.Text = DgvMarcas.Rows(fila).Cells(1).Value
            TxtDescMarca.Text = DgvMarcas.Rows(fila).Cells(2).Value
            BtnAgregarM.Enabled = False
        End If
    End Sub

    'Validaciones

    'Función que valida los campos obligatorios del formulario
    Private Function validarCampos() As Boolean
        Dim camposLlenados = False

        If (TxtNomMarca.Text <> "") Then
            camposLlenados = True
        End If

        Return camposLlenados
    End Function

    'Función que valida los campos obligatorios del formulario
    Private Function validarCamposEditar() As Boolean
        Dim camposLlenados = False

        If (TxtCodMarca.Text <> "" And TxtNomMarca.Text <> "") Then
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
        If (DgvMarcas.Rows.Count = 0) Then
            MsgBox("No hay registros guardados, porfavor agregue registros", MsgBoxStyle.Exclamation, "Advertencia")
            TxtNomMarca.Focus()
            Return False
            Exit Function
        Else
            resp = True
        End If
        Return True
    End Function

    Private Sub BtnAgregarM_Click(sender As Object, e As EventArgs) Handles BtnAgregarM.Click
        Try
            If Not validarCampos() Then
                MsgBox("Datos obligatorios de la marca incompletos.", MsgBoxStyle.Exclamation, "Advertencia")
                Exit Sub
            End If

            Dim marca = New Tbl_Marcas() 'Entidad/Tabla de Productos
            Dim marcaDao As New Tbl_MarcasDAO 'DAO de Marca

            marca.NombreMarca = TxtNomMarca.Text.Trim()
            marca.DescripcionMarca = validarCamposNull(marca.DescripcionMarca, TxtDescMarca)


            If marcaDao.validarMarca(marca) Then
                MsgBox("La marca ingresada ya existe.", MsgBoxStyle.Exclamation, "Advertencia")
                TxtNomMarca.Clear()
                TxtNomMarca.Focus()
                Exit Sub
            End If

            Dim resp = marcaDao.AgregarMarca(marca)
            If (resp) Then
                MsgBox("Registro guardado exitosamente.", MsgBoxStyle.Information, "Marcas")
            Else
                MsgBox("Error al guardar el registro.", MsgBoxStyle.Critical, "Marcas")
            End If

            Limpiar()
            LlenarTabla()

        Catch ex As Exception
            MsgBox("Error al intentar guardar el registro..." & ex.Message, MsgBoxStyle.Critical, "Marcas")
        End Try
    End Sub

    Private Sub BtnLimpiarP_Click(sender As Object, e As EventArgs) Handles BtnLimpiarP.Click
        Limpiar()
    End Sub

    Private Sub BtnEditarP_Click(sender As Object, e As EventArgs) Handles BtnEditarP.Click
        Try
            If Not validarCamposEditar() Then
                MsgBox("No ha seleccionado ningún registro", MsgBoxStyle.Exclamation, "Advertencia")
                Exit Sub
            End If

            Dim marcaDao As New Tbl_MarcasDAO()
            Dim marca As New Tbl_Marcas

            marca.Id_marca = TxtCodMarca.Text.Trim()
            marca.NombreMarca = TxtNomMarca.Text.Trim()
            marca.DescripcionMarca = validarCamposNull(marca.DescripcionMarca, TxtDescMarca)


            If marcaDao.validarMarca(marca) Then
                MsgBox("La marca ingresada ya existe.", MsgBoxStyle.Exclamation, "Advertencia")
                Limpiar()
                Exit Sub
            End If

            Dim resp = marcaDao.EditarMarca(marca)
            If (resp) Then
                MsgBox("Marca editada exitosamente.", MsgBoxStyle.Information, "Marcas")
            Else
                MsgBox("Error al intentar editar la marca", MsgBoxStyle.Critical, "Marcas")
            End If

            Limpiar()
            LlenarTabla()
        Catch ex As Exception
            MsgBox("Error al intentar editar el registro..." & ex.Message, MsgBoxStyle.Critical, "Marcas")
        End Try
    End Sub

    Private Sub BtnEliminarP_Click(sender As Object, e As EventArgs) Handles BtnEliminarP.Click
        Try
            If Not validarCamposEditar() Then
                MsgBox("No ha seleccionado nigún registro", MsgBoxStyle.Exclamation, "Advertencia")
                Exit Sub
            End If

            Dim CodMarca As Integer = Integer.Parse(TxtCodMarca.Text.Trim())
            Dim marcaDAO As New Tbl_MarcasDAO()
            Dim marca As New Tbl_Marcas
            marca = marcaDAO.BuscarMarca(CodMarca)

            If (marca.Id_marca = 0) Then
                MsgBox("La marca no existe. ", MsgBoxStyle.Exclamation, "Marcas")
                Exit Sub
            End If

            Dim resp As VariantType
            resp = (MsgBox("Desea eliminar la marca: " & marca.NombreMarca, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Marcas"))
            If (resp = vbNo) Then
                MsgBox("Tarea cancelada", MsgBoxStyle.Information, "Marcas")
                Limpiar()
                Exit Sub
            End If

            Dim eliminado = marcaDAO.EliminarMarca(marca.Id_marca)
            If (eliminado) Then
                MsgBox("Marca eliminada exitosamente", MsgBoxStyle.Information, "Marcas")
                LlenarTabla()
                Limpiar()
            Else
                Limpiar()
            End If

        Catch ex As Exception
            MsgBox("Error al intentar eliminar el registro... " & ex.Message, MsgBoxStyle.Critical, "Marcas")
        End Try
    End Sub

    Private Sub BtnBuscarMarcas_Click(sender As Object, e As EventArgs) Handles BtnBuscarMarcas.Click
        Dim ds As New DataSet
        Dim dao As New Tbl_MarcasDAO

        ds = dao.BuscarXNombreM(TxtBuscar.Text.Trim)
        DgvMarcas.DataSource = ds.Tables(0)
        DgvMarcas.Refresh()

        If TxtBuscar.Text = "" Then
            MsgBox("No hay registros que buscar.", MsgBoxStyle.Information, "Marcas")
            LlenarTabla()
        End If
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        If TxtBuscar.Text = "" Then
            LlenarTabla()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        LlenarTabla()
    End Sub



    'Función para cargar la información del formulario
    Private Sub FrmMarcas_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Ajustar tamaño del formulario a la pantalla.
        Size = Screen.PrimaryScreen.WorkingArea.Size
        Location = Screen.PrimaryScreen.WorkingArea.Location
        LlenarTabla()
    End Sub



End Class