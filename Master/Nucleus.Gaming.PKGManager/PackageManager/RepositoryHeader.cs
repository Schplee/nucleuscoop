﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nucleus.Gaming.PackageManager
{
    public class RepositoryHeader
    {
        /// <summary>
        /// An array with all available games on this store
        /// </summary>
        public RepositoryGameInfo[] Games { get; set; }

        /// <summary>
        /// Root folder for all packages infos
        /// </summary>
        public string PackagesInfoRoot { get; set; }

        /// <summary>
        /// Root folder for all packages installers
        /// </summary>
        public string PackagesRoot { get; set; }
    }
}
