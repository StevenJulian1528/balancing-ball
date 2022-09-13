using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainMenuManager : MonoBehaviour
{
    public AudioSource click;
    public Text highScoreInfo, coinInfo;
    Player player;
    float t = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        highScoreInfo.text = "" + player.m_highScore;
        coinInfo.text = "" + player.m_coin;
    }
    public void playButton()
    {
        t = t - Time.time;
        click.Play();
        if (t <= 0)
        {
            SceneManager.LoadScene("mainPlay");
        }
        
    }
    public void shopButton()
    {
        t = t - Time.time;
        click.Play();
        if (t <= 0)
        {
            SceneManager.LoadScene("mainShop");
        }
    }
}
