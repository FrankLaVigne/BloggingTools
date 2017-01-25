using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloggingUtilities.Video
{
    public class Channel9Post : VideoPost
    {
        public Channel9Post(string videoPostUrl) : base(videoPostUrl)
        {

        }


        public override string ExportHtml()
        {
            return string.Empty;
        }
    }


}

