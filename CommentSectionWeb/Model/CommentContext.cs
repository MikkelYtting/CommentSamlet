using CommentSection;
using Microsoft.EntityFrameworkCore;
using CommentSectionWeb;



namespace CommentSectionWeb.Model
{
    public class CommentContext
    {
        public CommentContext(DbContextOptions<CommentContext> options) 
            : base(options)

        { }


        public DbSet<Comment> Comments { get; set; }

        // another DbSet<Owner> Owners { get; set; }
    }
}
