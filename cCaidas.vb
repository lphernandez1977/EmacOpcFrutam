Imports System.Data.SqlClient
Imports System.Configuration
Public Class cCaidas

    Private _Codigo As String
    Private _Salida As Integer

    Public Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
        End Set
    End Property
    Public Property Salida() As String
        Get
            Return _Salida
        End Get
        Set(ByVal value As String)
            _Salida = value
        End Set
    End Property

    Public Function Create() As Integer
        Dim Res As Integer
        Res = 0
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("CONEXION").ConnectionString)
            Dim cmd As New SqlCommand("SP_I_CAIDAS", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@pCODIGO", SqlDbType.VarChar).Value = Me.Codigo.ToString
            cmd.Parameters.Add("@pSALIDA", SqlDbType.VarChar).Value = Me.Salida.ToString
            conex.Open()
            cmd.ExecuteNonQuery()
            conex.Close()
            Res = 1
            Return Res
        Catch ex As Exception
            'MsgBox(ex.Message)
            Return Res
        End Try
    End Function

    Public Function Delete() As Integer
        Dim Res As Integer
        Res = 0
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("CONEXION").ConnectionString)
            Dim cmd As New SqlCommand("SP_D_CAIDAS", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@pCODIGO", SqlDbType.VarChar).Value = Me.Codigo.ToString
            conex.Open()
            cmd.ExecuteNonQuery()
            conex.Close()
            Res = 1
            Return Res
        Catch ex As Exception
            'MsgBox(ex.Message)
            Return Res
        End Try
    End Function


End Class
