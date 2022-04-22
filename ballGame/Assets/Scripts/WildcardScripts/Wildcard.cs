using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wildcard : MonoBehaviour
{
    #region Public Variables
    #endregion
    #region Inspector Variables
    [SerializeField] private int numToSpawn;
    [SerializeField] private List<GameObject> spawnPool;
    [SerializeField] private GameObject spawnRange;
    #endregion
    #region Private Variables
    #endregion
    #region Components
    #endregion

    private void Start()
    {
        SpawnObjects();
    }



    #region Method
    public void SpawnObjects()
    {
        int randomItem = 0;
        GameObject toSpawn;
        MeshCollider c = spawnRange.GetComponent<MeshCollider>();

        float screenX, screenY;
        Vector2 pos;

        for(int i = 0; i < numToSpawn; i++)
        {
            randomItem =  Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
            screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);

            pos = new Vector2(screenX, screenY);
            Instantiate(toSpawn, pos, toSpawn.transform.rotation);
        }
    }

    private void DestroyObjects()
    {
        foreach(GameObject o in GameObject.FindGameObjectsWithTag("Spawnable"))
        {
            Destroy(o);
        }
    }


    #endregion

}
