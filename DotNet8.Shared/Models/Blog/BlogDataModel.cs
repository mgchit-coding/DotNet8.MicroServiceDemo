using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNet8.Shared.Models.Blog;

[Table("Tbl_Blog")]
public class BlogDataModel
{
    [Key]
    public int BlogId { get; set; }
    public string? BlogAuthor { get; set; }
    public string? BlogTitle { get; set; }
    public string? BlogContent { get; set; }
}