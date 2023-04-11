using Marker_Design_Pattern.Marker;

namespace Marker_Design_Pattern.Models;

public class Customer : IContainSensitiveContent
{
    public Customer(string name, string family, string nationalCode)
    {
        Name = name;
        Family = family;
        NationalCode = nationalCode;
    }

    public string Name { get; set; }
    public string Family { get; set; }
    public string NationalCode { get; set; }
}