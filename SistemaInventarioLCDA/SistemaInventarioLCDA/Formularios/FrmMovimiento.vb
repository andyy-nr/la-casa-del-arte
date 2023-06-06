Imports System.Data.SqlClient

Public Class FrmMovimiento
    Dim tblMovimiento As New DBLaCasaDelArteDataSet.DTMovimientosBuscarDataTable
    Dim rptMovimiento As New DBLaCasaDelArteDataSetTableAdapters.DTMovimientosBuscarTableAdapter
    Dim tbl As New DataTable

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


    'Datos

    'Función para dar diseño al DgvMovimientos
    Sub DiseñoTabla()
        'Titulos o encabezados de la tabla
        DgvMovimientos.Columns(0).HeaderText = "CÓDIGO"
        DgvMovimientos.Columns(1).HeaderText = "PRODUCTO"
        DgvMovimientos.Columns(2).HeaderText = "USUARIO"
        DgvMovimientos.Columns(3).HeaderText = "TIPO MOVIMIENTO"
        DgvMovimientos.Columns(4).HeaderText = "FECHA"
        DgvMovimientos.Columns(5).HeaderText = "CANTIDAD DE PRODUCTO"
        DgvMovimientos.Columns(6).HeaderText = "DESCRIPCIÓN MOVIMIENTO"
    End Sub

    'Función para limpiar los campos
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
        LlenarGridMovimientos()
        Limpiar()
    End Sub

    Private Sub LlenarTabla()
        Dim movimientosDAO As New Tbl_MovimientosDAO
        DgvMovimientos.DataSource = movimientosDAO.MostrarMovimientos.Tables(0)
        DgvMovimientos.Refresh()
        GbMovimientos.Text = "Movimientos Realizados: " & DgvMovimientos.RowCount
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
                TxtUnidadesProd.Text = row("cantidad_disponible").ToString()
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
            TxtUnidadesProd.Text = row("cantidad_disponible").ToString()
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

    Private Sub restarInventario()
        Dim productoDAO As New Tbl_ProductosDAO()
        Dim resp As Boolean = False
        If (CbTipoMovimiento.Text = "Salida") Then
            resp = productoDAO.restarUnidades(Integer.Parse(TxtCantidadUP.Text), CbProductos.SelectedValue)
            If Not resp Then
                MsgBox("Error al restar la cantidad de producto al inventario", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If

    End Sub

    Public Sub sumarInventario()
        If (CbTipoMovimiento.Text = "Entrada") Then
            Dim productoDAO As New Tbl_ProductosDAO()
            Dim resp = productoDAO.sumarUnidades(Integer.Parse(TxtCantidadUP.Text), CbProductos.SelectedValue)
            If Not resp Then
                MsgBox("Error al sumar la cantidad de producto al inventario", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub

    Private Sub BtnLimpiarE_Click(sender As Object, e As EventArgs) Handles BtnLimpiarE.Click
        Limpiar()
    End Sub

    Private Sub DgvMovimientos_MouseClick(sender As Object, e As MouseEventArgs) Handles DgvMovimientos.MouseClick
        Try
            If (validarRegistros()) Then
                cargarDatosProd()
                Dim fila As Integer = DgvMovimientos.CurrentRow.Index
                TxtCodigoMov.Text = DgvMovimientos.Rows(fila).Cells(0).Value
                CbProductos.Text = DgvMovimientos.Rows(fila).Cells(1).Value
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
            sumarInventario()
            restarInventario()
            MsgBox("Registro guardado exitosamente.", MsgBoxStyle.Information, "Movimientos")
            LlenarGridMovimientos()
            Limpiar()
        End If

    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        CmbFiltrarMov.Text = "Filtrar movimientos"
        TxtBuscar.Enabled = True
        LlenarGridMovimientos()
    End Sub

    'Método LinkQ para filtrar registros de productos

    'Funcion para llenar la tabla con método LinkQ
    Sub LlenarGridMovimientos()
        rptMovimiento.Fill(tblMovimiento)
        DgvMovimientos.DataSource = tblMovimiento
        DgvMovimientos.Refresh()
        DiseñoTabla()
        GbMovimientos.Text = "Movimientos Realizados: " & DgvMovimientos.RowCount
    End Sub

    'Funcion para crear la tabla aplicando método de LinkQ
    Private Function CrearTablaMovimientos(query) As DataTable
        Dim tbl As DataTable = New DataTable("tblMovimiento")
        Dim fila As DataRow

        tbl.Columns.Add("id_movimiento")
        tbl.Columns.Add("nombreProd")
        tbl.Columns.Add("usuario")
        tbl.Columns.Add("tipo_movimiento")
        tbl.Columns.Add("fecha_movimiento")
        tbl.Columns.Add("cantidadProd")
        tbl.Columns.Add("descripcionMov")

        For Each movm In query
            fila = tbl.NewRow
            fila("id_movimiento") = movm.id_movimiento
            fila("nombreProd") = movm.nombreProd
            fila("usuario") = movm.usuario
            fila("tipo_movimiento") = movm.tipo_movimiento
            fila("fecha_movimiento") = movm.fecha_movimiento
            fila("cantidadProd") = movm.cantidadProd
            fila("descripcionMov") = movm.descripcionMov
            tbl.Rows.Add(fila)

        Next
        Return tbl

    End Function

    Private Sub BuscarMovimiento()
        Dim ds As New DataSet
        Dim dao As New Tbl_MovimientosDAO

        ds = dao.buscarXproducto(TxtBuscar.Text.Trim)
        DgvMovimientos.DataSource = ds.Tables(0)
        DiseñoTabla()
        DgvMovimientos.Refresh()
    End Sub

    'Funcion para filtrar movimientos haciendo uso de linkQ
    Private Sub FiltrarMovimiento()
        Try
            Dim dato As String = TxtBuscar.Text.Trim()
            Dim entrada As String = "Entrada"
            Dim salida As String = "Salida"

            Dim campo As String = "movm.id_movimiento"
            Dim query = From movm In tblMovimiento
                        Select movm.id_movimiento, movm.nombreProd, movm.usuario, movm.tipo_movimiento, movm.fecha_movimiento, movm.cantidadProd, movm.descripcionMov

            Select Case CmbFiltrarMov.SelectedIndex
                Case 0
                    query = From movm In tblMovimiento Where movm.id_movimiento = Integer.Parse(dato)
                            Select movm.id_movimiento, movm.nombreProd, movm.usuario, movm.tipo_movimiento, movm.fecha_movimiento, movm.cantidadProd, movm.descripcionMov

                Case 1
                    query = From movm In tblMovimiento Where movm.nombreProd Like dato
                            Select movm.id_movimiento, movm.nombreProd, movm.usuario, movm.tipo_movimiento, movm.fecha_movimiento, movm.cantidadProd, movm.descripcionMov

                Case 2
                    query = From movm In tblMovimiento Where movm.tipo_movimiento Like entrada
                            Select movm.id_movimiento, movm.nombreProd, movm.usuario, movm.tipo_movimiento, movm.fecha_movimiento, movm.cantidadProd, movm.descripcionMov

                Case 3
                    query = From movm In tblMovimiento Where movm.tipo_movimiento Like salida
                            Select movm.id_movimiento, movm.nombreProd, movm.usuario, movm.tipo_movimiento, movm.fecha_movimiento, movm.cantidadProd, movm.descripcionMov

                Case 4
                    query = From movm In tblMovimiento Where Month(movm.fecha_movimiento) = ObtenerNumeroMes(dato)
                            Select movm.id_movimiento, movm.nombreProd, movm.usuario, movm.tipo_movimiento, movm.fecha_movimiento, movm.cantidadProd, movm.descripcionMov

            End Select

            tbl = CrearTablaMovimientos(query)
            DgvMovimientos.DataSource = tbl
            DiseñoTabla()
            DgvMovimientos.Refresh()
            GbMovimientos.Text = "Movimientos Realizados: " & DgvMovimientos.RowCount
        Catch ex As Exception
            MsgBox("Ocurrió un error: " & ex.Message, MsgBoxStyle.Exclamation, "Advertencia")
            TxtBuscar.Clear()
            TxtBuscar.Focus()
        End Try
    End Sub

    'Función para obtener el valor numérico de los meses
    Function ObtenerNumeroMes(ByVal nombreMes As String) As Integer
        Dim mes As Integer = 0

        Select Case nombreMes.ToUpper()
            Case "ENERO"
                mes = 1
            Case "FEBRERO"
                mes = 2
            Case "MARZO"
                mes = 3
            Case "ABRIL"
                mes = 4
            Case "MAYO"
                mes = 5
            Case "JUNIO"
                mes = 6
            Case "JULIO"
                mes = 7
            Case "AGOSTO"
                mes = 8
            Case "SEPTIEMBRE"
                mes = 9
            Case "OCTUBRE"
                mes = 10
            Case "NOVIEMBRE"
                mes = 11
            Case "DICIEMBRE"
                mes = 12
        End Select

        Return mes
    End Function

    'Función para refrescar la tabla si no hay busqueda
    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        If TxtBuscar.Text = "" Then
            CmbFiltrarMov.Text = "Filtrar movimientos"
            LlenarGridMovimientos()
        End If
    End Sub

    'Función para desactivar la barra de busqueda cuando se busque por entrada o salida
    Private Sub CmbFiltrarMov_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbFiltrarMov.SelectedIndexChanged
        If CmbFiltrarMov.SelectedIndex = 2 Or CmbFiltrarMov.SelectedIndex = 3 Then
            TxtBuscar.Enabled = False
        Else
            TxtBuscar.Enabled = True
        End If
    End Sub

    'Botón para imprimir reporte
    Private Sub PibImprimir_Click(sender As Object, e As EventArgs) Handles PibImprimir.Click
        VerReporte(tbl, "DataSet1", "diseñosRpt\rptMovimientosFiltrados.rdlc")
    End Sub

    'Botón para buscar y filtrar los movimientos
    Private Sub BtnBuscarMov_Click(sender As Object, e As EventArgs) Handles BtnBuscarMov.Click
        If TxtBuscar.Text = "" And CmbFiltrarMov.SelectedIndex <> 2 And CmbFiltrarMov.SelectedIndex <> 3 Or TxtBuscar.Text = "" And CmbFiltrarMov.SelectedIndex = 0 Then
            MsgBox("No hay registros que buscar.", MsgBoxStyle.Information, "Movimientos")
            LlenarGridMovimientos()
            Exit Sub
        End If

        If (CmbFiltrarMov.Text = "Filtrar movimientos") Then
            BuscarMovimiento()
            Exit Sub
        Else
            FiltrarMovimiento()
        End If
    End Sub


End Class