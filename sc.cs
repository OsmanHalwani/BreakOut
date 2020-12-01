using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sc : MonoBehaviour
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
            scEasy.lives = 3;
            scEasy.score = 0;
            Ball.speed = 7f;
            SceneManager.LoadScene("gameover");

        }

       // /if (score > 30)
         //   Ball.speed = 10;
      //  if (score > 100)
       //     Ball.speed = 15;
       // if (score > 200)
         //   Ball.speed = 20;
        
    }
}
