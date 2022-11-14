using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text waveNumberText;
    public GameObject winText;
    public GameObject startText;
    public GameObject loseText;

    public PlayerControllerX player;

    public SpawnManagerX spawnManager;

    public bool gameOver = false;

    public bool touch = false;

    // Start is called before the first frame update
    void Start()
    {
        spawnManager = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManagerX>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControllerX>();


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            startText.SetActive(false);
        }

        waveNumberText.text = "Wave Number: " + (spawnManager.waveCount - 1 );

        //if statement so when enemy touches goal, you lose
        if (touch)
        {
            gameOver = true;
            loseText.SetActive(true);

            Destroy(player);

            if (Input.GetKeyDown(KeyCode.R) && gameOver == true)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

        if (spawnManager.waveCount >= 10)
        {
            gameOver = true;
            winText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.R) && gameOver == true)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

        }

    }
}
