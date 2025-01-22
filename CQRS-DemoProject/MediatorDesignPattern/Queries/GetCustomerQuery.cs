using CQRS_DemoProject.MediatorDesignPattern.Results;
using MediatR;

namespace CQRS_DemoProject.MediatorDesignPattern.Queries
{
    public class GetCustomerQuery : IRequest<List<GetCustomerQueryResult>>
    {

    }
}
