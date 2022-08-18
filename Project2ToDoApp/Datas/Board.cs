// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2ToDoApp.Datas;
internal class Board
{
    public List<Card> Todo { get;set; }
    public List<Card> Inprogress { get;set; }
    public List<Card> Done { get;set; }

}
