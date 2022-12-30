<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128648238/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2579)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF Data Grid - Apply Data Annotations

This example uses data annotation attributes to customize data displayed in the [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl). Set the [DataControlBase.EnableSmartColumnsGeneration](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlBase.EnableSmartColumnsGeneration) property to `true` to configure grid columns based on applied attributes.

![image](https://user-images.githubusercontent.com/65009440/209819101-4460427c-df7e-4db4-ae5a-908b50574713.png)

The following help topic lists supported attributes from the [System.ComponentModel.DataAnnotations](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations) and [DevExpress.Mvvm.DataAnnotations](https://docs.devexpress.com/CoreLibraries/DevExpress.Mvvm.DataAnnotations) namespaces: [Data Annotation Attributes](https://docs.devexpress.com/WPF/16863/mvvm-framework/data-annotation-attributes).

## Files to Review

* [Products.cs](./CS/Apply%20Data%20Annotations/Products.cs) (VB: [Products.vb](./VB/Apply%20Data%20Annotations/Products.vb))
* [MainWindow.xaml](./CS/Apply%20Data%20Annotations/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/Apply%20Data%20Annotations/MainWindow.xaml))

## Documentation

* [Apply Data Annotations](https://docs.devexpress.com/WPF/8834/controls-and-libraries/data-grid/grid-view-data-layout/columns-and-card-fields/applying-data-annotations)
* [DataControlBase.EnableSmartColumnsGeneration](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlBase.EnableSmartColumnsGeneration)
* [Data Annotation Attributes](https://docs.devexpress.com/WPF/16863/mvvm-framework/data-annotation-attributes)
* [Attribute-Based Validation](https://docs.devexpress.com/WPF/9770/controls-and-libraries/data-grid/data-editing-and-validation/input-validation/attribute-based-validation)

## More Examples

* [WPF Data Grid - Implement Attribute-Based Validation](https://github.com/DevExpress-Examples/how-to-implement-attributes-based-validation-e3191)
* [Format GridControl Columns Using Data Attributes and Fluent API](https://github.com/DevExpress-Examples/how-to-format-gridcontrol-columns-using-data-attributes-and-fluent-api-e5119)
* [Use DataAnnotation Attributes with DevExpress Controls](https://github.com/DevExpress-Examples/how-to-use-dataannotation-attributes-with-devexpress-controls-e5179)
