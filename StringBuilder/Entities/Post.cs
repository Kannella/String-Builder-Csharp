using Course.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities {
    class Post {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post() {
        }

        public Post(DateTime moment, string title, string content, int likes) {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment) {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment) {
            Comments.Remove(comment);
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title); //line pq eu vou imprimir vai coisas embaixo dele
            sb.Append(Likes); //nao tem line pq eu vou imprimir mais coisas na frente dele
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss")); // converte a data para string fromatando ela da maneira que esta entre parenteses
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            foreach (Comment c in Comments) { // para cada comentrio c na lista Comments
                sb.AppendLine(c.Text); //imprime o comentario
            }
            return sb.ToString(); // converter o conteudo do stringbuilder para string
        }
    }
}