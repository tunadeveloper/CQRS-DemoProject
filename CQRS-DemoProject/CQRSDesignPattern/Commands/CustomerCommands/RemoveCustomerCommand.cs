namespace CQRS_DemoProject.CQRSDesignPattern.Commands.CustomerCommands
{
    public class RemoveCustomerCommand
    {
        public int CustomerID { get; set; }

        public RemoveCustomerCommand(int customerID)
        {
            CustomerID = customerID;
        }
    }
}
