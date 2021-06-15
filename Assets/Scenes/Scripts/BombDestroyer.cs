using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombDestroyer : MonoBehaviour
{
    public Text lifeText;
    private int life = 3;
    public GameObject gameOverPanel;
    public Text gameScore;
    public Text endScore;

    private void Start()
    {
        gameOverPanel.gameObject.SetActive(false);
    }

    void Update()
    {
        if (life != -1)
            lifeText.text = "Life: " + life.ToString();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Circle")
        {   
            life -= 1;
            Destroy(other.gameObject);
        }
        if (life < 0)
        {
            endScore.text = gameScore.text;
            gameOverPanel.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
        if (other.gameObject.tag == "Brick")
        {
            life += 1;
            Destroy(other.gameObject);
        }
    }
    
    
}
