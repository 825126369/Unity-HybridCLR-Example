using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

public class VersionConfig
{
    public string minVersion = string.Empty;
    public string maxVersion = string.Empty;
    public List<string> testUserId = new List<string>();
}

public static class InitSceneVersionCheck
{
    private static VersionConfig mLocalConfig = null;
    private static VersionConfig mWWWConfig = null;
    private static bool bHaveError = false;

    private static IEnumerator InitLocalVersionConfig()
    {
        string url = GameConst.getStreamingAssetsPathUrl("CustomLocalCache/" + GameConst.versionFileName);
        UnityWebRequest www = UnityWebRequest.Get(url);
        yield return www.SendWebRequest();
        if (www.result != UnityWebRequest.Result.Success)
        {
            string netErrorDes = $"{GameConst.versionUpdateTimeCheckFileName} WWW Error:" + www.responseCode + " | " + url + " | " + www.error;
            Debug.LogError(netErrorDes);
            www.Dispose();
            yield break;
        }

        mLocalConfig = JsonTool.FromJson<VersionConfig>(www.downloadHandler.text);
        Debug.Assert(mLocalConfig != null, "mLocalConfig == null");
        Debug.Log("VersionUpdateTimeCheck  5555555555");
        www.Dispose();
    }
    
    public static IEnumerator Do()
    {
        bHaveError = false;
        yield return InitLocalVersionConfig();

        string url = GameConst.GetVersionConfigUrl();
        UnityWebRequest www = UnityWebRequest.Get(url);
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            string netErrorDes = "www Load Error:" + www.responseCode + " | " + url + " | " + www.error;
            Debug.LogError(netErrorDes);
            bHaveError = true;
            www.Dispose();
            yield break;
        }

        string jsonStr = www.downloadHandler.text;
        www.Dispose();
        mWWWConfig = JsonTool.FromJson<VersionConfig>(jsonStr);
    }

    public static bool orHaveError()
    {
        return bHaveError;
    }
    
    // 是否游戏刚启动时候，就强制用户更新
    public static bool orNeedUpdateInLauncher()
    {
        if (VersionTool.VersionCompare(mWWWConfig.minVersion, Application.version) > 0)
        {
            return true;
        }

        return false;
    }

    // 进入游戏后，是否提示玩家 有更新版本可用，需要去下载
    public static bool orNeedUpdateInGame()
    {
        if (VersionTool.VersionCompare(mWWWConfig.minVersion, Application.version) > 0)
        {
            return true;
        }
        
        if (!string.IsNullOrWhiteSpace(mWWWConfig.maxVersion) && VersionTool.VersionCompare(mWWWConfig.maxVersion, Application.version) > 0)
        {
            return true;
        }

        return false;
    }

    public static bool orTestUser()
    {
        if (mWWWConfig == null) return false;
        return mWWWConfig.testUserId.Contains(TestUserManager.GetId());
    }
}
