using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System.Collections.Generic;

namespace PassPRNT_SDK_CS_Test
{
    [TestClass]
    public class UriManagerTest
    {
        static List<string> asciiList = new List<string> {
            "\x20", "\x21", "\x22", "\x23", "\x24", "\x25", "\x26", "\x27", "\x28", "\x29", "\x2a", "\x2b", "\x2c", "\x2d", "\x2e", "\x2f",
            "\x30", "\x31", "\x32", "\x33", "\x34", "\x35", "\x36", "\x37", "\x38", "\x39", "\x3a", "\x3b", "\x3c", "\x3d", "\x3e", "\x3f",
            "\x40", "\x41", "\x42", "\x43", "\x44", "\x45", "\x46", "\x47", "\x48", "\x49", "\x4a", "\x4b", "\x4c", "\x4d", "\x4e", "\x4f",
            "\x50", "\x51", "\x52", "\x53", "\x54", "\x55", "\x56", "\x57", "\x58", "\x59", "\x5a", "\x5b", "\x5c", "\x5d", "\x5e", "\x5f",
            "\x60", "\x61", "\x62", "\x63", "\x64", "\x65", "\x66", "\x67", "\x68", "\x69", "\x6a", "\x6b", "\x6c", "\x6d", "\x6e", "\x6f",
            "\x70", "\x71", "\x72", "\x73", "\x74", "\x75", "\x76", "\x77", "\x78", "\x79", "\x7a", "\x7b", "\x7c", "\x7d", "\x7e", "\x7f",
        };
        static List<string> encodedResultList = new List<string>
        {
            "%20", "%21", "%22", "%23", "%24", "%25", "%26", "%27", "%28", "%29", "%2A", "%2B", "%2C", "-",   ".",   "%2F",
            "0",   "1",   "2",   "3",   "4",   "5",   "6",   "7",   "8",   "9",   "%3A", "%3B", "%3C", "%3D", "%3E", "%3F",
            "%40", "A",   "B",   "C",   "D",   "E",   "F",   "G",   "H",   "I",   "J",   "K",   "L",   "M",   "N",   "O",
            "P",   "Q",   "R",   "S",   "T",   "U",   "V",   "W",   "X",   "Y",   "Z",   "%5B", "%5C", "%5D", "%5E", "_",
            "%60", "a",   "b",   "c",   "d",   "e",   "f",   "g",   "h",   "i",   "j",   "k",   "l",   "m",   "n",   "o",
            "p",   "q",   "r",   "s",   "t",   "u",   "v",   "w",   "x",   "y",   "z",   "%7B", "%7C", "%7D", "~",   "%7F",
        };
        static byte[] byteArray = {
            0x20, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x27, 0x28, 0x29, 0x2a, 0x2b, 0x2c, 0x2d, 0x2e, 0x2f,
            0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39, 0x3a, 0x3b, 0x3c, 0x3d, 0x3e, 0x3f,
            0x40, 0x41, 0x42, 0x43, 0x44, 0x45, 0x46, 0x47, 0x48, 0x49, 0x4a, 0x4b, 0x4c, 0x4d, 0x4e, 0x4f,
            0x50, 0x51, 0x52, 0x53, 0x54, 0x55, 0x56, 0x57, 0x58, 0x59, 0x5a, 0x5b, 0x5c, 0x5d, 0x5e, 0x5f,
            0x60, 0x61, 0x62, 0x63, 0x64, 0x65, 0x66, 0x67, 0x68, 0x69, 0x6a, 0x6b, 0x6c, 0x6d, 0x6e, 0x6f,
            0x70, 0x71, 0x72, 0x73, 0x74, 0x75, 0x76, 0x77, 0x78, 0x79, 0x7a, 0x7b, 0x7c, 0x7d, 0x7e, 0x7f,
        };

        [TestMethod]
        public void EncodeTest()
        {
            for(int i = 0; i < asciiList.Count; i++)
            {
                string encodedResult = PassPRNT_SDK_CS.UriManager.UriEncode(asciiList[i]);
                string compareString = encodedResultList[i];

                Assert.AreEqual(compareString, encodedResult, true, "Fail: Unexpected encode " + encodedResult + "-" + compareString);
            }
        }

        [TestMethod]
        public void DecodeTest()
        {
            for (int i = 0; i < asciiList.Count; i++)
            {
                string decodedResult = PassPRNT_SDK_CS.UriManager.UriDecode(encodedResultList[i]);
                string compareString = asciiList[i];

                Assert.AreEqual(compareString, decodedResult, true, "Fail: Unexpected decode character " + decodedResult + "-" + compareString);
            }
        }
    }
}
