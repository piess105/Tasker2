using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.Models.Pub;

namespace Tasker.BL.Extensions
{
    public static class CellIndexModelExtension
    {
        public static string ToPosition(this CellIndexModel model)
        {
            var letter = model.Column.ToLetter();

            var res = $"{letter}{model.Row}:{letter}";

            return res;
        }
    }
}
