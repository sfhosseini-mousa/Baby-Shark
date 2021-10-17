using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int Health { get; set; } = 3;
    public int NextHeartIn { get; set; } = 3;
    [SerializeField] private GameObject[] hearts;
    [SerializeField] GameManager gameManager;

    [SerializeField] GameObject score;

    public void ReduceHealth(int amount)
    {
        Health -= amount;
        ManageCanvasHearts();
        if(Health == 0)
        {
            StartCoroutine(gameManager.EndGame());
        }
    }

    public void IncreaseHealth(int amount)
    {
        Health += amount;
        ManageCanvasHearts();
    }

    void ManageCanvasHearts()
    {
        for (int i = 2; i > Health - 1; i--)
        {
            hearts[i].SetActive(false);
        }

        for (int i = 0; i < Health; i++)
        {
            hearts[i].SetActive(true);
        }
    }

    public void NextHealthForward()
    {
        score.GetComponent<Text>().text = (System.Convert.ToInt32(score.GetComponent<Text>().text) + 1).ToString();
        NextHeartIn--;
        if(NextHeartIn == 0)
        {
            if (Health < 3)
                Health++;
            NextHeartIn = 3;
        }
    }
}
