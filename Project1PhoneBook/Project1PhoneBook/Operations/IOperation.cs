// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1PhoneBook.Operations;
internal interface IOperation
{
    public void Save() { }
    public void Delete() { }
    public void Update() { }
    public void List() { }
    public void Serach() { }
}
