using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveNegative : MonoBehaviour
{
    public float moveRange = 3f; // ������� ������� ����
    public float moveSpeed = 2f; // �������� ����
    private bool moveRight = true; // ���������, �� ����� �� �������� ����
    public string targetTag = "Life";

    void Update()
    {
        // ��������, �� ��������� ��� ��� ����� ���� ��������
        if (transform.position.x >= moveRange && moveRight)
            moveRight = false;
        else if (transform.position.x <= -moveRange && !moveRight)
            moveRight = true;

        // ��� ������� ���� ��� ������ ������� �� �������� ����
        if (moveRight)
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        else
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
    }
}

