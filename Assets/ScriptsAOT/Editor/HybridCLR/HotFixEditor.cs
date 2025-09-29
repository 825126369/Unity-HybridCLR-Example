using HybridCLR.Editor;
using HybridCLR.Editor.Commands;
using System.IO;
using UnityEditor;
using UnityEngine;

public static class HotFixEditor
{
    const string AOTOutDir = "Assets/ScriptsAOT/Runtime/Resources/AotDll/";
    const string HotFixOutDir = "Assets/HotFixScriptsRes/";

    //[InitializeOnLoadMethod]
    //static void CopyDll()
    //{
    //    List<string> HotFixList = new List<string>()
    //    {
    //        "ScriptsHotFix", "ScriptsHotFix_InitScene"
    //    };

    //    foreach (string name in HotFixList)
    //    {
    //        string oriDllPath = $"Library/ScriptAssemblies/{name}.dll";
    //        string targetDll = $"{HotFixOutDir}{name}.dll.txt";
    //        File.Copy(oriDllPath, targetDll, true);

    //        string oriPdbPath = $"Library/ScriptAssemblies/{name}.pdb";
    //        string targetPdbPath = $"{HotFixOutDir}{name}.pdb.txt";
    //        File.Copy(oriPdbPath, targetPdbPath, true);
    //    }

    //    AssetDatabase.SaveAssets();
    //    AssetDatabase.Refresh();
    //    Debug.Log("Copy HotFix Dll");
    //}

    [MenuItem("Tools/HotFix Dll Copy")]
    public static void BuildAndCopyABAOTHotUpdateDlls()
    {
        BuildTarget target = EditorUserBuildSettings.activeBuildTarget;
        CompileDllCommand.CompileDll(target);
        CopyABAOTHotUpdateDlls(target);
        AssetDatabase.Refresh();
        AssetDatabase.SaveAssets();
    }

    public static void CopyABAOTHotUpdateDlls(BuildTarget target)
    {
        CopyAOTAssembliesToResources();
        CopyHotUpdateAssemblies();
    }

    public static void CopyAOTAssembliesToResources()
    {
        var target = EditorUserBuildSettings.activeBuildTarget;
        string aotAssembliesSrcDir = SettingsUtil.GetAssembliesPostIl2CppStripDir(target);
        string aotAssembliesDstDir = AOTOutDir;

        foreach (var dll in SettingsUtil.AOTAssemblyNames)
        {
            string srcDllPath = $"{aotAssembliesSrcDir}/{dll}.dll";
            if (!File.Exists(srcDllPath))
            {
                Debug.LogError($"ab中添加AOT补充元数据dll:{srcDllPath} 时发生错误,文件不存在。裁剪后的AOT dll在BuildPlayer时才能生成，因此需要你先构建一次游戏App后再打包。");
                continue;
            }
            string dllBytesPath = $"{aotAssembliesDstDir}{dll}.dll.bytes";
            File.Copy(srcDllPath, dllBytesPath, true);
            Debug.Log($"[CopyAOTAssembliesToStreamingAssets] copy AOT dll {srcDllPath} -> {dllBytesPath}");
        }
    }

    public static void CopyHotUpdateAssemblies()
    {
        var target = EditorUserBuildSettings.activeBuildTarget;
        string hotfixDllSrcDir = SettingsUtil.GetHotUpdateDllsOutputDirByTarget(target);
        string hotfixAssembliesDstDir = HotFixOutDir;
        foreach (string dll in SettingsUtil.HotUpdateAssemblyFilesExcludePreserved)
        {
            string dllPath = $"{hotfixDllSrcDir}/{dll}";
            string dllBytesPath = $"{hotfixAssembliesDstDir}{dll}.bytes";
            File.Copy(dllPath, dllBytesPath, true);
            Debug.Log($"copy hotfix dll: {dllPath} -> {dllBytesPath}");

            string dllPdbPath = $"{hotfixDllSrcDir}/{Path.GetFileNameWithoutExtension(dll)}.pdb";
            string dllPdbPathOut = $"{hotfixAssembliesDstDir}{Path.GetFileNameWithoutExtension(dll)}.pdb.bytes";
            File.Copy(dllPdbPath, dllPdbPathOut, true);
            Debug.Log($"copy hotfix dll: {dllPdbPath} -> {dllPdbPathOut}");
        }
    }

}
