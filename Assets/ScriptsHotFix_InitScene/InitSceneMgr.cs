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
        Debug.Log("���½���: " + mStatus.Percent);
    }

    void UpdateErrorFunc()
    {
        Debug.Log("���´���");
    }

    void UpdateFinishFunc()
    {
        Debug.Log("�������");
        GameLauncher.Instance.OnHotUpdateFinish();
    }

    void UpdateVersionFunc()
    {
        Debug.Log("�汾���ͣ����������°汾");
    }
}
