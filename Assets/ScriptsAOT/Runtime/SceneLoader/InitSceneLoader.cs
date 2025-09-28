using System;
using System.Collections;
using System.Reflection;
using UnityEngine;

public class InitSceneLoader : SingleTonMonoBehaviour<InitSceneLoader>
{
    private Assembly mHotUpdateAssembly;
    private object mInitSceneMgr;
    //ох╪сть dll
    public IEnumerator Init()
    {
        string assetPath = "Assets/ResourceABs/InitScene/ScriptsRef.prefab";
        yield return AssetsLoader.Instance.AsyncLoadSingleAsset(assetPath);
        GameObject go = AssetsLoader.Instance.GetAsset(assetPath) as GameObject;
        var mCommonResSerialization = go.GetComponent<CommonResSerialization>();

        string dllName = "ScriptsHotFix_InitScene";
        var mText1 = mCommonResSerialization.FindTextAsset(dllName + ".dll");
        var mText2 = mCommonResSerialization.FindTextAsset(dllName + ".pdb");
        byte[] assData2 = mText1.bytes;
        byte[] pdbData2 = mText2.bytes;
        mHotUpdateAssembly = Assembly.Load(assData2, pdbData2);

        Type type = mHotUpdateAssembly.GetType("InitSceneMgr");
        mInitSceneMgr = Activator.CreateInstance(type);
        type.GetMethod("Start").Invoke(mInitSceneMgr, null);
    }

    public void UnLoad()
    {
        Type type = mHotUpdateAssembly.GetType("InitSceneMgr");
        type.GetMethod("UnLoad").Invoke(mInitSceneMgr, null);
        mInitSceneMgr = null;
        mHotUpdateAssembly = null;
        AssetsLoader.Instance.RemoveAssetByLabel("InitScene");
        Resources.UnloadUnusedAssets();
    }

}
