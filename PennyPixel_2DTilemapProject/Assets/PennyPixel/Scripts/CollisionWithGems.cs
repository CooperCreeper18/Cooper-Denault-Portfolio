using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithGems : MonoBehaviour
{
    private ScoreManager displayScoreScript;

    // Start is called before the first frame update
    void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<ScoreManager>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        displayScoreScript.score += 10;
    }
}
