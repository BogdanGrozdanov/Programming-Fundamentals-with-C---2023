namespace MovingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sequenceOftarget = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> comand = Console.ReadLine().Split().ToList();
            comand = MoveTargetLogic(sequenceOftarget, comand);
        }

        static List<string> MoveTargetLogic(List<int> sequenceOftarget, List<string> comand)
        {
            while (comand[0].ToLower() != "end")
            {
                string action = comand[0];
                int index = int.Parse(comand[1]);
                int value = int.Parse(comand[2]);
                if (action.ToLower() == "shoot")
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
                else if (action.ToLower() == "add")
                {
                    if (index < sequenceOftarget.Count)
                    {
                        sequenceOftarget.Insert(index, value);
                    }
                    else { Console.WriteLine("Invalid placement!"); }
                }
                else if (action.ToLower() == "strike")
                {
                    if ((index - value) >= 0 && (index + value) < sequenceOftarget.Count - 1)
                    {
                        sequenceOftarget.RemoveRange(index - value, (value * 2) + 1);
                    }
                    else { Console.WriteLine("Strike missed!"); }
                }
                comand = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join("|", sequenceOftarget));
            return comand;
        }
    }
}