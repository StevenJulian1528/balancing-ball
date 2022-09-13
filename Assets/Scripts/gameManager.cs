using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    [Header("Score and Coin")]
    Player player;
    private float timeScore;
    public int score;
    public Text textScore;
    public Text textCoin;
    public int currentCoin;

    public GameObject[] bola;

    [Header("GameOver")]
    bool isSpawnOver;
    infoFallUI fall;
    public GameObject enemySpawn, coinSpawn, spellSpawn, UIScoreCoin, UIGameOver;
    // Start is called before the first frame update
    void Start()
    {
        isSpawnOver = false;
        fall = GameObject.FindObjectOfType<infoFallUI>();
        player = GameObject.FindObjectOfType<Player>();
    }
    private void Awake()
    {
        float t = 2;
        t = t - Time.deltaTime;
        if (t <= 0)
        {
            selectBola();
        }
    }

    // Update is called once per frame
    void Update()
    {
        selectBola();
        timeScore += Time.deltaTime;
        score = (int)timeScore;
        textScore.text = ""+score;
        textCoin.text = "" + currentCoin;
        
    }

    public void addCoin(int coins)
    {
        currentCoin = currentCoin + coins;
    }

    public void checkGameOver(bool isGameOver)
    {
        if(isGameOver)
        {
            gameOver();
        }
    }
    public void gameOver()
    {
        player.checkHighScore(score);
        player.mergeCoin(currentCoin);

        fall.getCoin(currentCoin);
        fall.getScore(score);


        enemySpawn.SetActive(false);
        coinSpawn.SetActive(false);
        spellSpawn.SetActive(false);
        UIScoreCoin.SetActive(false);
        UIGameOver.SetActive(true);
    }

    public void selectBola()
    {
        bola[player.m_skin].SetActive(true);

    }
}
