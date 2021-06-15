using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BombSpawner : MonoBehaviour
{
    public Rigidbody2D Circle;
    private float bonusSpeed = 0.01f;
    private float speed = 1f;
    private float time = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBomb", 1f, time);
    }
    void SpawnBomb()
    {
        int i = Random.Range(-2, 3);
        Rigidbody2D instance = Instantiate(Circle, transform);
        instance.velocity = Vector2.down * (speed + bonusSpeed);
        instance.transform.position = instance.transform.position + Vector3.right * i;
        bonusSpeed += 0.1f;
    }

 
}
