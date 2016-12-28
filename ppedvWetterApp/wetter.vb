Imports Newtonsoft.Json

Public Class Wetter
    Public Property Ort As String

End Class


Public Class Rootobject
    Public Property city As City
    Public Property cod As String
    Public Property message As Single
    Public Property cnt As Integer
    <JsonProperty("list")>
    Public Property wlist As List(Of Liste)
End Class

Public Class City
    Public Property id As Integer
    Public Property name As String
    Public Property coord As Coord
    Public Property country As String
    Public Property population As Integer
End Class

Public Class Coord
    Public Property lon As Single
    Public Property lat As Single
End Class

Public Class Liste
    Public Property dt As Integer
    Public Property temp As Temp
    Public Property pressure As Single
    Public Property humidity As Integer
    Public Property weather As List(Of Weather)
    Public Property speed As Single
    Public Property deg As Integer
    Public Property clouds As Integer
    Public Property snow As Single
    Public Function Int2Datum(s As Integer) As String
        Dim d = New DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
        Dim dd = String.Format("{0:d.ddd}", d.AddSeconds(s))
        Return dd
    End Function
End Class

Public Class Temp
    Public Property day As Single
    Public Property min As Single
    Public Property max As Single
    Public Property night As Single
    Public Property eve As Single
    Public Property morn As Single
    Public Function AsPfad(icon As String) As ImageSource
        Dim bi = New BitmapImage(New Uri($"ms-appx:///Assets/{icon}.png", UriKind.RelativeOrAbsolute))

        Return bi
    End Function
    Public Function AsInt(t As Double) As String
        Return Math.Round(t).ToString
    End Function
End Class

Public Class Weather
    Public Property id As Integer
    Public Property main As String
    Public Property description As String
    Public Property icon As String
End Class
