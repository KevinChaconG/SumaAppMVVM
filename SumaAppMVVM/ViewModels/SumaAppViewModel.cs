using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SumaAppMVVM.ViewModels
{
    public partial class SumaAppViewModel : ObservableObject
    {
        [ObservableProperty]
        private double num1;

        [ObservableProperty]
        private double num2;

        [ObservableProperty]
        private double resultado;

        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }

        [RelayCommand]
        private void Calcular()
        {
            Alerta("Operacion", "Se ejecutó el comando Calcular");
            resultado = num1 + num2;

        }

        [RelayCommand]
        private void Limpiar()
        {
            Alerta("Operacion", "Se ejecutó el comando Limpiar");
            num1 = 0;
            num2 = 0;
            resultado = 0;
        }

    }
}
