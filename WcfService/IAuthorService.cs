using System.Collections.Generic;
using System.ServiceModel;
using WcfService.Models;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAuthorService" in both code and config file together.
    [ServiceContract]
    public interface IAuthorService
    {
        [OperationContract]
        IEnumerable<Author> GetAuthors(int pageIndex, int pageSize);

        [OperationContract]
        Author GetAuthorByEmail(string email);
    }
}
