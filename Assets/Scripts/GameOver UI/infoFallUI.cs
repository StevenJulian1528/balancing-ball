using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class infoFallUI : MonoBehaviour
{
    public Text scoreInfoText, coinInfoText;
    int currentCoin, currentScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreInfoText.text = "" + currentScore;
        coinInfoText.text = "" + currentCoin;
    }
    
    public void getScore(int score)
    {
        currentScore = score;
    }

    public void getCoin(int coin)
    {
        currentCoin = coin;
    }
}
