using Marker_Design_Pattern.Models;

namespace Marker_Design_Pattern.Interfaces;

public interface ICustomerRepository
{
    void SaveCustomer(Customer customer);
}