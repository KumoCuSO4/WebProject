using UnityEditor;
using UnityEngine;

namespace Editor
{
    public class Test
    {
        [MenuItem("MyTools/Test")]
        static void OnClickTest()
        {
            Demo demo = new Demo();
            demo.Print();
        }
    }
}