using System.ComponentModel;

namespace InsuranceWeb.Transversal
{
    public enum PolicyType
    {
        [Description("Basico")]
        Basico,
        [Description("Oro")]
        Oro,
        [Description("Plata")]
        Plata,
    }
}
