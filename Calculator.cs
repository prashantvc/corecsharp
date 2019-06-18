namespace MyPackage
{
    class Calculator
    {
        private int result;
        // 1 + 1 = 2
        public int Add(int number1, int number2){
            result = number1 + number2;
            return result;
        }

        public int Add(int number1){
            result = result + number1;
            return result;
        }
        
        public int Substract(int number1, int number2){
            return number1 + number2;
        }
    }
}