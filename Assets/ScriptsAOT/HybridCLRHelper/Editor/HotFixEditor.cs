using UnityEngine;
using System.IO;
using UnityEditor;
using System.Collections.Generic;

public static class HotFixEditor
{
    [InitializeOnLoadMethod]
    static void CopyDll()
    {
        List<string> HotFixList = new List<string>()
        {
            "ScriptsHotFix", "ScriptsHotFix_InitScene"
        };
        
        foreach (string name in HotFixList)
        {
            string oriDllPath = $"Library/ScriptAssemblies/{name}.dll";
            string targetDll = $"Assets/HotFixScriptsRes/{name}.dll.txt";
            File.Copy(oriDllPath, targetDll, true);

            string oriPdbPath = $"Library/ScriptAssemblies/{name}.pdb";
            string targetPdbPath = $"Assets/HotFixScriptsRes/{name}.pdb.txt";
            File.Copy(oriPdbPath, targetPdbPath, true);
        }

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
        Debug.Log("Copy HotFix Dll");
    }
}
