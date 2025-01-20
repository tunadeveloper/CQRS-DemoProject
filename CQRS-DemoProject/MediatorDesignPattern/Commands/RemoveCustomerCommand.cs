using MediatR;

namespace CQRS_DemoProject.MediatorDesignPattern.Commands
{
    public class RemoveCustomerCommand : IRequest
    {
        public int CustomerID { get; set; }

        public RemoveCustomerCommand(int customerID)
        {
            CustomerID = customerID;
        }
    }
}
