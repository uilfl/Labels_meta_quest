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
        // ����w�I������ɡA�����C��
        ChangeColor();
    }

    public void OnPointerDown(MixedRealityPointerEventData eventData)
    {
        // �o�̥i�H�K�[���U�ƥ�B�z�޿�
    }

    public void OnPointerDragged(MixedRealityPointerEventData eventData)
    {
        // �o�̥i�H�K�[��ʨƥ�B�z�޿�
    }

    public void OnPointerUp(MixedRealityPointerEventData eventData)
    {
        // �o�̥i�H�K�[���w��_�ƥ�B�z�޿�
    }

    private void ChangeColor()
    {
        // ���ܪ����C��
        if (cubeRenderer != null)
        {
            cubeRenderer.material.color = Random.ColorHSV();
        }
    }
}
