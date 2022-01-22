using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace blogPostMakeUpdateCsharp
{
    public class Post
    {
		public DateTime dateTime { get; set; }
		public string title { get; set; }
		public string body { get; set; }
		public string fileName { get; set; }

		public void editExistingPost(string fileName, string title)
        {

        }
		
	}
}
