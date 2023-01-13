using System.Data;
using System.Windows.Forms;

namespace MultiGame.Tools
{
    public partial class DebugVars : Form
    {
        DataTable dt = new DataTable("vars");
        public DebugVars()
        {
            InitializeComponent();
        }


        private void DebugVars_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID", Type.GetType("System.Int32"));
            dt.Columns.Add("Name", Type.GetType("System.String"));
            dt.Columns.Add("Value", Type.GetType("System.String"));
            rewerite();
        }
        private void rewerite()
        {
            dt.Rows.Add(1, "Endecode", endecode);
            dt.Rows.Add(2, "Username", username);
            dt.Rows.Add(3, "Log Update Interval", logupdateinterval.ToString());
            dt.Rows.Add(4, "Auto Clicker Interval", autoclickerinterval.ToString());
            dt.Rows.Add(5, "Money", money.ToString());
            dt.Rows.Add(6, "Generation", generation.ToString());
            dt.Rows.Add(7, "Outcome", outcome.ToString());
            dt.Rows.Add(8, "Auto Gen Mult", autogenmult.ToString());
            dt.Rows.Add(9, "Level", level.ToString());
            dt.Rows.Add(10, "Xp", xp.ToString());
            dt.Rows.Add(11, "Xpn", xpn.ToString());
            dt.Rows.Add(12, "Add1", add1.ToString());
            dt.Rows.Add(13, "Add2", add2.ToString());
            dt.Rows.Add(14, "Add3", add3.ToString());
            dt.Rows.Add(15, "Add4", add4.ToString());
            dt.Rows.Add(16, "Add5", add5.ToString());
            dt.Rows.Add(17, "Add6", add6.ToString());
            dt.Rows.Add(18, "Add7", add7.ToString());
            dt.Rows.Add(19, "Add8", add8.ToString());
            dt.Rows.Add(20, "Add9", add9.ToString());
            dt.Rows.Add(21, "Add10", add10.ToString());
            dt.Rows.Add(22, "Mult1", mult1.ToString());
            dt.Rows.Add(23, "Mult2", mult2.ToString());
            dt.Rows.Add(24, "Mult3", mult3.ToString());
            dt.Rows.Add(25, "Mult4", mult4.ToString());
            dt.Rows.Add(26, "Mult5", mult5.ToString());
            dt.Rows.Add(27, "Mult6", mult6.ToString());
            dt.Rows.Add(28, "Mult7", mult7.ToString());
            dt.Rows.Add(29, "Mult8", mult8.ToString());
            dt.Rows.Add(30, "Mult9", mult9.ToString());
            dt.Rows.Add(31, "Mult10", mult10.ToString());
            dt.Rows.Add(32, "Time Spent", timespent.ToString());
            dt.Rows.Add(33, "Workers", workers.ToString());
            dt.Rows.Add(34, "Inventions", inventions.ToString());
            dt.Rows.Add(35, "Mini Companies", minicompanies.ToString());
            dt.Rows.Add(36, "Company Net Worth", companynetworth.ToString());
            dt.Rows.Add(37, "Invested", invested.ToString());
            dt.Rows.Add(38, "Auto Collect Boosts", autocollectboosts.ToString());
            dt.Rows.Add(39, "Automatic Upgrade", automaticupgrade.ToString());
            dt.Rows.Add(40, "Magic Power", magicpower.ToString());
            dataGridView1.DataSource = dt;
        }

        private void DebugVars_FormClosing(object sender, FormClosingEventArgs e)
        {
            debugvarsshown = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rewerite();
        }
    }
}
