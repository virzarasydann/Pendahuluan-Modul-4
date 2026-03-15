using System;
using System.Collections.Generic;
using System.Text;

namespace tpModul4_103082400034
{
    internal class DoorMachine
    {
        enum State  {TERKUNCI, TERBUKA, EXIT};

        public static void AutomataDriven()
        {

            State state = State.TERKUNCI;
            string[] sreenName = { "TERKUNCI", "TERBUKA",  "EXIT" };

            while (state != State.EXIT)
            {

                Console.Clear();
                Console.WriteLine($"State Sekarang : " + sreenName[(int)state]);

                Console.Write("Input Command : ");

                string command = Console.ReadLine();
                switch (state)
                {

                    case State.TERKUNCI:
                        if (command == "KUNCI")
                        {
                            state = State.TERKUNCI;
                            Console.Write("Pintu Terkunci");
                        }
                        else if (command == "BUKA")
                        {
                            state = State.TERBUKA;
                            Console.Write("Pintu Terbuka");
                        }
                        else  
                            state = State.EXIT;
                        break;
                    case State.TERBUKA:
                        if (command == "KUNCI")
                        {
                            state = State.TERKUNCI;
                            Console.Write("Pintu Terkunci");
                        }
                        else
                            state = State.EXIT;
                        break;
                   


                }

            }

            Console.WriteLine("EXIT SCREEN");
        }
    }

}

