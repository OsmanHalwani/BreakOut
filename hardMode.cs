﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hardMode : MonoBehaviour
{
    // Start is called before the first frame update
    public void GameOne()
    {
        SceneManager.LoadScene("game2");
    }
}
