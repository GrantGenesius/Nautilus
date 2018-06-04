using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateMove : MonoBehaviour {

    public float movingspeed;
    public int multiplier;
    int toggle=0;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("f") && toggle == 0) 
        {
            transform.Translate(0f, 0f, movingspeed  * multiplier);
            toggle += 1;
        }
        else if (Input.GetKeyDown("f") && toggle == 1)
        {
            transform.Translate(0f, 0f, movingspeed  * multiplier * -1);
            toggle -= 1;

        }
	}
}
