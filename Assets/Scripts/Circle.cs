using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Objects
{
    public Sprite[] sprites;


    private void Update()
    {
        Move();
    }

    protected override void Action()
    {
        base.Action();
        int i = Random.Range(0, 3);
        spriteRenderer.sprite = sprites[i];
    }
}
