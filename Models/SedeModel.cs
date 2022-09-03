using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDemo.Models
{
    public class SedeModel
    {
        [PrimaryKey, AutoIncrement]
        public int SedeID { get; set; }
        public string NomSede { get; set; }
      
    }
}

