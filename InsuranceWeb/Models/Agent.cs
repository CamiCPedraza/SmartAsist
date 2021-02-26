using InsuranceWeb.Transversal;
using System;
using System.ComponentModel.DataAnnotations;

namespace InsuranceWeb.Models
{
    public class Agent : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Ocupation { get; set; }
        public AccessType AccessType { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DocumentType DocumentType { get; set; }
        public string Document { get; set; }
        public MarriageState MarriageState { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Salary { get; set; }
        public string Commission { get; set; }
        [Display(Name = "Tiene documentos")]
        public bool HasDocuments { get; set; }
    }
}
