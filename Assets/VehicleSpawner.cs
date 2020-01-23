using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSpawner : MonoBehaviour
{
    public GameObject[] vehicleFabs;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnVehicle");
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator SpawnVehicle() {
        while(true){
            yield return new WaitForSeconds(Random.Range(2,10));
            GameObject v = Instantiate(vehicleFabs[Random.Range(0,2)], transform.position, Quaternion.AngleAxis(-90, Vector3.up));
            v.transform.position = new Vector3(v.transform.position.x, 3, v.transform.position.z);
        }
    }
}
