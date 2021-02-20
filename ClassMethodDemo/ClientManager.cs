using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class ClientManager
    {
        

        public void Add(Client client)
        {
            Console.WriteLine(client.Name +" " + client.Lastname + " xxx kredi planına eklendi.");
            
        }
        public void Delete(Client client) 
        {
            Console.WriteLine(client.Name + " " + client.Lastname + " xxx kredi planından çıkarıldı." );
              
        }
        public void Update (Client client) 
        {
            Console.WriteLine(client.Name + " " + client.Lastname + " xxx kredi planı güncellendi.");
              
        }


    }
}
