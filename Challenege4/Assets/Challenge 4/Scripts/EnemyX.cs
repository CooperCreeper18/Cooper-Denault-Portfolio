using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class EnemyX : MonoBehaviour
{
    private Rigidbody enemyRb;
    private GameObject playerGoal;

    public float speed;
    public float waveSpeed;

    private SpawnManagerX spawnManagerX;
    private UIManager uIManagerX;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
        enemyRb = GetComponent<Rigidbody>();
        playerGoal = GameObject.Find("Player Goal");
        spawnManagerX = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManagerX>();
        uIManagerX = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
        waveSpeed = speed * (spawnManagerX.waveCount - 1);

    }

    // Update is called once per frame
    void Update()
    {
        // Set enemy direction towards player goal and move there
        Vector3 lookDirection = (playerGoal.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * waveSpeed * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision other)
    {
        // If enemy collides with either goal, destroy it
        if (other.gameObject.name == "Enemy Goal")
        {
            Destroy(gameObject);

        } 
        else if (other.gameObject.name == "Player Goal")
        {
            uIManagerX.touch = true;
            Destroy(gameObject);

        }

    }

}
