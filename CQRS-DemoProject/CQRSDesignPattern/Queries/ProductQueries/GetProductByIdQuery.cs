namespace CQRS_DemoProject.CQRSDesignPattern.Queries.ProductQueries
{
    public class GetProductByIdQuery
    {
        public int ProductID { get; set; }

        public GetProductByIdQuery(int productID)
        {
            ProductID = productID;
        }
    }
}
