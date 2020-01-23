using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public static GameManagerScript instance;

    public GameObject scoreBoard;
    private int score;
    public int Score {
        get {
            return score;
        }
        set {
            scoreBoard.GetComponent<UnityEngine.UI.Text>().text = value.ToString();
            score = value;
        }
    }

    // Start is called before the first frame update
    void Awake(){
        if(instance==null){
            instance=this;
        }else{
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }
}
