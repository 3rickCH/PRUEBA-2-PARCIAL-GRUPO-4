Public Class EMPLEADO
    Inherits PERSONA

    'átributos
    Private _tipocontrato As String

    Private _sueldos As Double

    'propiedaes
    Public Property tipocontrato As String
        Get
            Return _tipocontrato
        End Get
        Set(value As String)
            _tipocontrato = value
        End Set
    End Property

    Public Property sueldo As Double
        Get
            Return _sueldos
        End Get
        Set(value As Double)
            _sueldos = value
        End Set
    End Property

    'operaciones
    Public Sub calcularsueldo(sueldobase As Double)
        If (Me.tipocontrato = "C") Then
            Me.sueldo = sueldobase + 400
        ElseIf (Me.tipocontrato = "N") Then
            Me.sueldo = sueldobase + 750
        Else
            Me.sueldo = 0

        End If

    End Sub

End Class
