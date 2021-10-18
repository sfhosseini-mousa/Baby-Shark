using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkController : MonoBehaviour
{
    [SerializeField] private Transform moveTo;
    private bool move;
    private bool canPressSpace;
    private Vector3 initialPos;
    [SerializeField] private GameObject spaceText;

    // Start is called before the first frame update
    void Start()
    {
        initialPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canPressSpace)
        {
            spaceText.SetActive(false);
            move = true;
            canPressSpace = false;
        }

        if (move)
        {
            Vector3 newPos = Vector3.MoveTowards(transform.position, moveTo.position, 15f * Time.deltaTime);
            transform.position = newPos;

            if (newPos == moveTo.position)
                move = false;
        }

        if (!move)
        {
            Vector3 newPos = Vector3.MoveTowards(transform.position, initialPos, 20f * Time.deltaTime);
            transform.position = newPos;

            if (newPos == initialPos)
                canPressSpace = true;
        }
    }
}
