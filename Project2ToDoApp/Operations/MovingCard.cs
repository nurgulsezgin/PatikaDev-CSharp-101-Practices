// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Project2ToDoApp.Datas;

namespace Project2ToDoApp.Operations;
internal class MovingCard : IOperations
{
    public void Move()
    {
    againDo:
        Console.WriteLine(" Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.\r\n Lütfen kart başlığını yazınız:  ");
        string input = Console.ReadLine();
        Card card = Database.Cards.FirstOrDefault(x => x.Title == input);
        if (card != null)
        {
            Console.WriteLine("Bulunan kart bilgiler");
            Console.WriteLine("*******************************************");

            Console.WriteLine("Başlık      :  {0}", card.Title);
            Console.WriteLine("İçerik      :  {0}", card.Content);
            Console.WriteLine("Atanan Kişi :  {0}", card.Person);
            Console.WriteLine("Büyüklük    :  {0}", card.Size);
            Console.WriteLine("Line        :  {0}\n", card.BoardType);

            Console.WriteLine("Lütfen taşımak istediğiniz Durum'u seçiniz");
            Console.WriteLine("(0) TODO");
            Console.WriteLine("(1) IN PROGRESS");
            Console.WriteLine("(2) DONE");

            int line = int.Parse(Console.ReadLine());

            if (line == 0) { card.BoardType = "TODO"; }
            else if (line == 1) { card.BoardType = "IN PROGRESS"; }
            else if (line == 2) { card.BoardType = "DONE"; }
            else { card.BoardType = "Hatalı bir seçim yaptınız!"; }

        }
        else
        {
            Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\r\n * İşlemi sonlandırmak için : (1)\r\n * Yeniden denemek için : (2)");
        againTry:
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Kart taşıma işlemi sonlandırıldı.");
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
