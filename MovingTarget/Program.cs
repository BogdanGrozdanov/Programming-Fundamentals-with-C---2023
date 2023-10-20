namespace MovingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sequenceOftarget = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> comand = Console.ReadLine().Split().ToList();

            string action = comand[0];
            int index = int.Parse(comand[1]);
            int value = int.Parse(comand[2]);

            while (action != "end")
            {
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
                    if ((index - value) >= 0 && (index + value) <= sequenceOftarget.Count - 1)
                    {
                        sequenceOftarget.RemoveRange(index, value);
                        sequenceOftarget.RemoveAt(index + 1,);
                    }

                }
            }
        }
    }
}