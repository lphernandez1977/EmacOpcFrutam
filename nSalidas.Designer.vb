<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nSalidas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(nSalidas))
        Me.DgvCaidas = New System.Windows.Forms.DataGridView()
        Me.TxtIdOla = New System.Windows.Forms.TextBox()
        Me.TxtNsalida = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Salida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.DgvCaidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvCaidas
        '
        Me.DgvCaidas.AllowUserToAddRows = False
        Me.DgvCaidas.AllowUserToDeleteRows = False
        Me.DgvCaidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCaidas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Salida, Me.Eliminar})
        Me.DgvCaidas.Location = New System.Drawing.Point(55, 159)
        Me.DgvCaidas.Name = "DgvCaidas"
        Me.DgvCaidas.ReadOnly = True
        Me.DgvCaidas.Size = New System.Drawing.Size(240, 192)
        Me.DgvCaidas.TabIndex = 0
        '
        'TxtIdOla
        '
        Me.TxtIdOla.Location = New System.Drawing.Point(136, 42)
        Me.TxtIdOla.MaxLength = 3
        Me.TxtIdOla.Name = "TxtIdOla"
        Me.TxtIdOla.Size = New System.Drawing.Size(159, 20)
        Me.TxtIdOla.TabIndex = 1
        Me.TxtIdOla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNsalida
        '
        Me.TxtNsalida.Location = New System.Drawing.Point(136, 82)
        Me.TxtNsalida.MaxLength = 1
        Me.TxtNsalida.Name = "TxtNsalida"
        Me.TxtNsalida.Size = New System.Drawing.Size(159, 20)
        Me.TxtNsalida.TabIndex = 2
        Me.TxtNsalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Codigo Salida"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nª Salida"
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar.Location = New System.Drawing.Point(59, 115)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(236, 32)
        Me.Btn_Agregar.TabIndex = 5
        Me.Btn_Agregar.Text = "Guardar"
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Column1"
        Me.DataGridViewImageColumn1.Image = Global.EmacOpc.My.Resources.Resources.images
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 50
        '
        'Salida
        '
        Me.Salida.HeaderText = "Salida"
        Me.Salida.Name = "Salida"
        Me.Salida.ReadOnly = True
        Me.Salida.Width = 50
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Image = Global.EmacOpc.My.Resources.Resources.images
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Width = 50
        '
        'nSalidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 363)
        Me.Controls.Add(Me.Btn_Agregar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNsalida)
        Me.Controls.Add(Me.TxtIdOla)
        Me.Controls.Add(Me.DgvCaidas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "nSalidas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Salidas"
        CType(Me.DgvCaidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvCaidas As System.Windows.Forms.DataGridView
    Friend WithEvents TxtIdOla As System.Windows.Forms.TextBox
    Friend WithEvents TxtNsalida As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Salida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewImageColumn
End Class
