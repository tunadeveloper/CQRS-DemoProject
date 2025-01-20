using MediatR;

namespace CQRS_DemoProject.MediatorDesignPattern.Commands
{
    public class UpdateCustomerCommand : IRequest
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
    }
}
