﻿//Copyright (C) 2015  Timothy Watson, Jakub Pachansky

//This program is free software; you can redistribute it and/or
//modify it under the terms of the GNU General Public License
//as published by the Free Software Foundation; either version 2
//of the License, or (at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with this program; if not, write to the Free Software
//Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

using System;
using R.MessageBus.Core;
using R.MessageBus.Interfaces;
using R.MessageBus.UnitTests.Fakes.Messages;

namespace R.MessageBus.UnitTests.Fakes.ProcessManagers
{
    public class FakeProcessManager1 : ProcessManager<FakeProcessManagerData>,
                                       IStartProcessManager<FakeMessage1>,
                                       IMessageHandler<FakeMessage2>
    {
        public void Execute(FakeMessage1 command)
        {
            Data.User = command.Username;
        }

        public void Execute(FakeMessage2 command)
        {
            Data.Email = command.Email;
        }
    }
}