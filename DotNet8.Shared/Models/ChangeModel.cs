using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNet8.Shared.Models.Blog;

namespace DotNet8.Shared.Models
{
    public static class ChangeModel
    {
        public static BlogDataModel Change(this BlogCreateModel requestModel)
        {
            var model = new BlogDataModel()
            {
               Blog_Author = requestModel.BlogAuthor,
               Blog_Content = requestModel.BlogContent,
               Blog_Title = requestModel.BlogTitle
            };

            return model;
        }
    }
}
