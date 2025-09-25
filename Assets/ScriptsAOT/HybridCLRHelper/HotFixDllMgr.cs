using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using UnityEngine;

public class HotFixDllMgr : SingleTonMonoBehaviour<HotFixDllMgr>
{
    public CommonResSerialization mCommonResSerialization;

    public IEnumerator Init()
    {
        string assetPath = "Assets/ResourceABs/ScriptsRef.prefab";
        yield return AssetsLoader.Instance.AsyncLoadSingleAsset(assetPath);
        GameObject go = AssetsLoader.Instance.GetAsset(assetPath) as GameObject;
        mCommonResSerialization = go.GetComponent<CommonResSerialization>();
    }

    public void LoadDll(string name)
    {
        var mText1 = mCommonResSerialization.FindTextAsset(name + "dll.txt");
        var mText2 = mCommonResSerialization.FindTextAsset(name + "pdb.txt");
        byte[] assData2 = mText1.bytes;
        byte[] pdbData2 = mText2.bytes;
        Assembly.Load(assData2, pdbData2);
    }

    public static void Func1()
    {
#if !UNITY_EDITOR
        Assembly hotUpdateAss = Assembly.Load(File.ReadAllBytes($"{Application.streamingAssetsPath}/ScriptsHotFix.dll.bytes"));
#else
        Assembly hotUpdateAss = System.AppDomain.CurrentDomain.GetAssemblies().First(a => a.GetName().Name == "ScriptsHotFix");
#endif

        Type type = hotUpdateAss.GetType("Hello");
        type.GetMethod("Run").Invoke(null, null);
    }
}
