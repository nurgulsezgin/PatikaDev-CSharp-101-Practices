// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Project1PhoneBook.Datas;

namespace Project1PhoneBook.Operations;
internal class DeletingOperation : IOperation
{
    public void Delete()
    {
        while (true)
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadınıgiriniz:");
            string input = Console.ReadLine();

            bool exits = CheckExist(input);

            if (exits)
            {
                Person personDelete = PhoneBookDatabase.PhoneList.FirstOrDefault(x => x.FirstName == input || x.LastName == input);
                bool confirmation = YesOrNo(personDelete);
                if (confirmation)
                {
                    PhoneBookDatabase.PhoneList.Remove(personDelete);
                    Console.WriteLine("Silme işlemi başarıyla gerçekleştirildi.");
                    break;
                }
                else
                {
                    Console.WriteLine("Silme işlemi iptal edildi.");
                    break;
                }

            }
            else
            {
                int step = NotExist();

                if (step == 1)
                {
                    Console.WriteLine("Silme işlemi sonlandırıldı.");
                    break;
                }
                else if (step == 2)
                {
                    Console.WriteLine("************************************************************");
                }
            }
        }

    }
    public bool CheckExist(string input)
    {
        bool exists = PhoneBookDatabase.PhoneList.Any(x => x.FirstName == input || x.LastName == input);
        return exists;
    }
    public bool YesOrNo(Person input)
    {
        while (true)
        {
            Console.WriteLine(input.FirstName + " " + input.LastName + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz ? Y/N");

            string option = Console.ReadLine().ToUpper();
            if (option == "Y")
            {
                return true;
                break;
            }
            else if (option == "N")
            {
                return false;
                break;
            }
            else
            {
                Console.WriteLine("Gecersiz bir karakter girdiniz. Tekrar deneyiniz");
            }
        }

    }
    public int NotExist()
    {
        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
        int input2;

        while (true)
        {
            Console.WriteLine("*Silmeyi sonlandırmak için : (1)");
            Console.WriteLine("*Yeniden denemek için      : (2)");

            if (int.TryParse(Console.ReadLine(), out input2))
            {
                if (input2 == 1)
                {
                    return 1;
                }
                else if (input2 == 2)
                {
                    return 2;
                }
            }
            else
            {
                Console.WriteLine("Gecersiz bir karakter girdiniz. Tekrar deneyiniz ");
            }
        }
    }
}
