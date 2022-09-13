using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spellSpawner : MonoBehaviour
{
    float randTime;
    // Start is called before the first frame update
    void Start()
    {
        randTime = Random.Range(5,15);
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
            spellSpawn();
            randTime = Random.Range(5, 15);
        }
    }
    public void spellSpawn()
    {
        GameObject spellies = spellPool.SharedInstance.GetPooledObjects();
        if (spellies != null)
        {
            spellies.transform.position = gameObject.transform.position;
            spellies.transform.rotation = gameObject.transform.rotation;
            spellies.SetActive(true);
        }

    }

}
