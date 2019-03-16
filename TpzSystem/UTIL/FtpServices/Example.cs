using System;
using System.IO;
using System.Net;
using System.Text;

namespace UTIL.ftpServices {

    public class WebRequestGetExample {
        public static void Main() {
            
            FtpWebRequest request = (FtpWebRequest) WebRequest.Create("ftp://www.contoso.com/test.htm"); // Get the object used to communicate with the server
            
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential("anonymous", "janeDoe@contoso.com"); // This example assumes the FTP site uses anonymous logon.

            byte[] fileContents; // Get the object used to communicate with the server

            using (StreamReader sourceStream = new StreamReader("testfile.txt")) {
                fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
            }

            request.ContentLength = fileContents.Length;

            using (Stream requestStream = request.GetRequestStream()) {
                requestStream.Write(fileContents, 0, fileContents.Length);
            }

            using (FtpWebResponse response = (FtpWebResponse) request.GetResponse()) {
                Console.WriteLine($"Upload File Complete, status {response.StatusDescription}");
            }
        }
    }

}