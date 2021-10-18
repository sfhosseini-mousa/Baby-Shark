using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageManager : MonoBehaviour
{
    [SerializeField] GameObject gJText, ouchText;

    public void ShowMessage(bool GJ)
    {
        if (GJ)
            StartCoroutine(ShowMessageGJ());
        else
            StartCoroutine(ShowMessageOuch());
    }

    public IEnumerator ShowMessageGJ()
    {
        gJText.SetActive(true);
        yield return new WaitForSeconds(1);
        gJText.SetActive(false);
    }

    public IEnumerator ShowMessageOuch()
    {
        ouchText.SetActive(true);
        yield return new WaitForSeconds(1);
        ouchText.SetActive(false);
    }
}
