using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNet8.MicroServiceDemo.Shared.Models.Blog;

namespace DotNet8.MicroServiceDemo.Shared.Models;

public static class ChangeModel
{
    public static BlogDataModel Change(this BlogCreateModel requestModel)
    {
        var model = new BlogDataModel()
        {
           BlogAuthor = requestModel.BlogAuthor,
           BlogContent = requestModel.BlogContent,
           BlogTitle = requestModel.BlogTitle
        };

        return model;
    }
}
