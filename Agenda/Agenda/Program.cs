using System.Net;
using System.Text.RegularExpressions;

namespace Agenda
{
    internal class Program
    {
        StreamWriter agendaEscriure = new StreamWriter("agenda.txt");
        StreamReader agendaLlegir = new StreamReader("agenda.txt");
        static void Menu()
        {
            bool sortir = false;

            do
            {
                Console.Clear();
                Console.WriteLine("1. Donar d’alta usuari");
                Console.WriteLine("2. Recuperar usuari");
                Console.WriteLine("3. Modificar usuari");
                Console.WriteLine("4. Eliminar usuari");
                Console.WriteLine("5. Mostrar agenda ");
                Console.WriteLine("6. Ordenar agenda");
                Console.WriteLine("Q. Sortir menú");

                char opcio = Convert.ToChar(Console.ReadLine());

                switch (opcio)
                {
                    case '1':
                        DonarAltaUsuari();
                        break;
                    case '2':
                        RecuperarUsuari();
                        break;
                    case '3':
                        ModificarUsuari();
                        break;
                    case '4':
                        EliminarUsuari();
                        break;
                    case '5':
                        MostrarAgenda();
                        break;
                    case '6':
                        OrdenarAgenda();
                        break;
                    case 'q':
                    case 'Q':
                        sortir = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("ERROR. Has de posar els numeros que demana o la lletra Q per sortir");
                        break;
                }

                if (!sortir)
                {

                }

            } while (!sortir);
        }
        static void DonarAltaUsuari()
        {
            string totJunt;

            Console.WriteLine("Fica el nom:");
            string nom = Console.ReadLine();
            ValidarNomCognom(nom);

            Console.WriteLine("Fica el cognom:");
            string cognom = Console.ReadLine();
            ValidarNomCognom(cognom);

            Console.WriteLine("Fica el DNI:");
            string dni = Console.ReadLine();
            ValidarDni(dni);

            Console.WriteLine("Fica el telèfon:");
            string telefon = Console.ReadLine();


            Console.WriteLine("Fica la data de naixement:");
            DateTime dataNaixement;

            Console.WriteLine("Fica el correu electrònic:");
            string correu = Console.ReadLine();



        }
        static string ValidarNomCognom(string nomCognon)
        {
            nomCognon = nomCognon.Substring(0, 1).ToUpper() + nomCognon.Substring(1).ToLower();
            return nomCognon;
        }

        static void ValidarDni(string dni)
        {
            Regex dniPatro = new Regex("^[1 - 9][0 - 9]{ 7 }[A - Z]$");
            if (dniPatro.IsMatch(dni))
            {
                Console.WriteLine("Dni correcte");
            }
            else
            {
                Console.WriteLine("ERROR. El Dni és incorrecte");
                Menu();
            }

        }

        static void ValidarTelefon(string telefon)
        {
            Regex telefonPatro = new Regex("^[6,7][0-9]{8}$");
            if (telefonPatro.IsMatch(telefon))
            {
                Console.WriteLine("Telefon correcte");
            }
            else
            {
                Console.WriteLine("ERROR. El Telefon és incorrecte");
                Menu();
            }

        }

        static DateTime ValidarDateTime(string data)
        {
            DateTime dataTime;
            Regex dataPatro = new Regex("^[0-9]{2}/[0-9]{2}/[0-9]{4}$");
            if (dataPatro.IsMatch(data))
            {
                Console.WriteLine("Data correcte");
                dataTime=Convert.ToDateTime(data);
            }
            else
            {
                Console.WriteLine("ERROR. El Data és incorrecte");
                Menu();
            }
            return dataTime;
        }

        static void RecuperarUsuari()
        {
            bool trobat = false;
            string nom;
            StreamReader agendaLlegir = new StreamReader("agenda.txt");
            Console.WriteLine("Fica el nom del usuari que vols trobar:");
            string nomTrobar = Console.ReadLine();
            if (nomTrobar.EndsWith("*"))
            {
                do
                {
                    nom = agendaLlegir.ReadLine();
                    if (nom.Contains(nomTrobar))
                    {
                        trobat = true;
                        Console.WriteLine(nomTrobar);
                    }
                } while (!agendaLlegir.EndOfStream);
            }
            else
            {
                do
                {
                    nom = agendaLlegir.ReadLine();
                    if (nom.Equals(nomTrobar))
                    {
                        trobat = true;
                        Console.WriteLine(nomTrobar);
                    }
                    Console.WriteLine(nomTrobar);
                } while (!agendaLlegir.EndOfStream);
            }
            if (!trobat)
            {
                Console.WriteLine("Usuari no trobat");
                Main();
            }
        }

        static void ModificarUsuari()
        {
            
        }

        static void EliminarUsuari()
        {
            
        }

        static void MostrarAgenda()
        {
            
        }

        static void OrdenarAgenda()
        {
            
        }
        static void Main(string[] args)
        {

        }
    }
}