using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController: MonoBehaviour
{

float dist = 0;
float  t = 0;
float moveSpd = 10;

void Update()
{
    t +=   1 * Time.deltaTime;
        sign = -sign;
        t= 0;
        dist = Random.Range(5,7);

    transform.position += (Vector3.right * (moveSpd * sign) * dist) * Time.deltaTime;
}
}