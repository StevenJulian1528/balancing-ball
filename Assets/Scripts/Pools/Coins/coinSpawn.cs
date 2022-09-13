using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSpawner : MonoBehaviour
{
    float randTime;
    // Start is called before the first frame update
    void Start()
    {
        randTime = Random.Range(4,8);
    }

    // Update is called once per frame
    void Update()
    {

        float spawnY = gameObject.transform.position.y;
        float spawnX = Random.Range(-3.5f, 3.5f);
        transform.position = new Vector3(spawnX, spawnY, 0);

        randTime = randTime - Time.deltaTime;
        if (randTime < 0)
        {
            coinSpawn();
            randTime = Random.Range(4, 8);
        }
    }
    public void coinSpawn()
    {
        GameObject coins = coinPool.SharedInstance.GetPooledObjects();
        if (coins != null)
        {
            coins.transform.position = gameObject.transform.position;
            coins.transform.rotation = gameObject.transform.rotation;
            coins.SetActive(true);
        }

    }

}
