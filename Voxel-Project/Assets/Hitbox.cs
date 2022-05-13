using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hitbox : MonoBehaviour {

    public GameObject HitboxAttack;
    private Animator anim;
    
    void Start() {
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("r") && Input.GetKey("left shift")) {
            SceneManager.LoadScene("GameOver");
        }
        if(Input.GetMouseButtonDown(0)) {
            //if(anim != null) {
                anim.Play("Base Layer.SwordAnimation", 0, 0);
            //}
            swing();
        }
    }
    private void swing() {
        StartCoroutine(SwingSword());
    }
 
    private IEnumerator SwingSword() {
            HitboxAttack.SetActive(true);
            yield return new WaitForSeconds(.1f);
            HitboxAttack.SetActive(false);
    }

    

}

