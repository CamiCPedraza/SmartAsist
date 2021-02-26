using System.ComponentModel;

namespace InsuranceWeb.Transversal
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
