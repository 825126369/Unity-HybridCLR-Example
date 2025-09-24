using System;
using UnityEngine;
using UnityEngine.UI;

public static class UnityEngineObjectExtention
{
    public static Transform FindDeepChild(this Transform aParent, string aName)
    {
        var result = aParent.Find(aName);
        if (result != null)
        {
            return result;
        }

        foreach (Transform child in aParent)
        {
            result = child.FindDeepChild(aName);
            if (result != null)
            {
                return result;
            }
        }
        return null;
    }

    public static void SetAlpha(this Image obj, float alpha)
    {
        Color oriColor = obj.color;
        obj.color = new Color(oriColor.r, oriColor.g, oriColor.b, alpha);
    }

    public static T AddMissComponent<T>(this GameObject obj) where T : Component
    {
        T t = obj.GetComponent<T>();
        if (t == null)
        {
            t = obj.AddComponent<T>();
        }
        return t;
    }

    public static Component AddMissComponent(this GameObject go, Type t)
    {
        if (null != go)
        {
            var component = go.GetComponent(t);
            if (null == component)
            {
                component = go.AddComponent(t);
            }
            return component;
        }
        Debug.LogWarning("要添加组件的物体为空！");
        return null;
    }
}
