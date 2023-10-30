using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 8f;     

    Rigidbody playerRigid;     
    Animator anim;

    void Awake()
    {
        playerRigid = GetComponent<Rigidbody>();     
        anim = GetComponent<Animator>(); 
    }

    void Update()    
    {
        float hAxis = Input.GetAxis("Horizontal");     
        float vAxis = Input.GetAxis("Vertical");    

        Vector3 moveVec = new Vector3 (hAxis, 0f, vAxis);

        transform.position += moveVec * speed * Time.deltaTime;
    
        anim.SetBool("isWalk", moveVec != Vector3.zero);
        transform.LookAt(transform.position + moveVec);
    }

    public void Die()    
    {
        gameObject.SetActive(false);  
    }
}
