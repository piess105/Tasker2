using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasker.Models.Pub
{
    public class SheetCellModel
    {
        public SheetHeaderModel Header { get; set; }
        public CellIndexModel CellIndex { get; set; }
        public string Content { get; set; }
    }
}