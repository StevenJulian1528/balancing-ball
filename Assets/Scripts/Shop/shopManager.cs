using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class shopManager : MonoBehaviour
{
    public Button buyBtn, selectBtn,backBtn;
    Player player;
    public SpriteRenderer sr;
    public List<Sprite> skins = new List<Sprite>();
    private int selectedSkin = 0;
    public GameObject playerSkin,buybtn,selectbtn ;
    int currentCoin;
    public Text coinText,priceText;
    public AudioSource buyed, notbuyed,click;
    float t = 1.5f;

    private void Start()
    {
        player = GameObject.FindObjectOfType<Player>();
        sr.sprite = skins[selectedSkin];
    }
    private void Update()
    {
        checkButton();
        priceText.text = "" + player.m_shopItem[selectedSkin, 2];
        coinText.text = ""+player.m_coin;
    }
    public void nextButton()
    {
        click.Play();
        selectedSkin = selectedSkin + 1;
        if (selectedSkin == skins.Count)
        {
            selectedSkin = 0;
        }
        sr.sprite = skins[selectedSkin];
        checkButton();
    }

    public void previousButton()
    {
        click.Play();
        selectedSkin = selectedSkin - 1;
        if (selectedSkin < skins.Count)
        {
            if(selectedSkin <= 0)
            {
                selectedSkin = 0;
            }
        }
        sr.sprite = skins[selectedSkin];
        checkButton();
    }
    public void checkButton()
    {
        if (player.m_shopItem[selectedSkin,1] == 0)
        {
            buybtn.SetActive(true);
            selectbtn.SetActive(false) ;
        }
        if(player.m_shopItem[selectedSkin, 1] == 1)
        {
            buybtn.SetActive(false); ;
            selectbtn.SetActive(true);
        }
    }
    public void buySkin()
    {
        print(player.m_shopItem[selectedSkin, 2]);
        if(player.m_coin >= player.m_shopItem[selectedSkin,2])
        {
            player.buyItem(selectedSkin);
            buyed.Play();
            print("Buyed!");

        }
        else
        {
            notbuyed.Play();
            print("tidak cukup duit");
        }
    }
    public void selectSkin()
    {
        click.Play();
        player.changeSkin(selectedSkin);

    }

    public void backButton()
    {
        t = t - Time.time ;
        click.Play();
        if (t<=0)
        {
            SceneManager.LoadScene("mainMenu");
        }
    }

}
