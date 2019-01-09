using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Domain;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApp2
{
    public class DataAccess
    {
        public string conString = "Server=(localdb)\\mssqllocaldb; Database=Blogg";

        public List<BlogPost> GetAllBlogPostsBrief()
        {
            var sql = @"SELECT [BlogPostID], [Author], [Title], [Created], [Description] FROM BlogPosts";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                var list = new List<BlogPost>();

                while (reader.Read())
                {
                    var bp = new BlogPost
                    {
                        BlogPostId = reader.GetSqlInt32(0).Value,
                        Author = reader.GetSqlString(1).Value,
                        Title = reader.GetSqlString(2).Value,
                        Created = reader.GetSqlDateTime(3).Value,
                        Description = reader.GetSqlString(4).Value,
                    };
                    list.Add(bp);

                }
                return list;
            }
        }

        public void UpdateBlogpost(BlogPost blogPost)
        {
            var sql = "UPDATE BlogPosts SET title=@Title WHERE BlogPostId=@Id";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("Id", blogPost.BlogPostId));
                command.Parameters.Add(new SqlParameter("Title", blogPost.Title));
                command.ExecuteNonQuery();
            }

        }

        public BlogPost GetPostById(int blogPostId)
        {
            var sql = @"SELECT [BlogPostID], [Author], [Title] FROM BlogPosts WHERE BlogPostId=@id";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("Id", blogPostId));

                SqlDataReader reader = command.ExecuteReader();

                var list = new List<BlogPost>();

                if(reader.Read())
                {
                    var bp = new BlogPost
                    {
                        BlogPostId = reader.GetSqlInt32(0).Value,
                        Author = reader.GetSqlString(1).Value,
                        Title = reader.GetSqlString(2).Value,
                    };
                    list.Add(bp);

                return bp; 
                }
                return null;
            }
        }

        internal void AddCommentToDatabase(string comment)
        {
            var sql = @"INSERT into Comments (Comment) VALUES (@Comment)";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Comment", comment);
                command.ExecuteNonQuery();
            }
        }

        internal void AddCommentatorNameToDatabase(int blogPostId, string commentatorName, string comment)
        {
            var sql = @"INSERT into Comments (BlogPostId, Author, Comment) VALUES (@BlogPostId, @Author, @Comment)";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue(@"BlogPostId", blogPostId);
                command.Parameters.AddWithValue("@Author", commentatorName);
                command.Parameters.AddWithValue("@Comment", comment);
                command.ExecuteNonQuery();
            }
        }

        public BlogPost GetTagsByBlogPostId(int blogPostId)
        {
            var sql = @"SELECT [TaggId] FROM BlogTagg WHERE BlogPostId=@id";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter(@"id", blogPostId));

                SqlDataReader reader = command.ExecuteReader();

                var list = new List<BlogPost>();
                if (reader.Read())
                {
                    var tags = new BlogPost
                    {
                        BlogPostId = reader.GetSqlInt32(0).Value
                    };
                    list.Add(tags);
                    return tags;
                }
                return null;
            }
            }

        public void DeleteTagFromBlogPost(BlogPost blogPostTags)
        {
            var sql = @"Delete FROM BloggTagg WHERE BlogPostId=@id";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", blogPostTags.BlogPostId);
                command.ExecuteNonQuery();
            }
        }

        public int GetTagIdByName(string tagname)
        {
            // select ....
            var sql = @"select * from Tagg where Name=@TagName ";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@TagName", tagname);
                int tagId = new int();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    tagId = reader.GetSqlInt32(0).Value;
                    
                }
                return tagId;
            }
        }

        public void AddTagToPost(int blogpostId, int tagId)
        {
            // insert ...
            var sql = @"INSERT into BloggTagg (BlogPostId, TaggId) VALUES (@blogPostId, @tagId)";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@blogpostId", blogpostId);
                command.Parameters.AddWithValue("@tagId", tagId);
                command.ExecuteNonQuery();
            }
        }

        public bool CheckIfTagExist(string tagname)
        {
            var sql = @"select * from Tagg where Name=@TagName";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@TagName", tagname);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return true;
                } else
                {
                    return false;
                }

            }
        }

        public  void AddTagToDatabase(string tagname)
        {
            var sql = @"INSERT into Tagg (Name) VALUES (@Name)";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Name", tagname);
                command.ExecuteNonQuery();
            }
        }

        public void AddTaggToPost(BlogPost blogPost)
        { 
            var sql = @"ALTER TABLE BlogPosts WHERE BlogPostId=@id ADD Tagg=int";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", blogPost.BlogPostId);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteBlogPost(BlogPost blogPost)
        {
            var sql = @"Delete FROM BlogPosts WHERE BlogPostId=@id";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", blogPost.BlogPostId);
                command.ExecuteNonQuery();
            }
        }

        //internal BlogPost DeletePostById(BlogPost blogPost)
        //{
            //var sql = @"Delete FROM Blogg WHERE BlogPostId=@id";

            //using (SqlConnection connection = new SqlConnection(conString))
            //using (SqlCommand command = new SqlCommand(sql, connection))
            //{
            //    connection.Open();
            //    command.Parameters.AddWithValue("@id", blogPost.BlogPostId);
            //    command.ExecuteNonQuery();
                

            //    return null;
            //}
        //}
    }
}

