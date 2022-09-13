using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHit : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("isFreeze", false);
        //rb = GetComponent<Rigidbody2D>();
        //rb.constraints = RigidbodyConstraints2D.None;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("Pembatas"))
        {
            gameObject.SetActive(false);
        }
    }
}
