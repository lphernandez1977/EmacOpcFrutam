Imports RsiOPCAuto
'Imports OPCAutomation
Imports System.Runtime.InteropServices

Public Class ClOpc
    Private WithEvents ServidorOPC As OPCServer
    Private WithEvents GrupoOPC As OPCGroup
    Private WithEvents GruposOPC As OPCGroups
    Private ItemOPC() As OPCItem

    Public Conectado As Boolean 'Para saber si la conexión está activada

    'Si hay algún error se indica en estas variables
    Public Mensaje As String
    Public Detalle_Error As String
    'Constructor
    Public Sub New()
        'Al crear el objeto, no estamos conectados
        Conectado = False
    End Sub
    'Función para activar la conexión OPC
    Public Function Conectar() As Boolean

        'Si ya estoy conectado aviso y salgo.
        If Conectado Then
            Mensaje = "Error conexión OPC."
            Detalle_Error = "Se ha intentado crear una conexión OPC cuando ya hay una creada."
            Conectar = False
            Exit Function
        End If
        Try
            Mensaje = "Conectando con el servidor OPC..."
            ServidorOPC = New OPCServer
            'Se declara el servidor OPC
            ServidorOPC.Connect("RSLinx OPC Server")

            Mensaje = "Añadiendo grupo al servidor OPC..."
            GruposOPC = ServidorOPC.OPCGroups
            GrupoOPC = GruposOPC.Add("Grupo1")

            GrupoOPC.IsActive = True
            GrupoOPC.UpdateRate = 1000
            GrupoOPC.IsSubscribed = True

            Mensaje = "Añadiendo Items al grupo..."
            ReDim ItemOPC(100) 'Dimensionar según las necesidades

            'Introducir un ítem por cada variable del PLC en la que queramos leer o escribir
            'A cada ítem le asignamos un número, que debemos recordar para referirnos a él en el programa

            'ItemOPC(0) = GrupoOPC.OPCItems.AddItem("[segregado]C5:0.ACC", 0)

            'ETIQUETA
            'ItemOPC(1) = GrupoOPC.OPCItems.AddItem("[segregado]ST17:0", 1)

            'CAIDA
            ItemOPC(2) = GrupoOPC.OPCItems.AddItem("[segregado]N7:0", 2)

            'Reset
            'ItemOPC(3) = GrupoOPC.OPCItems.AddItem("[segregado]B3:0/3", 3)

            'Salidas
            'ItemOPC(4) = GrupoOPC.OPCItems.AddItem("[segregado]B9:0/1", 4)
            'ItemOPC(5) = GrupoOPC.OPCItems.AddItem("[segregado]B9:0/2", 5)
            'ItemOPC(6) = GrupoOPC.OPCItems.AddItem("[segregado]B9:0/3", 6)
            'ItemOPC(7) = GrupoOPC.OPCItems.AddItem("[segregado]B9:0/4", 7)
            'ItemOPC(8) = GrupoOPC.OPCItems.AddItem("[segregado]B9:0/6", 8)
            'ItemOPC(9) = GrupoOPC.OPCItems.AddItem("[segregado]B9:0/6", 9)

            'Contadores
            'ItemOPC(10) = GrupoOPC.OPCItems.AddItem("[segregado]C5:1.ACC", 10)
            'ItemOPC(11) = GrupoOPC.OPCItems.AddItem("[segregado]C5:2.ACC", 11)
            'ItemOPC(12) = GrupoOPC.OPCItems.AddItem("[segregado]C5:3.ACC", 12)
            'ItemOPC(13) = GrupoOPC.OPCItems.AddItem("[segregado]C5:4.ACC", 13)
            'ItemOPC(14) = GrupoOPC.OPCItems.AddItem("[segregado]C5:5.ACC", 14)
            'ItemOPC(15) = GrupoOPC.OPCItems.AddItem("[segregado]C5:6.ACC", 15)

            'Total
            'ItemOPC(16) = GrupoOPC.OPCItems.AddItem("[segregado]C5:10.ACC", 16)

            'Start
            ItemOPC(17) = GrupoOPC.OPCItems.AddItem("[segregado]B3:0/1", 17)

            'Stop
            ItemOPC(18) = GrupoOPC.OPCItems.AddItem("[segregado]B3:0/2", 18)

            'Emergencia
            ItemOPC(19) = GrupoOPC.OPCItems.AddItem("[segregado]I:0/0", 19)

            'START OR STOP
            'Falta crear bit
            ItemOPC(20) = GrupoOPC.OPCItems.AddItem("[segregado]B3:0/3", 20)


        Catch ex As Exception

            Detalle_Error = "Error: " & ex.ToString
            Conectado = False
            Conectar = False
            Exit Function

        End Try

        Mensaje = "Conexión OPC realizada correctamente."
        Detalle_Error = ""
        Conectado = True
        Conectar = True

    End Function
    'Función para deshacer la conexión OPC
    Public Function Desconectar() As Boolean
        Try
            Mensaje = "Desconectando..."
            ItemOPC = Nothing

            If Not IsNothing(ServidorOPC) Then
                ServidorOPC.OPCGroups.RemoveAll()
                ServidorOPC.Disconnect()
                ServidorOPC = Nothing
            End If
            GrupoOPC = Nothing
            GruposOPC = Nothing

        Catch ex As Exception

            Detalle_Error = "Error: " & ex.ToString
            Desconectar = False
            Exit Function

        End Try

        Mensaje = "Desconexión realizada correctamente."
        Detalle_Error = ""
        Conectado = False
        Desconectar = True

    End Function

    'Función para escribir en un ítem que representa una variable entera
    'Se le pasa el índice del ítem y el valor que vamos a escribir
    'Si todo va bien devuelve True
    Public Function EscribirItemInt(ByVal Indice As Integer, ByVal Entero As String) As Boolean
        Dim Dims() As Integer = New Integer() {1}
        Dim Bounds() As Integer = New Integer() {1}
        Dim Serverhandles As Array = Array.CreateInstance(GetType(Integer), Dims, Bounds)
        Dim Errores As Array = Array.CreateInstance(GetType(Integer), Dims, Bounds)
        Dim Valores As Array = Array.CreateInstance(GetType(Object), Dims, Bounds)

        If Not Conectado Then
            Mensaje = "Error conexión OPC."
            Detalle_Error = "No hay establecida una conexión OPC."
            EscribirItemInt = False
            Exit Function
        End If

        Try
            Serverhandles.SetValue(ItemOPC(Indice).ServerHandle, 1)
            Errores.SetValue(0, 1)
            Valores.SetValue(Entero, 1)

            GrupoOPC.SyncWrite(1, Serverhandles, Valores, Errores)

        Catch ex As Exception

            Detalle_Error = ex.ToString
            Mensaje = "¡Error al escribir Item! [Int, Índice " & Indice & "]"
            EscribirItemInt = False
            Exit Function

        End Try

        Mensaje = ""
        Detalle_Error = ""
        EscribirItemInt = True

    End Function

    'Función para leer un ítem que representa una variable entera
    'Se le pasa el índice del ítem que vamos a leer
    'Si todo va bien devuelve el valor de la variable
    Public Function LeerItemInt(ByVal Indice) As Integer

        Dim Valor As Object = Nothing
        Dim Calidad As Object = Nothing
        Dim TimeStamp As Object = Nothing

        If Not Conectado Then
            Mensaje = "Error conexión OPC."
            Detalle_Error = "No hay establecida una conexión OPC."
            LeerItemInt = 0
            Exit Function
        End If

        Try
            ItemOPC(Indice).Read(OPCDataSource.OPCDevice, Valor, Calidad, TimeStamp)
            LeerItemInt = CInt(Valor.ToString)

        Catch ex As Exception

            Detalle_Error = ex.ToString
            Mensaje = "¡Error al leer Item! [Int, Índice " & Indice & "]"
            LeerItemInt = 0
            Exit Function

        End Try

        Mensaje = ""
        Detalle_Error = ""

    End Function
End Class
