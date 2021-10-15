Imports DevExpress.Xpf.Core

Namespace HeatmapMatrixData

    Public Partial Class MainWindow
        Inherits ThemedWindow

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class MatrixHeatmapViewModel

        Public Property XArguments As String()

        Public Property YArguments As String()

        Public Property Values As Double(,)

        Public Sub New()
            XArguments = New String() {"North", "South", "West", "East", "Central"}
            YArguments = New String() {"Accessories", "Bikes", "Clothing", "Components"}
            Values = New Double(,) {{214.3, 530.1, 630.2, 854.4, 313.4}, {321.3, 514.4, 281.3, 533.4, 541.9}, {604.3, 429.1, 632.6, 438.4, 265.4}, {485.3, 544.7, 740.3, 661.4, 516.6}}
        End Sub
    End Class
End Namespace
