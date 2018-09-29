using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.BL.Extensions;
using Tasker.BL.Savers;
using Tasker.Models.Pub;

namespace Tasker.BL.Proxies
{
    public class SheetDataSaverProxy
    {
        private SheetDataSaver SheetDataSaver { get; }

        public SheetDataSaverProxy(SheetDataSaver sheetDataSaver)
        {
            SheetDataSaver = sheetDataSaver;
        }
        
        public void Save(SheetCellModel model)
        {
            var position = model.CellIndex.ToPosition();

            SheetDataSaver.SaveData(model.Content, position);
        }
    }
}
