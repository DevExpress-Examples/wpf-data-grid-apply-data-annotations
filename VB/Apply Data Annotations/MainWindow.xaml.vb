Imports System.Windows

Namespace Apply_Data_Annotations

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = Products.GetProducts()
        End Sub
    End Class
End Namespace
