using Caliburn.Micro;

namespace CaliburnMicro_Calculator.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        public ShellViewModel()
        {
        }
        public void ShowCalculator()
        {
            ActivateItemAsync(new CalculatorViewModel());
        }

    }

}