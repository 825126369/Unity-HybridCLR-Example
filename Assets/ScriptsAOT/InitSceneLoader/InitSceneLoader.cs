using UnityEngine;

public class InitSceneLoader : SingleTonMonoBehaviour<InitSceneLoader>
{
    public void Init()
    {
        
    }

    public void LoadInitScene()
    {
        var go = AssetsLoader.Instance.GetAsset("Assets/ResourceABs/InitScene/InitSceneEntry.prefab") as GameObject;
        go.SetActive(true);
    }
}
