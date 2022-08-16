// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Project1PhoneBook.Datas;

namespace Project1PhoneBook.Operations;
public class SavingOperation
{
    public void Save()
    {
        Console.WriteLine("Lütfen isim giriniz:");
        string name = Console.ReadLine();
        Console.WriteLine("Lütfen soyisim giriniz:");
        string surname = Console.ReadLine();
        Console.WriteLine("Lütfen telefon numarası giriniz:");
        string number = Console.ReadLine();

        Person person = new Person();
        person.FirstName = name;
        person.LastName = surname;
        person.PhoneNumber = number;

        PhoneBookDatabase.PhoneList.Add(person);
        Console.WriteLine(name + " " + surname + " added successfully.");

    }
    public bool CheckExist(string input)
    {
        bool exists = PhoneBookDatabase.PhoneList.Any(x => x.FirstName == input || x.LastName == input);
        return exists;
    }
}
