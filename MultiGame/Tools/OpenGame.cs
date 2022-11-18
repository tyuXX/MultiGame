using System;
using System.IO;
using System.Numerics;
using System.Windows.Forms;
using static MultiGame.rntm;

namespace MultiGame.Tools
{
    public partial class OpenGame : Form
    {
        public OpenGame()
        {
            InitializeComponent();
        }

        private void OpenGame_Load(object sender, EventArgs e)
        {
            log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Form]{(Log)}Opening Form");
        }

        private void OpenGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Form]{(Log)}Closing Form");
            opengameshown = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] masterfile = File.ReadAllLines(textBox1.Text);
            string endest = endecode;
            endecode = textBox2.Text;
            if (decode(masterfile[0]) == textBox2.Text)
            {
                endecode = textBox2.Text;
                try { username = decode(masterfile[1]); }catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { logupdateinterval = Convert.ToInt32(decode(masterfile[2])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { autoclickerinterval = Convert.ToInt32(decode(masterfile[3])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { money = BigInteger.Parse(decode(masterfile[4])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { generation = BigInteger.Parse(decode(masterfile[5])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { outcome = BigInteger.Parse(decode(masterfile[6])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { autogenmult = BigInteger.Parse(decode(masterfile[7])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { level = BigInteger.Parse(decode(masterfile[8])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { xp = BigInteger.Parse(decode(masterfile[9])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { xpn = BigInteger.Parse(decode(masterfile[10])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { add1 = BigInteger.Parse(decode(masterfile[11])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { add2 = BigInteger.Parse(decode(masterfile[12])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { add3 = BigInteger.Parse(decode(masterfile[13])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { add4 = BigInteger.Parse(decode(masterfile[14])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { add5 = BigInteger.Parse(decode(masterfile[15])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { add6 = BigInteger.Parse(decode(masterfile[16])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { add7 = BigInteger.Parse(decode(masterfile[17])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { add8 = BigInteger.Parse(decode(masterfile[18])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { add9 = BigInteger.Parse(decode(masterfile[19])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { add10 = BigInteger.Parse(decode(masterfile[20])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { mult1 = BigInteger.Parse(decode(masterfile[21])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { mult2 = BigInteger.Parse(decode(masterfile[22])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { mult3 = BigInteger.Parse(decode(masterfile[23])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { mult4 = BigInteger.Parse(decode(masterfile[24])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { mult5 = BigInteger.Parse(decode(masterfile[25])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { mult6 = BigInteger.Parse(decode(masterfile[26])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { mult7 = BigInteger.Parse(decode(masterfile[27])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { mult8 = BigInteger.Parse(decode(masterfile[28])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { mult9 = BigInteger.Parse(decode(masterfile[29])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { mult10 = BigInteger.Parse(decode(masterfile[30])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { timespent = BigInteger.Parse(decode(masterfile[31])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { workers = BigInteger.Parse(decode(masterfile[32])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { inventions = BigInteger.Parse(decode(masterfile[33])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { minicompanies = BigInteger.Parse(decode(masterfile[34])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { companynetworth = BigInteger.Parse(decode(masterfile[35])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { invested = BigInteger.Parse(decode(masterfile[36])); } catch(Exception ex) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at reading file error is:" + ex); }
                try { recalculatevars(); } catch (Exception) { log.Add("[" + DateTime.Now + "][From:Internal/Tool/OpenGame/Opening]{(Error)}Error at recalculating varirables"); }
            }
            else
            {
                endecode = endest;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open Save File For MultiGame";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }
    }
}
