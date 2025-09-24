using System.IO;
using UnityEditor;
using UnityEditor.U2D;
using UnityEngine;
using UnityEngine.U2D;

public class AtlasPackerByFolderEditor
{
    [MenuItem("Assets/导出 Atlas Script")]
    static void DoAtlas()
    {
        foreach (var obj in Selection.objects)
        {
            string selectionPath = AssetDatabase.GetAssetPath(obj);
            DoPackerBySelectionPath(selectionPath);
        }

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }

    public static void DoGenScript(SpriteAtlas obj)
    {
        if (obj == null) return;

        string path = AssetDatabase.GetAssetPath(obj);
        string targetDir = Path.GetDirectoryName(path);
        string outPath = Path.Combine(targetDir, obj.name + ".prefab");

        GameObject go = new GameObject();
        AtlasSpriteSheet mScript = go.AddComponent<AtlasSpriteSheet>();
        mScript.mSpriteAtlas = obj as SpriteAtlas;
        PrefabUtility.SaveAsPrefabAsset(go, outPath);
        UnityEngine.Object.DestroyImmediate(go);

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }

    private static void DoPackerBySelectionPath(string selectionPath)
    {
        if (Directory.Exists(selectionPath))
        {
            string resDirPath = selectionPath;
            string atlasDir = FileToolEditor.GetDirParentDir(resDirPath);
            DoPackerByFolder1(atlasDir, resDirPath);
        }
        else
        {
            var obj = AssetDatabase.LoadAssetAtPath<SpriteAtlas>(selectionPath);
            DoGenScript(obj);
        }
    }

    private static void DoPackerByFolder1(string atlasDir, string resDir)
    {
        TextureToSpriteEditor.DoFolder(resDir);
        SpriteAtlas mAtlas = CreateSpriteAtlas(atlasDir, resDir);
        DoGenScript(mAtlas);
    }
    
    private static SpriteAtlas CreateSpriteAtlas(string atlasDir, string resDir)
    {
        string name = FileToolEditor.GetDirName(resDir);
        string outPath = Path.Combine(atlasDir, name + GameConst.spriteAtlasExtention);
        SpriteAtlasAsset mSpriteAtlasAsset = SpriteAtlasAsset.Load(outPath);
        if(mSpriteAtlasAsset == null)
        {
            mSpriteAtlasAsset = new SpriteAtlasAsset();
            mSpriteAtlasAsset.name = name;
            var mFolderAssets = AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(resDir);
            mSpriteAtlasAsset.Add(new UnityEngine.Object[] { mFolderAssets });
            SpriteAtlasAsset.Save(mSpriteAtlasAsset, outPath);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }
        
        return AssetDatabase.LoadAssetAtPath<SpriteAtlas>(outPath);
    }
}