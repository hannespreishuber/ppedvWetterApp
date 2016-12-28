' Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x407 dokumentiert.

Imports System.Net.Http
Imports Windows.Storage
''' <summary>
''' Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page
    ' Public Property WetterListe As ObservableCollection(Of Wetter) = New ObservableCollection(Of Wetter)
    Public Sub New()
        'Dummy: Bindung über Index sonst fehl schlägt- Daten kommen später
        'Dim ro = New Rootobject

        'ro.wlist = New ObservableCollection(Of Liste)
        'ro.wlist.Add(New Liste)
        'ro.wlist.Add(New Liste)
        'ro.wlist.Add(New Liste)
        'ro.wlist.Add(New Liste)
        'ro.wlist.Add(New Liste)
        'Wetter.WetterListe.Add(ro)
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub
    Public Property Wetter As WetterVM = New WetterVM
    Private Async Function MainPage_LoadedAsync(sender As Object, e As RoutedEventArgs) As Task Handles Me.Loaded
        ''Dim client = New HttpClient()
        ''Dim file = Await StorageFile.GetFileFromApplicationUriAsync(New Uri("ms-appx:///orte.txt"))
        ''Dim orte = Await FileIO.ReadLinesAsync(file)

        ''For Each Ort In orte
        ''    WetterListe.Add(New Wetter With {.Ort = Ort})
        ''    Dim json = Await client.GetStringAsync($"http://api.openweathermap.org/data/2.5/forecast/daily?q={Ort}&units=metric&appid=b72e486c65374cfd2e73de0c78332d8f")
        ''    Debug.WriteLine(json)
        ''Next

        ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.FullScreen


        Wetter.loadVMAsync()


    End Function
End Class
