Imports DevExpress.Mvvm.DataAnnotations
Imports System
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

Namespace Apply_Data_Annotations

    Public Enum Countries
        <Image("pack://application:,,,/Images/at.png")>
        Austria
        <Image("pack://application:,,,/Images/br.png")>
        Brazil
        <Image("pack://application:,,,/Images/de.png")>
        Germany
        <Image("pack://application:,,,/Images/it.png")>
        Italy
        <Image("pack://application:,,,/Images/mx.png")>
        Mexico
        <Image("pack://application:,,,/Images/gb.png")>
        UK
        <Image("pack://application:,,,/Images/us.png")>
        USA
    End Enum

    Public Class Product

        <Editable(False)>
        Public Property Id As Integer

        <Display(Name:="Product")>
        Public Property ProductName As String

        <GridEditor(TemplateKey:="comboBox")>
        Public Property Country As Countries

        <Required>
        Public Property City As String

        <NumericMask(Mask:="c", UseAsDisplayFormat:=True)>
        Public Property UnitPrice As Double

        Public Property Quantity As Integer

        <DisplayFormat(DataFormatString:="yyyy-MMM-dd dddd")>
        Public Property OrderDate As Date

        <Display(AutoGenerateField:=False, Description:="This column is not created.")>
        Public Property AdditionalInfo As String
    End Class

    Public Class Products

        Public Shared Function GetProducts() As ObservableCollection(Of Product)
            Dim products = New ObservableCollection(Of Product) From {New Product() With {.Id = 0, .ProductName = "Chang", .Country = Countries.UK, .City = "Cowes", .UnitPrice = 19, .Quantity = 10, .OrderDate = New DateTime(2021, 10, 23)}, New Product() With {.Id = 1, .ProductName = "Gravad lax", .Country = Countries.Italy, .City = "Reggio Emilia", .UnitPrice = 12.5, .Quantity = 16, .OrderDate = New DateTime(2021, 10, 22)}, New Product() With {.Id = 2, .ProductName = "Ravioli Angelo", .Country = Countries.Brazil, .City = "Rio de Janeiro", .UnitPrice = 19, .Quantity = 12, .OrderDate = New DateTime(2021, 10, 21)}, New Product() With {.Id = 3, .ProductName = "Tarte au sucre", .Country = Countries.Germany, .City = "Leipzig", .UnitPrice = 22, .Quantity = 50, .OrderDate = New DateTime(2021, 10, 15)}, New Product() With {.Id = 4, .ProductName = "Steeleye Stout", .Country = Countries.USA, .City = "Denver", .UnitPrice = 18, .Quantity = 20, .OrderDate = New DateTime(2021, 10, 8)}, New Product() With {.Id = 5, .ProductName = "Pavlova", .Country = Countries.Austria, .City = "Graz", .UnitPrice = 21, .Quantity = 52, .OrderDate = New DateTime(2021, 10, 1)}, New Product() With {.Id = 6, .ProductName = "Longlife Tofu", .Country = Countries.USA, .City = "Boise", .UnitPrice = 7.75, .Quantity = 120, .OrderDate = New DateTime(2021, 9, 17)}, New Product() With {.Id = 7, .ProductName = "Alice Mutton", .Country = Countries.Mexico, .City = "México D.F.", .UnitPrice = 21, .Quantity = 15, .OrderDate = New DateTime(2021, 9, 25)}}
            Return products
        End Function
    End Class
End Namespace
