using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpossumMove : MonoBehaviour
{
    Vector3 back = new Vector3(6f,-8.5f, .1782574f);
    Vector3 forth = new Vector3(-12f, -8.5f, .1782574f);
    float phase = 0;
    float speed = 1;
    float phaseDirection = 1;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(back, forth, phase);
        phase += Time.deltaTime * speed * phaseDirection;
        if(phase >= 1 || phase <= 0) phaseDirection *= -1;
    }
}
