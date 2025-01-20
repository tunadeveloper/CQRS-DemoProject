using MediatR;

namespace CQRS_DemoProject.MediatorDesignPattern.Commands
{
    public class CreateCustomerCommand : IRequest
    {
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
    }
}
