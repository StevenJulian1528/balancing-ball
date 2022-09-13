using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinsIdle : MonoBehaviour
{
    coinsManager cm;

    // Start is called before the first frame update
    void Start()
    {
        cm = GameObject.FindObjectOfType<coinsManager>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if(collision.gameObject.tag.Equals("trophy"))
    //    {
    //        cm.addCoin(true);
    //        gameObject.SetActive(false);
    //    }

    //    if(collision.gameObject.tag.Equals("Pembatas"))
    //    {
    //        gameObject.SetActive(false);
    //    }
    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("trophy"))
        {
            cm.addCoin(true);
            gameObject.SetActive(false);
        }

        if (collision.gameObject.tag.Equals("Pembatas"))
        {
            gameObject.SetActive(false);
        }
    }
}
