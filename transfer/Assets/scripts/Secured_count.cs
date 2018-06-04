using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Secured_count : MonoBehaviour {
    public Text securedslave;
    public static int secured_count;
    public GameObject spawnedobject;
    public GameObject spawnedobject2;
    string asd;
    public int win_condition = 10;
    int x = 0;

    void Start(){
        secured_count = 0;
        set_secured(asd);
    }

    void Update(){
    
    }

    void OnCollisionEnter(Collision coll) {
        //escape
        if (coll.gameObject.name == "human circle(Clone)" || coll.gameObject.name == "human_G circle(Clone)") {
            Debug.Log("HIT");
            secured_count += 1;
            set_secured(coll.gameObject.name);
        }
        if (secured_count >= win_condition){
            //endstage();
        }

        
    }

    void poof() {
        Instantiate(spawnedobject, transform.position, transform.rotation);
    }
    void poof2() {
        Instantiate(spawnedobject2, transform.position, transform.rotation);
    }

    void endstage() {
        Debug.Log("Level won!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    void set_secured(string spawnobjectname) {
        securedslave.text = secured_count.ToString();
        if (spawnobjectname == "human circle(Clone)")
        {
            poof();
        }
        if (spawnobjectname == "human_G circle(Clone)")
        {
            poof2();
        }
    }
}
