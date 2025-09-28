using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;

[CustomEditor(typeof(AssetsLoader))]
public class AssetsLoaderEditor : Editor
{
	private AssetsLoader mTarget;
	private void OnEnable()
	{
		mTarget = target as AssetsLoader;
	}

	public override void OnInspectorGUI()
	{
		serializedObject.Update();
		base.DrawDefaultInspector();
		DrawCustomInspectorGUI();
		serializedObject.ApplyModifiedProperties();
	}

    private Dictionary<object, bool> mFoldOutDic = new Dictionary<object, bool>();
    private void DrawCustomInspectorGUI()
    {
        var mChildrenList1 = Get_m_resultToHandle();
        EditorGUILayout.LabelField("Inner Handle Count: " + mChildrenList1.Count);
        EditorGUILayout.Space();
        foreach (var v in mChildrenList1)
        {
            if (v.Key is UnityEngine.Object)
            {
                var mObject = v.Key as UnityEngine.Object;
                EditorGUILayout.LabelField(v.Key.GetType().Name + " : " + mObject.name);
            }
            else if (v.Key is IList<UnityEngine.Object>)
            {
                var Key2 = v.Key as IList<UnityEngine.Object>;
                if (Key2.Count > 0)
                {
                    if (!mFoldOutDic.ContainsKey(Key2))
                    {
                        mFoldOutDic.Add(Key2, false);
                    }

                    mFoldOutDic[Key2] = EditorGUILayout.Foldout(mFoldOutDic[Key2], v.Key.GetType().Name + ": " + Key2.Count);
                    if (mFoldOutDic[v.Key])
                    {
                        EditorGUI.indentLevel += 2;
                        foreach (var v2 in Key2)
                        {
                            EditorGUILayout.LabelField(v2.GetType().Name + " | " + v2.name + ": ");
                        }
                        EditorGUI.indentLevel -= 2;
                    }
                }
                else
                {
                    EditorGUILayout.LabelField(v.Key.GetType().Name  + ": " + Key2.Count);
                }
            }
            else if (v.Key is SceneInstance)
            {
                SceneInstance mSceneInstance = (SceneInstance)v.Key;
                EditorGUILayout.LabelField(v.Key.GetType().Name + " : " + mSceneInstance.Scene.name);
            }
            else
            {
                Debug.LogError("Error: " + v.Key.GetType().Name);
            }
        }
        
        EditorGUILayout.Space();
        EditorGUILayout.Space();

        var mAssetDic = Get_mAssetDic();
        if (!mFoldOutDic.ContainsKey(mAssetDic))
        {
            mFoldOutDic.Add(mAssetDic, false);
        }

        mFoldOutDic[mAssetDic] = EditorGUILayout.Foldout(mFoldOutDic[mAssetDic], "Asset Count: " + mAssetDic.Count);
        if (mFoldOutDic[mAssetDic])
        {
            EditorGUI.indentLevel += 2;
            foreach (var v in mAssetDic)
            {
                EditorGUILayout.ObjectField(v.Key, v.Value, typeof(UnityEngine.Object), false);
            }
            EditorGUI.indentLevel -= 2;
        }

        EditorGUILayout.Space();
        EditorGUILayout.Space();

        var mLabelDic = Get_mAssetLabelDic();
        if (!mFoldOutDic.ContainsKey(mLabelDic))
        {
            mFoldOutDic.Add(mLabelDic, false);
        }

        mFoldOutDic[mLabelDic] = EditorGUILayout.Foldout(mFoldOutDic[mLabelDic], "Label Count: " + mLabelDic.Count);
        if (mFoldOutDic[mLabelDic])
        {
            EditorGUI.indentLevel += 2;
            foreach (var v in mLabelDic)
            {
                if (!mFoldOutDic.ContainsKey(v.Key))
                {
                    mFoldOutDic.Add(v.Key, false);
                }

                mFoldOutDic[v.Key] = EditorGUILayout.Foldout(mFoldOutDic[v.Key], v.Key + ": " + v.Value.Count);
                if (mFoldOutDic[v.Key])
                {
                    EditorGUI.indentLevel += 2;
                    foreach (var v1 in v.Value)
                    {
                        EditorGUILayout.LabelField(v1);
                    }
                    EditorGUI.indentLevel -= 2;
                }
            }
            EditorGUI.indentLevel -= 2;
        }
    }

    private Dictionary<string, List<string>> Get_mAssetLabelDic()
    {
        var mChildrenListFieldInfo = mTarget.GetType().GetField("LabelDic", BindingFlags.Instance | BindingFlags.GetField | BindingFlags.NonPublic);
        var mChildrenList = mChildrenListFieldInfo.GetValue(mTarget) as Dictionary<string, List<string>>;
        return mChildrenList;
    }

    private Dictionary<string, UnityEngine.Object> Get_mAssetDic()
    {
        var mChildrenListFieldInfo = mTarget.GetType().GetField("mAssetDic", BindingFlags.Instance | BindingFlags.GetField | BindingFlags.NonPublic);
        var mChildrenList = mChildrenListFieldInfo.GetValue(mTarget) as Dictionary<string, UnityEngine.Object>;
		return mChildrenList;
    }

    private Dictionary<object, AsyncOperationHandle> Get_m_resultToHandle()
    {
        var m_Addressables = typeof(Addressables).GetProperty("m_Addressables", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
        var m_resultToHandle = m_Addressables.PropertyType.GetField("m_resultToHandle", BindingFlags.NonPublic | BindingFlags.Instance);
        var m_Addressables_Value = m_Addressables.GetValue(null);
        var m_resultToHandle_Value = m_resultToHandle.GetValue(m_Addressables_Value) as Dictionary<object, AsyncOperationHandle>;

        Debug.Assert(m_resultToHandle_Value != null, "m_resultToHandle_Value == null");
		return m_resultToHandle_Value;
    }
}