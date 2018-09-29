using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.Models.Pub;

namespace Tasker.BL.Factories
{
    public static class CellIndexModelFactory
    {
        public static CellIndexModel Create(int columnIndex, int rowIndex)
        {
            var model = new CellIndexModel
            {
                Column = columnIndex,
                Row = rowIndex
            };

            return model;
        }
    }
}
