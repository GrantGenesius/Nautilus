using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Living_counter : MonoBehaviour {
    public Text livingslave;
    public static int living_count = 0;
    public static int max_living_count = -100;
	// Use this for initialization
	void Start () {
        //living_count = 28;
        set_living();
        living_count = 0;
        max_living_count = -1;
	}
	
	// Update is called once per frame
	void Update () {
       set_living();
        if(max_living_count < living_count){
            max_living_count = living_count;
        }
	}

    void set_living() {
        livingslave.text = living_count.ToString();
    }
}
