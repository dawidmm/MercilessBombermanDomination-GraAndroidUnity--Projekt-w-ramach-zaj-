using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PointCounter : MonoBehaviour
{
    public Text pointText;
    private int points = 0;
    

    void Update()
    {
        pointText.text = "Score: " + points.ToString();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Circle")
        {
            points += 1;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Brick")
        {
            Destroy(other.gameObject);
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }


    
}
