using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseEntityFrameworkDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //AdoNetSample();
            EntityFrameworkSample();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private static void EntityFrameworkSample()
        {
            using (var ctx = new AppContext())
            {
                var newPost = new BlogPost
                {
                    Title = "Entity Framework",
                    Body = "This is going to be sooo much easier than ADO.NET!"
                };

                ctx.BlogPosts.Add(newPost);
                ctx.SaveChanges();
                Console.WriteLine(string.Format("Blog post #{0} created successfully.", newPost.Id));
            }
        }

        private static void AdoNetSample()
        {
            using (var conn = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=BlogDemo;Integrated Security=True"))
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    var newPost = new BlogPost
                    {
                        Title = "Another Post!",
                        Body = "I'm on a roll now!"
                    };

                    // Always parameterize your inputs http://bobby-tables.com
                    cmd.Parameters.Add("@title", System.Data.SqlDbType.VarChar).Value = newPost.Title;
                    cmd.Parameters.Add("@body", System.Data.SqlDbType.NVarChar).Value = newPost.Body;

                    // Don't use @@IDENTITY!!!
                    cmd.CommandText = "INSERT INTO BlogPosts (Title, Body) VALUES (@title, @body); SELECT SCOPE_IDENTITY();";

                    try
                    {
                        conn.Open();
                        newPost.Id = (int)(decimal)(cmd.ExecuteScalar());
                        Console.WriteLine(string.Format("Blog Post #{0} created successfully.", newPost.Id));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }


    }

    public class BlogPost
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }

        public string Body { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated { get; set; }

        public ICollection<BlogPostComment> Comments { get; set; }
    }

    public class BlogPostComment
    {
        [Key]
        public int Id { get; set; }

        public int BlogPostId { get; set; }

        [MaxLength(4000)]
        public string Comment { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated { get; set; }

        public BlogPost BlogPost { get; set; }
    }

    public class AppContext : DbContext
    {
        public AppContext()
            : base(@"Data Source=(localdb)\v11.0;Initial Catalog=BlogDemo;Integrated Security=True")
        {

        }

        public DbSet<BlogPost> BlogPosts { get; set; }

        public DbSet<BlogPostComment> BlogPostComments { get; set; }
    }
}
