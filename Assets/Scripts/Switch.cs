using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Switch : MonoBehaviour
{
    // 觸碰籤詩的數量
    public int butterfliesCount = 0;
    // 引用 ButterflyGenerator 的obeject
    public ButterflyGenerator butterflyGenerator;

   
    void Start()
    {
        // 如果 butterflyGenerator 未被設置，則嘗試在場景中找到一個 ButterflyGenerator 的實例
        if (butterflyGenerator == null)
        {
            butterflyGenerator = FindObjectOfType<ButterflyGenerator>();
        }
    }

    // 增加 butterfliesCount 的方法
    public void CountButterflies()
    {
        butterfliesCount++;
    }

   
    public void OnTriggerEnter(Collider butterflies)
    {
        // 如果觸碰籤詩的數量大於等於 5
        if (butterfliesCount >= 5)
        {
            Debug.Log("butterfliesCount: " + butterfliesCount);
            // 獲取下一個場景的 SceneInfo 
            SceneInfo sceneInfo = butterflies.gameObject.GetComponent<SceneInfo>();
            // 如果 SceneInfo 組件存在，則加載對應的場景
            if (sceneInfo != null)
            {
                SceneManager.LoadScene(sceneInfo.SceneName); // 加載下一個場景
            }
            else
            {
                Debug.LogError("SceneInfo component not found on the collided object!");
            }
        }
        else
        {
            // 否則增加 butterfliesCount
            CountButterflies();
        }
    }
}