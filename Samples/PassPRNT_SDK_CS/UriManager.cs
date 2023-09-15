using System;

namespace PassPRNT_SDK_CS
{
    public class UriManager
    {
        static public string UriEncode(string str)
        {
            string encode = "";
            try
            {
                encode = System.Uri.EscapeDataString(str);
            }
            catch (UriFormatException e)
            {
                MyDebug.Console(e.Message);
            }
            catch (ArgumentNullException e)
            {
                MyDebug.Console(e.Message);
            }
            return encode;
        }

        static public string UriDecode(string str)
        {
            return System.Net.WebUtility.UrlDecode(str);
        }
    }
}
