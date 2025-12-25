namespace src.padkey
{
    public class phone3310
    {
        private static Dictionary<char, List<char>> phoneKeys = new Dictionary<char, List<char>> {
            {'1', new List<char> {'&', (char)39, '('}},
            {'2', new List<char> {'A', 'B', 'C'}},
            {'3', new List<char> {'D', 'E', 'F'}},
            {'4', new List<char> {'G', 'H', 'I'}},
            {'5', new List<char> {'J', 'K', 'L'}},
            {'6', new List<char> {'M', 'N', 'O'}},
            {'7', new List<char> {'P', 'Q', 'R', 'S'}},
            {'8', new List<char> {'T', 'U', 'V'}},
            {'9', new List<char> {'W', 'X', 'Y', 'Z'}},
            {'0', new List<char> {(char)32}},
            {'*', new List<char> {(char)8}},
            {'#', new List<char> {(char)13}},
        };

        public static string OldPhonePad(string input)
        {

            string result = "";
            int count = 0;

            if (input.Last() != '#')
            {
                return "# should be on the last character";
            }
            
            for (int i=1; i<input.Length; i++)
            {

                if (input[i] == input[i - 1] && !"#0*".Contains(input[i]))
                {
                    count++;
                }
                else 
                {
                    if(input[i-1] == ' ') continue;

                    char prevKey = input[i - 1];

                    // Delete Key
                    if (prevKey == '*')
                    {
                        if (result.Length > 0) result = result.Substring(0, result.Length - 1);
                    }
                    else if (prevKey == '#')
                    {
                        break;
                    }
                    else
                    {
                        count = count % phoneKeys[prevKey].Count();
                        var letters = phoneKeys[prevKey][count];
                        result += letters;
                        count = 0;
                    }
                }
                
            }

            return result;
        }
    }
}