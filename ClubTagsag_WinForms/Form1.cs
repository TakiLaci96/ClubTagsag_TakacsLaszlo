using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubTagsag_WinForms
{
    public partial class Form1 : Form
        // Sajnos nem megy rendesen a rögzítés és a módosítás. Index értéket ad át, azaz 0,1,2... 
        //emiatt összeomlik a retool api... 
    {
        string url = "https://retoolapi.dev/OEDUXm/member";
        HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            textBox_Id.Clear();
            textBox_Fullname.Clear();
            textBox_Entry.Clear();
            textBox_Raiting.Clear();
            comboBox_Interest.DataSource = Enum.GetValues(typeof(Interest));
            comboBox_Interest.Text = "";
            listBox_Members.Items.Clear();

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var members = Member.FromJson(jsonResponse);
                    foreach (Member member in members) 
                    { 
                        listBox_Members.Items.Add(member);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void listBox_Members_SelectedIndexChanged(object sender, EventArgs e)
        {

            Member member = (Member)listBox_Members.SelectedItem;
            textBox_Id.Text = member.Id.ToString();
            textBox_Fullname.Text = member.Fullname;
            textBox_Entry.Text = member.Entry;
            textBox_Raiting.Text = member.Rating.ToString();
            comboBox_Interest.Text = member.Interest.ToString();

        }

        private void button_uj_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            if (string.IsNullOrEmpty(textBox_Fullname.Text))
            {
                MessageBox.Show("Név megadása kötelező");
                textBox_Fullname.Focus();
                return;
            }
            member.Fullname = textBox_Fullname.Text;
            member.Entry = textBox_Entry.Text;
            member.Rating = long.Parse(textBox_Raiting.Text);
            // chat gpt megoldása: 
            member.Interest = (Interest)Enum.Parse(typeof(Interest), comboBox_Interest.SelectedIndex.ToString());


            var json = JsonConvert.SerializeObject(member);
            var data  = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PostAsync(url, data).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Sikeres rörzítés");
                Form1_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Sikertelen felvitel");
            }
            textBox_Id.Clear();
            textBox_Fullname.Clear();
            textBox_Entry.Clear();
            textBox_Raiting.Clear();
            comboBox_Interest.DataSource = Enum.GetValues(typeof(Interest));
            comboBox_Interest.Text = "";
        }

        private void button_torol_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Valóban törli?")==DialogResult.OK)
            {
                Member member = (Member)listBox_Members.SelectedItem;
                var response = client.DeleteAsync(url + "/" +  member.Id).Result;
                if (response.IsSuccessStatusCode)
                {
                    Form1_Load(sender, e);
                }
            }
        }

        private void button_frissit_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private async void button_modosit_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox_Id.Text))
            {
                MessageBox.Show("Nem választott ki klubtagot!");
                return;
            }

            try
            {
                Member member = new Member();

                member.Id = long.Parse(textBox_Id.Text);
                member.Fullname = textBox_Fullname.Text;
                member.Entry = textBox_Entry.Text;
                member.Rating = long.Parse(textBox_Raiting.Text);
                // chat gpt megoldása: 
                member.Interest = (Interest)Enum.Parse(typeof(Interest), comboBox_Interest.SelectedIndex.ToString());

                var json = JsonConvert.SerializeObject(member);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(url + "/" + member.Id, data);
                if (response.IsSuccessStatusCode)
                {
                    Form1_Load(sender, e);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
