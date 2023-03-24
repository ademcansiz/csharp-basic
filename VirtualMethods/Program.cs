using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Update();
            Console.ReadKey();
        }

        class Database 
        {
            public virtual void Add() 
            {
                Console.WriteLine("Added By Default");
            }        
            public virtual void Update() 
            {
                Console.WriteLine("Updated By Default"); 
            }
        }

        class SqlServer : Database 
        {
            public override void Add()
            {
                /*base.Update();*/
                Console.WriteLine("Added By Sql Code");
            }
            public override void Update()
                {
                    base.Update();
                    /*Default olanı uygular*/
                }
        }
        class MySql : Database
        {
            public override void Add()
            {
         
                base.Add();
                /*Default olanı uygular*/
            }
            public override void Update()
            {
                /*base.Update();*/
                Console.WriteLine("Update By MySql Code");
            }
        }   
    }
}
