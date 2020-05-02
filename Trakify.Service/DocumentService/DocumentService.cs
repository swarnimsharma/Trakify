using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Entities;
using Trakify.Repository.Common;

namespace Trakify.Service.DocumentService
{
    public class DocumentService : IDocumentService
    {
        private readonly IRepository<Trakify_Documents> Document;
        public DocumentService(IRepository<Trakify_Documents> Document)
        {
            this.Document = Document;
        }
        public void DeleteDocument(long id)
        {
            Trakify_Documents userProfile = Document.Get(id);
            Document.Remove(userProfile);
            Document.SaveChanges();
        }

        public IEnumerable<Trakify_Documents> GetDocument()
        {
            return Document.GetAll();
        }

        public Trakify_Documents GetDocument(long id)
        {
            return Document.Get(id);
        }

        public void InsertDocument(Trakify_Documents job)
        {
            Document.Insert(job);
        }

        public void UpdateDocument(Trakify_Documents job)
        {
            Document.Update(job);
        }
    }
}
