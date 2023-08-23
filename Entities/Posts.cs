using System.Collections.Generic;
using System.Text;

namespace Principal.Entities {
    class Posts {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public int Likes { get; set; }
        public string Content { get; set; }
        public List<Comments> CommentsList { get; private set; } = new List<Comments>();

        public Posts() {

        }
        public Posts(DateTime moment, string title, int likes, string content) {
            Moment = moment;
            Title = title;
            Likes = likes;
            Content = content;
        }

        public void AddComment(Comments comment) {
            CommentsList.Add(comment);
        }
        public void RemoveComment(Comments comment) {
            CommentsList.Remove(comment);
        }

        public override string ToString() {
            StringBuilder Post = new StringBuilder();
            Post.AppendLine(Title);
            Post.Append(Likes);
            Post.Append(" - ");
            Post.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            Post.AppendLine(Content);
            Post.AppendLine("Comments:");
            foreach(Comments comment in CommentsList) {
                Post.AppendLine(comment.Text);
            }
            return Post.ToString();
        }
    }
}