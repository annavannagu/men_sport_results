using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.IO;
using System.Windows;

namespace Trascon.Models
{
    class XLSAdapter
    {
        private string _connectionString;
        private OleDbDataAdapter _adapter = null;
        string _query = "Select * from [Лист1$]";


        public XLSAdapter (string file_name)
        {
            _connectionString = ConnectionString(file_name);
            try
            {
                ConfigureAdapter(out _adapter);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid file format", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            };

        }


        private void ConfigureAdapter(out OleDbDataAdapter adapter)
        {

            adapter = new OleDbDataAdapter(_query, _connectionString);
            var builder = new OleDbCommandBuilder(adapter);

        }


        public DataTable GetAllData()
        {
            DataTable tbl = new DataTable("Table");

            try
            {
                _adapter.Fill(tbl);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            };
            return tbl;
        }


        public string ConnectionString(string FileName)
        {
            OleDbConnectionStringBuilder builder = new OleDbConnectionStringBuilder();

            string ext = Path.GetExtension(FileName).ToLower();


            switch (ext)
            {
                case ".xls":
                    builder.Provider = "Microsoft.Jet.OLEDB.4.0";
                    builder.Add("Extended Properties", "Excel 8.0;IMEX=1;HDR=Yes;");
                    break;
                case ".xlsx":
                    builder.Provider = "Microsoft.ACE.OLEDB.12.0";
                    builder.Add("Extended Properties", "Excel 12.0 Xml;HDR=YES;");
                    break;
            }


            builder.DataSource = FileName;
            return builder.ConnectionString;
        }
    }
}
