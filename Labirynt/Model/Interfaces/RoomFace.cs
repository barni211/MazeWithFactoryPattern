﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirynt.Model
{
    public interface RoomFace
    {
        bool playerInside();
        void enterPlayer();
        void leavePlayer();
    }
}
