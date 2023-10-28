using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigid;     // �̵��� ����� rigidbody ������Ʈ
    public float speed = 8f;     // �̵� �ӷ�

    void Start()     // Start() �޼��� : ���� ����� ó�� �ѹ��� ����
    {
        playerRigid = GetComponent<Rigidbody>();     // ���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� playerRigid�� �Ҵ�    
    }

    void Update()     // Update() �޼��� : �� �����ӿ� �ѹ�, �� �����Ӹ��� �ݺ� ����
    {
        float xInput = Input.GetAxis("Horizontal");     // �������� �Է°��� �����Ͽ� ����
        float zInput = Input.GetAxis("Vertical");     // �������� �Է°��� �����Ͽ� ����

            // ���� �̵� �ӵ��� �Է°��� �̵� �ӷ��� ����� ����
        float xSpeed = speed * xInput;
        float zSpeed = speed * zInput;

        Vector3 newVelocity = new Vector3 (xSpeed, 0f, zSpeed);     // Vector3 �ӵ��� (xSpeed, 0f, zSpeed)�� ����

        playerRigid.velocity = newVelocity;     // ������ٵ��� �ӵ��� newVelocity �Ҵ�
    }

    public void Die()     // �÷��̾� ��� �޼���
    {
        gameObject.SetActive(false);     // �ڽ��� ���� ������Ʈ�� ��Ȱ��ȭ
    }
}
