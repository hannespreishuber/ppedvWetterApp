Imports System.Net.Http
Imports Newtonsoft.Json
Imports Windows.Storage

Public Class WetterVM
    Public WetterListe As ObservableCollection(Of Rootobject) = New ObservableCollection(Of Rootobject)


    Public Async Sub loadVMAsync()
        Dim client = New HttpClient()

        Dim file = Await StorageFile.GetFileFromApplicationUriAsync(New Uri("ms-appx:///orte.txt"))
        Dim orte = Await FileIO.ReadLinesAsync(file)
        ' WetterListe.Clear() 'dummy Daten weg

        For Each Ort In orte
            Dim wetter As Rootobject
            Dim json = Await client.GetStringAsync($"http://api.openweathermap.org/data/2.5/forecast/daily?q={Ort}&units=metric&appid=b72e486c65374cfd2e73de0c78332d8f")
            wetter = JsonConvert.DeserializeObject(Of Rootobject)(json)
            wetter.city.name = Ort 'Fix für Wetterstationsname 
            WetterListe.Add(wetter)
        Next

    End Sub

End Class
