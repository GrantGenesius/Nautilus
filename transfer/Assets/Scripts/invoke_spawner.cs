using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class invoke_spawner : MonoBehaviour {

    public GameObject spawnee;
    public bool stop_spawning = false;
    public float spawn_timeWait;
    public float spawn_interval;
    int i = 0;
   
	void Start () {
        
        InvokeRepeating("spawn_slave", spawn_timeWait, spawn_interval);
        //set_living();
	}

    void spawn_slave() {
        Instantiate(spawnee, transform.position, transform.rotation);
        Living_counter.living_count += 1;
        i += 1;
        if(i>=10){
            stop_spawning = true;
        }
        if (stop_spawning) {
            CancelInvoke("spawn_slave");
        }
    }

    void update(){
        //set_living();
    }

    void set_living()
    {
        //roaming.text = Living_count.ToString();
    }


}
