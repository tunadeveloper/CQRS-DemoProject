namespace CQRS_DemoProject.CQRSDesignPattern.Commands.CustomerCommands
{
    public class UpdateCustomerCommand
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
    }
}
