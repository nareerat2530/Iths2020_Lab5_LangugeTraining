using System;
using System.Collections.Generic;

using System.IO;

using System.Net;
using System.Net.Http;

using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_WebScraper
{
    public partial class Form1 : Form
    {
        private List<string> _imageUrls = new ();
        
        public Form1()
        {
            InitializeComponent(); 
            UrlPattern = new Regex("<img.*src=\"(.*?\\.(jpg|jpeg|png|gif|bmp).*?)\"");
        }
        private Regex UrlPattern { get; set; }

        public string ImagePattern { get; set; }

        private void  ExtractButton_Click(object sender, EventArgs e)
        {
           
           var matches = FindMatchRex("www.gp.se");
        }

        private async Task FindMatchRex(string url)
        {
            ImagesTextBox.Clear();
            if (string.IsNullOrEmpty(textBox.Text))
            {
               return;
        
            }

            url = textBox.Text;
            if (!url.Contains("https://"))
            {
                url = $"https://{url}";
            }
            
                
            using var client = new HttpClient();
            var downloadHtml = await client.GetStringAsync(url);
            var matches = UrlPattern.Matches(downloadHtml);

            foreach (Match match in matches)
            {
                var matchValue = match.Groups[1].Value;
                ImagesTextBox.Text += $"{url}{match.Groups[1].Value}{Environment.NewLine}";
            }

        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
                
            }
        }

       
    }
}