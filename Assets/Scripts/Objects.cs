using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{
    public float speed = 5f;
    public int signX = 1;
    public int signY = 1;
    protected SpriteRenderer spriteRenderer;

    protected void Start()
    {
        signX = Random.Range(0, 2) * 2 - 1;
        signY = Random.Range(0, 2) * 2 - 1;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Move();
    }

    protected void Move()
    {
        Vector3 newPos = new Vector3(transform.position.x + speed * signX * Time.deltaTime,
            transform.position.y + speed * signY * Time.deltaTime);
        transform.position = newPos;
    }

    protected virtual void Action()
    {
        
    }

    protected virtual void ChangeSign(int num)
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

    protected virtual void OnCollisionEnter2D(Collision2D other)
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