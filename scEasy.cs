using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scEasy : MonoBehaviour
{
    public static int lives = 3;
    public static int score = 0;
    Text textOfLives;
    // Start is called before the first frame update
    void Start()
    {
        textOfLives = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textOfLives.text = "Lives: " + lives + "      Score: " + score;
        if (lives <= 0)
        {
            score = 0;
            lives = 3;
            sc.lives = 3;
            sc.score = 0;
            Ball.speed = 7f;
            SceneManager.LoadScene("gameover");

        }

       
        
    }
}
