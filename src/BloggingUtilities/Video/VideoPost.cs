using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BloggingUtilities.Video
{
    public abstract class VideoPost
    {
        public string Url { get; private set; }
        public string Description { get; private set; }

        public string RawHtml;


        public VideoPost(string videoPostUrl)
        {
            this.Url = videoPostUrl;
        }

        public async void Parse()
        {
            LoadHtml();

        }


       
        protected async void LoadHtml()
        {

            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(this.Url);

            this.RawHtml = await response.Content.ReadAsStringAsync();

        }




        public abstract string ExportHtml();


    }
}
