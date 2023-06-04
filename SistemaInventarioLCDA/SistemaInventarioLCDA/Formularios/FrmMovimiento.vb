Imports System.Data.SqlClient

Public Class FrmMovimiento

    Dim strConn As String = My.Settings.StrConexion

    'Instancia de un objeto de la clase Usuario como atributo del formulario movimiento
    Private _usuarioSistema As New Usuario()
    Public Property UsuarioSistema As Usuario
        Get
            Return _usuarioSistema
        End Get
        Set(value As Usuario)
            _usuarioSistema = value
        End Set
    End Property
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

    Private Sub Limpiar()
        CbProductos.Text = "Seleccione el producto..."
        TxtMarcaProd.Clear()
        TxtCategoriaProd.Clear()
        TxtDescripcionProd.Clear()
        TxtPrecioProd.Clear()
        TxtUnidadesProd.Clear()
        TxtCodigoMov.Clear()
        CbTipoMovimiento.Text = "Seleccione el movimiento..."
        TxtCantidadUP.Clear()
        TxtDesMovimiento.Clear()
        TxtUsuarioMov.Text = UsuarioSistema.NombreCompleto
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
            FrmPrincipal.UsuarioSistema = UsuarioSistema
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

    Private Function validarCampos() As Boolean
        Dim camposLlenados = False
        If (CbTipoMovimiento.Text <> "Seleccione el movimiento..." And CbProductos.Text <> "Seleccione el producto..." And TxtCantidadUP.Text <> "") Then
            camposLlenados = True
        End If
        Return camposLlenados
    End Function


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
        TxtUsuarioMov.Text = UsuarioSistema.NombreCompleto
        LlenarComboxProd()
        LlenarTabla()
        Limpiar()
    End Sub

    Private Sub LlenarTabla()
        Dim movimientosDAO As New Tbl_MovimientosDAO
        DgvMovimientos.DataSource = movimientosDAO.MostrarMovimientos.Tables(0)
        DgvMovimientos.Refresh()
        GbMovimientos.Text = "Movimientos Almacenados: " & DgvMovimientos.RowCount
    End Sub

    'Función para llenar los datos del producto en los campos del formulario 
    Dim prod As New Tbl_MovimientosDAO

    Private Sub CbProductos_TextChanged(sender As Object, e As EventArgs) Handles CbProductos.TextChanged
        If CbProductos.Text <> "Seleccione el producto..." And CbProductos.Text <> "" Then
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

    Private Sub cargarDatosProd()
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
    End Sub

    'Función para validar que el DataGridView tenga datos
    Private Function validarRegistros() As Boolean
        Dim resp = False
        If (DgvMovimientos.Rows.Count = 0) Then
            MsgBox("No hay registros guardados, porfavor agregue registros", MsgBoxStyle.Exclamation, "Advertencia")
            Return False
            Exit Function
        Else
            resp = True
        End If
        Return True
    End Function

    'Validaciones necesarias para aquellos campos que no sean tan exigidos en la base de datos
    Private Function validarCamposNull(ByVal campo As String, txt As TextBox) As String
        If String.IsNullOrEmpty(txt.Text.Trim) Then
            campo = ""
        Else
            campo = txt.Text
        End If
        Return campo
    End Function

    'Validaciones necesarias en caso de que el movimiento sea una salida

    Private Function ValidarUnidades() As Boolean
        Dim resp As Boolean = False
        If (CbTipoMovimiento.Text = "Salida") Then
            If (Integer.Parse(TxtUnidadesProd.Text) < Integer.Parse(TxtCantidadUP.Text)) Then
                resp = True
                Return resp
            End If
        End If
        Return resp
    End Function

    'Private Sub restarInventario()
    '    Dim productoDAO As New Tbl_ProductosDAO()
    '    Dim resp As Boolean = False
    '    If (CbTipoMovimiento.Text = "Salida") Then
    '        resp = productoDAO.restarUnidades(Integer.Parse(TxtCantidadUP.Text), CbProductos.SelectedValue)
    '        If Not resp Then
    '            MsgBox("Error al restar la cantidad de producto al inventario", MsgBoxStyle.Exclamation, "Advertencia")
    '        End If
    '    End If

    'End Sub

    'Public Sub sumarInventario()
    '    If (CbTipoMovimiento.Text = "Entrada") Then
    '        Dim productoDAO As New Tbl_ProductosDAO()
    '        Dim resp = productoDAO.sumarUnidades(Integer.Parse(TxtCantidadUP.Text), CbProductos.SelectedValue)
    '        If Not resp Then
    '            MsgBox("Error al sumar la cantidad de producto al inventario", MsgBoxStyle.Exclamation, "Advertencia")
    '        End If
    '    End If
    'End Sub

    Private Sub BtnLimpiarE_Click(sender As Object, e As EventArgs) Handles BtnLimpiarE.Click
        Limpiar()
    End Sub

    Private Sub DgvMovimientos_MouseClick(sender As Object, e As MouseEventArgs) Handles DgvMovimientos.MouseClick
        Try
            If (validarRegistros()) Then
                Dim fila As Integer = DgvMovimientos.CurrentRow.Index
                TxtCodigoMov.Text = DgvMovimientos.Rows(fila).Cells(0).Value
                CbProductos.Text = DgvMovimientos.Rows(fila).Cells(1).Value
                cargarDatosProd()
                TxtUsuarioMov.Text = DgvMovimientos.Rows(fila).Cells(2).Value
                CbTipoMovimiento.Text = DgvMovimientos.Rows(fila).Cells(3).Value
                DtpFechaMovimiento.Text = DgvMovimientos.Rows(fila).Cells(4).Value
                TxtCantidadUP.Text = DgvMovimientos.Rows(fila).Cells(5).Value
                TxtDesMovimiento.Text = DgvMovimientos.Rows(fila).Cells(6).Value

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnAgregarE_Click(sender As Object, e As EventArgs) Handles BtnAgregarE.Click

        If Not validarCampos() Then
            MsgBox("Datos obligatorios del movimiento incompletos.", MsgBoxStyle.Exclamation, "Advertencia")
            Exit Sub
        End If

        If ValidarUnidades() Then
            MsgBox("No hay suficientes unidades de producto para realizar esa salida", MsgBoxStyle.Exclamation, "Advertencia")
            TxtCantidadUP.Clear()
            TxtCantidadUP.Focus()
            Exit Sub
        End If

        Dim movimiento = New Tbl_Movimientos() 'Entidad/Tabla de movimientos
        Dim movimientoDAO As New Tbl_MovimientosDAO() 'DAO de movimientos

        movimiento.Id_producto = CbProductos.SelectedValue
        movimiento.Usuario_id = UsuarioSistema.UsuarioID
        If CbTipoMovimiento.Text = "Entrada" Then
            movimiento.Tipo_movimiento = True
        Else
            movimiento.Tipo_movimiento = False
        End If
        movimiento.Fecha_movimiento = DtpFechaMovimiento.Value
        movimiento.CantidadProd = Integer.Parse(TxtCantidadUP.Text)
        movimiento.DescripcionMov = validarCamposNull(movimiento.DescripcionMov, TxtDesMovimiento)
        Dim resp = movimientoDAO.agregarMovimiento(movimiento)
        If (resp) Then
            'sumarInventario()
            'restarInventario()
            MsgBox("Registro guardado exitosamente.", MsgBoxStyle.Information, "Roles")
            LlenarTabla()
            Limpiar()
        End If

    End Sub

End Class