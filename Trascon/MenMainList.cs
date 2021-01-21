using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Windows;
using Trascon.Models;

namespace Trascon
{
    public class MenMainList 
    {
        private DataTable _dt;

        public MenMainList()
        {
            _dt = new XLSAdapter(@"C:\List.xls").GetAllData();
        }

        public List<Man> GetAll()
        {
            List<Man> men = new List<Man> { };

            for (int currRow = 0; currRow < _dt.Rows.Count; currRow++)
                men.Add(new Man
                { Name = Convert.ToString(_dt.Rows[currRow][0]),
                  Jump = Convert.ToUInt32(_dt.Rows[currRow][1]),
                  Flex = Convert.ToInt32(_dt.Rows[currRow][2]),
                  Push = Convert.ToUInt32(_dt.Rows[currRow][3]),
                  Group = Convert.ToInt32(_dt.Rows[currRow][4]),
                  Medal = Convert.ToInt32(_dt.Rows[currRow][5])
                });
            return men;
        }
    }
}
