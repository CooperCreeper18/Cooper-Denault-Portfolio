using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameLoseText : MonoBehaviour
{
    public GameObject gameLoseText;
    private bool gameOver = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            gameLoseText.SetActive(true);
            gameOver = true;
        }

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && gameOver == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
