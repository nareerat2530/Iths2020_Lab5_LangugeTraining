using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_WebScraper
{
    public partial class Form1 : Form
    {
        private List<string> _imageUrls = new();

        public Form1()
        {
            InitializeComponent();
            UrlPattern = new Regex("<img.*src=\"(.*?\\.(jpg|jpeg|png|gif|bmp).*?)\"");
            ImagePattern = new Regex("\\.(jpg|jpeg|png|gif|bmp)");
            ListBoxResult.Text = "";
        }

        private Dictionary<Task<byte[]>, string> TaskDictionary { get; } = new();
        private Regex UrlPattern { get; }

        public Regex ImagePattern { get; set; }

        private async void ExtractButton_Click(object sender, EventArgs e)
        {
            UrlFoundLabl.Show();
            _imageUrls.Clear();
            ListBoxResult.DataSource = null;
            var url = textBox.Text;          
            await FindMatchRex(url);
        }

        private async Task FindMatchRex(string url)
        {
            ListBoxResult.Items.Clear();
            if (string.IsNullOrEmpty(textBox.Text)) return;

            url = textBox.Text;
            if (!url.Contains("https://")) url = $"https://{url}";


            using var client = new HttpClient();
            var downloadHtml = await client.GetStringAsync(url);
            var matches = UrlPattern.Matches(downloadHtml);


            _imageUrls = matches.OfType<Match>().SelectMany(m => m.Groups[1].Value.Split(' ')).Distinct().Select(s => s.Contains("http") ? s : url + s).ToList();

            ListBoxResult.DataSource = _imageUrls;
        }

        private async void btn_SaveAll_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.OK) return;

            await DownloadAndSaveImages(dialog.SelectedPath, _imageUrls.ToArray());
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.OK) return;

            var userSelected = ListBoxResult.SelectedItems;
            var urlArray = new string[ListBoxResult.SelectedItems.Count];
            userSelected.CopyTo(urlArray, 0);
            await DownloadAndSaveImages(dialog.SelectedPath, urlArray);
        }

        private async Task DownloadAndSaveImages(string path, string[] images)
        {
            UrlFoundLabl.Hide();
            using var client = new HttpClient();


            foreach (var image in images)
            {
                var matches = ImagePattern.Matches(image);
                TaskDictionary.Add(client.GetByteArrayAsync(image), matches[0].Value);
            }


            var tasks = TaskDictionary.Keys;

            var i = 1;

            while (TaskDictionary.Count > 0)
            {
                var completeTask = await Task.WhenAny(tasks);
                var fileExtension = TaskDictionary[completeTask];
                var result = completeTask.Result;

                await using var fs = new FileStream($"{path}\\Image{i}{fileExtension}", FileMode.OpenOrCreate);

                fs.Seek(0, SeekOrigin.End);

                await fs.WriteAsync(result, 0, result.Length);
                i++;
                TaskDictionary.Remove(completeTask);
                DownloadedImageLabel.Text = $"{i} images have been downloaded";
            }
        }

        private void ListBoxResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrlFoundLabl.Text = $"{ListBoxResult.Items.Count.ToString()} Images found";
        }


    }
}