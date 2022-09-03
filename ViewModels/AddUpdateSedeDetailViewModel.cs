using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using SQLiteDemo.Models;
using SQLiteDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SQLiteDemo.ViewModels
{
    [QueryProperty(nameof(SedeDetail), "SedeDetail")]
    public partial class AddUpdateSedeDetailViewModel : ObservableObject
    {
        [ObservableProperty]
        private SedeModel _sedeDetail = new SedeModel();

        private readonly ISedeService _sedeService;
        public AddUpdateSedeDetailViewModel(ISedeService sedeService)
        {
            _sedeService = sedeService;
        }

        [ICommand]
        public async void AddUpdateSede()
        {
            int response = -1;
            if (SedeDetail.SedeID > 0)
            {
                response = await _sedeService.UpdateSede(SedeDetail);
            }
            else
            {
                response = await _sedeService.AddSede(new Models.SedeModel
                {

                    NomSede = SedeDetail.NomSede,
                    
                });
            }

        

            if (response > 0)
            {
                await Shell.Current.DisplayAlert("Registro Guardado Exitosamente", "Guardado", "Aceptar");
            }
            else
            {
                await Shell.Current.DisplayAlert("Error!", "El registro no fue guardado", "Aceptar");
            }
        }

    }
}
