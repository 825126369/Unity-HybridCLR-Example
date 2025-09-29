using HybridCLR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Networking;

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
        StartCoroutine(StartInitSystem());
    }

    // Application.runInBackground = true; 这个API 会影响 这个函数的调用
	void OnApplicationPause(bool bPause)
	{
		Debug.Log("GameLauncher OnApplicationPause: " + bPause);
	}

    private IEnumerator StartInitSystem()
    {
        yield return LoadMetadataForAOTAssemblies();
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
        yield return MainSceneLoader.Instance.Init();
        MainSceneLoader.Instance.LoadScene();
    }

    private IEnumerator LoadMetadataForAOTAssemblies()
    {
        Dictionary<string, byte[]> mDllDic = new Dictionary<string, byte[]>();
        foreach (var aotDllName in HotFixDllHelper.AOTMetaAssemblyFiles)
        {
            string fileName = "AotDll/" + aotDllName + ".dll.bytes";
            string dllPath = GameConst.getStreamingAssetsPathUrl(fileName);
            UnityWebRequest www = UnityWebRequest.Get(dllPath);
            yield return www.SendWebRequest();
            
            if (www.result == UnityWebRequest.Result.Success)
            {
                byte[] assetData = www.downloadHandler.data;
                mDllDic[aotDllName] = assetData;
            }
            else
            {
                Debug.LogError(www.error + ": " + dllPath);
                www.Dispose();
                yield break;
            }

            www.Dispose();
        }

        HomologousImageMode mode = HomologousImageMode.SuperSet;
        foreach (var aotDllName in HotFixDllHelper.AOTMetaAssemblyFiles)
        {
            Debug.Log("LoadMetadataForAOTAssemblies: 00000: " + aotDllName);
            //string fileName = "AotDll/" + aotDllName + ".dll";
            //TextAsset mTextAsset = Resources.Load<TextAsset>(fileName);
            //Debug.Assert(mTextAsset != null, $"{fileName} == null");
            byte[] dllBytes = mDllDic[aotDllName];
            Debug.Assert(dllBytes != null, "dllBytes == null");
            Debug.Log("LoadMetadataForAOTAssemblies: 11111");
            LoadImageErrorCode err = RuntimeApi.LoadMetadataForAOTAssembly(dllBytes, mode);
            Debug.Log($"LoadMetadataForAOTAssembly:{aotDllName}. mode:{mode} ret:{err}");
        }
    }

}
