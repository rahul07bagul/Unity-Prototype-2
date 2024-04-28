using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    public bool isGameOver = false;

    public void Setup()
    {
        gameObject.SetActive(true);
        isGameOver = true;
    }
}
