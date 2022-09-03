using SQLiteDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SQLiteDemo.Services
{
    public interface ISedeService
    {
        Task<List<SedeModel>> GetSedeList();
        Task<int> AddSede(SedeModel sedeModel);
        Task<int> DeleteSede(SedeModel sedeModel);
        Task<int> UpdateSede(SedeModel sedeModel);
    }
}
