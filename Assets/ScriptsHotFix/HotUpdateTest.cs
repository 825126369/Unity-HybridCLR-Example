using System;
using UnityEngine;
using UnityEngine.UI;

public class HotUpdateTest : MonoBehaviour
{
    public Text mText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mText.text = "ÈÈ¸üÐÂ£º" + DateTime.Now.ToString();
    }
}
