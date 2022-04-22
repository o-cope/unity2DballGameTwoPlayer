using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
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

    #region Method
    private void setPause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    #endregion


}
