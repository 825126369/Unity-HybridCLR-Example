using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

public class InitSceneMgr : MonoBehaviour
{
    void Start()
    {
        var mInitSceneHotUpdateManager = GetComponent<InitSceneHotUpdateManager>();
        if (mInitSceneHotUpdateManager == null)
        {
            mInitSceneHotUpdateManager = gameObject.AddComponent<InitSceneHotUpdateManager>();
        }

        mInitSceneHotUpdateManager.UpdateFinishFunc = UpdateFinishFunc;
        mInitSceneHotUpdateManager.UpdateErrorFunc = UpdateErrorFunc;
        mInitSceneHotUpdateManager.UpdateProgressFunc = UpdateProgressFunc;
        mInitSceneHotUpdateManager.UpdateVersionFunc = UpdateVersionFunc;
        StartCoroutine(mInitSceneHotUpdateManager.CheckHotUpdate());
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
