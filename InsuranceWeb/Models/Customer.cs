using InsuranceWeb.Transversal;
using System;

namespace InsuranceWeb.Models
{
    public class Customer : Entity
    {
        public string Title { get; set; }
        public DocumentType DocumentType { get; set; }
        public string Document { get; set; }
        public Genere Genere { get; set; }
        public MarriageState MarriageState { get; set; }
        public Marriage Marriage { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Nationality { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public bool HasMarriage { get; set; }
        public string BussinessAddress { get; set; }
        public string BussinessPhone { get; set; }
        public string BussinessEmail { get; set; }
        public bool HasDocuments { get; set; }
        public string Activity { get; set; }
        public string Contact { get; set; }
        public bool LegalRepresentant { get; set; }
        public string Name { get; set; }
    }
}
