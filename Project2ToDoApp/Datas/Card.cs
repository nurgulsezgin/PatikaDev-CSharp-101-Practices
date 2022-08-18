// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2ToDoApp.Datas;
internal class Card
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Person { get; set; }
    public string Size { get; set; }
    public string BoardType { get; set; } = "TODO";
}
