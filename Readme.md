<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/417457153/21.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1036990)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# How to Create a Heatmap Based on Arrays of String and Numeric Values

This example shows how to use string and numeric value arrays to create a heatmap.

![Resulting heatmap](Images/heatmap.png)

To load array data to a heatmap, follow the steps below:

- Create a [HeatmapMatrixAdapter](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.Heatmap.HeatmapMatrixAdapter?v=21.2&p=netframework) object. 

- Specify the following adapter properties:

    - [XArguments](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.Heatmap.HeatmapMatrixAdapter.XArguments)
    - [YArguments](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.Heatmap.HeatmapMatrixAdapter.YArguments)
    - [Values](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.Heatmap.HeatmapMatrixAdapter.Values)

- Assign the adapter object to the [HeatmapControl.DataAdapter](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.Heatmap.HeatmapControl.DataAdapter) property.

<!-- default file list -->
## Files to Look At

- [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
- [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))

<!-- default file list end -->

## Documentation

- [HeatmapControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.Heatmap.HeatmapControl)

## More Examples

- [How to Create a Heatmap Chart Based on a Data Source](https://github.com/DevExpress-Examples/wpf-heatmap-bind-to-data-source)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-heatmap-matrix-data&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-heatmap-matrix-data&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
