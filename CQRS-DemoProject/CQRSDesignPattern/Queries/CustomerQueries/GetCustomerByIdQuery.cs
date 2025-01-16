namespace CQRS_DemoProject.CQRSDesignPattern.Queries.CustomerQueries
{
    public class GetCustomerByIdQuery
    {
        public int CustomerID { get; set; }

        public GetCustomerByIdQuery(int customerID)
        {
            CustomerID = customerID;
        }
    }
}
