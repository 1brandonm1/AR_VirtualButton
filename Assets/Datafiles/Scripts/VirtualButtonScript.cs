using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonScript : MonoBehaviour
{
    public GameObject cubeGO, sphereGO;
    VirtualButtonBehaviour vrb;
    // Start is called before the first frame update
    void Start()
    {
        cubeGO.SetActive(false);
        sphereGO.SetActive(true);

        // Since the VirtualButton is a child of the ImageTarget,
        //  we the component of the button InChildren
        vrb = GetComponentInChildren <VirtualButtonBehaviour>();

        vrb.RegisterOnButtonPressed(onButtonPressed);
        vrb.RegisterOnButtonReleased(onButtonReleased);
    }

    public void onButtonPressed(VirtualButtonBehaviour vb)
    {
        cubeGO.SetActive(true);
        sphereGO.SetActive(false);
        Debug.Log("Button Pressed");
    }

    public void onButtonReleased(VirtualButtonBehaviour vb)
    {
        cubeGO.SetActive(false);
        sphereGO.SetActive(true);
        Debug.Log("Button Released");
    }
}
