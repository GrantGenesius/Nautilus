using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class right_click_ray : MonoBehaviour {
    public Camera cam;
    public Transform Spawnpoint;
    public Rigidbody Prefab;

	void Update () {
        // right click mouse input
        //if(Input.GetMouseButtonDown(1)){

        //spacebar input
        if(Input.GetKeyDown("space")){
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit)){
                //action here
                Debug.Log("ray casted using right spacebar");

                //spawn prefab
                Rigidbody RigidPrefab;
                RigidPrefab = Instantiate(Prefab, hit.point, Spawnpoint.rotation);
            }
        }
	}
}
