using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GurinchukAV.Sprint6.Task6.V2.Lib
{
    public class DataService : ISprint6Task6V2
    {
        public string CollectTextFromFile(string path)
        {
            string stringValues = File.ReadAllText(path); //взяли путь
            string result = "";

            // Разделяем строку на отдельные строки по символу новой строки
            string[] lines = stringValues.Split(new[] { '\n' }, StringSplitOptions.None);

            foreach (string line in lines)
            {
                // Разделяем строку на слова по пробелам
                string[] words = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // Проверяем, что есть хотя бы два слова, и добавляем второе в результат
                if (words.Length >= 2)
                {
                    result += words[1] + " ";
                }
            }
            return result.TrimEnd();
        }
    }
}