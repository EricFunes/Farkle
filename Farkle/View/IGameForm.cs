﻿using FarkleLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farkle.View
{
    public interface IGameForm
    {
        bool IsDisposed { get; }

        IGameForm CreateNewInstance();
        void setPlayers(List<IPlayer> players);
        void Show();
    }
}
