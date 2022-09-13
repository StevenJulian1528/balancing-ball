using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballHit : MonoBehaviour
{
    bool onCol;
    gameManager gm;
    public GameObject ball;
    public AudioSource hit;
    int checkOnce;
    // Start is called before the first frame update
    void Start()
    {
        int checkOnce = 0;
        onCol = false;
        gm = GameObject.FindObjectOfType<gameManager>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Pembatas"))
        {
            checkOnce = checkOnce + 1;
            passingGameOver(true);
        }
        if(collision.gameObject.tag.Equals("enemy"))
        {
            if (!hit.isPlaying)
            {
                hit.PlayOneShot(hit.clip);
            }
        }
        
        }
    public void passingGameOver(bool onCol)
    {
        if(onCol & checkOnce == 1)
        {
            gm.checkGameOver(true);

        }
    }

}
