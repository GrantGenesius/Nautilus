using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class Improved_AI : MonoBehaviour
{

    public ThirdPersonCharacter character;
    public string target_tag;
    public string target_tag2;
    public int a;
    

    //[SerializeField]
    Transform _destination2;

    NavMeshAgent _navMeshAgent2;

    void Start()
    {
        //lock rotation of 3d model when using a premade controller script
        //_navMeshAgent2.updateRotation = false;

        _navMeshAgent2 = this.GetComponent<NavMeshAgent>();

        if (_navMeshAgent2 == null)
        {
            Debug.LogError("navmesh not connected to " + gameObject.name);
        }
        else
        {
            //FindClosestEnemy();
            GoToNearest();
        }
    }

    public void GoToNearest()
    {
        //if (_destination2 != null)
        //{
           //_destination2.transform.position;

           //a = GetComponent<right_click_ray>().b;
           //var newgameobject = GameObject.Find("gos");

            //if(gos.length == 0){
        Vector3 defaultVector = FindClosestEscape().transform.position;
        _navMeshAgent2.SetDestination(defaultVector);
            //}
            
            //a = GameObject.Find("FindClosestObject").GetComponent<>().gos.length;

           
                Vector3 targetVector = FindClosestObject().transform.position;
                _navMeshAgent2.SetDestination(targetVector);
                
            
            
    }

    public GameObject FindClosestObject()    
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag(target_tag);
        
        GameObject closest = null;
        float distance = 50;
        //float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
            a += 1; 
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;

    }



    public GameObject FindClosestEscape()
    {
        GameObject[] gos2;
        gos2 = GameObject.FindGameObjectsWithTag(target_tag2);
        GameObject closest2 = null;
        float distance2 = Mathf.Infinity;
        Vector3 position2 = transform.position;
        foreach (GameObject go2 in gos2)
        {
            Vector3 diff2 = go2.transform.position - position2;
            float curDistance2 = diff2.sqrMagnitude;
            if (curDistance2 < distance2)
            {
                closest2 = go2;
                distance2 = curDistance2;
            }
        }
        return closest2;
    }

    void Update()
    {
        //FindClosestObject();
        GoToNearest();

        //basic movemeny
        if (_navMeshAgent2.remainingDistance > _navMeshAgent2.stoppingDistance) {
            character.Move(_navMeshAgent2.desiredVelocity, false, false);
        }
        else {
            character.Move(Vector3.zero, false, false);
        }

        
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.name == "Magic_cube")
        {

        }
    }


}
