using UnityEngine;
using System.IO;
using UnityEditor;

public class HotFixEditor
{
    [InitializeOnLoadMethod]
    static void CopyDll()
    {
        string oriDllPath = "Library/ScriptAssemblies/ScriptsHotFix.dll";
        string targetDll = "Assets/ResourcesAB/ScriptsHotFix.dll.txt";
        File.Copy(oriDllPath, targetDll, true);
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
        Debug.Log("Copy HotFix Dll");
    }
}
