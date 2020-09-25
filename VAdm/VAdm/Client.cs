using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Net;
using System.IO;
using System.Net.Sockets;

namespace VAdm
{

    public struct Tree
    {
        string name, worker;
        List<Tree> solders;
    }
    static class Client
    {
        static string name, password;
        static bool isGeneral, isLeader, isComander, isWorker;

        public static bool Login(string name, string password)
        {
            WebRequest qwerty = WebRequest.Create("http\\:127.0.0.1\\" + name + " " + password);
            qwerty.GetResponse();

            return false;
        }

        public static void My_profile(out string Name, out Image avatar, out int blackPoint, out int WhitePoint, out int Complete, out int Project, out int UTC, out bool Status)
        {
            Name = "";
            avatar = null;
            blackPoint = 0;
            WhitePoint = 0;
            Complete = 0;
            Project = 0;
            UTC = -3;
            Status = true;
        }

        public static string[] listOfProjects()
        {
            string streamString = "";
            WebRequest req = WebRequest.Create("http://127.0.0.1" + "Projects");
            WebResponse res = null;
            try
            {
                res = req.GetResponse();
            }
            catch (WebException exc)
            {
                throw new Exception(exc.Message);
            }
            Stream st = res.GetResponseStream();
            while (true)
            {
                int i = st.ReadByte();
                if (i == -1) break;
                streamString += (char)i;
            }
            string[] output = streamString.Split(" ");
            return output;
        }

        public static void Project(out string Name, out string FunDoc, out string TechDoc, out DateTime date, out int progress, out Tree workers)
        {
            Name = "";
            FunDoc = "";
            TechDoc = "";
            date = new DateTime();
            progress = 0;
            workers = new Tree();
        }

        public static string[] listOfTasks()
        {
            string streamString = "";
            WebRequest req = WebRequest.Create("http://127.0.0.1" + "Tasks");
            WebResponse res = null;
            try
            {
                res = req.GetResponse();
            }
            catch (WebException exc)
            {
                throw new Exception(exc.Message);
            }
            Stream st = res.GetResponseStream();
            while (true)
            {
                int i = st.ReadByte();
                if (i == -1) break;
                streamString += (char)i;
            }
            string[] output = streamString.Split(" ");
            return output;
        }
    }
}
