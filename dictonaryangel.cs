using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, string> myDictionary = new Dictionary<string, string>();

    static void Main()
    {
        bool running = true;
   

        while (running)
        {
            Console.WriteLine("Select a option:");
            Console.WriteLine("1: Add a new Key and Value");
            Console.WriteLine("2: Search a Key");
            Console.WriteLine("3: Edit a value's key");
            Console.WriteLine("4: Delete a key");
            Console.WriteLine("5: Show all the key");
            Console.WriteLine("6: exit");

            
            string input = Console.ReadLine();
            int option;

            if (int.TryParse(input, out option))
            {
                switch (option)
                {
                    case 1:
                        
                        Console.Write("Digit the key: ");
                        string keyToAdd = Console.ReadLine();
                        Console.Write("Digit the value: ");
                        string valueToAdd = Console.ReadLine();

                        if (!myDictionary.ContainsKey(keyToAdd))
                        {
                            myDictionary.Add(keyToAdd, valueToAdd);
                            Console.WriteLine("Added element.");
                        }
                        else
                        {
                            Console.WriteLine("The key already exist.");
                        }
                        break;

                    case 2:
                        
                        Console.Write("Digit the key you want to search: ");
                        string keyToSearch = Console.ReadLine();

                        if (myDictionary.TryGetValue(keyToSearch, out string value))
                        {
                            Console.WriteLine($"Valor: {value}");
                        }
                        else
                        {
                            Console.WriteLine("Can not find that key.");
                        }
                        break;

                    case 3:
                        
                        Console.Write("Digit the key you want to edit: ");
                        string keyToEdit = Console.ReadLine();

                        if (myDictionary.ContainsKey(keyToEdit))
                        {
                            Console.Write("Digit the new value: ");
                            string newValue = Console.ReadLine();
                            myDictionary[keyToEdit] = newValue;
                            Console.WriteLine("Value update.");
                        }
                        else
                        {
                            Console.WriteLine("Can not find that key.");
                        }
                        break;

                    case 4:
                        
                        Console.Write("Digit the key you want to Delete: ");
                        string keyToRemove = Console.ReadLine();

                        if (myDictionary.Remove(keyToRemove))
                        {
                            Console.WriteLine("Key deleted.");
                        }
                        else
                        {
                            Console.WriteLine("Can not find that key.");
                        }
                        break;

                    case 5:
                        
                        Console.WriteLine("Dictonary's elements:");
                        foreach (var kvp in myDictionary)
                        {
                            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
                        }
                        break;

                    case 6:
                        
                        running = false;
                        Console.WriteLine("Bye");
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Can not use that option, digit another option.");
            }
        }
    }
}
