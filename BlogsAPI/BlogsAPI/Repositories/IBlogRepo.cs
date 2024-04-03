using BlogsAPI.Models;

namespace BlogsAPI.Repositories
{
    public interface IBlogRepo
    {
        List<Blog> GetAll();
        Blog Get(int id);
        int Delete(int id);
    }
}

