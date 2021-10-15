using DevExpress.Xpf.Core;

namespace HeatmapMatrixData {
    public partial class MainWindow : ThemedWindow {
        public MainWindow() {
            InitializeComponent();
        }
    }
    public class MatrixHeatmapViewModel {
        public string[] XArguments { get; set; }
        public string[] YArguments { get; set; }
        public double[,] Values { get; set; }
        public MatrixHeatmapViewModel() {
            XArguments = new string[] { "North", "South", "West", "East", "Central" };
            YArguments = new string[] { "Accessories", "Bikes", "Clothing", "Components" };
            Values = new double[,] {
               { 214.3, 530.1, 630.2, 854.4, 313.4 },
               { 321.3, 514.4, 281.3, 533.4, 541.9 },
               { 604.3, 429.1, 632.6, 438.4, 265.4 },
               { 485.3, 544.7, 740.3, 661.4, 516.6 }
            };
        }
    }
}
