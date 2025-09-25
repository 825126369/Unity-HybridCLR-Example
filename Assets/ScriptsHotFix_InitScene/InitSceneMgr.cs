using UnityEngine;

public class InitSceneMgr : MonoBehaviour
{
    CommonResSerialization2 mLuaRes;
    void Start()
    {
        var go = AssetsLoader.Instance.GetAsset("Assets/ResourceABs/InitScene/InitSceneEntry.prefab") as GameObject;
        mLuaRes = go.GetComponent<CommonResSerialization2>();
    }
        
    void Update()
    {
        
    }
}
