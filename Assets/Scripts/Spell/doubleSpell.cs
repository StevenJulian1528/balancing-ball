using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doubleSpell : MonoBehaviour
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("trophy"))
        {
            cm.checkDoubleSpell(true);
            gameObject.SetActive(false);
        }
        if (collision.gameObject.tag.Equals("Pembatas"))
        {
            gameObject.SetActive(false);
        }
    }
}
