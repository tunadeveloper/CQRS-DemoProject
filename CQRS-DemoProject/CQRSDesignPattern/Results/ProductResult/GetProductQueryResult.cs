namespace CQRS_DemoProject.CQRSDesignPattern.Results.ProductResult
{
    public class GetProductQueryResult
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }

        public int CategoryID { get; set; }
    }
}
