using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class right_click_ray : MonoBehaviour {
    public Camera cam;
    public Transform Spawnpoint;
    public Rigidbody Prefab;
    public Rigidbody Prefab_c;

	void Update () {
        // right click mouse input
        //if(Input.GetMouseButtonDown(1)){

        //spacebar input, spawn apple
        if(Input.GetKeyDown("space")){
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit)){
                //action here
                Debug.Log("ray casted using spacebar");

                //spawn prefab
                Rigidbody RigidPrefab;
                RigidPrefab = Instantiate(Prefab, hit.point + Vector3.up/2, Spawnpoint.rotation);
            }
        }

        //c input, spawn coin
        if (Input.GetKeyDown("c"))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                //action here
                Debug.Log("ray casted using c");

                //spawn prefab
                Rigidbody RigidPrefab2;
                RigidPrefab2 = Instantiate(Prefab_c, hit.point + Vector3.up/2, Spawnpoint.rotation);
            }
        }

        //f input, spawn magic cubes
	}
}
