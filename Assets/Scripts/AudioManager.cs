using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource musicPlay;
    // Start is called before the first frame update
    void Start()
    {
        musicPlay = GetComponent<AudioSource>();



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
