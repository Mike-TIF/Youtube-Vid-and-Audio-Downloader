using HtmlAgilityPack;
using MediaToolkit.Model;
using MediaToolkit;
using System.Net;
using System.Security.Policy;
using VideoLibrary;

namespace SongDownloader
{
    public partial class BaseForm : Form
    {
        const string LatestHtmlFile = "./LatestHtml.txt";

        public BaseForm()
        {
            InitializeComponent();
            OutputTxt.SelectionChanged += (s, e) =>
            {
                CurrentlySelectedFileLbl.Text = OutputTxt.SelectedText;
            };
        }

        private void CheckUrlBtn_Click(object sender, EventArgs e)
        {
            OutputTxt.Text = "";

            foreach (var mp3 in TextManipulation.GetFiles(UrlInputTxt.Text, ExtensionInputTxt.Text, LatestHtmlFile))
                OutputTxt.AppendText(mp3 + "\n");
        }

        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            if (!CurrentlySelectedFileLbl.Text.Contains("/")) return;

            FolderBrowserDialog fbd = new();

            if (fbd.ShowDialog() != DialogResult.OK) return;

            string[] urlData = CurrentlySelectedFileLbl.Text.Split("/");
            FileDownloader.DownloadFile(CurrentlySelectedFileLbl.Text, fbd.SelectedPath, urlData[urlData.Length - 1]);
        }

        private void DownloadAllBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(OutputTxt.Text)) return;

            FolderBrowserDialog fbd = new();
            if (fbd.ShowDialog() != DialogResult.OK) return;

            foreach(string url in OutputTxt.Text.Split("\n"))
            {
                string[] urlData = url.Split("/");
                FileDownloader.DownloadFile(url, fbd.SelectedPath, urlData[urlData.Length - 1]);
            }
        }
    }

    class HtmlDownloader
    {
        public static void DownloadHtml(string remoteFilename, string localFilename)
        {
            //Downloading the Html
            var htmlDoc = new HtmlWeb().Load(remoteFilename);
            File.WriteAllText(localFilename, htmlDoc.ParsedText);
        }
    }
    class FileDownloader
    {
        public static void DownloadFile(string remoteFilename, string localFolder, string localFilename)
        {
            //Removing all illegal characters from filename
            localFilename = localFilename.Replace("?", "");
            localFilename = localFilename.Replace("*", "");
            localFilename = localFilename.Replace("=", "");
            localFilename = localFilename.Replace("/", "");
            localFilename = localFilename.Replace(@"\", "");
            localFilename = localFilename.Replace(@":", "");
            localFilename = localFilename.Replace("\"", "");
            localFilename = localFilename.Replace("'", "");
            localFilename = localFilename.Replace("<", "");
            localFilename = localFilename.Replace(">", "");
            localFilename = localFilename.Replace("|", "");

            string fullFilePath = localFolder + "/" + localFilename;

            //Platform Specific Handlers
            if (remoteFilename.Contains("youtube.com"))
            {
                YoutubeDownloader.SaveYoutubeToMp3(remoteFilename, localFolder);
                return;
            }

            try
            {
                WebClient client = new WebClient();
                client.DownloadFile(remoteFilename, fullFilePath.Replace("\n", ""));
            }
            catch (Exception e){ }
        }
    }
    class YoutubeDownloader
    {
        public static void SaveYoutubeToMp3(string VideoURL, string SaveToFolder)
        {
            var source = @SaveToFolder + "\\";
            var youtube = YouTube.Default;
            var vid = youtube.GetVideo(VideoURL);
            File.WriteAllBytes(source + vid.FullName, vid.GetBytes());

            var inputFile = new MediaFile { Filename = source + vid.FullName };
            var outputFileMp3 = new MediaFile { Filename = $"{source + vid.FullName.Replace(".mp4", ".mp3")}" };
            var outputFileFlac = new MediaFile { Filename = $"{source + vid.FullName.Replace(".mp4", ".flac")}" };

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);

                //Convert to .mp3
                engine.Convert(inputFile, outputFileMp3);

                //Convert to .flac
                engine.Convert(inputFile, outputFileFlac);
            }
        }
    }
    class TextManipulation
    {
        public static IEnumerable<string> GetFiles(string url, string extension, string outputFilepath)
        {
            //Platform Specific Handlers
            if(url.Contains("youtube.com")
                || url.Contains("spotify.com"))
            {
                yield return url;
                yield break;
            }

            HtmlDownloader.DownloadHtml(url, outputFilepath);

            string fileContent = File.ReadAllText(outputFilepath);
            string[] files = fileContent.Split(extension);

            for (int i = 0; i < files.Length - 1; i++)
            {
                string file = files[i];
                string[] https = file.Split("https");
                yield return "https" + https[https.Length - 1] + extension;
            }
        }
    }
}