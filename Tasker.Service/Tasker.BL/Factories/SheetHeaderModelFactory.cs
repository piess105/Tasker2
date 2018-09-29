using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.BL.Extensions;
using Tasker.Models.Pub;

namespace Tasker.BL.Factories
{
    public class SheetHeaderModelFactory
    {
        public IList<SheetHeaderModel> Create(IList<string> headerColumns)
        {
            var models = new List<SheetHeaderModel>();

            for (int i = 0; i < headerColumns.Count; i++)
            {
                var column = headerColumns[i];

                var model = Create(column, i + 1);

                models.Add(model);
            }

            return models;
        }

        private SheetHeaderModel Create(string name, int columnIndex)
        {
            var model = new SheetHeaderModel
            {
                Name = name,
                CellIndex = CellIndexModelFactory.Create(columnIndex, 1)
            };

            return model;
        }
    }
}
