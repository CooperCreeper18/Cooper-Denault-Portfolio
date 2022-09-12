using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DisplayHealth : MonoBehaviour
{
    public Text textbox;

    public int health = 5;
    public bool gameOver = false;

    public GameObject gameOverText;


    // Start is called before the first frame update
    void Start()
    {
        //set text component reference on start
        textbox = GetComponent<Text>();

        textbox.text = "Health: 5/";
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Health: 5/" + health;


        if (health <= 0)
        {
            gameOver = true;
            gameOverText.SetActive(true);

            //Press R to restart if game is over
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

}
