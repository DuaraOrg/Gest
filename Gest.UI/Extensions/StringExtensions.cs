namespace Gest.UI.Extensions
{
    public  static class StringExtensions
    {
        public static string ToAvatar(this string text)
        {
            var words = text.Split(' ');
            if(words.Count() > 1)
                return $"{words[0][0]}{words[1][0]}";
            return $"{text[0]}{text[1]}";
        }
    }
}
