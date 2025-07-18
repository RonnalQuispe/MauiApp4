﻿using System.Threading.Tasks;
using MauiApp4.Repositories;
using MauiApp4.Repositories;

namespace MauiApp4
{
    public partial class MainPage : ContentPage
    {
        private FilesRepository _filesRepository;

        public MainPage()
        {
            _filesRepository = new FilesRepository();
            InitializeComponent();
            CargarInformacionArchivo();
        }

        private async Task CargarInformacionArchivo()
        {
            // Llamada correcta al método DevuelveInformacionArchivo() con paréntesis
            string texto = await _filesRepository.DevuelveInformacionArchivoAsync();
            LabelArchivo.Text = texto;
        }

        private async void BtnGuardarArchivo_Clicked(object sender, EventArgs e)
        {
            string texto = TxtArchivo.Text;
            await _filesRepository.GenerarArchivoAsync(texto);
            await CargarInformacionArchivo();
        }

    }
}
