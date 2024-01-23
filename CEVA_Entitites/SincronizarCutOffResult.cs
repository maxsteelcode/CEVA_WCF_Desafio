using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CEVA_Entitites
{
    [DataContract]
    public class SincronizarCutOffResult
    {
        [DataMember]
        public string Acao { get; set; }

        [DataMember]
        public string Erro { get; set; }

        [DataMember]
        public bool ExecutouOK { get; set; }

        [DataMember]
        public Viagem[] Viagem { get; set; }
    }
}
