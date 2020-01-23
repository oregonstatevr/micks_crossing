using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceBuilderScript : MonoBehaviour
{
    // Start is called before the first frame update

    public float rightFenceStart = -35f;
    public float leftFenceStart = -195f;

    public float fenceLength = 40f;

    public float rightLimit = 565f;

    public float leftLimit = -455f;

    public GameObject fenceFab;
    void Start()
    {
        Debug.Log("Building Fence");
        float currentLeftStart = leftFenceStart;
        float currentRightStart = rightFenceStart;
        while(currentLeftStart > leftLimit){
            Vector3 fencePosition = new Vector3(currentLeftStart, 25, 155);
            Instantiate(fenceFab, fencePosition, Quaternion.identity);
            currentLeftStart -= fenceLength;
        }
        while(currentRightStart < rightLimit){
            Vector3 fencePosition = new Vector3(currentRightStart, 25, 155);
            Instantiate(fenceFab, fencePosition, Quaternion.identity);
            currentRightStart += fenceLength;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
