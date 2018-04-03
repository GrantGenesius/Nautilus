using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete_spawn : MonoBehaviour {

    public float lifetime = 10f;

	void Update () {
		if(lifetime > 0) {
            lifetime -= Time.deltaTime;
            if (lifetime <= 0) {
                Destruction();
            }
        }

        if (this.transform.position.y <= -20) {
            Destruction();
        }
	}

    void OnCollisionEnter(Collision coll) { 
        if(coll.gameObject.name == "delete_spawn"){
            Destruction();
        }
    }

    void Destruction() {
        Destroy(this.gameObject);
    }
}
