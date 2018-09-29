using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.BL.Extensions;
using Tasker.Models.Pub;

namespace Tasker.BL.Factories
{
    public class SheetCellModelFactory
    {
        public SheetCellModelFactory(SheetHeaderModelFactory sheetHeaderModelFactory)
        {
            SheetHeaderModelFactory = sheetHeaderModelFactory;
        }

        private SheetHeaderModelFactory SheetHeaderModelFactory { get; }

        private SheetCellModel Create(SheetHeaderModel header, string content, int rowIndex)
        {
            var model = new SheetCellModel
            {
                Header = header,
                Content = content,
                CellIndex = CellIndexModelFactory.Create(header.CellIndex.Column, rowIndex)
            };

            return model;
        }

        public IList<SheetCellModel> Create(IList<string> columns, IList<SheetHeaderModel> headers, int rowIndex)
        {
            var models = new List<SheetCellModel>();

            for (int i = 0; i < headers.Count; i++)
            {
                var header = headers[i];

                var model = Create(header, columns[i], rowIndex);

                models.Add(model);
            }            

            return models;
        }
    }
}
