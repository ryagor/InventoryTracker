﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
	public class DatabaseWrapper
	{
        DatabaseWrapper()
        {
            var q = SQLite.SQLiteConnection("path");
        }
	}
}
