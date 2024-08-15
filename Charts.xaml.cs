using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace NotSoEpicApp
{
    public partial class Charts : Page
    {
        public Charts()
        {
            InitializeComponent();
            UpdatePieChart("Last Month");
        }

        private void BackToMainButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void Time_Range_Box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)Time_Range_Box.SelectedItem;
            string selectedPeriod = selectedItem.Content.ToString();

            UpdatePieChart(selectedPeriod);
        }

        private void UpdatePieChart(string period)
        {
            DateTime startDate;
            DateTime endDate = DateTime.Now;

            switch (period)
            {
                case "Last Month":
                    startDate = DateTime.Now.AddMonths(-1);
                    break;
                case "Last Quarter":
                    startDate = DateTime.Now.AddMonths(-3);
                    break;
                case "Last Year":
                    startDate = DateTime.Now.AddYears(-1);
                    break;
                default:
                    startDate = DateTime.Now.AddMonths(-1);
                    break;
            }

            var (TotalIncome, TotalExpenses) = TransactionManager.CalculateTotalsForPeriod(startDate, endDate);

            PieChartCanvas.Children.Clear();

            double total = Math.Abs((double)TotalIncome) + Math.Abs((double)TotalExpenses);

            if (total == 0) return;

            double incomeAngle = Math.Abs((double)TotalIncome) / total * 360;
            double expensesAngle = Math.Abs((double)TotalExpenses) / total * 360;

            DrawPieSlice(PieChartCanvas, 0, incomeAngle, Colors.Green);
            DrawPieSlice(PieChartCanvas, incomeAngle, expensesAngle, Colors.Red);

            double incomePercentage = (Math.Abs((double)TotalIncome) / total) * 100;
            double expensesPercentage = (Math.Abs((double)TotalExpenses) / total) * 100;

            IncomeTextBlock.Text = $"Income: {TotalIncome:C} ({incomePercentage:F1}%)";
            ExpensesTextBlock.Text = $"Expenses: {TotalExpenses:C} ({expensesPercentage:F1}%)";
        }

        private void DrawPieSlice(Canvas canvas, double startAngle, double angle, Color color)
        {
            double radius = 150;
            Point center = new Point(radius, radius);
            PathFigure figure = new PathFigure { StartPoint = center };
            double endAngle = startAngle + angle;

            Point startPoint = new Point(center.X + radius * Math.Cos(Math.PI * startAngle / 180.0),
                                         center.Y + radius * Math.Sin(Math.PI * startAngle / 180.0));
            Point endPoint = new Point(center.X + radius * Math.Cos(Math.PI * endAngle / 180.0),
                                       center.Y + radius * Math.Sin(Math.PI * endAngle / 180.0));

            bool isLargeArc = angle > 180.0;
            var segment = new ArcSegment
            {
                Point = endPoint,
                Size = new Size(radius, radius),
                SweepDirection = SweepDirection.Clockwise,
                IsLargeArc = isLargeArc
            };

            figure.Segments.Add(new LineSegment(startPoint, true));
            figure.Segments.Add(segment);
            figure.Segments.Add(new LineSegment(center, true));

            var pathGeometry = new PathGeometry();
            pathGeometry.Figures.Add(figure);

            var path = new Path
            {
                Fill = new SolidColorBrush(color),
                Data = pathGeometry
            };

            canvas.Children.Add(path);
        }
    }
}