using System;
namespace Calculator
{
	public class Functions
	{
        int number1;
        int number2;

        //public Functions(int number1, int number2)
        //{
        //    this.number1 = number1;
        //    this.number2 = number2;
        //}

        public void SetNumber1(int number)
        {
            this.number1 = number;
        }

        public void SetNumber2(int number)
        {
            this.number2 = number;
        }
        public int GetNumber1()
        {
            return this.number1;
        }


        public int GetNumber2()
        {
            return this.number2;
        }

        public int Add()
		{
			return this.number1 + this.number2;
        }

		public int Sub()
		{
            return this.number1 - this.number2;
        }

        public int Mult()
        {
            return this.number1 * this.number2;
        }
    }
}

