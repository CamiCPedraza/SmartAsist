using InsuranceWeb.Transversal;
using System;

namespace InsuranceWeb.Models
{
    public class Marriage : Entity
    {
        public DocumentType DocumentType { get; set; }
        public string Document { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public bool HasDocuments { get; set; }
    }
}
