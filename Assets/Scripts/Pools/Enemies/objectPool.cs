using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectPool : MonoBehaviour
{
    public static objectPool SharedInstance;
    public List<GameObject>[] pooledObjects;
    public GameObject[] objectToPool;
    public int amountToPool;

    // Start is called before the first frame update
    void Awake()
    {
        SharedInstance = this;
    }

    void Start()
    {
        pooledObjects = new List<GameObject>[objectToPool.Length];
        for (int i = 0; i < objectToPool.Length; i++)
        {
            pooledObjects[i] = new List<GameObject>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject GetPooledObjects()
    {
        int randomIndex = Random.Range(0, pooledObjects.Length);

        for (int i = 0; i < pooledObjects[randomIndex].Count; i++)
        {
            GameObject go = pooledObjects[randomIndex][i];
            if (!go.activeInHierarchy)
            {
                return go;
            }
        }
        GameObject obj = (GameObject)Instantiate(objectToPool[randomIndex]);
        pooledObjects[randomIndex].Add(obj);
        return obj;
    }
    
}
