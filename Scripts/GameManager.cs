using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverText, ouchText;

    public IEnumerator EndGame()
    {
        ouchText.SetActive(false);
        gameOverText.SetActive(true);
        yield return new WaitForSeconds(2f);

        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
}
