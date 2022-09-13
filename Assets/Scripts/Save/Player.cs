using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private int coin;
    private int highScore;
    private int[,] shopItem = { { 0, 1, 0 }, { 1, 0, 10 }, { 2, 0, 20 }, { 3, 0, 30 } };
    private int skinUsed;


    public int m_coin
    {
        get { return coin; }
        set { coin = value; }
    }

    public int m_highScore
    {
        get { return highScore; }
        set { highScore = value; }
    }
    public int[,] m_shopItem
    {
        get { return shopItem; }
        set { shopItem = value; }
    }

    public int m_skin
    {
        get { return skinUsed; }
        set { skinUsed = value; }
    }

    public void buyItem(int skin)
    {
        shopItem[skin, 1] = 1;
        coin = coin - shopItem[skin, 2];
        skinUsed = skin;
        SavePlayer();
        print(skinUsed);
    }

    public void mergeCoin(int coinGet)
    {
        m_coin = m_coin + coinGet;
        SavePlayer();
    }
    public void checkHighScore(int ScoreGet)
    {
        print("check highscore");
        if(ScoreGet > highScore)
        {
            highScore = ScoreGet;
            SavePlayer();
        }
    }
    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        playerData data = SaveSystem.LoadPlayer();

        coin = data.coin;
        highScore = data.highScore;
        for(int i =0;i<4;i++)
        {
            for(int j =0;j<3;j++)
            {
                shopItem[i, j] = data.shopItem[i, j];
            }
        }
        m_skin = data.selectedSkin;
    }

    private void Start()
    {
        LoadPlayer();
        print(Application.persistentDataPath);
    }
    private void Update()
    {
        LoadPlayer();
    }
    public void changeSkin(int skin)
    {
        m_skin = skin;
        print(m_skin);
        SavePlayer();

    }


}
