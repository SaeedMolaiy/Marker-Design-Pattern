using Marker_Design_Pattern.Implementations;
using Marker_Design_Pattern.Marker;
using Marker_Design_Pattern.Models;

var secureCustomerRepository = new SecureCustomerRepository();
var regularCustomerRepository = new RegularCustomerRepository();

var customer = new Customer("Saeed", "Molaiy", "123123");

if (customer is IContainSensitiveContent)
{
    secureCustomerRepository.SaveCustomer(customer);
}
else
{
    regularCustomerRepository.SaveCustomer(customer);
}

Console.ReadKey();