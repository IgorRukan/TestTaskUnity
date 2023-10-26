using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Objects
{
    private void Update()
    {
        Move();
    }
    protected override void Action()
    {
        Color randomColor = Random.ColorHSV();
        ChangeColor(randomColor);
    }

    private void ChangeColor(Color newColor)
    {
        spriteRenderer.color = newColor;
    }
}