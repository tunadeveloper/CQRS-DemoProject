namespace CQRS_DemoProject.CQRSDesignPattern.Queries.CategoryQueries
{
    public class GetCategoryByIdQuery
    {
        public int CategoryID { get; set; }

        public GetCategoryByIdQuery(int categoryID)
        {
            CategoryID = categoryID;
        }
    }
}
