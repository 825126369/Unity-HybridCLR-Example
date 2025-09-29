using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

public class InitSceneMgr
{
    private GameObject go;
    public void Start()
    {
        var goPreafb = AssetsLoader.Instance.GetAsset("Assets/ResourceABs/InitScene/InitSceneEntry.prefab") as GameObject;
        go = UnityEngine.Object.Instantiate<GameObject>(goPreafb);
        go.transform.position = Vector3.zero;
        go.transform.rotation = Quaternion.identity;
        go.transform.localScale = Vector3.one;
        go.SetActive(true);

        var mInitSceneHotUpdateManager = go.GetComponent<InitSceneHotUpdateManager>();
        if (mInitSceneHotUpdateManager == null)
        {
            mInitSceneHotUpdateManager = go.AddComponent<InitSceneHotUpdateManager>();
        }

        mInitSceneHotUpdateManager.UpdateFinishFunc = UpdateFinishFunc;
        mInitSceneHotUpdateManager.UpdateErrorFunc = UpdateErrorFunc;
        mInitSceneHotUpdateManager.UpdateProgressFunc = UpdateProgressFunc;
        mInitSceneHotUpdateManager.UpdateVersionFunc = UpdateVersionFunc;
        GameLauncher.Instance.StartCoroutine(mInitSceneHotUpdateManager.CheckHotUpdate());
    }

    public void UnLoad()
    {
        Object.Destroy(go);
    }
    
    void UpdateProgressFunc(DownloadStatus mStatus)
    {
        Debug.Log("更新进度: " + mStatus.Percent);
    }

    void UpdateErrorFunc()
    {
        Debug.Log("更新错误");
    }

    void UpdateFinishFunc()
    {
        Debug.Log("更新完成");
        GameLauncher.Instance.OnHotUpdateFinish();
    }

    void UpdateVersionFunc()
    {
        Debug.Log("版本过低，请下载最新版本");
    }
}
