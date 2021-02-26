using System.ComponentModel;

namespace Insurance.Web.Transversal
{
    public enum CustomerType
    {
        [Description("Individual")]
        Individual,
        [Description("Corporativo")]
        Corporativo,
    }
}
