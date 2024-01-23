using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CEVA_Entitites
{
    [DataContract]
    public class Viagem
    {
        [DataMember]
        public string Code_5C { get; set; }

        [DataMember]
        public string Code_5P { get; set; }

        [DataMember]
        public string[] Codes { get; set; }

        [DataMember]
        public string Fornecedor { get; set; }

        [DataMember]
        public string[] Pedidos { get; set; }
    }
}
