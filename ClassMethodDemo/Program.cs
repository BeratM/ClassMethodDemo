using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Client client1 = new Client();
            client1.Id = 1;
            client1.Name = "Berat";
            client1.Lastname = "Macit";
            client1.CreditScore = 1111;
            client1.TcNo = "09876543210";


            Client client2 = new Client();
            client2.Id = 2;
            client2.Name = "Semih";
            client2.Lastname = "Zambak";
            client2.CreditScore = 1350;
            client2.TcNo = "12345678901";

            Client client3 = new Client();
            client3.Id = 3;
            client3.Name = "Suna";
            client3.Lastname = "Kara";
            client3.CreditScore = 900;
            client3.TcNo = "13246578902";
            

            ClientManager clientManagerAdd = new ClientManager();
            clientManagerAdd.Add(client1);
            clientManagerAdd.Add(client2);
            clientManagerAdd.Add(client3);
            Console.WriteLine("EKLEME İŞLEMİ TAMAMLANDI!!");
            Console.WriteLine("-------------------------");

            ClientManager clientManagerDel = new ClientManager();
            clientManagerDel.Delete(client1);
            clientManagerDel.Delete(client2);
            clientManagerDel.Delete(client3);
            Console.WriteLine("SİLME İŞLEMİ TAMAMLADI!!");
            Console.WriteLine("------------------------");

            ClientManager clientManagerUpd = new ClientManager();
            clientManagerUpd.Update(client1);
            clientManagerUpd.Update(client2);
            clientManagerUpd.Update(client3);
            Console.WriteLine("GÜNCELLEME İŞLEMİ TAMAMLANDI!!");
            Console.WriteLine("-------------------------------");

            Client[] clients = new Client[] {client1, client2, client3 };
            Console.WriteLine("XXX KREDİ PLANINDAKİ MÜŞTERİLER");
            foreach (var client in clients)
            {
                Console.WriteLine("=> " + client.Id +"| "+ client.TcNo +"| "+ client.Name +"| "+ client.Lastname);
                Console.WriteLine("-----------------------------------------------------------------");
            }
            


            Console.ReadLine();
           
        }
    }
}
