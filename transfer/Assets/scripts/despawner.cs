using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class despawner : MonoBehaviour {

	void Update () {
		
	}


    void OnCollisionEnter(Collision coll){
        //escape
        if (coll.gameObject.name == "escapebox")
        {
            Destruction();
            Living_counter.living_count -= 1;
        }
        //death
        if (coll.gameObject.name == "doom")
        {
            Destruction();
            Living_counter.living_count -= 1;
        }
        //secure
        if (coll.gameObject.name == "Safe")
        {
            Destruction();
            Living_counter.living_count -= 1;
        }
    }
 
    void Destruction(){
        Destroy(this.gameObject);
    }

}
