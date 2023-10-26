using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Square : Objects
{
    private void Update()
    {
        Move();
    }

    protected override void Action()
    {
        base.Action();
        Vector3 newSize = new Vector2(Random.Range(0.1f, 2f), Random.Range(0.1f, 2f));
        transform.localScale = newSize;
    }
}