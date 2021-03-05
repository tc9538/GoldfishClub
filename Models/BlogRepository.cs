using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldfishClub.Models
{
    public class BlogRepository :IBlogRepository
    {
        private readonly AppDbContext _appDbContext;
        public BlogRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Blog GetBlogById(int blogId)
        {
            Blog b = _appDbContext.Blogs.FirstOrDefault(predicate => predicate.BlogId == blogId);
            return b;
        }

    }
}
