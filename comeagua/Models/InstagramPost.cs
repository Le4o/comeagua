using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstagramNet.Service.Extensions;

namespace InstagramLogin.Models
{
    public class InstagramPost
    {
        public string type { get; set; } //video ya da image

        public string id { get; set; }

        public InstagramVideoList videos { get; set; }

        public InstagramPostCommentLike comments { get; set; }

        public string created_time { get; set; }

        public DateTime CreatedAt { get { return created_time.UnixTimeStampToDateTime(); } }

        public string link { get; set; }

        public InstagramPostCommentLike likes { get; set; }

        public instagramImageList images { get; set; }

        public InstagramCaption caption { get; set; }
    }
}