using System.Runtime.Serialization;

namespace WcfService.Models
{
    [DataContract]
    public class Author
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Gender { get; set; }

        [DataMember]
        public string Ip { get; set; }
    }
}