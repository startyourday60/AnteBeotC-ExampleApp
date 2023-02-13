using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace AnteBeotWinClient
{
    public partial class LoginBox : Form
    {
        private ClientOptions opt;
        private CookieContainer lastCaptchaCookie;
        private CookieContainer sessionCookieContainer;
        private String m_tokenCaptcha;
        // private bool sessionExists = false;
        private string usfile;
        public LoginBox(string usfile = "usession.dat")
        {
            InitializeComponent();
            opt = new ClientOptions();
            m_tokenCaptcha = "";
            lastCaptchaCookie = new CookieContainer();
            sessionCookieContainer = null;
            this.usfile = usfile;
        }
        // Returns cookie
        private void getCaptcha()
        {
            String uri = opt.GetUri();
            var request = WebRequest.Create(uri+ "/captcha/?w=get");

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox1.Image = Bitmap.FromStream(stream);
                var cookies = response.Headers[HttpResponseHeader.SetCookie];
                if (cookies == null) throw new Exception("Broken connection? no cookie");
                //CookieContainer c = new CookieContainer();
                foreach (string c in cookies.Split(";"))
                {
                    //var pair = c.Split("=");
                    //if (pair[0] == null || pair[1] == null) continue;
                    lastCaptchaCookie.SetCookies(new Uri(uri), c);
                }
                // this.lastCaptchaCookie = cookies;
                return;
            }
        }
        private String doAuth(string workname, string workpass, string otp, string captcha, string ulang = "en_US")
        {
            String uri = opt.GetUri();
            String rUri = String.Format("{0}/signin/?workname={1}&workpass={2}&captchaText={3}&otpcode={4}&lang={5}",
                uri, workname, workpass, captcha, otp, ulang);
            //MessageBox.Show(rUri);
            //foreach (Cookie cookie in this.lastCaptchaCookie.GetCookies(new Uri(uri)))
            //{
            //    MessageBox.Show(cookie.Name + "="+ cookie.Value);
            //}
            
            //Cookie cook = new Cookie();
            
            var request = (HttpWebRequest)WebRequest.Create(rUri);
            request.CookieContainer = this.lastCaptchaCookie;
            //var cookie_id = this.lastCaptchaCookie.Split(";")[0].Split("=");
            //request.CookieContainer.Add(cookie_id[0], "....")

            // 'workname': name, 'workpass': pass, 'captchaText': captcha, 'otpcode': ocode, 'lang': ulang 
            string err;
            try
            {
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream);
                    string text = reader.ReadToEnd();
                    var cookies = response.Headers[HttpResponseHeader.SetCookie];
                    if (cookies != null)
                    {
                        return cookies;
                    }
                    MessageBox.Show(text);

                }
            } catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return "";
        }
        public void reauth()
        {
            File.Delete(this.usfile);
            Application.Restart();
        }
       // public bool isSessionExists()
       // {
       //     return sessionExists;
       // }
        private void LoginBox_Load(object sender, EventArgs e)
        {
            //this.pictureBox1.LoadImage(null);
            try
            {
                this.sessionCookieContainer = ClientOptions.ReadCookiesFromDisk(this.usfile);
                MessageBox.Show("Сессия была восстановлена из файла");
                this.Hide();
                this.Close();
            } catch(Exception _)
            {
                getCaptcha();
            }
            
        }
        public void delSessionCookie()
        {
            sessionCookieContainer = null;
        }
        public CookieContainer getSessionContainer()
        {
            if (sessionCookieContainer == null) throw new Exception("Сначала авторизируйтесь");
            return sessionCookieContainer;
        }
        private void AuthBut_Click(object sender, EventArgs e)
        {
            var pass = this.PasswordTextBox.Text;
            var login = this.LoginTextBox.Text;
            var _2fa = this._2faTextBox.Text;
            var opt = new ClientOptions();
            // getCaptcha();
            var cookie = this.doAuth(login, pass, _2fa, this.captchaTextBox.Text);
            if (cookie != "")
            {
                sessionCookieContainer = new CookieContainer();
                MessageBox.Show("Successfully log: " + cookie);
                File.Create(this.usfile).Close();
                foreach (string c in cookie.Split(";"))
                {
                    //var pair = c.Split("=");
                    //if (pair[0] == null || pair[1] == null) continue;
                    sessionCookieContainer.SetCookies(new Uri(opt.GetUri()), c);
                }
                ClientOptions.WriteCookiesToDisk(this.usfile, sessionCookieContainer);
                this.Hide();
            } // if
        } // auth but

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            getCaptcha();
        }
    }
}
