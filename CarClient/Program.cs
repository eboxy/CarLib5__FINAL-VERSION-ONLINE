using CarClient.CarServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace CarClient
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int choice=7;
            Program p = new Program();


            while (true)   //loop för att hålla igång programmet
            {
                Console.Clear();

                Console.WriteLine("");
                Console.Write("   ");
                Console.WriteLine("Tompas Bil-Bibbla");
                Console.Write("   ");
                Console.WriteLine(".................");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.Write("   ");
                Console.WriteLine("Valj atgard i bil-bibblan:");
                Console.Write("   ");
                Console.WriteLine("..........................");
                Console.WriteLine("");
                Console.Write("   ");
                Console.WriteLine("Valj 1 för att se alla bilar");
                Console.WriteLine("");
                Console.Write("   ");
                Console.WriteLine("Valj 2 för att lagga till en bil");
                Console.WriteLine("");
                Console.Write("   ");
                Console.WriteLine("Valj 3 för att ta bort en bil");
                Console.WriteLine("");
                Console.Write("   ");
                Console.WriteLine("Valj 4 för att andra en bils uppgifter");
                Console.WriteLine("");
                Console.Write("   ");
                Console.WriteLine("Valj 5 för att avsluta program");
                Console.WriteLine("");
                Console.Write("   ");
                Console.WriteLine("Valj vilken siffra som helst utom 5 for att aterga till denna meny");
                Console.WriteLine("");


                choice = p.CheckIfOnlyNumbers();  //kolla om inmatat värde är en siffra
                if (choice == 5) { p.KillProgram(); }

               
                switch (choice)
                        {
                            case 1:

                        //visa alla bilar i bibblan


                        using (CarServiceClient proxy = new CarServiceClient())
                                {
                                    List<Car> Cars = proxy.GetCars().ToList();

                                    int numOfCars = Cars.Count;

                                    Console.Clear();

                                    Console.WriteLine("");
                                    Console.Write("   ");
                                    Console.WriteLine("Bil-Bibblan");
                                    Console.Write("   ");
                                    Console.WriteLine("...........");
                                    Console.WriteLine("");


                                    for (int z = 0; z <= numOfCars - 1; z++)
                                    {

                                        Console.Write("   ");
                                        Console.WriteLine("CarId: " + Cars[z].Id);


                                        Console.Write("   ");
                                        Console.WriteLine("Brand: " + Cars[z].Brand);

                                        Console.Write("   ");
                                        Console.WriteLine("Model: " + Cars[z].Model);

                                        Console.Write("   ");
                                        Console.WriteLine("Year:  " + Cars[z].Year);
                                        Console.WriteLine("");
                                    }

                                }


                            break;

                           case 2:

                                    //Lägga till en bil till bibblan

                                    using (CarServiceClient proxy = new CarServiceClient())
                                    {

                                            Car newCar = new Car();
                                            string newCarMarke = "";
                                            string newCarModell = "";
                                            int newCarAr = 0;

                                            Console.Clear();

                                            Console.WriteLine("");
                                            Console.Write("   ");
                                            Console.WriteLine("Lagga till en bil");
                                            Console.Write("   ");
                                            Console.WriteLine(".................");
                                            Console.WriteLine("");

                                            Console.WriteLine("");
                                            Console.Write("   ");
                                            Console.WriteLine("Mata in nya bilens marke");
                                            Console.Write("   ");
                                            newCarMarke = Console.ReadLine();
                                            newCar.Brand = newCarMarke;

                                            Console.WriteLine("");
                                            Console.Write("   ");
                                            Console.WriteLine("Mata in nya bilens modell");
                                            Console.Write("   ");
                                            newCarModell = Console.ReadLine();
                                            newCar.Model = newCarModell;

                                            Console.WriteLine("");
                                            Console.Write("   ");
                                            Console.WriteLine("Mata in nya bilens tillverkningsar");
                                            newCarAr = p.CheckIfOnlyNumbers();  //checka om siffra
                                            newCar.Year = newCarAr;
                                            
                                            proxy.Add(newCar);

                                            Console.WriteLine("");
                                            Console.Write("   ");
                                            Console.WriteLine("En ny bil ar tillagd i bibblan");
                                    }

                            break;

                           case 3:

                                //ta bort en bil från bibblan

                                using (CarServiceClient proxy = new CarServiceClient())
                                {

                                    int removeCarId = 0;

                                    Console.Clear();

                                    Console.WriteLine("");
                                    Console.Write("   ");
                                    Console.WriteLine("Ta bort en bil");
                                    Console.Write("   ");
                                    Console.WriteLine("..............");
                                    Console.WriteLine("");

                                    Console.WriteLine("");
                                    Console.Write("   ");
                          Console.WriteLine("Amge id for den bil som skall tas bort fran bibblan");
                                    Console.Write("   ");
                                    removeCarId = int.Parse(Console.ReadLine());

                                    List<Car> Cars = proxy.GetCars().ToList();

                                    int numOfCars = Cars.Count;

                                        for (int z = 0; z <= numOfCars - 1; z++)
                                        {

                                            if (Cars[z].Id == removeCarId)
                                            {
                                                proxy.Delete(Cars[z]);
                                                Console.WriteLine("");
                                                Console.Write("   ");
                          Console.WriteLine($"Bil med id {removeCarId} har tagits bort fran bibblan");
                                                Console.WriteLine("");

                                }
                                        }

                                   }

                            break;

                           case 4:

                                //uppdatera en bil från bibblan

                                using (CarServiceClient proxy = new CarServiceClient())
                                {

                                    int updateCarId = 0;
                                    string updateCarMarke = "";
                                    string updateCarModell = "";
                                    int? updateCarAr = 0;
                                    int updateCarArINT = 0;

                                    Console.Clear();

                                    Console.WriteLine("");
                                    Console.Write("   ");
                                    Console.WriteLine("Andra en bils uppgifter");
                                    Console.Write("   ");
                                    Console.WriteLine(".......................");
                                    Console.WriteLine("");

                                    Console.WriteLine("");
                                    Console.Write("   ");
                                    Console.WriteLine("Ange id for den bil som skall uppdateras i bibblan");
                                    Console.Write("   ");
                                    updateCarId = int.Parse(Console.ReadLine());

                                    List<Car> Cars = proxy.GetCars().ToList();

                                    int numOfCars = Cars.Count;

                                    for (int z = 0; z <= numOfCars - 1; z++)
                                    {

                                        if (Cars[z].Id == updateCarId)
                                        {

                                            Console.WriteLine("");
                                            Console.Write("   ");
                                            Console.WriteLine("Uppdatera bilens marke?");
                                            Console.Write("   ");
                                            updateCarMarke = Console.ReadLine();
                                            if(updateCarMarke != "")
                                             Cars[z].Brand = updateCarMarke;

                                            Console.WriteLine("");
                                            Console.Write("   ");
                                            Console.WriteLine("Uppdatera bilens modell?");
                                            Console.Write("   ");
                                            updateCarModell = Console.ReadLine();
                                            if (updateCarModell != "")
                                            Cars[z].Model = updateCarModell;

                                            Console.WriteLine("");
                                            Console.Write("   ");
                                            Console.WriteLine("Uppdatera bilens tillverkningsar?");
                                            Console.Write("   ");
                                            if (int.TryParse(Console.ReadLine(), out updateCarArINT))
                                            updateCarAr = (int?)updateCarArINT;

                                            if (updateCarAr != null & updateCarArINT != 0)
                                            Cars[z].Year = updateCarArINT;


                                            proxy.Update(Cars[z]);
                                            Console.WriteLine("");
                                            Console.Write("   ");
                                   Console.WriteLine($"Bil med id {updateCarId} har uppdaterats i bibblan");
                                            Console.WriteLine("");
                                        }

                                    }

                                }


                    break;


                }  //sweitch-sats slutar här



                Console.WriteLine("");
                Console.Write("   ");
                Console.WriteLine("Avsluta? Tryck 5. Till meny? Vilken siffra som helst utom 5");
                choice = p.CheckIfOnlyNumbers();  //kolla om inmatat värde är en siffra

                if (choice == 5)
                 p.KillProgram();
                
               
          }    //program-loop slutar här



        }  //Main slutar här

        
        
        //dödar programmet  :-P
        void KillProgram()
        {
                Console.WriteLine("");
                Console.Write("   ");
                Console.WriteLine("Slut i rutan :D ");
                Thread.Sleep(1000);
                Environment.Exit(0);
        }



        //kolla om inmatat värde är en siffra
        int CheckIfOnlyNumbers()
        {
            int choice = 0;

            while (true)
            {
                Console.Write("   ");
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    return choice;
                }
                else
                Console.WriteLine("");
                Console.Write("   ");
                Console.WriteLine("Mata in ENDAST siffror!");
            }
         }



    } //klass slutar här
}
