using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public string targetTag; // �������� ��� ��������� ��'����

    void OnCollisionEnter(Collision collision)
    {
        // ����������, �� ��� ��������� ��'���� ������� � �������� �����
        if (collision.gameObject.CompareTag(targetTag))
        {
            // ���� ����� ���������� � ��'����� � �������� �����, ������ ��� ��'���
            Destroy(gameObject);
        }
    }
}
