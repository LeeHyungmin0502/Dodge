using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f; // 탄알 이동속력
    private Rigidbody bulletRigid; // 이동에 사용할 리지드바디 컴포넌트

    void Start()
    {
        bulletRigid = GetComponent<Rigidbody>();     // 게임 오브젝트에서 Rigidbody 컴포넌트를 찾아 bulletRigid에 할당

        bulletRigid.velocity = Vector3.forward * speed; // 리지드바디의 속도 = 앞쪽 방향 * 이동 속력

        Destroy(gameObject, 3f); // 3초 뒤에 자신의 게임 오브젝트 파괴
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();
            
            if (playerController != null)
            {
                playerController.Die();
            }
        }
    }

}
