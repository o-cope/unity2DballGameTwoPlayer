using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WildcardSmall : MonoBehaviour
{
    #region Public Variables
    #endregion
    #region Inspector Variables
    [SerializeField] private float smallTime;
    #endregion
    #region Private Variables
    #endregion
    #region Components
    #endregion


    #region Triggers
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("wildcardSmall"))
        {
            StartCoroutine(DecreaseSize());
            Destroy(other.gameObject);
        }
    }
    #endregion

    #region Coroutines
    IEnumerator DecreaseSize()
    {
        transform.localScale = new Vector2( transform.localScale.x / 2, transform.localScale.y /2 );
        yield return new WaitForSeconds(smallTime);
        transform.localScale = new Vector2(transform.localScale.x * 2, transform.localScale.y * 2 );
    }
    #endregion
}
