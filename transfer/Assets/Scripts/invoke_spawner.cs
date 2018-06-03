using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invoke_spawner : MonoBehaviour {

    public GameObject spawnee;
    public bool stop_spawning = false;
    public float spawn_timeWait;
    public float spawn_interval;
    int i = 0;
   
	void Start () {
        
        InvokeRepeating("spawn_slave", spawn_timeWait, spawn_interval);
	}

    void spawn_slave() {
        Instantiate(spawnee, transform.position, transform.rotation);
        i += 1;
        if(i>=10){
            stop_spawning = true;
        }
        if (stop_spawning) {
            CancelInvoke("spawn_slave");
        }
    }


}
