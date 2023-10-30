using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f; // ź�� �̵��ӷ�
    private Rigidbody bulletRigid; // �̵��� ����� ������ٵ� ������Ʈ

    void Start()
    {
        bulletRigid = GetComponent<Rigidbody>();     // ���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� bulletRigid�� �Ҵ�

        bulletRigid.velocity = Vector3.forward * speed; // ������ٵ��� �ӵ� = ���� ���� * �̵� �ӷ�

        Destroy(gameObject, 3f); // 3�� �ڿ� �ڽ��� ���� ������Ʈ �ı�
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
