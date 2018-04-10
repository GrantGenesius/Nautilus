using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Secured_count : MonoBehaviour {
    public Text securedslave;
    public static int secured_count;


    void Start(){
        secured_count = 0;
        set_secured();
    }

    void Update(){
    
    }

    void OnCollisionEnter(Collision coll) {
        //escape
        if (coll.gameObject.name == "slave_03") {
            secured_count += 1;
            set_secured();
        }
        if (secured_count >= 10){
            endstage();
        }
    }

    void endstage() {
        Debug.Log("Level won!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    void set_secured() {
        securedslave.text = "Secured slaves : " + secured_count.ToString();
    }
}
