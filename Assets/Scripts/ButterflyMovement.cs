using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class ButterflyMovement : MonoBehaviour
{
    public float speed;
    public float changeDirectionInterval;
    public Vector3 boundsMax;
    public Vector3 boundsMin;
    private Vector3 direction;
    private float timer = 0.0f;

    void Start()
    {
        ChangeDirection();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= changeDirectionInterval)
        {
            ChangeDirection();
            timer = 0.0f;
        }
        transform.Translate(direction * speed * Time.deltaTime);
        CheckBounds();
    }

    void ChangeDirection()
    {
        direction = new Vector3(
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f)
        ).normalized;
    }

    void CheckBounds()
    {
        Vector3 position = transform.position;

        // check x
        if (position.x <= boundsMin.x || position.x >= boundsMax.x)
        {
            direction.x = -direction.x;
        }
        // check y
        if (position.y <= boundsMin.y || position.y >= boundsMax.y)
        {
            direction.y = -direction.y;
        }
        // check z
        if (position.z <= boundsMin.z || position.z >= boundsMax.z)
        {
            direction.z = -direction.z;
        }
    }

}
