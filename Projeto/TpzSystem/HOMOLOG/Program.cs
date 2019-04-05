using System;
using System.Threading.Tasks;

using HOMOLOG.FtpServices;
using HOMOLOG.HttpServices;

namespace HOMOLOG {

    class Program {
        static async Task Main(string[] args) {
            // WebRequestGetExample.SendFtpArchive("/home/notim/GitHub/Notim/learning_bash/docker/container_testes");
            // WebRequestGetExample.SendFtpArchive("/home/notim/GitHub/Notim/learning_bash/docker/Teste_de_upload");
            // WebRequestGetHttpExample.RequestGet();

            await WebRequestGetHttpExample.RequestGetHttpClient();
        }
    }

}