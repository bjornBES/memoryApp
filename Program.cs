using System;

namespace memory
{
    class Program
    {
        public int RamIndex;
        public string[] RamS = {
            "0", "0", "0", "0", "0", "0", "0", "0", "0", "0",
            "0", "0", "0", "0", "0", "0", "0", "0", "0", "0",
            "0", "0", "0", "0", "0", "0", "0", "0", "0", "0",
            "0", "0", "0", "0", "0", "0", "0", "0", "0", "0",
            "0", "0", "0", "0", "0", "0", "0", "0", "0", "0",
            "0", "0", "0", "0", "0", "0", "0", "0", "0", "0",
            "0", "0", "0", "0", "0", "0", "0", "0", "0", "0",
            "0", "0", "0", "0", "0", "0", "0", "0", "0", "0",
            "0", "0", "0", "0", "0", "0", "0", "0", "0", "0",
            "0", "0", "0", "0", "0", "0", "0", "0", "0", "0",
        };
        public int[ ] Ram = {
            0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,0,0,
        };
        public string[] Hex = new string[100];

        string[] Date = new string[6];
        int num = 2;
        static void Main(string[ ] args)
        {
            Console.WriteLine("Hello World!");
            Program program = new Program();
            program.start();
        }
        void start()
        {
            Date[0] = DateTime.Now.ToString("dd");
            Date[1] = DateTime.Now.ToString("MM");
            Date[2] = DateTime.Now.ToString("yy");
            Date[3] = DateTime.Now.ToString("HH");
            Date[4] = DateTime.Now.ToString("mm");
            Date[5] = DateTime.Now.ToString("ss");
            pointerText(0, "Time");
            pointer(1, Date[0]);
            pointer(2, Date[1]);
            pointer(3, Date[2]);
            pointer(4, Date[3]);
            pointer(5, Date[4]);
            pointer(6, Date[5]);
            for (int i = 0; i < Ram.Length; i++)
            {
                Hex[i] = Convert.ToString(Ram[i], 16);
                Console.WriteLine(Hex[i] + " "+ Ram[i]);
            }
        }
        void pointer(int index, object val)
        {
            Ram[index] = Convert.ToInt32(val);
        }
        void pointerText(int index, string val)
        {
            for (int i = 0; i < val.Length; i++)
            {
                switch (val[i])
                {
                    case 'A':
                        Ram[index] = Convert.ToInt32("65", 10);
                        break;
                    case 'B':
                        Ram[index] = Convert.ToInt32("66", 10);
                        break;
                    case 'C':
                        Ram[index] = Convert.ToInt32("67", 10);
                        break;
                    case 'D':
                        Ram[index] = Convert.ToInt32("68", 10);
                        break;
                    case 'E':
                        Ram[index] = Convert.ToInt32("69", 10);
                        break;
                    case 'F':
                        Ram[index] = Convert.ToInt32("70", 10);
                        break;
                }
            }
        }
    }
}
