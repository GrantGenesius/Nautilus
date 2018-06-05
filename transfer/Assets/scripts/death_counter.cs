using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class death_counter : MonoBehaviour {
    public Text deadslave;
    public static int death_count;

	void Start () {
        death_count = 0;
        set_dead();
	}

	void Update () {
		
	}

    void OnCollisionEnter(Collision coll){
        //death
        if (coll.gameObject.name == "human circle(Clone)" || coll.gameObject.name == "human_G circle(Clone)" || coll.gameObject.name == "human_D circle(Clone)" || coll.gameObject.name == "human_B circle(Clone)")
        {
            death_count += 1;
            set_dead();
        }
        if (death_count + escape_counter.escape_count >= Living_counter.max_living_count / 2)
        {
            loststage();
        }
    }

    void loststage() {
        //Debug.Log("Level lost!");
        //SceneManager.LoadScene(6);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);
    }

    void set_dead(){
        deadslave.text =  death_count.ToString();
    }
}
