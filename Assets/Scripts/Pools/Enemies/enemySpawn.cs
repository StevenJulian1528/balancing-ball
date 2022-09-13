using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    float randTime;
    // Start is called before the first frame update
    void Start()
    {
        randTime = Random.Range(2, 5);
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
            EnemiesSpawn();
            randTime = Random.Range(0, 5);
        }
    }
    public void EnemiesSpawn()
    {
        GameObject enemies = objectPool.SharedInstance.GetPooledObjects();
        if (enemies != null)
        {
            enemies.transform.position = gameObject.transform.position;
            enemies.transform.rotation = gameObject.transform.rotation;
            enemies.SetActive(true);
        }

    }

}
