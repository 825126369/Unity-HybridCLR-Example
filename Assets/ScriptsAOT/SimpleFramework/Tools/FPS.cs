using UnityEngine;
using UnityEngine.UI;

public class FPS : MonoBehaviour
{
    public Text fpsText;

    private int nFrameCount;
    private float _lastTime;
    private const float _fpsDuringTime = 0.5f;

    private void Start()
    {
        _lastTime = Time.time;
        nFrameCount = 0;
    }

    private void Update()
    {
        nFrameCount++;
        float fInternalTime = Time.time - _lastTime;
        if (fInternalTime > _fpsDuringTime)
        {
            _lastTime = Time.time;
            int _fps = (int)(nFrameCount / fInternalTime);
            nFrameCount = 0;

            if (fpsText)
            {
                fpsText.text = "FPS : " + _fps;
            }
        }
    }
}