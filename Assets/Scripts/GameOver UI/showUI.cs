using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showUI : MonoBehaviour
{
    public AudioSource backsound, gameover;
    // Start is called before the first frame update
    void Start()
    {
        backsound.Stop();
        gameover.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
