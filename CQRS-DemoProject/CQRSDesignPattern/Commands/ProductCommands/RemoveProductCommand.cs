namespace CQRS_DemoProject.CQRSDesignPattern.Commands.ProductCommands
{
    public class RemoveProductCommand
    {
        public int ProductID { get; set; }

        public RemoveProductCommand(int productID)
        {
            ProductID = productID;
        }
    }
}
