using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    ObjectPooler objectPooler;
    // Start is called before the first frame update
    void Start()
    {
        objectPooler = FindObjectOfType<ObjectPooler>();
    }
    #region variables
    new public string tag;
    #endregion

    #region methods
    public void spawnBullet( string tag , Vector2 position, Quaternion rotation)
    {
        if (!objectPooler.poolDict.ContainsKey(tag))
        {
            Debug.LogWarning("Pool" + tag + "does not exist");
        }

        GameObject objectToSpawn = objectPooler.poolDict[tag].Dequeue();//gets bullet from queue

        objectToSpawn.SetActive(true);
        objectToSpawn.transform.position = position;
        objectToSpawn.transform.rotation = rotation;
        
        objectPooler.poolDict[tag].Enqueue(objectToSpawn);
    }
    public void OnFire()
    {
          spawnBullet(tag, transform.position, transform.rotation);
    }
    #endregion
}
