using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD_movement : MonoBehaviour {

    public float speed = 1f;
    public Vector3 boundsMax;
    public Vector3 boundsMin;

	void Start () {

	}
	
	
	void Update () {
        transform.position = new Vector3
            (
            Mathf.Clamp(transform.position.x, -15, 15),
            Mathf.Clamp(transform.position.y, 5, 15), 
            Mathf.Clamp(transform.position.z, -15, 15)
            );

        float hori = Input.GetAxis("Horizontal");
        float verti = Input.GetAxis("Vertical");
        transform.position += (Vector3.forward * verti + Vector3.right * hori) * speed * Time.deltaTime;

        float mouse_wheel = Input.GetAxis("Mouse ScrollWheel");

        if (mouse_wheel != 0) {  
            transform.position += (Vector3.down * mouse_wheel) * 200 * Time.deltaTime;

        }

	}
}
