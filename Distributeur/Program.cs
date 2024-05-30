namespace Distributeur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stock1 = 5, stock2 = 2, stock3 = 0, choix;

            do{
                Console.WriteLine("Veuillez sélectionner une boisson :\n1. Eau\n2. Soda\n3. Orangeade");

                do{
                    Console.WriteLine("Faîtes votre choix:");
                }while (!int.TryParse(Console.ReadLine(), out choix));

                switch (choix)
                {
                    case 1:
                        if( stock1 != 0 ){
                            Console.WriteLine("Voici votre eau");
                            stock1 --;
                        }
                        else{
                            Console.WriteLine("Sold out!");
                        }
                        break;
                    case 2:
                        if( stock2 != 0 ){
                            Console.WriteLine("Voici votre soda");
                            stock2 --;
                        }
                        else{
                            Console.WriteLine("Sold out!");
                        }
                        break;
                    case 3:
                        if( stock3 != 0 ){
                            Console.WriteLine("Voici votre orangeade");
                            stock3 --;
                        }
                        else{
                            Console.WriteLine("Sold out!");
                        }
                        break;
                    default:
                        Console.WriteLine("Choix indisponible");
                        break;
                }
            }while(stock1 + stock2 + stock3 > 0);
            Console.WriteLine("Merci d'avoir utilisé distributeur 3000!");
        }
    }
}
