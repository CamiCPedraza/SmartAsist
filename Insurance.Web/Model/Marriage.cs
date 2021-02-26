using Insurance.Web.Transversal;
using System;

namespace Insurance.Web.Model
{
    public class Marriage : IEntity
    {
        public DocumentType DocumentType { get; set; }
        public string Document { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public bool HasDocuments { get; set; }
    }
}
