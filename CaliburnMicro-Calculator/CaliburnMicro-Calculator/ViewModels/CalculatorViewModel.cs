using System.ComponentModel;
using System.Threading;
using System.Windows;
using Caliburn.Micro;

namespace CaliburnMicro_Calculator.ViewModels
{
    public class CalculatorViewModel: Screen, INotifyPropertyChanged
    {

        private int _left;
        private int _right;
        private int _result;

        public int Left
        {
            get { return _left; }
            set
            {
                _left = value;
                NotifyOfPropertyChange();
            }
        }

        public int Right
        {
            get { return _right; }
            set
            {
                _right = value;
                NotifyOfPropertyChange();
            }
        }

        public int Result
        {
            get { return _result; }
            set
            {
                _result = value;
                NotifyOfPropertyChange();
            }
        }
   
        public bool CanDivide(int left, int right)
        {
            return right != 0;
        }

        public void Divide(int left, int right, int sys_o, int sys_t)
        {
            Thread.Sleep(600);
            if (CanDivide(left, right) == true)
            {
                Result = ConvertToSys(left, sys_o) / ConvertToSys(right, sys_t);
                string Result_copy = System.Convert.ToString(Result);
                Result_copy = System.Convert.ToString(Result, 10);
                Result = System.Convert.ToInt32(Result_copy);
            }
            else MessageBox.Show("Divider cannot be zero.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        public void Plus(int left, int right, int sys_o, int sys_t)
        {
            Result = ConvertToSys(left, sys_o) + ConvertToSys(right, sys_t);
            string Result_copy = System.Convert.ToString(Result);
            Result = System.Convert.ToInt32(Result_copy);
        }

        public void Minus(int left, int right, int sys_o, int sys_t)
        {
            Result = ConvertToSys(left, sys_o) - ConvertToSys(right, sys_t);
            string Result_copy = System.Convert.ToString(Result);
            Result_copy = System.Convert.ToString(Result, 10);
            Result = System.Convert.ToInt32(Result_copy);
        }

        public void Multipy(int left, int right, int sys_o, int sys_t)
        {
            Result = ConvertToSys(left, sys_o) * ConvertToSys(right, sys_t);
            string Result_copy = System.Convert.ToString(Result);
            Result_copy = System.Convert.ToString(Result, 10);
            Result = System.Convert.ToInt32(Result_copy);
        }
        public int ConvertToSys(int take, int sys)
        {
            string res = System.Convert.ToString(take, sys);
            //Берет take в системе счисления и переводит в систему 10
            try { return System.Convert.ToInt32(res); } catch { return System.Convert.ToInt32(res); }
        }

    }
}