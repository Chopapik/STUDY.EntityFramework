using System.ComponentModel.DataAnnotations;

namespace entity_framework_v2
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            ClientRepository clientRepository = new ClientRepository();

            bool _while = true;

            while (_while)
            {
                Console.WriteLine("\n\n     -Wybierz opcję- \n" +
                "-----------------------------\n" +
                "1. Dodaj nowego klienta\n" +
                "2. Zaktualizuj dane klienta\n" +
                "3. Usuń klienta\n" +
                "4. Wyświetl dane klienta\n" +
                "5. Wyświetl zawartość tabeli Klienci\n" +
                "6. Wyjście z programu\n" +
                "-----------------------------\n");

                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                switch (choice)
                {
                    //Dodawanie nowego klienta.
                    case 1:
                        Console.WriteLine("Podaj imię: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Podaj nazwisko: ");
                        string surname = Console.ReadLine();
                        Console.WriteLine("Podaj adres: ");
                        string address = Console.ReadLine();
                        Console.WriteLine("Podaj numer telefonu: ");
                        string phoneNumber = Console.ReadLine();
                        Console.WriteLine("Podaj adres email: ");
                        string email = Console.ReadLine();

                        Client newClient = new Client
                        {
                            Name = name,
                            Surname = surname,
                            Address = address,
                            PhoneNumber = phoneNumber,
                            Email = email
                        };

                        clientRepository.Add(newClient);

                        Console.WriteLine("Tabela Klienci po modyfikacji:\n");

                        Console.WriteLine("____________________________________________________________________________________");
                        Console.WriteLine("|   ID   |   Imię   |   Nazwisko   |            Adres            |     Telefon     |");
                        Console.WriteLine("|________|__________|______________|_____________________________|_________________|");
                        foreach (var client in clientRepository.GetAllClients())
                        {
                            Console.WriteLine($"|{client.ClientId,-8}|{client.Name,-10}|{client.Surname,-14}|{client.Address,-29}|{client.PhoneNumber,-17}|");
                            Console.WriteLine("|________|__________|______________|_____________________________|_________________|");
                        }



                        break;

                    //Modyfikowanie danych klienta.
                    case 2:
                        Console.WriteLine("Podaj id Klienta do modyfikacji.");
                        int up_clientId = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Podaj nowe imię: ");
                        string newName = Console.ReadLine();
                        Console.WriteLine("Podaj nowe nazwisko: ");
                        string newSurname = Console.ReadLine();
                        Console.WriteLine("Podaj nowy adres: ");
                        string newAddress = Console.ReadLine();
                        Console.WriteLine("Podaj nowy numer telefonu: ");
                        string newPhoneNumber = Console.ReadLine();
                        Console.WriteLine("Podaj nowy adres email: ");
                        string newEmail = Console.ReadLine();


                        Client upClient = new Client
                        {
                            ClientId = up_clientId,
                            Name = newName,
                            Surname = newSurname,
                            Address = newAddress,
                            PhoneNumber = newPhoneNumber,
                            Email = newEmail
                        };

                        clientRepository.Update(upClient);

                        Console.WriteLine("Tabela Klienci po modyfikacji:\n");

                        Console.WriteLine("____________________________________________________________________________________");
                        Console.WriteLine("|   ID   |   Imię   |   Nazwisko   |            Adres            |     Telefon     |");
                        Console.WriteLine("|________|__________|______________|_____________________________|_________________|");
                        foreach (var client in clientRepository.GetAllClients())
                        {
                            Console.WriteLine($"|{client.ClientId,-8}|{client.Name,-10}|{client.Surname,-14}|{client.Address,-29}|{client.PhoneNumber,-17}|");
                            Console.WriteLine("|________|__________|______________|_____________________________|_________________|");
                        }


                        break;

                    //Usuwanie danych klienta.
                    case 3:
                        Console.WriteLine("Podaj id Klienta do usunięcia.");

                        int del_clientId = Convert.ToInt32(Console.ReadLine());

                        clientRepository.Delete(del_clientId);

                        Console.WriteLine("Tabela Klienci po modyfikacji:\n");

                        Console.WriteLine("____________________________________________________________________________________");
                        Console.WriteLine("|   ID   |   Imię   |   Nazwisko   |            Adres            |     Telefon     |");
                        Console.WriteLine("|________|__________|______________|_____________________________|_________________|");
                        foreach (var client in clientRepository.GetAllClients())
                        {
                            Console.WriteLine($"|{client.ClientId,-8}|{client.Name,-10}|{client.Surname,-14}|{client.Address,-29}|{client.PhoneNumber,-17}|");
                            Console.WriteLine("|________|__________|______________|_____________________________|_________________|");
                        }
                        break;

                    //Wyszukiwanie danych klienta,
                    case 4:
                        Console.WriteLine("Podaj ID klienta do znalezienia:");
                        int find_clientId = Convert.ToInt32(Console.ReadLine());

                        Client foundClient = clientRepository.GetById(find_clientId);

                        if (foundClient == null)
                        {
                            Console.WriteLine("Klient o podanym identyfikatorze nie został znaleziony.");
                        }
                        else
                        {
                            Console.WriteLine("\n\nZnaleziony klient:\n");
                            Console.WriteLine("____________________________________________________________________________________");
                            Console.WriteLine("|   ID   |   Imię   |   Nazwisko   |            Adres            |     Telefon     |");
                            Console.WriteLine("|________|__________|______________|_____________________________|_________________|");
                            Console.WriteLine($"|{foundClient.ClientId,-8}|{foundClient.Name,-10}|{foundClient.Surname,-14}|{foundClient.Address,-29}|{foundClient.PhoneNumber,-17}|");
                            Console.WriteLine("|________|__________|______________|_____________________________|_________________|");
                        }
                        break;

                        Console.WriteLine("\n\n");
                        break;

                    case 5:
                        Console.WriteLine("____________________________________________________________________________________");
                        Console.WriteLine("|   ID   |   Imię   |   Nazwisko   |            Adres            |     Telefon     |");
                        Console.WriteLine("|________|__________|______________|_____________________________|_________________|");
                        foreach (var client in clientRepository.GetAllClients())
                        {
                            Console.WriteLine($"|{client.ClientId,-8}|{client.Name,-10}|{client.Surname,-14}|{client.Address,-29}|{client.PhoneNumber,-17}|");
                            Console.WriteLine("|________|__________|______________|_____________________________|_________________|");
                        }
                        
                        Console.WriteLine("\n\n");
                        break;

                    case 6:

                        _while = false;
                        break;

                }
            }
        }
    }
}