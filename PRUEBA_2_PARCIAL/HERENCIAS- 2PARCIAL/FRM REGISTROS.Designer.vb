<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_REGISTROS
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Textdocumento = New System.Windows.Forms.TextBox()
        Me.TextApellido = New System.Windows.Forms.TextBox()
        Me.Textnombre = New System.Windows.Forms.TextBox()
        Me.Cbocontrato = New System.Windows.Forms.ComboBox()
        Me.Cbotipo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataEmpleados = New System.Windows.Forms.DataGridView()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Documentos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sueldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Textdocumento)
        Me.GroupBox1.Controls.Add(Me.TextApellido)
        Me.GroupBox1.Controls.Add(Me.Textnombre)
        Me.GroupBox1.Controls.Add(Me.Cbocontrato)
        Me.GroupBox1.Controls.Add(Me.Cbotipo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 327)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS GENERALES"
        '
        'Textdocumento
        '
        Me.Textdocumento.Location = New System.Drawing.Point(87, 137)
        Me.Textdocumento.Name = "Textdocumento"
        Me.Textdocumento.Size = New System.Drawing.Size(176, 20)
        Me.Textdocumento.TabIndex = 3
        '
        'TextApellido
        '
        Me.TextApellido.Location = New System.Drawing.Point(166, 31)
        Me.TextApellido.Name = "TextApellido"
        Me.TextApellido.Size = New System.Drawing.Size(99, 20)
        Me.TextApellido.TabIndex = 3
        '
        'Textnombre
        '
        Me.Textnombre.Location = New System.Drawing.Point(61, 31)
        Me.Textnombre.Name = "Textnombre"
        Me.Textnombre.Size = New System.Drawing.Size(99, 20)
        Me.Textnombre.TabIndex = 3
        '
        'Cbocontrato
        '
        Me.Cbocontrato.FormattingEnabled = True
        Me.Cbocontrato.Items.AddRange(New Object() {"C", "N"})
        Me.Cbocontrato.Location = New System.Drawing.Point(98, 177)
        Me.Cbocontrato.Name = "Cbocontrato"
        Me.Cbocontrato.Size = New System.Drawing.Size(121, 21)
        Me.Cbocontrato.TabIndex = 2
        Me.Cbocontrato.Text = "C"
        '
        'Cbotipo
        '
        Me.Cbotipo.FormattingEnabled = True
        Me.Cbotipo.Items.AddRange(New Object() {"Vendedor", "Cajero", "Administrador"})
        Me.Cbotipo.Location = New System.Drawing.Point(62, 81)
        Me.Cbotipo.Name = "Cbotipo"
        Me.Cbotipo.Size = New System.Drawing.Size(121, 21)
        Me.Cbotipo.TabIndex = 2
        Me.Cbotipo.Text = "Vendedor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Contrato:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Documento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombres:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(205, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataEmpleados
        '
        Me.DataEmpleados.AllowUserToAddRows = False
        Me.DataEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tipo, Me.Nombres, Me.Apellidos, Me.Documentos, Me.Sueldo})
        Me.DataEmpleados.Location = New System.Drawing.Point(325, 40)
        Me.DataEmpleados.Name = "DataEmpleados"
        Me.DataEmpleados.Size = New System.Drawing.Size(510, 279)
        Me.DataEmpleados.TabIndex = 0
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        '
        'Nombres
        '
        Me.Nombres.HeaderText = "Nombres"
        Me.Nombres.Name = "Nombres"
        '
        'Apellidos
        '
        Me.Apellidos.HeaderText = "Apellidos"
        Me.Apellidos.Name = "Apellidos"
        '
        'Documentos
        '
        Me.Documentos.HeaderText = "Documentos"
        Me.Documentos.Name = "Documentos"
        '
        'Sueldo
        '
        Me.Sueldo.HeaderText = "Sueldo"
        Me.Sueldo.Name = "Sueldo"
        '
        'FRM_REGISTROS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(847, 379)
        Me.Controls.Add(Me.DataEmpleados)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FRM_REGISTROS"
        Me.Text = "REGISTROS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Textdocumento As TextBox
    Friend WithEvents TextApellido As TextBox
    Friend WithEvents Textnombre As TextBox
    Friend WithEvents Cbocontrato As ComboBox
    Friend WithEvents Cbotipo As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataEmpleados As DataGridView
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Nombres As DataGridViewTextBoxColumn
    Friend WithEvents Apellidos As DataGridViewTextBoxColumn
    Friend WithEvents Documentos As DataGridViewTextBoxColumn
    Friend WithEvents Sueldo As DataGridViewTextBoxColumn
End Class
