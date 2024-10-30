<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128648371/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1521)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Data Grid - Generate Columns for All Fields in a Data Source

This example uses the [DataControlBase.AutoGenerateColumns](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlBase.AutoGenerateColumns) property to populate the grid with columns from its data source.

The image below demonstrates the difference between generation modes (**AddNew**, **KeepOld**, and **RemoveOld**). Manually defined columns are highlighted in light yellow; automatically generated columns do not have a background color.

![image](https://user-images.githubusercontent.com/65009440/209556936-8470d8a6-2878-49a5-908f-f1b70d603d34.png)

## Files to Review

* [Window1.xaml](./CS/Window1.xaml) (VB: [Window1.xaml](./VB/Window1.xaml))
* [Window1.xaml.cs](./CS/ViewModel.cs) (VB: [Window1.xaml.vb](./VB/ViewModel.vb))
* [SimpleData.cs](./CS/SimpleData.cs) (VB: [SimpleData.vb](./VB/SimpleData.vb))

## Documentation

* [DataControlBase.AutoGenerateColumns](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlBase.AutoGenerateColumns)
* [Create Columns and Bind Them to Data Properties](https://docs.devexpress.com/WPF/6094/controls-and-libraries/data-grid/grid-view-data-layout/columns-and-card-fields/create-columns-and-bind-them-to-data-properties)
* [Bind the Grid to a Collection of Columns](https://docs.devexpress.com/WPF/10121/controls-and-libraries/data-grid/examples/mvvm-enhancements/binding-to-a-collection-of-columns)

## More Examples

* [WPF Data Grid - Customize Automatically Generated Columns](https://github.com/DevExpress-Examples/how-to-customize-automatically-generated-columns-e2019)
* [Bind the WPF Data Grid to Data](https://github.com/DevExpress-Examples/how-to-bind-wpf-grid-to-data)
* [WPF Data Grid - Apply Data Annotations](https://github.com/DevExpress-Examples/how-to-apply-data-annotations-e2579)
* [Bind the WPF Data Grid to a Collection of Columns Specified in a ViewModel](https://github.com/DevExpress-Examples/wpf-data-grid-bind-columns-to-viewmodel-collection)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-generate-columns-for-all-fields-in-data-source&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-generate-columns-for-all-fields-in-data-source&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
