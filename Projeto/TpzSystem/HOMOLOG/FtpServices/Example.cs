using System;
using System.IO;
using System.Net;
using System.Text;

namespace UTIL.ftpServices {

    public class WebRequestGetExample {
        private static NetworkCredential NetworkCredential => 
            new NetworkCredential("paulino.joaovitor@yahoo.com.br", "topzera1234");

        private static string server => "ftp://localhost";
        private static string folders(string folder)  => folder;
        private static string uri(string directory = "/", string fileName = "") => server + "@" + folders(directory) + fileName;

        public static void SendFtpArchive(string archieveAddress) {
            try {
                Console.WriteLine(server);
                
                FileInfo      FileInfo = new FileInfo(archieveAddress);
                
                Console.WriteLine(FileInfo.Length);
                Console.WriteLine(FileInfo.Name);
                Console.WriteLine(FileInfo.Directory);
                Console.WriteLine(FileInfo.DirectoryName);

                var ur = new Uri(uri("/foldertest com espaco/", FileInfo.Name));
          
                Console.WriteLine();
                
                FtpWebRequest requestUpload  = (FtpWebRequest) WebRequest.Create(new Uri(uri("/foldertest com espaco/", FileInfo.Name)));

                requestUpload.Method        = WebRequestMethods.Ftp.AppendFile;
                requestUpload.Credentials   = NetworkCredential;
                requestUpload.UseBinary     = true;
                requestUpload.ContentLength = FileInfo.Length;
                
                using (FileStream fs = FileInfo.OpenRead()) {
                    byte[] buffer    = new byte[2048];
                    int    bytesSent = 0;
                    int    bytes     = 0;

                    using (Stream stream = requestUpload.GetRequestStream()) {
                        while (bytesSent < FileInfo.Length) {
                            bytes = fs.Read(buffer, 0, buffer.Length);
                            stream.Write(buffer, 0, bytes);
                            bytesSent += bytes;
                        }
                    }
                }
            } catch (Exception ex) {
                throw ex;
            }
        }

        public static void Test() {
            StreamReader sourceStream = new StreamReader("testfile.txt");
            var          fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
            sourceStream.Close();

            FtpWebRequest FtpWebRequest = (FtpWebRequest) WebRequest.Create("ftp://localhost");
            FtpWebRequest.Method        = WebRequestMethods.Ftp.UploadFile;
            FtpWebRequest.Credentials   = new NetworkCredential("paulino.joaovitor@yahoo.com.br", "topzera1234");
            FtpWebRequest.ContentLength = fileContents.Length;

            Stream requestStream = FtpWebRequest.GetRequestStream();
            requestStream.Write(fileContents, 0, fileContents.Length);
            requestStream.Close();

            FtpWebResponse response = (FtpWebResponse) FtpWebRequest.GetResponse();
            Console.WriteLine($"Upload File Complete, status {response.StatusDescription}");
            response.Close();
        }

    }

}