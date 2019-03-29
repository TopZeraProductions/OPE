using System;
using System.IO;
using System.Net;
using System.Text;

namespace UTIL.ftpServices {


    public class WebRequestGetExample {
        public static NetworkCredential NetworkCredential => 
            new NetworkCredential("paulino.joaovitor@yahoo.com.br", "topzera1234");
        
        public static string server => "ftp://localhost";
            
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

        public static void SendFtpArchieve(string archieveAddress) {
            try {
                
                FileInfo FileInfo = new FileInfo(archieveAddress);
                
                FtpWebRequest request = (FtpWebRequest) WebRequest.Create(new Uri(server));
                
                request.Method        = WebRequestMethods.Ftp.UploadFile;
                request.Credentials   = NetworkCredential;
                request.UseBinary     = true;
                request.ContentLength = FileInfo.Length;

                using (FileStream fs = FileInfo.OpenRead()) {
                    byte[] buffer    = new byte[2048];
                    int    bytesSent = 0;
                    int    bytes     = 0;

                    using (Stream stream = request.GetRequestStream()) {
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
    }
}