// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Project1PhoneBook.Datas;

namespace Project1PhoneBook.Operations;
internal class EditingOperation : IOperation
{
    public void Update()
    {
    update:
        Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz.");
        string input = Console.ReadLine();
        Person personEdit = PhoneBookDatabase.PhoneList.FirstOrDefault(x => x.FirstName == input || x.LastName == input);

        if (personEdit != null)
        {
            Console.Write("Lütfen yeni numarasını giriniz: ");
            string newPhoneNo = Console.ReadLine();
            personEdit.PhoneNumber = newPhoneNo;

        }
        else
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.Lütfen bir seçim yapınız.");
            while (true)
            {

                Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("Çıkış yapıldı.");
                    return;
                }
                else if (choice == "2")
                    goto update;
                else
                {
                    Console.WriteLine("Gecersiz bir karakter girdiniz. Tekrar deneyiniz");
                }
            }
        }

        Console.WriteLine("Güncelleme başarıyla gerçekleştirilmiştir.");
    }
}
