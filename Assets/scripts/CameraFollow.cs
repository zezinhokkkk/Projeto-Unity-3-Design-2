﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;

    public float lerpRate = 4f;
    bool follow = true;

    void Update()
    {
        if (follow == false) {
            return;
        }
        if (player.transform.position.y > transform.position.y) {
            Vector3 initialPosition = transform.position;
            Vector3 finalPosition = new Vector3(initialPosition.x, player.transform.position.y, initialPosition.z);
            transform.position = Vector3.Lerp(initialPosition, finalPosition, lerpRate * Time.deltaTime);

        }
    }
    public void TurnOff() {
        follow = false;
    }
}
