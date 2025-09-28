using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class GameLauncher : SingleTonMonoBehaviour<GameLauncher>
{
    public bool bPrintLog = true;
    public GameObject DebugObj;
    
    private void Start()
    {
        DontDestroyOnLoad(this);
        Debug.unityLogger.logEnabled = bPrintLog;
        DebugObj.SetActive(bPrintLog && GameConst.isMobilePlatform());
        Application.runInBackground = !GameConst.isMobilePlatform();
        Application.targetFrameRate = 60;
        LeanTween.init();
        UnityMainThreadDispatcher.Instance.Init();

        //LoadMetadataForAOTAssemblies();
        StartCoroutine(StartInitSystem());
    }

    // Application.runInBackground = true; 这个API 会影响 这个函数的调用
	void OnApplicationPause(bool bPause)
	{
		Debug.Log("GameLauncher OnApplicationPause: " + bPause);
	}

    private IEnumerator StartInitSystem()
    {
        if (GameConst.orUseAssetBundle())
        {
            if (GameConst.bHotUpdate)
            {
                yield return AddressablesRedirectManager.Do();
            }
            yield return Addressables.InitializeAsync();;
            yield return AssetsLoader.Instance.AsyncLoadManyAssetsByLabel("InitScene");
        }

        yield return InitSceneLoader.Instance.Init();
    }

    public void OnHotUpdateFinish()
    {
        StartCoroutine(StartLoadMainScript());
    }
    
    public IEnumerator StartLoadMainScript()
    {
        yield return 0;
        //yield return ResCenter.Instance.AsyncInit();
        yield return MainSceneLoader.Instance.Init();
        MainSceneLoader.Instance.LoadScene();
    }

    //private static void LoadMetadataForAOTAssemblies()
    //{
    //    /// 注意，补充元数据是给AOT dll补充元数据，而不是给热更新dll补充元数据。
    //    /// 热更新dll不缺元数据，不需要补充，如果调用LoadMetadataForAOTAssembly会返回错误
    //    /// 
    //    HomologousImageMode mode = HomologousImageMode.SuperSet;
    //    foreach (var aotDllName in AOTMetaAssemblyFiles)
    //    {
    //        byte[] dllBytes = ReadBytesFromStreamingAssets(aotDllName);
    //        // 加载assembly对应的dll，会自动为它hook。一旦aot泛型函数的native函数不存在，用解释器版本代码
    //        LoadImageErrorCode err = RuntimeApi.LoadMetadataForAOTAssembly(dllBytes, mode);
    //        Debug.Log($"LoadMetadataForAOTAssembly:{aotDllName}. mode:{mode} ret:{err}");
    //    }
    //}
}
