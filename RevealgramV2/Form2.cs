using System.Collections;
using System.Diagnostics;

namespace RevealgramV2
{
    public partial class Form2 : Form
    {
        public ArrayList userList = new ArrayList();

        public Form2()
        {
            InitializeComponent();
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < userList.Count; i++)
            {
                LinkLabel username = new LinkLabel();
                username.AutoSize = true;
                username.BackColor = Color.Transparent;
                username.LinkColor = Color.White;
                username.ActiveLinkColor = Color.Black;
                username.Font = new Font("Microsoft JhengHei UI", 10, style: FontStyle.Bold);
                username.Text = String.Format("https://www.instagram.com/{0}", userList[i]);
                username.Left = 10;
                username.Top = (i + 1) * 20;
                username.Click += new System.EventHandler(username_Click);
                this.Controls.Add(username);
            }
        }

        private void username_Click(object sender, EventArgs e)
        {
            LinkLabel username = sender as LinkLabel;
            Process.Start(new ProcessStartInfo() { FileName = username.Text, UseShellExecute = true });
        }

    }
}
