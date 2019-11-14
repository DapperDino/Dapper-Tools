using UnityEngine;

namespace DapperDino.DapperTools.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Return the text ready to be displayed on the UI as the supplied colour
        /// </summary>
        /// <param name="text"></param>
        /// <param name="colour"></param>
        /// <returns></returns>
        public static string WithColour(this string text, Color colour)
        {
            return $"<color=#{ColorUtility.ToHtmlStringRGB(colour)}>{text}</color>";
        }
    }
}
