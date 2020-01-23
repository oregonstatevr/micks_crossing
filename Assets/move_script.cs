using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_script : MonoBehaviour
{
    bool isVerticalReset = true;
    bool isHorizontalReset = true;

    public CharacterController controller;

    public GameObject reference;

    //private Vector3 targetVerticalPosition = new Vector3(0, 0, transform.position.z + 5);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetAxis ("Vertical") > 0 && transform.position.z <= targetVerticalPosition.z){
        //     controller.Move(reference.transform.forward * 1);
        //     //targetVerticalPosition = transform.position + new Vector3(0, 0, 5);
        // } 
        if(Input.GetKeyUp("w")){
            //Debug.Log("Vertical is up");
            FindObjectOfType<AudioManager>().Play("Step");
            FindObjectOfType<GameManagerScript>().Score+=1;
            //GetComponent<Animator>().SetTrigger("isJumping");
            StartCoroutine("JumpForward");
        }

        if(Input.GetKeyUp("s")){
            //Debug.Log("Vertical is up");
            FindObjectOfType<AudioManager>().Play("Step");
            FindObjectOfType<GameManagerScript>().Score-=1;
            //GetComponent<Animator>().SetTrigger("isJumping");
            StartCoroutine("JumpBack");
        }

        if(Input.GetKeyUp("a")){
            //Debug.Log("Vertical is up");
            FindObjectOfType<AudioManager>().Play("Step");
            //GetComponent<Animator>().SetTrigger("isJumping");
            StartCoroutine("JumpLeft");
        }

        if(Input.GetKeyUp("d")){
            //Debug.Log("Vertical is up");
            FindObjectOfType<AudioManager>().Play("Step");
            //GetComponent<Animator>().SetTrigger("isJumping");
            StartCoroutine("JumpRight");
        }

        // if(isHorizontalReset && Input.GetAxis ("Horizontal") > 0){
        //     Debug.Log("Moving "+isVerticalReset+" "+Input.GetAxis ("Vertical"));
        //     controller.Move(transform.forward * 1);
        //     isVerticalReset = false;
        // }        
        
    }

    IEnumerator JumpForward() {
        var currentPosition = transform.position;
        var targetPosition = new Vector3(currentPosition.x, currentPosition.y, currentPosition.z+10);
        Debug.Log("Position "+ transform.position);
        float t = 0f;
        while(t<1){
            t += Time.deltaTime / 0.5f;
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, reference.transform.forward, t, 0.0f);
            transform.position = Vector3.Lerp(currentPosition, targetPosition, t); 
            transform.rotation = Quaternion.LookRotation(newDirection);
            yield return null ;    
        }
    }
    IEnumerator JumpLeft() {
        var currentPosition = transform.position;
        var targetPosition = new Vector3(currentPosition.x-10, currentPosition.y, currentPosition.z);
        Debug.Log("Position "+ transform.position);
        float t = 0f;
        while(t<1){
            t += Time.deltaTime / 0.5f;
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, -reference.transform.right, t, 0.0f);
            transform.position = Vector3.Lerp(currentPosition, targetPosition, t); 
            transform.rotation = Quaternion.LookRotation(newDirection);
            yield return null ;    
        }
    }

    IEnumerator JumpRight() {
        var currentPosition = transform.position;
        var targetPosition = new Vector3(currentPosition.x+10, currentPosition.y, currentPosition.z);
        Debug.Log("Position "+ transform.position);
        float t = 0f;
        while(t<1){
            t += Time.deltaTime / 0.5f;
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, reference.transform.right, t, 0.0f);
            transform.position = Vector3.Lerp(currentPosition, targetPosition, t); 
            transform.rotation = Quaternion.LookRotation(newDirection);
            yield return null ;    
        }
    }

    IEnumerator JumpBack() {
        var currentPosition = transform.position;
        var targetPosition = new Vector3(currentPosition.x, currentPosition.y, currentPosition.z-10);
        Debug.Log("Position "+ transform.position);
        float t = 0f;
        while(t<1){
            t += Time.deltaTime / 0.5f;
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, -reference.transform.forward, t, 0.0f);
            transform.position = Vector3.Lerp(currentPosition, targetPosition, t); 
            transform.rotation = Quaternion.LookRotation(newDirection);
            yield return null ;    
        }
    }
}
