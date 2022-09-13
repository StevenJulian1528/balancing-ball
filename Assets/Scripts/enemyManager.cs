using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyManager : MonoBehaviour
{
    GameObject[] enemy;

    [Header("Freeze Spell")]
    bool isFreezeOk;
    bool notFreeze;
    float timeFreeze = 3f;
    stopSpell sp;
    public AudioSource spellFreeze;
    public AudioSource spellDestroy;
    // Start is called before the first frame update
    void Start()
    {
        notFreeze = false;
    }

    // Update is called once per frame
    void Update()
    {
        enemy = GameObject.FindGameObjectsWithTag("enemy");
        if (isFreezeOk)
        {
            timeFreeze = timeFreeze - Time.deltaTime;
            if (timeFreeze < 0)
            {
                notFreeze = true;
                isFreezeOk = false;
                checkIsFreeze(false);
            }
        }
    }
    public void checkIsFreeze(bool isFreeze)
    {
        if (isFreeze)
        {
            spellFreeze.Play();
            isFreezeOk = isFreeze;
            for (int i = 0; i < enemy.Length; i++)
            {
                enemy[i].GetComponent<Animator>().SetBool("isFreeze", true);
                enemy[i].GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            }
            notFreeze = false;
        }
        if(notFreeze)
        {
            for (int i = 0; i < enemy.Length; i++)
            {
                enemy[i].GetComponent<Animator>().SetBool("isFreeze", false);
                enemy[i].GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            }
            print("unfreeze");
            //eh.checkFreeze(false);
            //for (int i = 0; i < enemy.Length; i++)
            //{
            //    enemy[i].GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            //}
        }
    }
    //public void playAnimateFreeze(bool freeze)
    //{
    //    if (freeze)
    //    {
    //        eh.checkFreeze(true);
    //    }
    //    if (notFreeze)
    //    {
    //        eh.checkFreeze(false);
    //    }
    //}
    public void checkIsDestroy(bool isDestroy)
    {
        float[] t = new float[enemy.Length];
        if (isDestroy)
        {
            spellDestroy.Play();
            for (int i = 0; i < enemy.Length; i++)
            {
                enemy[i].GetComponent<Animator>().SetBool("isDestroy", true);

                t[i] = t [i]- Time.fixedTime;
                if (t[i] == 1)
                {
                    enemy[i].SetActive(false);
                }
                
            }
            isDestroy = false;
        }
    }
}
