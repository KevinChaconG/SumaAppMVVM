using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SumaAppMVVM.ViewModels
{
    public partial class SumaAppViewModel : ObservableObject
    {
        [ObservableProperty]
        private string num1;

        [ObservableProperty]
        private string num2;

        [ObservableProperty]
        private string resultado;

        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }

        [RelayCommand]
        private void Calcular()
        {
            resultado = $"$Texto: {num1}"; // Interpolación de cadenas


        }

        [RelayCommand]
        public void Limpiar()
        {
            num1 = "";
            num2 = "";
            resultado = "";
        }

    }
}
