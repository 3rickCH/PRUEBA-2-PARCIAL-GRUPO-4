
Public Class FRM_REGISTROS


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim empleado1 As EMPLEADO = New EMPLEADO()
        empleado1.apellido = TextApellido.Text
        empleado1.nombres = Textnombre.Text
        empleado1.documentos = Textdocumento.Text
        empleado1.tipos = Cbotipo.Text
        empleado1.tipocontrato = Cbocontrato.Text

        empleado1.calcularsueldo(750)
        DataEmpleados.Rows.Insert(0, empleado1.tipos, empleado1.apellido, empleado1.nombres, empleado1.documentos, empleado1.sueldo)
    End Sub


End Class