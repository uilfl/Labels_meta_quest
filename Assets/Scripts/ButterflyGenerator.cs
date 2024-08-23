using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterflyGenerator : MonoBehaviour
{
    public GameObject[] butterflies;
    public int spawnNum;
    public int spawnArea_X_min;
    public int spawnArea_X_max;
    public int spawnArea_Y_min;
    public int spawnArea_Y_max;
    public int spawnArea_Z_min;
    public int spawnArea_Z_max;
    public float assetLifetime = 10.0f;
    public float spawnInterval = 2.0f;
    private float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            GenerateAssets();
            timer = 0.0f;
        }
    }

    void GenerateAssets()
    {
        for (int i = 0; i < spawnNum; i++)
        {
            GameObject butterfly = butterflies[Random.Range(0, butterflies.Length)];
            Vector3 randomPosition = new Vector3(
                    Random.Range(spawnArea_X_min, spawnArea_X_max),
                    Random.Range(spawnArea_Y_min, spawnArea_Y_max),
                    Random.Range(spawnArea_Z_min, spawnArea_Z_max)
            );
            GameObject spawnedButterfly = Instantiate(butterfly, randomPosition, Quaternion.identity);
            Destroy(spawnedButterfly, assetLifetime);
        }
    }
}