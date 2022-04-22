using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    #region Public Variables
    #endregion
    #region Inspector Variables
    #endregion
    #region Private Variables
    #endregion
    #region Components
    #endregion


    #region Methods
    public void ResetCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    #endregion
}
