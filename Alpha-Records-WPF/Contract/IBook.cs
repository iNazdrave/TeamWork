﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Records_WPF.Contract
{
    public interface IBook
    {
        string Title { get; }

        string Autor { get; }

        string Language { get; }

    }
}
