// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Project2ToDoApp.Datas;

namespace Project2ToDoApp.Operations;
internal class AddingCard : IOperations
{
    public void Add()
    {
        Card newCard = new Card();

        Console.WriteLine("Card Ekleme Bölümü");
        Console.WriteLine("*******************************************");
        Console.Write(" Başlık Giriniz                                  : ");
        newCard.Title = Console.ReadLine();
        Console.Write(" İçerik Giriniz                                  : ");
        newCard.Content = Console.ReadLine();
        Console.Write(" Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  : ");
        int size = int.Parse(Console.ReadLine());

        if (size != null)
        {

            string sizeValue = Enum.GetName(typeof(Sizes), size);
            newCard.Size = sizeValue;
        }
        else
        {
            Console.WriteLine("Gecersiz bir karakter girdiniz. Tekrar deneyiniz ");
        }
        Console.Write(" Kişi Seçiniz                                    : ");
        newCard.Person = Console.ReadLine();
        CheckPersonId(newCard);
    }
    public void CheckPersonId(Card newCard)
    {
    againId:
        Console.WriteLine("İşleme devam edebilmek için ID nizi giriniz ");
        int id = int.Parse(Console.ReadLine());
        var person = Database.PersonList.FirstOrDefault(x => x.Id == id);
        if (person != null)
        {
            Database.Cards.Add(newCard);
            Console.WriteLine("Bu kart{0} tarafından oluşturulmuştur.", person.Name);
        }
        else
        {
            Console.WriteLine("Hatalı giriş yaptınız!");
        againTry:
            Console.WriteLine("Tekrar denemek için 1'e iptal etmek için 2'e basınız ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                goto againId;
            }
            else if (choice == 2)
            {
                Console.WriteLine("İşlemi iptal ettiniz.");
            }
            else
            {
                Console.WriteLine("Gecersiz bir karakter girdiniz.Tekrar deneyiniz ");
                goto againTry;
            }
        }

    }
    enum Sizes
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }
}
