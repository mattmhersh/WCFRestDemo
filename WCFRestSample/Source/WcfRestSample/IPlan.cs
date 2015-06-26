using System.Runtime.Serialization;

namespace WcfRestSample
{
    /// <summary>
    ///  Plan Contract
    /// </summary>
    [DataContract]
    public class IPlan
    {
        /// <summary>
        /// Id
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        public string Name { get; set; }
    }
}