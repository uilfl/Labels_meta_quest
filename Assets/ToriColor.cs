using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine;

public class ToriColor : MonoBehaviour, IMixedRealityPointerHandler
{
    private Renderer cubeRenderer;

    void Start()
    {
        cubeRenderer = GetComponent<Renderer>();
    }

    public void OnPointerClicked(MixedRealityPointerEventData eventData)
    {
        // 當指針點擊物體時，改變顏色
        ChangeColor();
    }

    public void OnPointerDown(MixedRealityPointerEventData eventData)
    {
        // 這裡可以添加按下事件處理邏輯
    }

    public void OnPointerDragged(MixedRealityPointerEventData eventData)
    {
        // 這裡可以添加拖動事件處理邏輯
    }

    public void OnPointerUp(MixedRealityPointerEventData eventData)
    {
        // 這裡可以添加指針抬起事件處理邏輯
    }

    private void ChangeColor()
    {
        // 改變物體顏色
        if (cubeRenderer != null)
        {
            cubeRenderer.material.color = Random.ColorHSV();
        }
    }
}
