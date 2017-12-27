using Conductor.Pier.Api;
using Conductor.Pier.Client;
using Conductor.Pier.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTeste
{
    class Program
    {
        static void Main(string[] args)
        {

            ApiClient apiClient = new ApiClient(HOST_NAME);

            String[] accerts = { "application/json" };

            apiClient.SelectHeaderAccept(accerts);

            ContaApi contaApi = new ContaApi(HOST_NAME);
            contaApi.Configuration.AddDefaultHeader("access_token", ACCESS_TOKEN_CREFISA);
            contaApi.Configuration.AddDefaultHeader("client_id", CLIENT_ID_CREFISA);
            contaApi.Configuration.AddDefaultHeader("Host", HOST_PARAM);
            
            var datePatter = "yyyy-MM-dd";
            var timerPatter = "T00:00:00";

            var dataAjuste = DateTime.Today.ToString(datePatter) + timerPatter;

            ContaDetalheResponse contaDetalheResponse = contaApi.ConsultarUsingGET11(7);                                   

            Console.WriteLine(contaDetalheResponse);


            Console.ReadKey();

        }
    }
}
