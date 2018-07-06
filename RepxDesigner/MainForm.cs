using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace RepxDesigner
{
    public partial class MainForm : Form
    {
        private ReportDesignTool _designer;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenDesigner();
        }

        private void OpenDesigner()
        {
            _designer = new ReportDesignTool(new XtraReport());
            _designer.ShowRibbonDesigner();
        }

        private void OpenDesignerClick(object sender, EventArgs e)
        {
            OpenDesigner();
        }
    }
}
