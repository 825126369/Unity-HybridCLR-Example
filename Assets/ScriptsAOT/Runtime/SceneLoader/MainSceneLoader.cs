using System.Collections;
using System.Reflection;
using UnityEngine;

public class MainSceneLoader : SingleTonMonoBehaviour<MainSceneLoader>
{
    //�ȼ��� dll
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

    //�ȼ��� dll, Ȼ��������Prefab�µ� �ű��Ż�����
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
