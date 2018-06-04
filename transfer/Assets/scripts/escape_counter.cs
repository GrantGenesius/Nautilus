using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class escape_counter : MonoBehaviour {
    public Text escapedslave;
    public static int escape_count;


    void Start() {
        escape_count = 0;
        set_escaped();
    }

    void Update() {

    }

    void OnCollisionEnter(Collision coll){
        //escape
        if (coll.gameObject.name == "human circle(Clone)" || coll.gameObject.name == "human_G circle(Clone)" || coll.gameObject.name == "human_D circle(Clone)")
        {
            escape_count += 1;
            set_escaped();
        }
    }

   
    void set_escaped(){
        escapedslave.text = escape_count.ToString();
    }
}
