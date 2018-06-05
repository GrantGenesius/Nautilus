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
    public GameObject spawnedobject3;
    public GameObject spawnedobject4;
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
        if (coll.gameObject.name == "human circle(Clone)" || coll.gameObject.name == "human_G circle(Clone)" || coll.gameObject.name == "human_D circle(Clone)" || coll.gameObject.name == "human_B circle(Clone)")
        {
            Debug.Log("HIT");
            secured_count += 1;
            right_click_ray.resources += 150;
            set_secured(coll.gameObject.name);
        }
        if (secured_count >= Living_counter.max_living_count/2){
            endstage();
        }

        
    }

    void poof() {
        x += 1;
        Instantiate(spawnedobject, transform.position, transform.rotation);
    }
    void poof2() {
        Instantiate(spawnedobject2, transform.position, transform.rotation);
    }
    void poof3()
    {
        Instantiate(spawnedobject3, transform.position, transform.rotation);
    }
    void poof4() {
        Instantiate(spawnedobject4, transform.position, transform.rotation);
    }

    void endstage() {
        Debug.Log("Level won!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 11);

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
        if (spawnobjectname == "human_D circle(Clone)")
        {
            poof3();
        }
        if (spawnobjectname == "human_B circle(Clone)"){
            poof4();
        }

    }
}
