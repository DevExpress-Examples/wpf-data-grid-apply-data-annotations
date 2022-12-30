Imports System.Windows

Namespace Apply_Data_Annotations

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = ProductList.GetData()
        End Sub
    End Class
End Namespace
