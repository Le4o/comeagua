using System.Collections.Generic;

namespace InstagramLogin.Models
{
    public class InstagramPostListModel
    {
        public InstagramPagination pagination { get; set; }

        public List<InstagramPost> data { get; set; }
    }
}