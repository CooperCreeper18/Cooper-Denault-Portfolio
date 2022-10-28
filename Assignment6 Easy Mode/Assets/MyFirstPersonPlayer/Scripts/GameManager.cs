using System.Collections;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public int score;

    public GameObject pauseMenu;


    //variable to keep track what level we are on
    private string CurrentLevelName = string.Empty;


    /*   #region This code makes this class a Singleton

       public static GameManager instance;

       private void Awake()
       {
           if (instance == null)
           {
               instance = this;
               //make sure this game manager persists across scenees
               DontDestroyOnLoad(gameObject);
           }
           else
           {
               Destroy(gameObject);
               Debug.LogError("Trying to instantiate a second instance of singleton GameManager");
           }


       }

       #endregion*/


    //methods to load and unload scenes
    public void LoadLevel(string levelname)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(levelname, LoadSceneMode.Additive);

        if (ao == null)
        {
            Debug.LogError("[GameManager] Unable to load level " + levelname);
            return;
        }
        CurrentLevelName = levelname;

    }

    public void UnLoadLevel(string levelname)
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(levelname);

        if (ao == null)
        {
            Debug.LogError("[GameManager] Unable to unload level " + levelname);
            return;
        }

    }

    public void UnloadCurrentLevel()
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(CurrentLevelName);

        if (ao == null)
        {
            Debug.LogError("[GameManager] Unable to unload level " + CurrentLevelName);
            return;
        }
    }

    //pausing and unpausing

    public void Pause()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }

    public void UnPause()
    {
        Time.timeScale =1f;
        pauseMenu.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Pause();
        }
    }

}


