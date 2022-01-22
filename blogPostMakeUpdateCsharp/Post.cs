using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace blogPostMakeUpdateCsharp
{
    class Post
    {
		private DateTime dateTime;
		private string title;
		private string body;
		private string fileName;
		/// <summary>
		/// ///////////////
		/// </summary>
		public void setDateTime() { dateTime = DateTime.Now; }
		public void setTitle(string t) { title = t; }
		public void setBody(string b) { body = b; }
		public void setFileName() { fileName = "C:/Users/hlucy/Documents/blogPostMakeUpdateCsharp/blogPostMakeUpdateCsharp/json1.json"; }
		public string getTitle() { return title; }
		public DateTime getDateTime() { return dateTime; }
		public string getbody() { return body; }
		public string getFileName() { return fileName; }
		public void editExistingPost(string fileName, string title)
        {

        }
		
	}
}
