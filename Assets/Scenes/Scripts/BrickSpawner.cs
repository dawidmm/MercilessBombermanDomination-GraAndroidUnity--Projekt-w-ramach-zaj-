using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSpawner : MonoBehaviour
{
    public Rigidbody2D Brick;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBrick", 1.0f, 2f);
    }
    void SpawnBrick()
    {
        int i = Random.Range(-1, 3);
        int y = Random.Range(1, 20);
        if (y == 1)
        {
            Rigidbody2D instance = Instantiate(Brick, transform);
            instance.velocity = Vector2.down * 2f;
            instance.transform.position = instance.transform.position + Vector3.right * i;
        }
    }
}
