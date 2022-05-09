using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AnimalCLass
    {
    }

    class AnimalKingdom : Tiger, Lion, hynea, fox, elephant
    {
     
        public List<AnimalsBehave> tiger_details(List<AnimalsBehave> lists)
        {
           
            lists.Add(new AnimalsBehave { drinking = "tigers can drink water",eating= "tigers can eat Meet" ,running= "tigers can run Fastly" });
            
            return lists;

            //foreach (var animal in list)
            //{
            //    Console.WriteLine(animal.drinking +" ,"+animal.eating+","+animal.running );
            //}

        }
        public List<AnimalsBehave> lion_details(List<AnimalsBehave> lists)
        {
            lists.Add(new AnimalsBehave { drinking = "Lion can drink water", eating = "Lion can eat Meet", running = "Lion can run Fastly" });
            return lists;
        }
        public List<AnimalsBehave> hynea_details(List<AnimalsBehave> lists)
        {
            lists.Add(new AnimalsBehave { drinking = "Hyna can drink water", eating = "Hyna can eat Meet", running = "Hyna can run Fastly" });
            return lists;

        }
        public List<AnimalsBehave> fox_details(List<AnimalsBehave> lists)
        {
            lists.Add(new AnimalsBehave { drinking = "Fox can drink water", eating = "Fox can eat Meet", running = "Fox can run Fastly" });
            return lists;
        }
        public List<AnimalsBehave> elephant_details(List<AnimalsBehave> lists)
        {
            lists.Add(new AnimalsBehave { drinking = "Elephant can drink water", eating = "Elephant can eat Grass", running = "Elephant can run Slowly" });
            return lists;
        }



        static void Main()
        {
            AnimalKingdom ak = new AnimalKingdom();

            List<AnimalsBehave> list = new List<AnimalsBehave>();
            
            ak.tiger_details(list);
           
            ak.fox_details(list); 
            ak.lion_details(list); 
            ak.hynea_details(list);
            ak.elephant_details(list);
            foreach (var animal in list)
            {
                Console.WriteLine(animal.drinking + " ," + animal.eating + "," + animal.running);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
    interface Tiger
    {
        List<AnimalsBehave> tiger_details(List<AnimalsBehave> obj);
    }
    interface Lion
    {
        List<AnimalsBehave> lion_details(List<AnimalsBehave> obj);
    }
    interface hynea
    {
        List<AnimalsBehave> hynea_details(List<AnimalsBehave> obj);
    }
    interface fox
    {
        List<AnimalsBehave> fox_details(List<AnimalsBehave> obj);
    }
    interface elephant
    {
        List<AnimalsBehave> elephant_details(List<AnimalsBehave> obj);
    }
    public class AnimalsBehave
    {
        public string eating { get; set; }
        public String running { get; set; }
        public string drinking { get; set; }
    }



}