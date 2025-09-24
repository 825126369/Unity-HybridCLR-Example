using UnityEngine;
using System.IO;
using UnityEditor;

public class HotFixEditor
{
    [InitializeOnLoadMethod]
    static void CopyDll()
    {
        string oriDllPath = "Library/ScriptAssemblies/HotFixScript.dll";
        string targetDll = "Assets/ResourcesAB/HotFixScript.dll.txt";
        File.Copy(oriDllPath, targetDll, true);
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
        Debug.Log("CopyDll");
    }
}
