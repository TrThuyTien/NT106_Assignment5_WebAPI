using Newtonsoft.Json;
using System.Net;

namespace API_Spotify
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Search_Click(object sender, EventArgs e)
        {
            getSpotifyInfo();
        }

        private async void getSpotifyInfo()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://spotify23.p.rapidapi.com/search/?q={textBox_Url.Text}&&type=multi&&offset=0&&limit=10&&numberOfTopResults=5"),
                Headers =
                {
                    { "x-rapidapi-key", "7167976ee9msheadacbe1c43a50ep176be5jsnbc3fc62ebed8" },
                    { "x-rapidapi-host", "spotify23.p.rapidapi.com" },
                },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                // Deserialize the JSON response into SpotifyInfo object
                var spotifyInfo = JsonConvert.DeserializeObject<SpotifyInfo>(body);

                // Check if data is available
                if (spotifyInfo?.Albums?.Items?.Count > 0)
                {
                    var firstAlbum = spotifyInfo.Albums.Items[0].Data;
                    textBox_TenAlbum.Text = firstAlbum.Name;
                    textBox_TenCaSi.Text = string.Join(" ", firstAlbum.Artists.Items.Select(artist => artist.Profile.Name));
                    textBox_NamPhatHanh.Text = firstAlbum.Date.Year.ToString();

                    var coverArtUrl = firstAlbum.CoverArt.Sources[0].Url;

                    // Download and display the image in the PictureBox
                    pictureBox_CoverArt.Image = await DownloadImageAsync(coverArtUrl);
                }
                else
                {
                    MessageBox.Show("Không thể tìm thấy bài hát.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private async Task<Image> DownloadImageAsync(string imageUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(imageUrl);
                response.EnsureSuccessStatusCode();
                using (var stream = await response.Content.ReadAsStreamAsync())
                {
                    return Image.FromStream(stream);
                }
            }
        }

    }
}
