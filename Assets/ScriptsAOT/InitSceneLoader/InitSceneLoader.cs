using System.Collections;
using System.Reflection;
using UnityEngine;

public class InitSceneLoader : SingleTonMonoBehaviour<InitSceneLoader>
{
    //先加载 dll
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
        Assembly.Load(assData2, pdbData2);
    }

    //先加载 dll, 然后挂在这个Prefab下的 脚本才会运行
    public void LoadInitScene()
    {
        var goPreafb = AssetsLoader.Instance.GetAsset("Assets/ResourceABs/InitScene/InitSceneEntry.prefab") as GameObject;
        var go = Instantiate<GameObject>(goPreafb);
        go.transform.position = Vector3.zero;
        go.transform.rotation = Quaternion.identity;
        go.transform.localScale = Vector3.one;
        go.SetActive(true);
    }

}
