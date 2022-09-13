using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinsManager : MonoBehaviour
{
    public AudioSource collectGold;
    gameManager gm;
    bool isSpell;
    float timeDouble = 10f;
    // Start is called before the first frame update
    void Start()
    {

        gm = GameObject.FindObjectOfType<gameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isSpell)
        {
            timeDouble = timeDouble - Time.deltaTime;
            if (timeDouble < 0)
            {
                timeDouble = 10f;
                isSpell = false;
            }
        }
    }
    public void checkDoubleSpell(bool isSpellDouble)
    {
        if (isSpellDouble == null)
        {
            isSpell = false;
        }
        if (isSpellDouble)
        {
            isSpell = isSpellDouble;
        }

    }
    public void addCoin(bool add)
    {
        if(add)
        {
            collectGold.Play();
            if (isSpell != null)
            {
                if (!isSpell)
                {
                    gm.addCoin(1);
                }

                if (isSpell)
                {
                    gm.addCoin(2);
                }
            }
        }
    }
}
