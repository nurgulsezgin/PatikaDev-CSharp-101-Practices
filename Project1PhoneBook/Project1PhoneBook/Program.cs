﻿using Project1PhoneBook.Operations;

Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
Console.WriteLine("*******************************************");
Console.WriteLine("(1) Yeni Numara Kaydetmek");
Console.WriteLine("(2) Varolan Numarayı Silmek");
Console.WriteLine("(3) Varolan Numarayı Güncelleme");
Console.WriteLine("(4) Rehberi Listelemek");
Console.WriteLine("(5) Rehberde Arama Yapmak");

string choice = Console.ReadLine();
switch (choice)
{
    case "1":
        SavingOperation operation1 = new SavingOperation();
        operation1.Save();
        break;

    case "2":
        DeletingOperation operation2 = new DeletingOperation();
        operation2.Delete();
        break;

    case "3":
        EditingOperation operation3 = new EditingOperation();
        operation3.Update();
        break;

    case "4":
        ListOperation operation4 = new ListOperation();
        operation4.List();
        break;

    case "5":
        SearchOperations operation5 = new SearchOperations();
        operation5.Search();
        break;
}
