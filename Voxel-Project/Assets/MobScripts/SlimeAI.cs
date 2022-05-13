using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SlimeAI : MonoBehaviour
{

    public Transform targetPos;
    public float jumpForce = 5000f;

    float lastJumpTime = 0;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        lookAtTarget();
        chaseTarget();

        if (Time.realtimeSinceStartup - lastJumpTime >= 2f)
        {
            lastJumpTime = Time.realtimeSinceStartup;
            jump();
        }
       
    }


    void lookAtTarget()
    {
        this.transform.LookAt(targetPos.position);
    }

    void chaseTarget()
    {
        this.transform.Translate(Vector3.forward * 5f * Time.deltaTime);
    }
    void jump()
    {
        this.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
    }
}
