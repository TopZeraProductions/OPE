using System;
using System.IO;
using System.Net;
using System.Net.Http;

using System.Threading.Tasks;

namespace HOMOLOG.HttpServices {

    public class WebRequestGetHttpExample {

        private static NetworkCredential NetworkCredential => new NetworkCredential("paulino.joaovitor@yahoo.com.br", "topzera1234");

        private static string uri => "http://localhost:5080/alunos";

        public static void RequestGet() {

            HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(uri);

            httpWebRequest.Method      = WebRequestMethods.Http.Get;
            httpWebRequest.Credentials = NetworkCredential;

            HttpWebResponse response = (HttpWebResponse) httpWebRequest.GetResponse();
            StreamReader    reader   = new StreamReader(response.GetResponseStream());

            string responseFromServer = reader.ReadToEnd();
            Console.WriteLine(responseFromServer);
            response.Close();
        }

        public static async Task RequestGetHttpClient() {
            using (
                HttpClientHandler handler = new HttpClientHandler() {
                    Credentials = NetworkCredential
                }
            )
            using (HttpClient request = new HttpClient(handler)) {
                try {
                    request.DefaultRequestHeaders.Add(HttpRequestHeader.Accept.ToString(), "*/*");
                    request.DefaultRequestHeaders.Add(HttpRequestHeader.ContentType.ToString(), ContentTypeConst.json);
                    request.DefaultRequestHeaders.Add(HttpRequestHeader.Connection.ToString(), "keep-alive");
                    request.DefaultRequestHeaders.Add(HttpRequestHeader.Cookie.ToString(),"cookie1=value1; cookie2=value2");
                    request.DefaultRequestHeaders.Add(HttpRequestHeader.Authorization.ToString(), "Basic 123456");
                    
                    Console.WriteLine(request.DefaultRequestHeaders.ToString());

                    //HttpContent content = new HttpContent();

                    HttpResponseMessage response = await request.PostAsync(uri, new StringContent("asd"));

                    response.EnsureSuccessStatusCode();

                    Console.WriteLine("Response :" + response.ToString());
                    var responseBody = await response.Content.ReadAsStringAsync();

                    Console.WriteLine(responseBody);

                } catch (HttpRequestException e) {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                }
            }
        }

        /*
        public static void get() {
            var request = new HttpRequestMessage {
                RequestUri = new Uri(EnvironmentSetup.BaseAddress + "Folder"),
                Method     = HttpMethod.Post,
                Headers = {
                    {HttpRequestHeader.Authorization.ToString(), "Basic " + EnvironmentSetup.GetAuthToken()},
                    {HttpRequestHeader.ContentType.ToString(), "multipart/mixed"},
                },
                Content = new MultipartContent {
                    new ObjectContent<FolderWithDocuments>(
                        new FolderWithDocuments {
                            Status = FolderStatus.Draft,
                            Users  = new List<User> {EnvironmentSetup.User1, EnvironmentSetup.User2},
                        }, 
                        new JsonMediaTypeFormatter(), "application/json"
                    ),
                    new ByteArrayContent(ResourceHelper.ReadResourceToByteArray("blank.pdf")) {
                        Headers = {
                            {"Content-Type", "application/Executable"},
                            {"Content-Disposition", "form-data; filename=\"test.pdf\""},
                        },
                    },
                },
            };
        }*/
    }

}