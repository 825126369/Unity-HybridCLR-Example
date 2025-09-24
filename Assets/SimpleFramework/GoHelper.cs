using UnityEngine;
using UnityEngine.UI;

public static class GoHelper
{
    public static Vector3 GetUIToWorldScale(GameObject uiElement)
    {
        return GetUIToWorldScale(uiElement.GetComponent<Image>());
    }

    public static Vector3 GetUIToWorldScale(Image uiElement)
    {
        /// <summary>
        /// ������ָ����ȣ�1 ���ض�Ӧ�����絥λ��С
        /// </summary>
        float GetWorldUnitsPerPixel(Camera cam, float depth)
        {
            if (cam.orthographic)
            {
                // ���������������߶� = orthographicSize * 2
                return (cam.orthographicSize * 2f) / Screen.height;
            }
            else
            {
                // ͸���������������Ⱥ� FOV ����
                float fovRad = cam.fieldOfView * Mathf.Deg2Rad;
                float heightAtDepth = 2f * depth * Mathf.Tan(fovRad * 0.5f);
                return heightAtDepth / Screen.height;
            }
        }

        // 3. ��ȡ UI Ԫ�ص�ʵ����Ļ�ߴ磨���� Canvas Scaler��
        Vector2 uiSize = uiElement.rectTransform.sizeDelta * uiElement.canvas.scaleFactor;

        // 4. �������絥λ�С�1 ���ء��Ĵ�С
        float worldUnitsPerPixel = GetWorldUnitsPerPixel(Camera.main, uiElement.canvas.planeDistance);

        // 5. ���� Sprite Ӧ�����Ŷ��ٲ���ƥ�� UI �ߴ�
        Vector2 spriteOriginalSize = uiElement.sprite.bounds.size;
        Vector3 targetScale = Vector3.one;
        targetScale.x = (uiSize.x * worldUnitsPerPixel) / spriteOriginalSize.x;
        targetScale.y = (uiSize.y * worldUnitsPerPixel) / spriteOriginalSize.y;
        return targetScale;
    }
}