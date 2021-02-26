using System.ComponentModel;

namespace Insurance.Web.Transversal
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
