
using SQLite;
using SQLiteDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDemo.Services
{
    public class SedeService : ISedeService
    {
        private SQLiteAsyncConnection _dbConnection;

        private async Task SetUpDb()
        {
            if (_dbConnection == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Student.db3");
                _dbConnection = new SQLiteAsyncConnection(dbPath);
                await _dbConnection.CreateTableAsync<SedeModel>();
            }
        }

        public async Task<int> AddSede(SedeModel sedeModel)
        {
            await SetUpDb();
            return await _dbConnection.InsertAsync(sedeModel);
        }

        public async Task<int> DeleteSede(SedeModel sedeModel)
        {
            await SetUpDb();
            return await _dbConnection.DeleteAsync(sedeModel);
        }

        public async Task<List<SedeModel>> GetSedeList()
        {
            await SetUpDb();
            var sedeList = await _dbConnection.Table<SedeModel>().ToListAsync();
            return sedeList;
        }

        public async Task<int> UpdateSede(SedeModel sedeModel)
        {
            await SetUpDb();
            return await _dbConnection.UpdateAsync(sedeModel);
        }
    }
}