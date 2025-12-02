namespace Performer
{
    public class Program
    {
        public static void Main()
        {
            int symbol_counter = 0;
            int spaces_counter = 0;
            int names = 0;
            string[] dirty_names = ["иванов иван", "петров петр", " сидорова Анна", " бобров БОРИС "];
            Console.Write("Исходная строка: ");
            foreach (string name in dirty_names )
            {
                Console.Write(name+",");
            }
            
            Console.WriteLine("Отформатированный список:");
            foreach (string name in dirty_names )
            {
                string result_name = "";
                foreach (char symbol in name)
                {
                    if (symbol == ' ' && symbol_counter > 0 && spaces_counter < 1)
                    {
                        result_name += symbol;
                        spaces_counter++;
                        symbol_counter = 0;
                    }
                    if (symbol != ' ' && symbol_counter == 0)
                    {
                        result_name += symbol.ToString().ToUpper();
                        symbol_counter++;
                    }
                    else if (symbol != ' ' && symbol_counter > 0)
                    {
                        result_name += symbol.ToString().ToLower();
                        symbol_counter++;
                    }
                }
                names++;
                Console.Write($"\n{names}. {result_name}");
                symbol_counter = 0;
                spaces_counter = 0;
            }
        }
    }
}