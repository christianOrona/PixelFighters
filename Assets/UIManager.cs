﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public Text points;
    public float numberOfPoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        points.text = numberOfPoints.ToString();
        Debug.Log(numberOfPoints.ToString());
    }


    public void setPoints(float points) {
        numberOfPoints = points;
    }
    public float getPoints() {
        return this.numberOfPoints;
    }
}
