using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine;

public class CraneInteraction : MonoBehaviour, IMixedRealityPointerHandler
{
    private Renderer craneRenderer;
    public Material[] materials;
    private string currentMaterialName = "";
    private PaperCraneManager craneManager;

    void Start()
    {
        craneRenderer = GetComponent<Renderer>();
        craneManager = FindObjectOfType<PaperCraneManager>();

        if (craneManager == null)
        {
            Debug.LogError("PaperCraneManager not found in the scene!");
        }
    }

    public void OnPointerClicked(MixedRealityPointerEventData eventData)
    {
        string newMaterialName = ChangeColor();

        if (!string.IsNullOrEmpty(newMaterialName) && craneManager != null)
        {
            craneManager.AddTouchedColor(newMaterialName);
        }
    }

    public void OnPointerDown(MixedRealityPointerEventData eventData)
    {
        // ���U�ƥ�B�z�޿�
    }

    public void OnPointerDragged(MixedRealityPointerEventData eventData)
    {
        // ��ʨƥ�B�z�޿�
    }

    public void OnPointerUp(MixedRealityPointerEventData eventData)
    {
        // ���w��_�ƥ�B�z�޿�
    }

    private string ChangeColor()
    {
        if (craneRenderer != null)
        {
            Material newMaterial;
            do
            {
                newMaterial = materials[Random.Range(0, materials.Length)];
            } while (newMaterial.name == currentMaterialName && materials.Length > 1);

            craneRenderer.material = newMaterial;
            currentMaterialName = newMaterial.name;
            return currentMaterialName;
        }
        return "";
    }
}
