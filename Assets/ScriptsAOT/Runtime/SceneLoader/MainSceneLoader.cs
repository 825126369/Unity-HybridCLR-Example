using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Unity.Entities;
using UnityEngine;

public class MainSceneLoader : SingleTonMonoBehaviour<MainSceneLoader>
{
    //先加载 dll
    public IEnumerator Init()
    {
        string assetPath = "Assets/ResourceABs/ThemePoker/ScriptsRef.prefab";
        yield return AssetsLoader.Instance.AsyncLoadSingleAsset(assetPath);
        GameObject go = AssetsLoader.Instance.GetAsset(assetPath) as GameObject;
        var mCommonResSerialization = go.GetComponent<CommonResSerialization>();

        string dllName = "ScriptsHotFix";
        var mText1 = mCommonResSerialization.FindTextAsset(dllName + ".dll");
        var mText2 = mCommonResSerialization.FindTextAsset(dllName + ".pdb");
        byte[] assData2 = mText1.bytes;
        byte[] pdbData2 = mText2.bytes;
        var A = Assembly.Load(assData2, pdbData2);

        //InitializeWorld(A);
    }

//    private static void InitializeWorld(params Assembly[] dotsAssemblies)
//    {
//#if !UNITY_EDITOR
//        // dotsAsseemblies为所有包含自定义Component、System等DOTS类型的AOT和热更新程序集
//        var componentTypes = new HashSet<Type>();
//        TypeManager.CollectComponentTypes(dotsAssemblies, componentTypes);
//        TypeManager.AddComponentTypes(dotsAssemblies, componentTypes);
//        TypeManager.RegisterSystemTypes(dotsAssemblies);
//        TypeManager.InitializeSharedStatics();
//        TypeManager.EarlyInitAssemblies(dotsAssemblies);
//#endif
//        DefaultWorldInitialization.Initialize("Default World", false);
//    }

    //先加载 dll, 然后挂在这个Prefab下的 脚本才会运行
    public void LoadScene()
    {
        SceneMgr.Instance.LoadSceneAsync("HotUpdate", (float fPercent)=>
        {
            Debug.Log("LoadScene: " + fPercent);
        },()=>
        {
            InitSceneLoader.readOnlyInstance.UnLoad();
        });
    }
}
