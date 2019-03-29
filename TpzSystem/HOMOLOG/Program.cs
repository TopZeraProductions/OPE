using System;

using UTIL.ftpServices;

namespace HOMOLOG {

    class Program {
        static void Main(string[] args) {
            WebRequestGetExample.SendFtpArchive("/home/notim/GitHub/Notim/learning_bash/docker/container_testes");
            WebRequestGetExample.SendFtpArchive("/home/notim/GitHub/Notim/learning_bash/docker/Teste_de_upload");
        }
    }

}