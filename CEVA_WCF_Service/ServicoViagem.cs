using CEVA_Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CEVA_WCF_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicoViagem" in both code and config file together.
    public class ServicoViagem : IServicoViagem
    {
        //public SincronizarCutOffResult ObterViagem(int numeroViagem)
        public ObterViagemResponse ObterViagem(string numeroViagem)
        {
            //To-do: Camada de recuperação de dados

            var resultado = new SincronizarCutOffResult
            {
                Acao = null,
                Erro = null,
                ExecutouOK = true,
                Viagem = new[]
           {
                new Viagem
                {
                    Code_5C = "5CFE5418",
                    Code_5P = "5PB2406C",
                    Codes = new[] {"5CFE5418", "5PB2406C", "5CFE5415", "5PB2406C"},
                    Fornecedor = "32474037000229",
                    Pedidos = new[]
                    {
                        "G20639900000134562", "G20639900000134563", "G20639900000134564", "G20639900000190",
                        "G20639900000195", "G20639900000198", "G20639900000199", "G20639900000200",
                        "G20639900000210", "G20639900000212", "G20639900000216", "G20639900000220",
                        "G20639999911118000", "G20639999911118100", "G20639999911118140", "G20639999911118150",
                        "G2063999991111902", "G2063999991111904", "G2063999991111909", "G2063999991111998"
                    }
                }
            }
            };

            ObterViagemResponse response = new ObterViagemResponse();
            response.SincronizarCutOffResult = resultado;
            return  response;
        }
    }
}
