<!-- default file list -->
*Files to look at*:

* [SimpleData.cs](./CS/SimpleData.cs) (VB: [SimpleData.vb](./VB/SimpleData.vb))
* [Window1.xaml](./CS/Window1.xaml) (VB: [Window1.xaml.vb](./VB/Window1.xaml.vb))
* [Window1.xaml.cs](./CS/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/Window1.xaml.vb))
<!-- default file list end -->
# How to automatically create columns for all fields in a grid's datasource


<p>The following example demonstrates how to automatically populate grid with all columns from its data source. This might be required, when it is necessary to show all columns from a data source, and no specific options should be defined for any column.</p><p>To accomplish this task, simply set the <strong>GridControl.AutoPopulateColumns</strong> property to <strong>True</strong>.</p><p>Starting with version<strong> 2013 vol 1</strong> the <strong>GridControl.AutoPopulateColumns</strong> property is marked as obsolete. The <strong>GridControl.AutoGenerateColumns</strong> property should be used instead.</p>

<br/>


