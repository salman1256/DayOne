using BlogsAPI.Models;

namespace BlogsAPI.Repositories
{
    public class BlogRepo : List<Blog>, IBlogRepo
    {
        private readonly static List<Blog> _blogs = Populate();

        private static List<Blog> Populate()
        {
            var result = new List<Blog>()
            { 
                new Blog()
                {
                    Id = 1,
                    Title = "Containerization using Docker",
                    LastUpdated = DateTime.Now
                },
                 new Blog()
                {
                    Id = 2,
                    Title = "Api Gateway using Ocelot",
                    LastUpdated = DateTime.Now
                },
                  new Blog()
                {
                    Id = 3,
                    Title = "Kubernetes in Microservices",
                    LastUpdated =new DateTime(day:25,month:10,year:2023)
                },
            };
            return result;
        }

        public int Delete(int id)
        {
            var delBlog=_blogs.SingleOrDefault(b => b.Id == id);
            if (delBlog != null)
            {
                _blogs.Remove(delBlog);
            }
            return delBlog?.Id ?? 0;
        }

        public Blog Get(int id)
        {
            return _blogs.FirstOrDefault(b => b.Id == id);
        }

        public List<Blog> GetAll()
        {
            return _blogs;
        }
    }
}
