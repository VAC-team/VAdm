using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

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

        public static bool Login(string name, string passwors)
        {
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
            return null;
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

        public static string[] listOfTaks()
        {
            return null;
        }
    }
}
