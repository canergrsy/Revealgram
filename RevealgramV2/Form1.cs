using System.Collections;
using Newtonsoft.Json.Linq;


namespace RevealgramV2
{
    public partial class revealgram : Form
    {
        public revealgram()
        {
            InitializeComponent();
        }
        int controller = 0;

        public void followerPathButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.DefaultExt = ".json";
            dialog.Filter = "JSON Source File (*.json)|*.json";
            if (DialogResult.OK == dialog.ShowDialog())
            {
                string follower_Path = dialog.FileName;
                followerPathBox.Text = follower_Path;
            }
            if (!followerPathBox.Text.Contains("followers.json"))
            {
                MessageBox.Show("Wrong File!\nPlease make sure you have selected the followers.json file.");
                controller = 0;
                checkButton.Enabled = false;
            } else
            {
                controller = controller + 1;
            }
            if (controller == 2)
            {
                checkButton.Enabled = true;
            }
        }

        public void followingPathButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.DefaultExt = ".json";
            dialog.Filter = "JSON Source File (*.json)|*.json";
            if (DialogResult.OK == dialog.ShowDialog())
            {
                string following_Path = dialog.FileName;
                followingPathBox.Text = following_Path;
            }
            if (!followingPathBox.Text.Contains("following.json"))
            {
                MessageBox.Show("Wrong File!\nPlease make sure you have selected the following.json file.");
                controller = 0;
                checkButton.Enabled = false;
            }
            else
            {
                controller = controller + 1;
            }
            if (controller == 2)
            {
                checkButton.Enabled = true;
            }
        }

        public void savePathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (DialogResult.OK == dialog.ShowDialog())
            {
                string save_path = dialog.SelectedPath + "\\revealgram.txt";
                savePathBox.Text = save_path;
                saveButton.Enabled = true;
            }
        }

        ArrayList follwers_username = new ArrayList();
        ArrayList following_username = new ArrayList();
        ArrayList difference_list = new ArrayList();

        public void checkButton_Click(object sender, EventArgs e)
        {
            string read_followers = File.ReadAllText(followerPathBox.Text);
            string read_following = File.ReadAllText(followingPathBox.Text);

            JArray followersObject = JArray.Parse(read_followers);
            JObject followingObject = JObject.Parse(read_following);

            for (int i = 0; i < followersObject.Count; i++)
            {
                follwers_username.Add(followersObject[i]["string_list_data"][0]["value"]);
            }

            foreach (var pair in followingObject)
            {
                for (int i = 0; i < pair.Value.Count(); i++)
                {
                    following_username.Add(pair.Value[i]["string_list_data"][0]["value"]);
                }
            }

            follwers_username.Sort();
            following_username.Sort();

            int followers_num = follwers_username.Count;
            int following_num = following_username.Count;

            followerNumLabel.Text = followers_num.ToString();
            followingNumLabel.Text = following_num.ToString();

            foreach (var element in following_username)
            {
                if (!follwers_username.Contains(element))
                {
                    difference_list.Add(element);
                }
            }

            int difference_num = difference_list.Count;

            difference_list.Sort();

            diffNumLabel.Text = difference_num.ToString();

            checkButton.Enabled= false;

            profileButton.Enabled= true;

            followerPathButton.Enabled= false;

            followingPathButton.Enabled= false;

            reloadLabel.Enabled= true;

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(savePathBox.Text))
            {
                writer.WriteLine("Users who don't follow you:\n");

                for (int i = 0; i < difference_list.Count; i++)
                {
                    writer.WriteLine(difference_list[i]);
                }
            }
            MessageBox.Show("File Created!");
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            Form2 userProfiles = new Form2();
            userProfiles.userList= difference_list;
            userProfiles.Show();
        }

        private void reloadLabel_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}