﻿using Project2ToDoApp.Operations;

start:
Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
Console.WriteLine("*******************************************");
Console.WriteLine("(1) Board Listelemek");
Console.WriteLine("(2) Board'a Kart Eklemek");
Console.WriteLine("(3) Board'dan Kart Silmek");
Console.WriteLine("(4) Kart Taşımak");

int selection = int.Parse(Console.ReadLine());

switch (selection)
{
    case 1:
        ListingBoard operation1 = new ListingBoard();
        operation1.List();
        break;
    case 2:
        AddingCard operation2 = new AddingCard();
        operation2.Add();
        break;
    case 3:
        DeletingCard operation3 = new DeletingCard();
        operation3.Delete();
        break;
    case 4:
        MovingCard operation4 = new MovingCard();
        operation4.Move();
        break;
    default:
        break;
}
Console.WriteLine("Başka işlem yapmak için herhangi bir tuşa basınız.");
string input = Console.ReadLine();
if (input != null) { goto start; }
