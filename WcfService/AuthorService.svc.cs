using System.Collections.Generic;
using WcfService.Models;
using WcfService.Repository;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AuthorService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AuthorService.svc or AuthorService.svc.cs at the Solution Explorer and start debugging.
    public class AuthorService : IAuthorService
    {
        private readonly AuthorRepository _repository = new AuthorRepository();

        public IEnumerable<Author> GetAuthors(int pageIndex, int pageSize)
        {
            return _repository.GetAuthors(pageIndex, pageSize);
        }

        public Author GetAuthorByEmail(string email)
        {
            return _repository.GetAuthorByEmail(email);
        }
    }
}
