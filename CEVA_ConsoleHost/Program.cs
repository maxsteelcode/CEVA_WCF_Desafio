using CEVA_WCF_Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace CEVA_ConsoleHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // As configurações do serviço estão na App.config
            using (ServiceHost host = new ServiceHost(typeof(ServicoViagem)))
            {
                // Iniciando o serviço
                host.Open();

                Console.WriteLine("Serviço está ativo. Pressione Enter para encerrar.");
                Console.ReadLine();

                // Parando o serviço
                host.Close();
            }

        }

    }

}
