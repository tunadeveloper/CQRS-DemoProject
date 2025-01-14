namespace CQRS_DemoProject.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }

        public int CategoryID { get; set; }
    }
}
