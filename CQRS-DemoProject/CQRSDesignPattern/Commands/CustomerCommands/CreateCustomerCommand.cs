namespace CQRS_DemoProject.CQRSDesignPattern.Commands.CustomerCommands
{
    public class CreateCustomerCommand
    {
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
    }
}
