namespace CQRS_DemoProject.CQRSDesignPattern.Commands.ProductCommands
{
    public class CreateProductCommand
    {
        public string ProductName { get; set; }
        public int ProductStock { get; set; }

        public int CategoryID { get; set; }
    }
}
