using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveNegative : MonoBehaviour
{
    public float moveRange = 3f; // Заданий діапазон руху
    public float moveSpeed = 2f; // Швидкість руху
    private bool moveRight = true; // Прапорець, що вказує на напрямок руху
    public string targetTag = "Life";

    void Update()
    {
        // Перевірка, чи досягнута ліва або права межа діапазону
        if (transform.position.x >= moveRange && moveRight)
            moveRight = false;
        else if (transform.position.x <= -moveRange && !moveRight)
            moveRight = true;

        // Рух фігурки вліво або вправо залежно від напрямку руху
        if (moveRight)
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        else
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
    }
}

