namespace MovingTarget
{
    internal class Program
    {/*
      52 74 23 44 96 110
      Shoot 5 10
      Shoot 1 80
      Strike 2 1
      Add 22 3
      End
      
      */
        static void Main(string[] args)
        {
            List<int> sequenceOftarget = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> comand = Console.ReadLine().Split().ToList();

            

            while (comand[0] != "End")
            {
                string action = comand[0];
                int index = int.Parse(comand[1]);
                int value = int.Parse(comand[2]);
                if (action == "Shoot")
                {
                    if (index < sequenceOftarget.Count)
                    {
                        sequenceOftarget[index] -= value;
                        if (sequenceOftarget[index] <= 0)
                        {
                            sequenceOftarget.RemoveAt(index);
                        }

                    }
                }
                else if (action == "Add")
                {
                    if (index < sequenceOftarget.Count)
                    {
                        sequenceOftarget.Insert(index, value);
                    }
                    else { Console.WriteLine("Invalid placement!"); }
                }
                else if (action == "Strike")
                {
                    if ((index - value) >= 0 && (index + value) < sequenceOftarget.Count - 1)
                    {
                        sequenceOftarget.RemoveRange(index - value, (value * 2)+1 );
                    }
                    else { Console.WriteLine("Strike missed!"); }
                }
                comand = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join("|", sequenceOftarget));
        }
    }
}