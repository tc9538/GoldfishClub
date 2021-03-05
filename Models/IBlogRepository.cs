using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldfishClub.Models
{
    public interface IBlogRepository
    {
        Blog GetBlogById(int blogId);
    }
}
