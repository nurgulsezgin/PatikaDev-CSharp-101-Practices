// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Project1PhoneBook.Datas;

namespace Project1PhoneBook.Operations;
public class ListOperation : IOperation
{
    public void List()
    {
        Console.WriteLine("Telefon Rehberi \n **********************************************");

        foreach (Person person in PhoneBookDatabase.PhoneList)
        {
            Console.WriteLine("İsim: " + person.FirstName);
            Console.WriteLine("Soyisim: " + person.LastName);
            Console.WriteLine("Telefon Numarası: " + person.PhoneNumber);
            Console.WriteLine("-");
        }
    }
}
