using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour {

    public Animator animator;
    //private int levelToLoad;
	// Update is called once per frame
	void Update () {
		
	}


    public void FadeToLevel() {

        animator.SetTrigger("FadeOut");
    }
}
