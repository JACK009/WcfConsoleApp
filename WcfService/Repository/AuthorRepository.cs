using System.Collections.Generic;
using System.Linq;
using WcfService.Context;
using WcfService.Mapper;
using WcfService.Models;

namespace WcfService.Repository
{
    public class AuthorRepository
    {
        private readonly AuthorContext _authorContext;
        private readonly AuthorMapper _authorMapper;

        public AuthorRepository()
        {
            _authorContext = new AuthorContext();
            _authorMapper = new AuthorMapper();
        }

        public IEnumerable<Author> GetAuthors(int pageIndex, int pageSize)
        {
            return _authorContext
                .GetAuthors()
                .Select(_authorMapper.MapAuthor)
                .OrderBy(a => a.LastName)
                .ThenBy(a => a.FirstName)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize);
        }

        public Author GetAuthorByEmail(string email)
        {
            return _authorContext
                .GetAuthors()
                .Where(a => a["email"].ToString() == email)
                .Select(_authorMapper.MapAuthor)
                .SingleOrDefault();
        }
    }
}