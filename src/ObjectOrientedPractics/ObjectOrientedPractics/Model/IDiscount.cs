﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Интерфейс для работы со скидками.
    /// </summary>
    public interface IDiscount
    {
        string Info { get; }
        double Calculate(List<Item> items);
        double Apply(List<Item> items);
        void Update(List<Item> items);
    }
}
