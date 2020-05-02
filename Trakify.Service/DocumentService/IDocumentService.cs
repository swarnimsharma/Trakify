using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Entities;

namespace Trakify.Service.DocumentService
{
    public interface IDocumentService
    {
        IEnumerable<Trakify_Documents> GetDocument();
        Trakify_Documents GetDocument(long id);
        void InsertDocument(Trakify_Documents job);
        void UpdateDocument(Trakify_Documents job);
        void DeleteDocument(long id);
    }
}
