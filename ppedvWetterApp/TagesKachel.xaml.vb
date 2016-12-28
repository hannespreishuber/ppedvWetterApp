' The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

Public NotInheritable Class TagesKachel
    Inherits UserControl
    Implements INotifyPropertyChanged
    Private _wetter As Liste
    Public Property Wetter() As Liste
        Get
            Return _wetter
        End Get
        Set(ByVal value As Liste)
            _wetter = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Wetter"))
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
