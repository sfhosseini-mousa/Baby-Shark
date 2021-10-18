using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishColideDitector : MonoBehaviour
{
    private PlayerHealth playerHealth;
    private MessageManager messageManager;

    private void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
        messageManager = FindObjectOfType<MessageManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Colider")
        {
            if(gameObject.name == "Good Fish(Clone)")
            {
                playerHealth.NextHealthForward();
                messageManager.ShowMessage(true);
                Destroy(gameObject);
            }
            else if (gameObject.name == "Bad Fish(Clone)")
            {
                playerHealth.ReduceHealth(1);
                messageManager.ShowMessage(false);
                Destroy(gameObject);
            }
        }
    }

    
}
