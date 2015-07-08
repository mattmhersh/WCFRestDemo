using System.Runtime.Serialization;

namespace Rk.Manager
{
    [DataContract]
    public class IPlan
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}