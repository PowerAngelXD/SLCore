﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLCore.Commands;
public interface ISLCommand : IDisposable
{
    string Id { get; }
    IEnumerable<string> Aliases { get; }
    string HelpContent { get; }
    Task<ISLCommand?> Execute(IEnumerable<string> args);
}
