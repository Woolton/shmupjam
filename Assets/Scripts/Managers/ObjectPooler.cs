using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    //make singleton
    public static ObjectPooler Instance;

    void Awake()
    {
        Instance = this;
    }

    [System.Serializable]
    public class Pool //pool of gameobjects
    {
        public string tag;//name of the pooled object
        public GameObject prefab;//object to pool
        public int size;//maximum quantity of pooled objects
    }

    public List<Pool> pools;//list of pool objects
    public Dictionary<string, Queue<GameObject>> poolDict;//dictionary of object queues
    void Start()
    {
        poolDict = new Dictionary<string, Queue<GameObject>>();
        foreach(Pool pool in pools)//creates a queue for each pool
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();
            for(int i = 0; i < pool.size; i++)//fills queue with object pool
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(false);
                objectPool.Enqueue(obj);
            }
            poolDict.Add(pool.tag, objectPool);
        }
    }
}
