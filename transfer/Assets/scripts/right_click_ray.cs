using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class right_click_ray : MonoBehaviour {
    public Camera cam;
    public Transform Spawnpoint;
    public Rigidbody Prefab;
    public Rigidbody Prefab_c;
    public static float resources = 5000;
    public int apple_cost = 250;
    public int coin_cost = 500;
    public float gainz = 2;
    public int b;

    public Image currentBarlevel;
    //public Text barpercent;

    float maximumpercent = resources;
    float currentpercent = resources;

    void start() {
        updatebar();
    }



	void Update () {
        // right click mouse input
        //if(Input.GetMouseButtonDown(1)){

        //spacebar input, spawn apple
        if (resources > 0)
        {
            if (Input.GetKeyDown("space"))
            {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    //action here
                    Debug.Log("ray casted using spacebar");

                    //spawn prefab
                    Rigidbody RigidPrefab;
                    RigidPrefab = Instantiate(Prefab, hit.point + Vector3.up / 2, Quaternion.Euler(-90, 0, 0));
                    resources -= apple_cost;
                    reducebar(apple_cost);
                    b += 1;
                    //Invoke("GoToNearest",2);
                }
            }
        }


        if (resources > 0)
        {
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
                    RigidPrefab2 = Instantiate(Prefab_c, hit.point + Vector3.up / 2, Quaternion.Euler(-45, -45, -45));
                    resources -= coin_cost;
                    reducebar(coin_cost);
                    b += 1;
                }
            }
        }


        restorebar(gainz);
        resources += gainz;

        //Spawnpoint.rotation
        //f input, spawn magic cubes
	}

    public void updatebar()
    {
        float ratio = currentpercent / maximumpercent;
        currentBarlevel.rectTransform.localScale = new Vector3(ratio, 1, 1);

    }

    public void reducebar(float cost)
    {
        currentpercent -= cost;
        Debug.Log("bar  reduced");
        if (currentpercent < 0)
        {
            currentpercent = 0;
        }

        updatebar();
    }

    void restorebar(float recovery)
    {
        currentpercent += recovery;
        if (currentpercent > maximumpercent)
        {
            currentpercent = maximumpercent;
        }

        updatebar();
    }
}
