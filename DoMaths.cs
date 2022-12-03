namespace MathsProject
{
    public static class Maths
    {
        public static double FindMin(double _number1, double _number2)
        {
            if (_number1 < _number2)
                return _number1;
            else
                return _number2;
        }
        public static double FindMax(double _number1, double _number2)
        {
            if (_number1 > _number2)
                return _number1;
            else
                return _number2;
        }
        public static uint DoFactorial(uint _number)
        {
            if (_number == 0)
                return 1;
            else
                return _number * DoFactorial(_number - 1);
        }
        public static double[] DoSort(params double[] _numbers)
        {
            int min;
            double temp;
            for (int i = 0; i < _numbers.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < _numbers.Length; j++)
                {
                    if (_numbers[min] > _numbers[j])
                    {
                        min = j;
                    }
                }
                temp = _numbers[min];
                _numbers[min] = _numbers[i];
                _numbers[i] = temp;
            }
            return _numbers;
        }
    }
}
