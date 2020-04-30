using System.Windows.Forms;

namespace APCRM
{
    public partial class GraphForm : Form
    {
        public GraphForm(int[] rolesData)
        {
            InitializeComponent();
            DrawHistogram(rolesData);
            DrawRadarChart(rolesData);
        }

        private void DrawHistogram(int[] rolesData)
        {
            Histogram.Series[0].Name = "";
            Histogram.ChartAreas[0].AxisX.Title = "Role";
            Histogram.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            Histogram.ChartAreas[0].AxisX.Interval = 1;
            Histogram.ChartAreas[0].AxisY.Title = "Frequency";
            Histogram.ChartAreas[0].AxisY.Interval = 1;
            Histogram.ChartAreas[0].AxisY.IntervalOffset = 1;

            string[] roles = new string[6]
            {
                "Information Holder",
                "Structurer",
                "Service Provider",
                "Controller",
                "Coordinator",
                "Interfacer"
            };

            for (int i = 0; i < rolesData.Length; i++)
            {
                Histogram.Series[0].Points.AddXY(roles[i], rolesData[i]);
            }
        }

        private void DrawRadarChart(int[] rolesData)
        {
            RadarChart.Series[0].Name = "";

            string[] roles = new string[6]
            {
                "Information Holder",
                "Structurer",
                "Service Provider",
                "Controller",
                "Coordinator",
                "Interfacer"
            };

            for (int i = 0; i < rolesData.Length; i++)
            {
                RadarChart.Series[0].Points.AddXY(roles[i], 0.5 + rolesData[i]);
            }
        }
    }
}
