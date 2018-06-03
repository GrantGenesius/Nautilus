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
        if (coll.gameObject.name == "slave_03"){
            death_count += 1;
            set_dead();
        }
        if (death_count >= 10)
        {
            //loststage();
        }
    }

    void loststage() {
        Debug.Log("Level lost!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    void set_dead(){
        deadslave.text =  death_count.ToString();
    }
}
