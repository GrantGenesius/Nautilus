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
        if (coll.gameObject.name == "slave_03") {
            escape_count += 1;
            set_escaped();
        }
    }

   
    void set_escaped(){
        escapedslave.text = "Escaped slaves : " + escape_count.ToString();
    }
}
