Class MainWindow
    Private OffColor As SolidColorBrush = New SolidColorBrush(Color.FromRgb(0, 0, 0))
    Private OnColor As SolidColorBrush = New SolidColorBrush(Color.FromRgb(240, 222, 45))

    Private Sub Bu_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles Bu.MouseLeftButtonDown
        If Bu.Toggled1 Then
            Light.Fill = OnColor
        Else
            Light.Fill = OffColor
        End If
    End Sub
End Class
