using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PaperCraneManager : MonoBehaviour
{
    private List<string> touchedMaterialNames = new List<string>();
    public UnityEvent transitionEvent;
    private const int TOUCHES_TO_SWITCH = 5;

    void Update()
    {
        // Testing Purpose, Show the result as you press P
        if (Input.GetKeyDown(KeyCode.P))
        {
            PrintAllTouchedColors();
        }
    }

    public void AddTouchedColor(string materialName)
    {
        touchedMaterialNames.Add(materialName);
        if (touchedMaterialNames.Count == TOUCHES_TO_SWITCH)
        {
            transitionEvent.Invoke();
        }

    }

    private void PrintAllTouchedColors()
    {
        Debug.Log("Touched Crane Colors in Order:");
        for (int i = 0; i < touchedMaterialNames.Count; i++)
        {
            Debug.Log($"Touch {i + 1}: Material {touchedMaterialNames[i]}");
        }
    }
}