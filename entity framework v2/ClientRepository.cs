using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_framework_v2
{
    public interface IClientRepository
    {
        void Add(Client client);
        void Update(Client client);  
        void Delete(int id);
        Client GetById(int id);
    }

    internal class ClientRepository : IClientRepository
    {
        public void Add(Client client)
        {
            using (var context = new HotelContext())
            {
                context.Clients.Add(client);
                context.SaveChanges();
            }
        }

        public void Update(Client client)
        {
            using (var context = new HotelContext())
            {

                context.Clients.Update(client);
                context.SaveChanges();


            }
        }

        public void Delete(int id)
        {
            using (var context = new HotelContext())
            {
                var clientToDelete = context.Clients.Find(id);

                if (clientToDelete == null)
                {
                    Console.WriteLine("Nie znaleziono klienta o takim identyfikatorze");

                }
                else
                {
                    context.Clients.Remove(clientToDelete);
                    context.SaveChanges();
                }



            }
        }

        public Client GetById(int id)
        {
            using (var context = new HotelContext())
            {
                return context.Clients.Find(id);
            }
        }

        public List<Client> GetAllClients()
        {
            using (var context = new HotelContext())
            {
                return context.Clients.ToList();
            }
        }

    }
}
