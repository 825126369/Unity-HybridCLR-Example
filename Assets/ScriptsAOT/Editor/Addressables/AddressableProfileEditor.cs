using UnityEditor.AddressableAssets;
using UnityEditor.AddressableAssets.Settings;

public static class AddressableProfileEditor
{
    public const string kRemoteBuildPath = "CustomRemote.BuildPath";
    public const string kRemoteLoadPath = "CustomRemote.LoadPath";

    //之所以对简介 进行修改，原因是先前设置的<custom>太多错了
    public static void SetProfile()
    {
        settings.profileSettings.CreateValue(kRemoteBuildPath, AddressableAssetSettings.kRemoteBuildPathValue);
        settings.profileSettings.CreateValue(kRemoteLoadPath, AddressableAssetSettings.kRemoteLoadPathValue);
        settings.profileSettings.SetValue(settings.activeProfileId, kRemoteLoadPath, GameConst.GetRemoteResUrl());
    }

    private static AddressableAssetSettings settings
    {
        get { return AddressableAssetSettingsDefaultObject.Settings; }
    }
}
