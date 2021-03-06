﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
public class InputAccepter : MonoBehaviour
{
    public float speed = 1.0f;
    public float zstep = 1.0f;
    public float xstep = 1.0f;
    public float ystep = 1.0f;
    public GameObject world;

    private void Awake()
    {
        Player.onTriggerDown += TriggerDown;
        Player.onTuchpadDown += TriggerDown;
        Player.onTuchpadUp += TriggerUp;
        Player.onBackButtonDown += BackButtonDown;
    }

    private void Start()
    {
        world = GameObject.FindWithTag("Player");
        world.transform.position = new Vector3(xstep, ystep, zstep);
    }

    private void TriggerDown()
    {
        world = GameObject.FindWithTag("Player");
    }

    private void TriggerUp()
    {
        world = GameObject.FindWithTag("Player");
    }

    private void BackButtonDown()
    {
        var scene = SceneManager.GetActiveScene().name;
      
        if (scene == "PlanetSystem")
        {
          
            SceneManager.LoadScene("StarMap", LoadSceneMode.Single);
        }
        else if (scene == "PlanetInfo")
        {
        
          SceneManager.LoadScene("PlanetSystem", LoadSceneMode.Single);
        }
        else
        {
            OVRManager.PlatformUIConfirmQuit();
        };
    }
}