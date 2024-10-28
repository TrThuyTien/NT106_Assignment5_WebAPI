using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;

namespace API_Spotify
{
    internal class SpotifyInfo
    {
        public Albums Albums { get; set; }
    } 

    public class Albums
    {
        public int TotalCount { get; set; }
        public List<Item> Items { get; set; }
    }

    public class Item
    {
        public AlbumData Data { get; set; }
    }

    public class AlbumData
    {
        public string Uri { get; set; }
        public string Name { get; set; }
        public Artist Artists { get; set; }
        public CoverArt CoverArt { get; set; }
        public Date Date { get; set; }
    }

    public class Artist
    {
        public List<ArtistItem> Items { get; set; }
    }

    public class ArtistItem
    {
        public string Uri { get; set; }
        public Profile Profile { get; set; }
    }

    public class Profile
    {
        public string Name { get; set; }
    }

    public class CoverArt
    {
        public List<Source> Sources { get; set; }
    }

    public class Source
    {
        public string Url { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class Date
    {
        public int Year { get; set; }
    }

}
