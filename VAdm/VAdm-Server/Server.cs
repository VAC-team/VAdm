using System;
using System.Net;
using System.IO;

namespace VAdm_Server
{
    class Server
    {
        static void Main(string[] args)
        {
            string[] prefix = new string[2];//здесь хранятся префиксы(вообще по хорошему их бы сюда через мейн пихать в
                                            //качестве аргумента пусть клиент озаботится, дабы я постоянно их вручную не вводил)
            prefix[0] = "http://127.0.0.1/login/";
            prefix[1] = "http://127.0.0.1/Projects/";
            prefix[1] = "http://127.0.0.1/task";

            HttpListener listener = new HttpListener();
            foreach (string s in prefix)
            { 
            listener.Prefixes.Add(s);//тут был саня  
            }
            listener.Start();
            
            while (true)
            {

                HttpListenerContext context = listener.GetContext();
                Console.WriteLine("See request!");
                HttpListenerRequest request = context.Request;
                HttpListenerResponse response = context.Response;
                string ReqResponse = RequestData(request);//сюда записывать ответ клиенту
                 //я еще не знаю как различать префиксы так что это просто болванка

                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(ReqResponse);//иуффер для вывода ответа клиенту
                response.ContentLength64 = buffer.Length;
                System.IO.Stream output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length);
                output.Close();// закрываем потоки
                listener.Stop();
                

            }

        }

        public static string RequestData(HttpListenerRequest request)//обработка тела запроса
        {
            if (!request.HasEntityBody){return "No client datea was sent with request";}
            return "nothing";
        }

         
    }
}

