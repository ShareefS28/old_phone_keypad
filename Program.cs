// See https://aka.ms/new-console-template for more information
using src.padkey;

class Program
{
    static void Main()
    {
        List<string> keyword = new List<string>
        {
            "33#",
            "227*#",
            "4433555 555666#",
            "8 88777444666*664#",
            "3",
            "3#",
            "4433555 #555666#",
            "123*456",
            "443355555566696667775553#",
            "4433555 55566600096667775553#",
            "4433555 555666000*96667775553#",
            "4433555 555666000**96667775553#",
            "3 33 333 3333 33333 333333#",
            "9 99 999 9999 99999 999999 9999999 99999999#",
            "4433555 555666000 * *     * 96667775553#"
        };

        foreach (string value in keyword)
        {
            string result = phone3310.OldPhonePad(value);
            Console.WriteLine(result);   
        }
    }
}