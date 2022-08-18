// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2ToDoApp.Datas;
internal class Database
{
    private static List<Card> _Cards;
    private static Board _Boards;
    private static List<Person> _PersonList;
    static Database()
    {
        _Cards = new List<Card>()
        {
            new Card{Title="Ödevler", Content="Web API ödevini yapacak. ",Person="Ali", Size="L",BoardType="TODO" },
            new Card{Title="Proje", Content="Proje dosyalarını tamamlayacak. ", Person="Ayşe", Size="M",BoardType="IN PROGRESS" },
            new Card{Title="Toplantı", Content="08.05.2022 00.00 da toplantı yapılacak ", Person="Ahmet", Size="XL",BoardType="DONE" },
            new Card{Title="Egitim", Content="Stajerlere eğitim verilecek", Person="Gül", Size="XS",BoardType="TODO" },
        };
        //_Boards = new List<Board>()
        //{
        //    Card Project2ToDoApasdds=_Cards.FirstOrDefault(x=>x.BoardType=="TODO");
        //    new Board{ TODO=_Cards.FirstOrDefault(x=>x.BoardType=="TODO"),INPROGRESS=}
        //};
        _PersonList = new List<Person>()
        {
            new Person{Id=1,Name="Ali",Team="A"},
            new Person{Id=2,Name="Ayşe",Team="A"},
            new Person{Id=3,Name="Ahmet",Team="B"},
            new Person{Id=4,Name="Gül",Team="B"},
        };

        Card toDo = _Cards.FirstOrDefault(x => x.BoardType == "TODO");
        Card InProgress = _Cards.FirstOrDefault(x => x.BoardType == "IN PROGRESS");
        Card done = _Cards.FirstOrDefault(x => x.BoardType == "DONE");

        _Boards = new Board();
        _Boards.Todo.Add(toDo);
        _Boards.Inprogress.Add(InProgress);
        _Boards.Done.Add(done);
    }
    public List<Card> Cards
    {
        get { return _Cards; }
    }
    public static Board Boards => _Boards;
}
