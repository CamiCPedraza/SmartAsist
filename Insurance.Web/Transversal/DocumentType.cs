using System.ComponentModel;

namespace Insurance.Web.Transversal
{
    public enum DocumentType
    {
        [Description("Cedula")]
        Cedula,
        [Description("Pasaporte")]
        Pasaporte,
        [Description("RUC")]
        Ruc,
    }
}
