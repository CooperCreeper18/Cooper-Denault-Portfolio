using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameWinText : MonoBehaviour
{
    public GameObject gameWinText;
    private bool gameOver = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gameWinText.SetActive(true);
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
