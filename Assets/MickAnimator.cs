using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MickAnimator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp("w") || Input.GetKeyUp("s") || Input.GetKeyUp("a") || Input.GetKeyUp("d")){
            GetComponent<Animator>().SetTrigger("isJumping");
        }
        
    }
}
