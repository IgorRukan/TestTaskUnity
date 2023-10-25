using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Square : MonoBehaviour
{
    public float speed = 5f;
    public int signX = 1;
    public int signY = 1;

    private void Start()
    {
        signX = Random.Range(0, 2) * 2 - 1;
        signY = Random.Range(0, 2) * 2 - 1;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 newPos = new Vector3(transform.position.x + speed * signX* Time.deltaTime,
            transform.position.y + speed * signY* Time.deltaTime);
        transform.position = newPos;
    }

    private void ChangeSign(int num)
    {
        if (num > 0)
        {
            signX *= -1;
        }
        else
        {
            signY *= -1;
        }
    }

    private void Action()
    {
        Vector3 newSize = new Vector2(Random.Range(0.1f, 2f), Random.Range(0.1f, 2f));
        transform.localScale = newSize;
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Enter");
        if (other.collider.gameObject.tag.Equals("WallX"))
        {
            ChangeSign(1);
        }

        if (other.gameObject.tag.Equals("WallY"))
        {
            ChangeSign(-1);
        }

        Action();
    }
}