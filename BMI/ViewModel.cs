using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BMI
{
    internal partial class ViewModel: ObservableObject
    {
        private Model _model;

        [ObservableProperty]
        private double _feetHeight;

        [ObservableProperty]
        private double _poundsWeight;

        [ObservableProperty]
        private double _bmi;

        public ViewModel()
        {
            _model = new Model();
        }

        [RelayCommand]
        private void CalculateBMI()
        {
            double meterH = FeetHeight / 3.2808;
            double kgW = PoundsWeight / 2.2046;
            double originalBmi = _model.Calc(meterH, kgW);
            
            // Round the BMI to 2 decimal places
            Bmi = Math.Round(originalBmi, 2);
        }
    }
}
