<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128648371/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1521)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [SimpleData.cs](./CS/SimpleData.cs) (VB: [SimpleData.vb](./VB/SimpleData.vb))
* [Window1.xaml](./CS/Window1.xaml) (VB: [Window1.xaml](./VB/Window1.xaml))
* [Window1.xaml.cs](./CS/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/Window1.xaml.vb))
<!-- default file list end -->
# How to automatically create columns for all fields in a grid's datasource


The following example demonstrates how to automatically populate grid with all columns from its data source. You can use this technique to show all columns from a data source when you don't need to customize the columns.

Set the [DataControlBase.AutoGenerateColumns](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlBase.AutoGenerateColumns) property to **AutoGenerateColumnsMode.AddNew**, **AutoGenerateColumnsMode.KeepOld**, or **AutoGenerateColumnsMode.RemoveOld**.

<br/>


