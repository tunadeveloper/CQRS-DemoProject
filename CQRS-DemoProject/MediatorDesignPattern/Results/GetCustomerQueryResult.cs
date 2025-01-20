namespace CQRS_DemoProject.MediatorDesignPattern.Results
{
    public class GetCustomerQueryResult
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
    }
}
