using System.Collections;
using System.Net;
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
        Application.targetFrameRate = 30;
        LeanTween.init();
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
            yield return Addressables.InitializeAsync();
            yield return AssetsLoader.Instance.AsyncLoadManyAssetsByLabel("InitScene");
        }
        InitSceneLuaEnv.Instance.Init();
        InitSceneLuaEnv.Instance.LoadInitScene();
    }

    public void OnHotUpdateFinish()
    {
        StartCoroutine(StartLoadMainScript());
    }
    
    public IEnumerator StartLoadMainScript()
    {
        yield return ResCenter.Instance.AsyncInit();
        LuaMainEnv.Instance.Init();
    }
}
