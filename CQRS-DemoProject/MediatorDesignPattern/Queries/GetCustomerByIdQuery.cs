using MediatR;

namespace CQRS_DemoProject.MediatorDesignPattern.Queries
{
    public class GetCustomerByIdQuery : IRequest<GetCustomerByIdQuery>
    {
        public int CustomerID { get; set; }

        public GetCustomerByIdQuery(int customerID )
        {
            CustomerID = customerID;
        }
    }
}
