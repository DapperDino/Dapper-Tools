using UnityEngine;

namespace DapperDino.DapperTools
{
    public static class StringExtensions
    {
        public static string AsColour(this string text, Color colour)
        {
            return $"<color=#{ColorUtility.ToHtmlStringRGB(colour)}>{text}</color>";
        }
    }
}
