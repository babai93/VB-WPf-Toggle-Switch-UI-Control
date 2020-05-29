Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Public Class ToggleButton
    Inherits UserControl
    Private LeftSide As Thickness = New Thickness(-45, 0, 0, 0)
    Private RightSide As Thickness = New Thickness(0, 0, -45, 0)
    Private OffColor As SolidColorBrush = New SolidColorBrush(Color.FromRgb(160, 160, 160))
    Private OnColor As SolidColorBrush = New SolidColorBrush(Color.FromRgb(130, 190, 125))
    Private Toggled As Boolean = False
    Public Sub New()
        InitializeComponent()
        Back.Fill = OffColor
        Toggled = False
        Dot.Margin = LeftSide
    End Sub
    Public Property Toggled1 As Boolean
        Get
            Return Toggled
        End Get
        Set(value As Boolean)
            Toggled = value
        End Set
    End Property
    Private Sub Dot_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles Dot.MouseLeftButtonDown
        If Not Toggled Then
            Back.Fill = OnColor
            Toggled = True
            Dot.Margin = RightSide
        Else
            Back.Fill = OffColor
            Toggled = False
            Dot.Margin = LeftSide
        End If
    End Sub
    Private Sub Back_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles Back.MouseLeftButtonDown
        If Not Toggled Then
            Back.Fill = OnColor
            Toggled = True
            Dot.Margin = RightSide
        Else
            Back.Fill = OffColor
            Toggled = False
            Dot.Margin = LeftSide
        End If
    End Sub
End Class
