﻿using System;

namespace Insurance.Web.Transversal
{
    public interface IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DocumentType DocumentType { get; set; }
        public string Document { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public bool HasDocuments { get; set; }
    }
}
