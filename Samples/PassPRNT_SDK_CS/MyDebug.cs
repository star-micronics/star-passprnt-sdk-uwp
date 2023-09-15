using System.Diagnostics;

namespace PassPRNT_SDK_CS
{
    class MyDebug
    {
        static public void Console(
            [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0,
            [System.Runtime.CompilerServices.CallerMemberName] string memberName = "")
        {
#if DEBUG
            Debug.WriteLine(memberName + " (" + lineNumber + ") ");
#endif
        }

        static public void Console(int i,
            [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0,
            [System.Runtime.CompilerServices.CallerMemberName] string memberName = "")
        {
#if DEBUG
            Debug.WriteLine(memberName + " (" + lineNumber + ") " + i.ToString());
#endif
        }

        static public void Console(object obj,
            [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0,
            [System.Runtime.CompilerServices.CallerMemberName] string memberName = "")
        {
#if DEBUG
            Debug.WriteLine(memberName + " (" + lineNumber + ") " + obj.ToString());
#endif
        }

        static public void Console(string msg,
            [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0,
            [System.Runtime.CompilerServices.CallerMemberName] string memberName = "")
        {
#if DEBUG
            Debug.WriteLine(memberName + " (" + lineNumber + ") " + msg);
#endif
        }
    }
}
