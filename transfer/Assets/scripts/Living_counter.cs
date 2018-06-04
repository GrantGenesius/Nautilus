using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Living_counter : MonoBehaviour {
    public Text livingslave;
    public static int living_count = 0;
	// Use this for initialization
	void Start () {
        //living_count = 28;
        set_living();
	}
	
	// Update is called once per frame
	void Update () {
       set_living();
	}

    void set_living() {
        livingslave.text = living_count.ToString();
    }
}
