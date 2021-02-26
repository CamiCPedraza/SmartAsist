using System.ComponentModel;

namespace InsuranceWeb.Transversal
{
    public enum MarriageState
    {
        [Description("Soltero(a)")]
        Soltero,
        [Description("Casado(a)")]
        Casado,
        [Description("Separado(a)")]
        Separado,
        [Description("Viudo(a)")]
        Viudo,
    }
}
