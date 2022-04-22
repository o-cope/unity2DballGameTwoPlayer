using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    #region Public Variables
    #endregion
    #region Inspector Variables
    [SerializeField] private GameObject pauseMenu;
    #endregion
    #region Private Variables
    #endregion
    #region Components
    #endregion


    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SetPause();
        }
    }

    #region Methods
    public void ResetCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void SetPause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumePlay()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void LoadSceneMainMenu(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
        Time.timeScale = 1f;
    }

    public void LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void Quit()
    {
        Application.Quit();
    }


    #endregion
}
