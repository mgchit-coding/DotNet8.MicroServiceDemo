namespace DotNet8.Client.Features.Blog.GetById
{
    public class BL_BlogById
    {
        private readonly DL_BlogById _dL_BlogById;

        public BL_BlogById(DL_BlogById dL_BlogById)
        {
            _dL_BlogById = dL_BlogById;
        }

        public async Task<BlogDataModel> BlogById(int id)
        {
            return await _dL_BlogById.BlogById(id);
        }
    }
}
