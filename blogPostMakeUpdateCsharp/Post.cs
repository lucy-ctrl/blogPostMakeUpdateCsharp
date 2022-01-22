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
		[JsonInclude]
		public DateTime dateTime { get; set; }
		[JsonInclude]
		public string title { get; set; }
		
		[JsonInclude]
		public string body { get; set; }
		
		public string fileName { get; set; }

		public void editExistingPost(string fileName, string title)
        {

        }
		
	}
}
