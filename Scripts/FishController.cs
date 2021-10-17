using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishController : MonoBehaviour
{
    private bool goodFish = false;
    private GameObject fish;
    [SerializeField] private Transform fishParent;
    private Vector3 initialPos;
    // Start is called before the first frame update
    void Start()
    {
        initialPos = fishParent.transform.position;
        StartCoroutine(BeginFishGeneration());
    }

    // Update is called once per frame
    void Update()
    {
        fishParent.transform.RotateAround(transform.position, Vector3.forward, 40 * Time.deltaTime);
    }

    IEnumerator BeginFishGeneration()
    {
        while (true)
        {
            GameObject fishPrefab;

            if (Random.Range(0, 100) >= 40)
                goodFish = true;
            else
                goodFish = false;

            if (goodFish)
            {
                fishPrefab = (Resources.Load("Good Fish")) as GameObject;
            }
            else
            {
                fishPrefab = (Resources.Load("Bad Fish")) as GameObject;
            }

            fish = Instantiate(fishPrefab);
            fish.transform.SetParent(fishParent);
            fish.transform.localPosition = Vector3.zero;

            yield return new WaitForSeconds(3f);

            try
            {
                Destroy(fish);
            }
            catch (System.Exception) { Debug.Log("already destroyed"); }
            
            fishParent.transform.position = initialPos;
        }
        
    }
}
