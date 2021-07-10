Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading

Public Class EmacOpc
    Dim OPCRockwell As ClOpc
    Dim WithEvents oCliente As New cIp
    Dim Val1 As Integer
    Dim flag As Boolean
    Dim buffer As String


    Private Sub buscarpuertos()
        Try
            Cmbport.Items.Clear()
            For Each puerto As String In My.Computer.Ports.SerialPortNames
                Cmbport.Items.Add(puerto)
            Next
            If Cmbport.Items.Count > 0 Then
                Cmbport.SelectedIndex = 0
            Else
                MsgBox("NO HAY PUERTOS DISPONIBLES")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub ConectarPtoCom()
        Try
            With Spport
                If .IsOpen Then
                    .Close()
                End If

                '.PortName = "COM1"
                '.BaudRate = 9600 '// 19200 baud rate
                '.DataBits = 8 '// 8 data bits
                '.StopBits = IO.Ports.StopBits.One '// 1 Stop bit
                '.Parity = IO.Ports.Parity.None '
                '.DtrEnable = False
                '.Handshake = IO.Ports.Handshake.None
                '.ReadBufferSize = 2048
                '.WriteBufferSize = 1024
                ''.ReceivedBytesThreshold = 1
                '.WriteTimeout = 5000
                '.Encoding = System.Text.Encoding.Default
                .Open() ' ABRE EL PUERTO SERIE
                Label2.Text = "Conexion Exitosa"
                Label2.ForeColor = Color.Green
                Label1.Hide()
            End With
        Catch ex As Exception

            MsgBox("Error abrir puerto serial:" & ex.Message, MsgBoxStyle.Critical)

            Label1.ForeColor = Color.Red
            Label2.ForeColor = Color.Red
            Label1.Text = ex.Message
            Label2.Text = ex.Message

            'MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub EmacOpc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ''Conexion Pto Com
        ' ConectarPtoCom()
        'Me.Cmbport.Visible = False

        'EL TIMER 1 SE ACTIVA CADA 1 MINUTO PARA LEER RESULTADO DE CAJAS CAIDAS
        ' ''Timer1.Enabled = False
        ' ''Timer1.Interval = 60000

        'EL TIMER 2 SE ACTIVA CADA 1 MINUTO PARA LEER RESULTADO SI EXISTE ALGUNA EMERGENCIA ACTIVA
        'Timer2.Enabled = True
        'Timer2.Interval = 2000

        'Conexion Opc
        'OpcCon()

        ''Oculta Elementos
        Me.PictureBox2.Hide()
        Me.PictureBox3.Hide()
        Me.Button3.Hide()
        Me.Label5.Hide()

        'Conecta Scanner Ip
        Cliente()

    End Sub

    Private Sub Spport_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles Spport.DataReceived
        'Dim Respuesta As String
        'Dim buffer2 As String

        'buffer = ""
        'Respuesta = ""

        'Control.CheckForIllegalCrossThreadCalls = False

        'buffer = Spport.ReadExisting
        'buffer2 = Spport.ReadExisting

        'If buffer.IndexOf(Chr(Keys.Enter)) > -1 Then
        '    Respuesta = buffer
        '    buffer = "" 'Borrar datos recibidos
        'End If

        'If Len(buffer) = 8 Then
        '    buffer = buffer
        '    buffer = buffer + buffer2
        'End If

        'MsgBox(buffer)

        ''Exit Sub

        'If ValidaString(buffer) = True Then
        '    Me.PictureBox2.Show()
        '    Me.PictureBox3.Hide()
        '    buffer = ""
        '    Spport.Dispose()
        '    ConectarPtoCom()
        'Else
        '    Me.PictureBox2.Hide()
        '    Me.PictureBox3.Show()
        '    buffer = ""
        '    Spport.Dispose()
        '    ConectarPtoCom()
        'End If
    End Sub

    Private Sub OpcCon()
        If OPCRockwell Is Nothing Then
            OPCRockwell = New ClOpc
        End If
        If OPCRockwell.Conectado Then
            If OPCRockwell.Desconectar() Then
                'ButtonConectar.Text = "Conectar"
                GroupBoxOPC.Enabled = False
            Else
                ListBoxMensajes.Items.Add(OPCRockwell.Detalle_Error)
            End If
            ListBoxMensajes.Items.Add(OPCRockwell.Mensaje)
            ListBoxMensajes.ForeColor = Color.Green
        Else
            If OPCRockwell.Conectar() Then
                'ButtonConectar.Text = "Desconectar"
                GroupBoxOPC.Enabled = True
            Else
                ListBoxMensajes.ForeColor = Color.Red
                ListBoxMensajes.Items.Add(OPCRockwell.Mensaje)
                Exit Sub
            End If
            ListBoxMensajes.ForeColor = Color.Green
            ListBoxMensajes.Items.Add(OPCRockwell.Mensaje)
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Emergencia()
        StartStop()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.BackColor = Color.Green
        Button2.BackColor = Color.Transparent
        OPCRockwell.EscribirItemInt(17, 1)
        OPCRockwell.EscribirItemInt(17, 0)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2.BackColor = Color.Red
        Button1.BackColor = Color.Transparent
        OPCRockwell.EscribirItemInt(18, 1)
        OPCRockwell.EscribirItemInt(18, 0)
    End Sub

    Private Sub Emergencia()
        Static c
        flag = OPCRockwell.LeerItemInt(19)
        'flag = False
        c = c + 1

        If flag = True Then
            LblEmer.ForeColor = Color.Black
            LblEmer.BackColor = Color.Transparent
        End If


        If flag = False And c = 1 Then
            LblEmer.ForeColor = Color.Blue
            LblEmer.BackColor = Color.Red
        ElseIf flag = False And c = 2 Then
            LblEmer.ForeColor = Color.Yellow
            LblEmer.BackColor = Color.Red
        ElseIf flag = False And c = 3 Then
            LblEmer.ForeColor = Color.Green
            LblEmer.BackColor = Color.Red
        Else
            c = 0
        End If

    End Sub

    Private Sub StartStop()

        If OPCRockwell.LeerItemInt(20) = False Then
            Button1.BackColor = Color.Transparent
            Button2.BackColor = Color.Red
        Else
            Button1.BackColor = Color.Green
            Button2.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ValidaString(TxtCaptura.Text) = True Then
            Me.PictureBox2.Show()
            Me.PictureBox3.Hide()
        Else
            Me.PictureBox2.Hide()
            Me.PictureBox3.Show()
        End If
    End Sub

    Private Function ValidaString(ByVal valor As String)
        Dim Etiqueta As String
        Dim LargoEtiqueta As Integer
        Dim Accion As Boolean
        Dim nError As Integer
        Dim EtVacia As Integer
        nError = 99
        EtVacia = 99
        CheckForIllegalCrossThreadCalls = False

        'Quito espacios
        Etiqueta = Trim(Replace(valor, " ", ""))

        'Valido Largo String
        LargoEtiqueta = Len(Etiqueta)

        'valor(0)

        Accion = False

        If LargoEtiqueta = 100 Then
            If InsertarEtiqueta(Etiqueta) = True Then
                If GetSalida(Etiqueta) = True Then
                    OPCRockwell.EscribirItemInt(2, Txtsalida.Text)
                    Accion = True
                    Return Accion
                Else
                    Accion = False
                    OPCRockwell.EscribirItemInt(2, nError)
                    TxtCaptura.Text = valor
                    Txtsalida.Text = "No existe Etiqueta"
                End If
            End If
            'OPCRockwell.EscribirItemInt(2, nError)
            'TxtCaptura.Text = valor
            'Txtsalida.Text = "Caja Invalida"
        Else
            OPCRockwell.EscribirItemInt(2, EtVacia)
            TxtCaptura.Text = "No Leido"
            Txtsalida.Text = "0"
        End If
        Return Accion
    End Function

    Private Function InsertarEtiqueta(ByVal xEtiqueta As String)
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("CONEXION").ConnectionString)
            Dim cmd As New SqlCommand("TB_I_TB_ETIQUETAS", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@pETIQUETA", SqlDbType.VarChar).Value = xEtiqueta.ToString
            conex.Open()
            cmd.ExecuteNonQuery()
            conex.Close()
            Return True
        Catch ex As Exception
            buffer = ""
            'MsgBox(ex.Message)
            Return False
        End Try

    End Function

    Private Function GetSalida(ByVal xEtiqueta)
        Try
            Dim rs As SqlDataReader
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("CONEXION").ConnectionString)
            Dim cmd As New SqlCommand("TB_S_TB_SEGREGADOR", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@pETIQUETA", xEtiqueta.ToString)
            conex.Open()
            rs = cmd.ExecuteReader()
            rs.Read()
            'TxtCaptura.Text = rs(0)
            TxtCaptura.Text = xEtiqueta.ToString
            Txtsalida.Text = rs(1)
            rs.Close()
            conex.Close()
            'buffer = ""
            Return True
        Catch ex As Exception
            'buffer = ""
            'MsgBox(ex.Message)
            Return False
        End Try

    End Function

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        nSalidas.ShowDialog()
    End Sub

    Private Sub Label5_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label5.MouseMove
        Label5.ForeColor = Color.Red
    End Sub

    Private Sub Label5_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.MouseHover
        Label5.ForeColor = Color.Blue
    End Sub

    Private Sub Cliente()
        Try
            With oCliente
                .IPDelHost = "192.168.100.51"
                .PuertoDelHost = "51235"
                .Conectar()
                'MsgBox("Scanner Conectado", MsgBoxStyle.Information)
                Label2.Text = "Conexion Exitosa"
                Label2.ForeColor = Color.Green
                Label1.Hide()
            End With
        Catch ex As Exception
            'MsgBox(ex.Message)
            Label2.Text = ex.Message
            Label2.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub WinSockCliente_DatosRecibidos(ByVal datos As String) Handles oCliente.DatosRecibidos
        'MsgBox("El servidor envio el siguiente mensaje: " & datos)

        If ValidaString(datos) = True Then
            Me.PictureBox2.Show()
            Me.PictureBox3.Hide()
        Else
            Me.PictureBox2.Hide()
            Me.PictureBox3.Show()
        End If

    End Sub

End Class
