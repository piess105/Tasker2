﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasker.Models.Pub
{
    public class SheetRowModel
    {
        public IList<SheetCellModel> Cells { get; set; }
        public DateTime Date { get; set; }
    }
}
