Public Class CLIENTE

    Inherits PERSONA
    'atributos
    Private _categoria As String
    Private _codigo As String

    'propiedades
    Public Property categoria As String
        Get
            Return _categoria

        End Get
        Set(value As String)
            _categoria = value
        End Set
    End Property
    Public Property codigo As String
        Get
            Return _codigo

        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property

    'operaciones
    Public Sub generarCodigo()
        Me.codigo = "C" & Me.apellido.Substring(0, 3) & "16"

    End Sub
End Class
