using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text waveNumberText;
    public GameObject winText;
    public GameObject loseText;
    public GameObject startText;

    public PlayerController player;

    public SpawnManager spawnManager;

    private bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        spawnManager = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManager>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            startText.SetActive(false);
        }

        waveNumberText.text = "Wave Number: " + spawnManager.waveNumber;

        if (player.transform.position.y < -10)
        {
            gameOver = true;
            loseText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.R) && gameOver == true)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

        }

        if (spawnManager.waveNumber >= 10)
        {
            gameOver = true;
            loseText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.R) && gameOver == true)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

        }

    }
}
