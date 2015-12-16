﻿using UnityEngine;
using System.Collections;

public class MovePlatform : MonoBehaviour {

    private bool asPosition = true;
    public float rightPosition = -11.7f;
    public float leftPosition = -12.3f;

    // Update is called once per frame
    void Update () {

        if (asPosition == true)
        {
            Vector3 right = Vector3.right;
            transform.Translate(right * Time.deltaTime, Space.World);
            if (transform.position.x > rightPosition) {
                asPosition = false;
            }
        }
        if (asPosition == false)
        {
            Vector3 left = Vector3.left;
            transform.Translate(left * Time.deltaTime, Space.World);
            if (transform.position.x < leftPosition) {
                asPosition = true;
            }
        }

    }

}
