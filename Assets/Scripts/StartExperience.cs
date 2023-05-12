using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartExperience : MonoBehaviour
{
    public GameObject[] destroyableObjects;
    public GameObject robot;
    public GameObject whiteboard;
    public GameObject pen;

    public void Start()
    {

    }

    public void StartExperienceButton()
    {
        for (int i = 0; i < destroyableObjects.Length; i++)
        {
            Destroy(destroyableObjects[i]);
        }
        Instantiate(robot, robot.transform);
        Instantiate(whiteboard, whiteboard.transform);
        Instantiate(pen, pen.transform);
    }
}
