// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Project1PhoneBook.Datas;

namespace Project1PhoneBook.Operations;
public class SearchOperations : IOperation
{
    public void Search()
    {
    Search:
        Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz. /n *********************************************");
        Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
        Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
        Person person;
        string input = Console.ReadLine();
        if (input == "1")
        {
            Console.WriteLine("İsim veya soyisim giriniz : ");
            String input2 = Console.ReadLine();
            person = PhoneBookDatabase.PhoneList.FirstOrDefault(x => x.FirstName == input2 || x.LastName == input2);
            Show(person);
        }
        else if (input == "2")
        {
            Console.WriteLine("Telefon numarası giriniz : ");
            String input3 = Console.ReadLine();
            foreach (Person item in PhoneBookDatabase.PhoneList)
            {
                if (item.PhoneNumber.Contains(input3))
                {
                    Show(item);
                }
            }
        }
        else
        {
            Console.WriteLine("Gecersiz bir karakter girdiniz.Tekrar deneyiniz");
            goto Search;
        }
    }
    public void Show(Person person)
    {
        Console.WriteLine("İsim: " + person.FirstName);
        Console.WriteLine("Soyisim: " + person.LastName);
        Console.WriteLine("Telefon Numarası: " + person.PhoneNumber);
        Console.WriteLine("-");
    }
}
