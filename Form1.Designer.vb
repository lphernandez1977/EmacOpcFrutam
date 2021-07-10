<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmacOpc
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmacOpc))
        Me.Spport = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBoxOPC = New System.Windows.Forms.GroupBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtsalida = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCaptura = New System.Windows.Forms.TextBox()
        Me.Cmbport = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBoxMensajes = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GrupoLector = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LblEmer = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GrupoLector.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Spport
        '
        Me.Spport.DataBits = 7
        Me.Spport.Parity = System.IO.Ports.Parity.Even
        Me.Spport.StopBits = System.IO.Ports.StopBits.Two
        '
        'GroupBoxOPC
        '
        Me.GroupBoxOPC.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxOPC.Name = "GroupBoxOPC"
        Me.GroupBoxOPC.Size = New System.Drawing.Size(200, 100)
        Me.GroupBoxOPC.TabIndex = 0
        Me.GroupBoxOPC.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Txtsalida)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtCaptura)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 159)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(546, 132)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lecturas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Salida"
        '
        'Txtsalida
        '
        Me.Txtsalida.Enabled = False
        Me.Txtsalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtsalida.Location = New System.Drawing.Point(142, 75)
        Me.Txtsalida.Name = "Txtsalida"
        Me.Txtsalida.Size = New System.Drawing.Size(300, 49)
        Me.Txtsalida.TabIndex = 9
        Me.Txtsalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Etiqueta"
        '
        'TxtCaptura
        '
        Me.TxtCaptura.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCaptura.Location = New System.Drawing.Point(76, 19)
        Me.TxtCaptura.MaxLength = 18
        Me.TxtCaptura.Name = "TxtCaptura"
        Me.TxtCaptura.Size = New System.Drawing.Size(450, 49)
        Me.TxtCaptura.TabIndex = 1
        Me.TxtCaptura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cmbport
        '
        Me.Cmbport.FormattingEnabled = True
        Me.Cmbport.Location = New System.Drawing.Point(377, 20)
        Me.Cmbport.Name = "Cmbport"
        Me.Cmbport.Size = New System.Drawing.Size(122, 21)
        Me.Cmbport.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'ListBoxMensajes
        '
        Me.ListBoxMensajes.FormattingEnabled = True
        Me.ListBoxMensajes.Location = New System.Drawing.Point(97, 55)
        Me.ListBoxMensajes.Name = "ListBoxMensajes"
        Me.ListBoxMensajes.Size = New System.Drawing.Size(402, 17)
        Me.ListBoxMensajes.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Puerto Com "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Puerto Opc"
        '
        'GrupoLector
        '
        Me.GrupoLector.Controls.Add(Me.Label8)
        Me.GrupoLector.Controls.Add(Me.Label7)
        Me.GrupoLector.Controls.Add(Me.ListBoxMensajes)
        Me.GrupoLector.Controls.Add(Me.Label2)
        Me.GrupoLector.Controls.Add(Me.Label1)
        Me.GrupoLector.Controls.Add(Me.Cmbport)
        Me.GrupoLector.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoLector.Location = New System.Drawing.Point(113, 22)
        Me.GrupoLector.Name = "GrupoLector"
        Me.GrupoLector.Size = New System.Drawing.Size(533, 80)
        Me.GrupoLector.TabIndex = 0
        Me.GrupoLector.TabStop = False
        Me.GrupoLector.Text = "Control Conexiones"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(245, 356)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 32)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(340, 356)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 31)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Stop"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LblEmer
        '
        Me.LblEmer.AutoSize = True
        Me.LblEmer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmer.Location = New System.Drawing.Point(266, 315)
        Me.LblEmer.Name = "LblEmer"
        Me.LblEmer.Size = New System.Drawing.Size(136, 25)
        Me.LblEmer.TabIndex = 17
        Me.LblEmer.Text = "Emergencia"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(486, 329)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.EmacOpc.My.Resources.Resources.X
        Me.PictureBox3.Location = New System.Drawing.Point(573, 180)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 102)
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.EmacOpc.My.Resources.Resources.visto
        Me.PictureBox2.Location = New System.Drawing.Point(573, 180)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 98)
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 414)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Agregar Caidas"
        '
        'EmacOpc
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(703, 441)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.LblEmer)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GrupoLector)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EmacOpc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "eMac-Sorter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrupoLector.ResumeLayout(False)
        Me.GrupoLector.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxOPC As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txtsalida As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtCaptura As System.Windows.Forms.TextBox
    Friend WithEvents Cmbport As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListBoxMensajes As System.Windows.Forms.ListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GrupoLector As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LblEmer As System.Windows.Forms.Label
    Public WithEvents Spport As System.IO.Ports.SerialPort
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label



End Class
