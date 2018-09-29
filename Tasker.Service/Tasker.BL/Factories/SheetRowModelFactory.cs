using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.Models.Pub;

namespace Tasker.BL.Factories
{
    public class SheetRowModelFactory
    {
        public SheetRowModelFactory(
            SheetHeaderModelFactory sheetHeaderModelFactory,
            SheetCellModelFactory sheetCellModelFactory)
        {
            SheetHeaderModelFactory = sheetHeaderModelFactory;
            SheetCellModelFactory = sheetCellModelFactory;
        }

        private SheetHeaderModelFactory SheetHeaderModelFactory { get; }
        private SheetCellModelFactory SheetCellModelFactory { get; }

        public IList<SheetRowModel> Create(IList<IList<string>> values)
        {
            var models = new List<SheetRowModel>();

            var headers = SheetHeaderModelFactory.Create(values[0]);

            for(var i  = 1; i < values.Count; i++)
            {
                var cells = SheetCellModelFactory.Create(values[i], headers, i + 1);

                var model = Create(cells);

                models.Add(model);
            }

            return models;
        }

        private SheetRowModel Create(IList<SheetCellModel> cells)
        {
            var model = new SheetRowModel();

            var firstCell = cells[0];

            model.Date = DateTime.Parse(firstCell.Content);
            model.Cells = cells.Skip(1).ToList();


            return model;
        }
    }
}
