namespace SchoolTask
{
    internal class NumberSchool
    {
       public enum allBases
        {
            Bin,
            Dec,
            Hex
        }
        public int value;
        public NumberSchool(int inValue)
        {
            value = inValue;
        }
        public NumberSchool(string inValue, allBases bases)
        {
            switch (bases){
                case allBases.Bin: value = Convert.ToInt32(inValue, 2); break;
                case allBases.Dec: value = Convert.ToInt32(inValue, 10); break;
				case allBases.Hex: value = Convert.ToInt32(inValue, 16); break;
                default:
                    Console.WriteLine("INCOMPATIBLE BASE AT NumberSchool()");
                    break;
			}
        }
        public string Bin()
        {
            int temp = value;
            // Handle the special case of 0
            if (temp == 0)
            {
                return "0";
            }

            string binary = "";

            // Process the number until it becomes 0
            while (temp > 0)
            {
                // Get the remainder (0 or 1) and add it to the binary string
                int remainder = temp % 2;
                binary = remainder + binary;

                // Update the number by dividing it by 2
                temp /= 2;
            }

            return binary;
        }
		public string Hex()
		{
			return value.ToString("x4");
		}
	}
}
