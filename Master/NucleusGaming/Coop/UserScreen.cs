﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nucleus.Gaming.Coop
{
    public class UserScreen
    {
        private Rectangle uiBounds;
        private Rectangle swapTypeRect;
        private UserScreenType type;

        public Rectangle display;
        public bool vertical;

        public Rectangle SwapTypeBounds
        {
            get { return swapTypeRect; }
            set { swapTypeRect = value; }
        }

        public Rectangle UIBounds
        {
            get { return uiBounds; }
            set { uiBounds = value; }
        }

        public UserScreenType Type
        {
            get { return type; }
            set { type = value; }
        }

        public Rectangle MonitorBounds
        {
            get { return display; }
        }

        public UserScreen(Rectangle display)
        {
            this.display = display;

            type = UserScreenType.FullScreen;
        }

        public int GetPlayerCount()
        {
            switch (type)
            {
                case UserScreenType.DualHorizontal:
                case UserScreenType.DualVertical:
                    return 2;
                case UserScreenType.FourPlayers:
                    return 4;
                case UserScreenType.SixteenPlayers:
                    return 16;
                default:
                    return -1;
            }
        }

        public bool IsFullscreen()
        {
            return type == UserScreenType.FullScreen;
        }

        public bool IsDualHorizontal()
        {
            return type == UserScreenType.DualHorizontal;
        }

        public bool IsDualVertical()
        {
            return type == UserScreenType.DualVertical;
        }

        public bool IsFourPlayers()
        {
            return type == UserScreenType.FourPlayers;
        }
    }
}
