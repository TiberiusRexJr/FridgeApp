﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeIt.Views
{

    public class NavigationMenuMasterMenuItem
    {
        public NavigationMenuMasterMenuItem()
        {
            TargetType = typeof(NavigationMenuMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}