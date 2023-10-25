using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    public float speed = 5f;
    public int signX = 1;
    public int signY = 1;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        signX = Random.Range(0, 2) * 2 - 1;
        signY = Random.Range(0, 2) * 2 - 1;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 newPos = new Vector3(transform.position.x + speed * signX * Time.deltaTime,
            transform.position.y + speed * signY * Time.deltaTime);
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
        Color randomColor = Random.ColorHSV();
        ChangeColor(randomColor);
    }

    private void ChangeColor(Color newColor)
    {
        spriteRenderer.color = newColor;
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