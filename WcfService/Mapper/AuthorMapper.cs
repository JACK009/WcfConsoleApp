using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;
using WcfService.Models;

namespace WcfService.Mapper
{
    public class AuthorMapper
    {
        public Author MapAuthor(JToken a)
        {
            return new Author()
            {
                Id = Int32.Parse(a["id"].ToString()),
                FirstName = a["first_name"].ToString(),
                LastName = a["last_name"].ToString(),
                Email = a["email"].ToString(),
                Gender = a["gender"].ToString(),
                Ip = a["ip_address"].ToString()
            };
        }
    }
}