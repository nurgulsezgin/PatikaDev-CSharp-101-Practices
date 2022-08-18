// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Project2ToDoApp.Datas;

namespace Project2ToDoApp.Operations;
internal class DeletingCard : IOperations
{
    public void Delete()
    {
    againDo:
        Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
        Console.WriteLine("Lütfen kart başlığını yazınız:  ");
        string input = Console.ReadLine();

        Card card = Database.Cards.FirstOrDefault(x => x.Title == input);
        if (card != null)
        {
            Database.Cards.Remove(card);
        }
        else
        {
        againTry:
            Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\r\n * Silmeyi sonlandırmak için : (1)\r\n * Yeniden denemek için : (2)");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Silme işlemi sonlandırıldı.");
            }
            else if (choice == 2)
            {
                goto againDo;
            }
            else
            {
                Console.WriteLine("Gecersiz bir karakter girdiniz.Tekrar deneyiniz ");
                goto againTry;
            }
        }
    }
}
