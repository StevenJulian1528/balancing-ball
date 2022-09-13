using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonsGameOver : MonoBehaviour
{
    public AudioSource click;
    float t = 2f;
    public void retry()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        t = t - Time.time;
        click.Play();
        if (t <= -3f)
        {
            SceneManager.LoadScene("mainPlay");
        }
    }

    public void shop()
    {
        t = t - Time.time;
        click.Play();
        if (t <= 0)
        {
            SceneManager.LoadScene("mainShop");
        }
    }

    public void home()
    {
        t = t - Time.time;
        click.Play();
        if (t <= 0)
        {
            SceneManager.LoadScene("mainMenu");
        }
    }
}
