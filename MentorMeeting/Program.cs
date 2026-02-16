using System;
using System.Collections.Generic;

namespace MentorMeeting{

  public class Jewellery{
    public string Id{get; set;}
    public string Type { get; set;}
    public string Material {get; set;}
    public int Price {get; set;}

    public Jewellery(string id, string type, string material, int price){
        Id=id;
        Type=type; 
        Material = material;
        Price = price;
    }
}

public class JewelleryUtility{

    public Dictionary<string, string> GetJewelleryDetails(string id){
        var dict  = new Dictionary<string, string>();

        Jewellery j=null;
        foreach(var diction in Program.jewelleryDetails){
            if(diction.Value.Id == id){
                j=diction.Value;
                break;
            }
        }

        if(j==null) return dict;

        string newStr = j.Type + "_" + j.Material;
        dict[id] = newStr;
        return dict;
    }

    public Dictionary<string, Jewellery> UpdateJewelleryPrice(string id, int price){
        var dict  = new Dictionary<string, Jewellery>();
        Jewellery j=null;

        foreach(var diction in Program.jewelleryDetails){
            if(diction.Value.Id == id){
                j=diction.Value;
                break;
            }
        }

        if(j==null) return dict;

        j.Price=price;
        dict.Add(id, j);
        return dict;
    }
}

public class Program{

    public static Dictionary<int, Jewellery> jewelleryDetails = new Dictionary<int, Jewellery>();

    public static void Main(){

        jewelleryDetails.Add(1, new Jewellery("JW01", "Bracelet", "Silver", 10000));
        jewelleryDetails.Add(2, new Jewellery("JW02", "Ring", "Gold", 20000));
        jewelleryDetails.Add(3, new Jewellery("JW03", "Necklace", "Diamond", 30000));

        while(true){
            Console.WriteLine("1. Get Jewellery Details");
            Console.WriteLine("2. Update Price");
            Console.WriteLine("3. Exit");
            Console.WriteLine();

            Console.WriteLine("Enter your choice");
            int choice = int.Parse(Console.ReadLine());

            if(choice==1){
                Console.WriteLine("Enter the jewellery id");
                string id = Console.ReadLine();

                var ju = new JewelleryUtility();
                var dict = ju.GetJewelleryDetails(id);

                if(dict.Count==0){
                    Console.WriteLine("Jewellery id not found");
                }else{
                    Console.WriteLine(id + " " + dict[id]);
                }
            }

            else if(choice==2){
                Console.WriteLine("Enter the jewellery id: ");
                string id = Console.ReadLine();

                Console.WriteLine("Enter the price to be updated");
                int newPrice = int.Parse(Console.ReadLine());

                var ju = new JewelleryUtility();
                var dict = ju.UpdateJewelleryPrice(id, newPrice);

                if(dict.Count==0){
                    Console.WriteLine("Jewellery id not found");
                }
                else{
                    Console.WriteLine($"Id : {dict[id].Id},    Type : {dict[id].Type},    Material : {dict[id].Material},    Price : {dict[id].Price}");
                }
            }

            else if(choice==3){
                break;
            }
            else{
                Console.WriteLine("Incorrect/Invalid choice");
            }
        }
    }
}
}


