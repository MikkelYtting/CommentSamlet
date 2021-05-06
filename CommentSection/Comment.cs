using System;

namespace CommentSection
{
    public class Comment
    {
        private int _id;
        private string _commenttext;
        
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
            }
        }
        public string Commenttext
        {
            get => _commenttext;
            set
            {
                _commenttext = value;
            }
        }


        public Comment(int Id, string Commenttext)
        { 
            this.Id = Id;
            _commenttext = Commenttext;
           
        }
        public Comment()
        {

        }
    }
}
