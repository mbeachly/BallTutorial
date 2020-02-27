﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinState : MonoBehaviour
{
    SceneLoader scene;
    // Load win scene when ball triggers red plane

    private void Start()
    {  
        //transform.position = new Vector3(Globals.endX, 0.5F, Globals.endZ);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Balls"))
		{
			GameObject gameObject = new GameObject("SceneLoader");
			scene = gameObject.AddComponent<SceneLoader>();
			scene.LoadWin();
		}
    }
    
}
