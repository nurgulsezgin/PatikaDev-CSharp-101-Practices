// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Project1PhoneBook.Datas;

namespace Project1PhoneBook.Datas;
public class PhoneBookDatabase
{

    private static List<Person> _phoneList;
    private static List<Dialing> _dialingList;

    static PhoneBookDatabase()
    {
        _phoneList = new List<Person>()
            {
                new Person{FirstName="Linda J.", LastName="Burks", PhoneNumber="(242) 352-0562" },
                new Person{FirstName="Sara A.", LastName="Ivy", PhoneNumber="(986) 695-0671" },
                new Person{FirstName="Cynthia E.", LastName="Jones", PhoneNumber="(415) 923-6596" },
                new Person{FirstName="Toni L.", LastName="Kenney", PhoneNumber="(450) 379-0231" },
                new Person{FirstName="Hiram S.", LastName="Morrow", PhoneNumber="(643) 928-0063" }
            };

        _dialingList = new List<Dialing>()
            {
                new Dialing{Name="Acil",Description="Yardım",PhoneNUmber="112"},
                new Dialing{Name="Polis",Description="Yardım",PhoneNUmber="155"},
                new Dialing{Name="Yangın",Description="Yardım",PhoneNUmber="110"},
                new Dialing{Name="Hastane",Description="Randevu",PhoneNUmber="182"},
                new Dialing{Name="Belediye",Description="İletişim",PhoneNUmber="153"},
            };
    }

    public static List<Person> PhoneList
    {
        get { return _phoneList; }
    }

    public static List<Dialing> DialingList
    {
        get { return _dialingList; }
    }
    
}
