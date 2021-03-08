using InsuranceWeb.Transversal;
using System.ComponentModel.DataAnnotations;

namespace InsuranceWeb.Models
{
    public class Agent : Entity
    {
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [Display(Name = "Ocupación")]
        public string Ocupation { get; set; }
        [Display(Name = "Tipo de acceso")]
        public AccessType AccessType { get; set; }
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }
        [Display(Name = "Dirección")]
        public string Address { get; set; }
        [Display(Name = "Tipo de documento")]
        public DocumentType DocumentType { get; set; }
        [Display(Name = "Documento")]
        public string Document { get; set; }
        [Display(Name = "Estado civil")]
        public MarriageState MarriageState { get; set; }
        [Display(Name = "Teléfono")]
        public string Phone { get; set; }
        [Display(Name = "Celular")]
        public string Mobile { get; set; }
        [Display(Name = "Salario")]
        public string Salary { get; set; }
        [Display(Name = "Comisión")]
        public string Commission { get; set; }
        [Display(Name = "Tiene documentos")]
        public bool HasDocuments { get; set; }
    }
}
