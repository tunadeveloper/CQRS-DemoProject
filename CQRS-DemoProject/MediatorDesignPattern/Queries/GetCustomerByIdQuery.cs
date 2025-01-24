using CQRS_DemoProject.MediatorDesignPattern.Results;
using MediatR;

namespace CQRS_DemoProject.MediatorDesignPattern.Queries
{
    public class GetCustomerByIdQuery : IRequest<GetCustomerByIdQueryResult>
    {
        public int CustomerID { get; set; }

        public GetCustomerByIdQuery(int customerID )
        {
            CustomerID = customerID;
        }
    }
}
