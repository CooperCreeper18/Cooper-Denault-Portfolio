using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public Text textbox;

    public int score = 0;
    public PlayerControllerX playercontrollerX;


    public GameObject gameWinText;


    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<Text>();
        playercontrollerX = GameObject.Find("Player").GetComponent<PlayerControllerX>();

        textbox.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score;

        if (score >= 10)
        {
            playercontrollerX.gameOver = true;
            gameWinText.SetActive(true);
        }

        if (playercontrollerX.gameOver == true)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
