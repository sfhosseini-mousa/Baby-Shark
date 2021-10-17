using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    public void ChangeToGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
}
