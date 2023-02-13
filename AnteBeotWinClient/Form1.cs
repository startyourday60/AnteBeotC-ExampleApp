using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace AnteBeotWinClient
{
    public partial class AntebeotLightClient : Form
    {
        private ClientOptions opt; // weird name. todo: change
        private LoginBox lform;
        public AntebeotLightClient()
        {
            InitializeComponent();
            opt = new ClientOptions();
            lform = new LoginBox();

        }
        public void showAllowedList(List<string> text)
        {
            var isFirst = true;
            StringBuilder b = new StringBuilder();
            foreach(var t in text)
            {
                if (!isFirst)
                {
                    b.Append("," + t);
                } else
                {
                    isFirst = false;
                    b.Append(t);
                }
            }
            MessageBox.Show("Сервер поддерживает:" + b.ToString());
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.showAllowedList(await opt.getAllowCoinList());
            } catch(Exception exc) {
                MessageBox.Show(exc.Message);
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // TODO: check if log already
            lform.Show();
        }

        private void UpdateSessionBut_Click(object sender, EventArgs e)
        {
            try
            {
                var session = lform.getSessionContainer();
                var ret = opt.updateSession(session);
                MessageBox.Show(ret);
                this.Exit.Show();

            } catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void reAuthButton_Click(object sender, EventArgs e)
        {
            lform.reauth();
        }
        private void AntebeotLightClient_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
                this.Exit.Hide();
        }
    }
}