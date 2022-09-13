using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class playerData
{
    public int coin;
    public int highScore;
    public int[,] shopItem = { { 0, 1, 0 }, { 1, 1, 10 }, { 2, 0, 20 }, { 3, 0, 30 } };
    public int selectedSkin;

    public playerData (Player player)
    {
        coin = player.m_coin;
        highScore = player.m_highScore;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                shopItem[i, j] = player.m_shopItem[i, j];
            }
        }
        selectedSkin = player.m_skin;
    }

}
