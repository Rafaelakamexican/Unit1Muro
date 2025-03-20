using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // press k to swich camera between Main Camera and Vice Camera
        if (Input.GetKeyDown(KeyCode.K))
        {
            // get the camera
            Camera camera = GetComponent<Camera>();
            // swich camera
            camera.enabled = !camera.enabled;
        }

    }
}
