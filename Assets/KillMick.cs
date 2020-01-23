using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillMick : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject deadMick;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="Vehicle" || other.gameObject.tag=="Hurdle"){
            Instantiate(deadMick, this.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
