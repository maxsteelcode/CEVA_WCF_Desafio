using CEVA_Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CEVA_WCF_Service
{    
    [ServiceContract]
    public interface IServicoViagem
    {        
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ObterViagem/{numeroViagem}")]
        //SincronizarCutOffResult ObterViagem(int numeroViagem);
        ObterViagemResponse ObterViagem(string numeroViagem);
    }
}
