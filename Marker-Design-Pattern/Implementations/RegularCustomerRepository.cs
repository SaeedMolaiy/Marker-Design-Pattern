using Marker_Design_Pattern.Interfaces;
using Marker_Design_Pattern.Models;

namespace Marker_Design_Pattern.Implementations;

public class RegularCustomerRepository : ICustomerRepository
{
    /// <inheritdoc />
    public void SaveCustomer(Customer customer)
    {
        Console.WriteLine("Regular customer repository SaveCustomer() called.");
    }
}
