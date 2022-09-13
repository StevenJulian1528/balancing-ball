using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroySpell : MonoBehaviour
{
    enemyManager em;
    // Start is called before the first frame update
    void Start()
    {
        em = GameObject.FindObjectOfType<enemyManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("trophy"))
        {
            em.checkIsDestroy(true);
            gameObject.SetActive(false);
        }
        if (collision.gameObject.tag.Equals("Pembatas"))
        {
            gameObject.SetActive(false);
        }
    }
}
