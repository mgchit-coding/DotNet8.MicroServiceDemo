namespace DotNet8.Client.Features.Blog.Get
{
    public class BL_BlogList
    {
        private readonly DL_BlogList _dL_BlogList;

        public BL_BlogList(DL_BlogList dL_BlogList)
        {
            _dL_BlogList = dL_BlogList;
        }

        public async Task<List<BlogDataModel>> BlogList()
        {
            return await _dL_BlogList.BlogList();
        }
    }
}
