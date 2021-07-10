Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data

Public Class nSalidas
    Private Sub Btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click
        Dim oInsert = New cCaidas
        Dim vCodigo As String
        Dim vSalida As Integer
        Dim Res As Integer

        If TxtNsalida.Text = "" Then
            TxtNsalida.Text = 0
        End If

        vCodigo = TxtIdOla.Text
        vSalida = Convert.ToInt32(TxtNsalida.Text)

        If vCodigo = "" Or vSalida = 0 Then
            MsgBox("Debe Ingresar Valores", MsgBoxStyle.Information)
            Exit Sub
        End If



        oInsert.Codigo = UCase(vCodigo)
        oInsert.Salida = vSalida

        Res = oInsert.Create()

        If Res > 0 Then
            MsgBox("Registro Insertado", MsgBoxStyle.Information)
            TxtIdOla.Text = ""
            TxtNsalida.Text = 0
        Else
            MsgBox("Error Insertar Registro", MsgBoxStyle.Critical)
        End If

        CargaGrid()

    End Sub

    Private Sub CargaGrid()
        Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("CONEXION").ConnectionString)
        Dim da As New SqlDataAdapter("SELECT CODIGO_CARTON,SALIDA_SEGREGADOR FROM TB_SALIDAS", conex)
        Dim ds As New DataSet

        Try
            da.Fill(ds)
            DgvCaidas.AutoGenerateColumns = False
            DgvCaidas.DataSource = ds.Tables(0)
            With DgvCaidas
                .Columns("Codigo").DataPropertyName = "CODIGO_CARTON"
                .Columns("Salida").DataPropertyName = "SALIDA_SEGREGADOR"
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub nSalidas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargaGrid()
    End Sub

    Private Sub DgvCaidas_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvCaidas.CellClick
        Dim oDelete = New cCaidas
        Dim valor As String
        Dim Res As Integer

        If e.RowIndex <> 0 Then
            Exit Sub
        End If

        valor = Me.DgvCaidas.Item(0, e.RowIndex).Value
        oDelete.Codigo = valor

        Res = oDelete.Delete()

        If Res > 0 Then
            MsgBox("Registro Eliminado", MsgBoxStyle.Information)
            CargaGrid()
        Else
            MsgBox("Error Eliminar Registro", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub DgvCaidas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvCaidas.CellContentClick
        'Dim oDelete = New cCaidas
        'Dim valor As String
        'Dim Res As Integer

        ''valor = Me.DgvCaidas.Item(0, e.RowIndex).Value.ToString()
        'valor = Me.DgvCaidas.Rows(e.RowIndex).Cells(0).Value()
        ''Me.USUARIODataGridView.Rows(e.RowIndex).Cells(0).Value()
        'oDelete.Codigo = Trim(valor)

        'Res = oDelete.Delete()

        'If Res > 0 Then
        '    MsgBox("Registro Eliminado", MsgBoxStyle.Information)
        '    CargaGrid()
        'Else
        '    MsgBox("Error Eliminar Registro", MsgBoxStyle.Critical)
        'End If
    End Sub
End Class



