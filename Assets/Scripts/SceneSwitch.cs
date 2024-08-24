using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSwitch : MonoBehaviour
{
    public string sceneName;
    private PaperCraneManager craneManager;

    void Start()
    {
        craneManager = FindObjectOfType<PaperCraneManager>();
        if (craneManager != null)
        {
            craneManager.transitionEvent.AddListener(SwitchScene);
        }
        else
        {
            Debug.LogError("PaperCraneManager not found in the scene!");
        }
    }

    private void SwitchScene()
    {
        StartCoroutine(LoadYourAsyncScene());
    }

    IEnumerator LoadYourAsyncScene()
    {
        Debug.Log("Start scene transistion");
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

}
