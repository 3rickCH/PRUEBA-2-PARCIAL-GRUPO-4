Public Class PERSONA
    'Atributos
    Private apellidos As String
    Private nombre As String
    Private documento As String
    Private tipo As String

    'propiedades
    Public Property apellido As String
        Get
            Return apellidos
        End Get
        Set(value As String)
            apellidos = value

        End Set
    End Property

    Public Property nombres As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value

        End Set
    End Property

    Public Property documentos As String
        Get
            Return documento
        End Get
        Set(value As String)
            documento = value

        End Set
    End Property
    Public Property tipos As String
        Get
            Return tipo
        End Get
        Set(value As String)
            tipo = value

        End Set
    End Property
End Class
