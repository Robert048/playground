using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Gegevens van de machines -> DropDown
namespace dsm
{
    public class DataTemplate
    {
        int id;
        DataRow dataRow;

        public DataTemplate(DataRow dataRow, int id)
        {
            this.dataRow = dataRow;
            this.id = id;
        }

        public DataRow getDataRow() {
            return dataRow;
        }

        public int getId()
        {
            return id;
        }

        public List<string[]> getData()
        {
            List<string[]> info = new List<string[]>();
            for (int i = 0; i < dataRow.Table.Columns.Count; i++) {
                string[] item = new string[2];
                item[0] = dataRow.Table.Columns[i].ColumnName;
                item[1] = dataRow.ItemArray[i].ToString();
                info.Add(item);
            }
            return info;
        }
    }
}
