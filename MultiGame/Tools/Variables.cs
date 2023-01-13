using System.Windows.Forms;

namespace MultiGame.Tools
{
    public partial class Variables : Form
    {
        public Variables()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            richTextBox1.Text = $"Variables:\r\nendecode:{endecode}\r\nusername:{username}\r\nlastfile:{lastfile}\r\nclshown:{clshown}\r\nfnfshown:{fnfshown}\r\nlogshown:{logshown}\r\naddlogshown:{addlogshown}\r\ntoggledevmodeshown:{toggledevmodeshown}\r\nshopshown:{shopshown}\r\nchangeusernameshown:{changeusernameshown}\r\nchangepasscodeshown:{changepasscodeshown}\r\nsavegameshown:{savegameshown}\r\nopengameshown:{opengameshown}\r\ngamesincshown:{gamesincshown}\r\nshop2shown:{shop2shown}\r\naboutshown:{aboutshown}\r\nmagicshown:{magicshown}\r\nmagicpowergeneratorshown:{magicpowergeneratorshown}\r\ndebugvarsshown:{debugvarsshown}\r\nshopthshown:{shopthshown}\r\nvarsshown:{varsshown}\r\ndevmode:{devmode}\r\ncheat:{cheat}\r\ncompanywork:{companywork}\r\nalwaysontop:{alwaysontop}\r\nautocollectboosts:{autocollectboosts}\r\nautomaticupgrade:{automaticupgrade}\r\ntooltips:{tooltips}\r\nformatnums:{formatnums}\r\ndialout:{dialout}\r\ndialset:{dialset}\r\nautosave:{autosave}\r\nclearlog:{clearlog}\r\nlogupdateinterval:{logupdateinterval}\r\nautoclickerinterval:{autoclickerinterval}\r\nautoupgradeinterval,:{autoupgradeinterval}\r\nmoneybagc:{moneybagc}\r\ngenboostc:{genboostc}\r\nautoclickerintervaln:{autoclickerintervaln}\r\nautoupgradeintervaln:{autoupgradeintervaln}\r\nmoneybagcn:{moneybagcn}\r\ngenboostcn:{genboostcn}\r\ntimespent:{timespent}\r\nmoney:{money}\r\ngeneration:{generation}\r\noutcome:{outcome}\r\nautogenmult:{autogenmult}\r\nautogenmultn:{autogenmultn}\r\nlevel:{level}\r\nxp:{xp}\r\nxpn:{xpn}\r\nadd1:{add1}\r\nadd1n:{add1n}\r\nadd2:{add2}\r\nadd2n:{add2n}\r\nadd3:{add3}\r\nadd3n:{add3n}\r\nadd4:{add4}\r\nadd4n:{add4n}\r\nadd5:{add5}\r\nadd5n:{add5n}\r\nadd6:{add6}\r\nadd6n:{add6n}\r\nadd7:{add7}\r\nadd7n:{add7n}\r\nadd8:{add8}\r\nadd8n:{add8n}\r\nadd9:{add9}\r\nadd9n:{add9n}\r\nadd10:{add10}\r\nadd10n:{add10n}\r\nmult1:{mult1}\r\nmult1n:{mult1n}\r\nmult2:{mult2}\r\nmult2n:{mult2n}\r\nmult3:{mult3}\r\nmult3n:{mult3n}\r\nmult4:{mult4}\r\nmult4n:{mult4n}\r\nmult5:{mult5}\r\nmult5n:{mult5n}\r\nmult6:{mult6}\r\nmult6n:{mult6n}\r\nmult7:{mult7}\r\nmult7n:{mult7n}\r\nmult8:{mult8}\r\nmult8n:{mult8n}\r\nmult9:{mult9}\r\nmult9n:{mult9n}\r\nmult10:{mult10}\r\nmult10n:{mult10n}\r\nworkers:{workers}\r\nworkersn:{workersn}\r\ninventions:{inventions}\r\ninventionsn:{inventionsn}\r\nminicompanies:{minicompanies}\r\nminicompaniesn:{minicompaniesn}\r\ncompanynetworth:{companynetworth}\r\ninvested:{invested}\r\ninvestedn:{investedn}\r\nboost1:{boost1}\r\nboost1t:{boost1t}\r\nboost2:{boost2}\r\nboost2t:{boost2t}\r\nboost3:{boost3}\r\nboost3t:{boost3t}\r\nboost4:{boost4}\r\nboost4t:{boost4t}\r\nboost5:{boost5}\r\nboost5t:{boost5t}\r\nboost6:{boost6}\r\nboost6t:{boost6t}\r\nboost7:{boost7}\r\nboost7t:{boost7t}\r\nboost8:{boost8}\r\nboost8t:{boost8t}\r\nboost9:{boost9}\r\nboost9t:{boost9t}\r\nboost10:{boost10}\r\nboost10t:{boost10t}\r\nmagicpower:{magicpower}\r\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            button2.Text = $"Auto Refresh\r\n{timer1.Enabled}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            refresh();
        }

        private void Variables_FormClosing(object sender, FormClosingEventArgs e)
        {
            varsshown = false;
        }

        private void Variables_Load(object sender, EventArgs e)
        {

        }
    }
}
