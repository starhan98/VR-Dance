using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBox : MonoBehaviour
{
    public Material unpressed;
    public Material pressed;

    public bool isPressed;
    // Start is called before the first frame update
    void Start()
    {
        isPressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("LeftHand") || other.CompareTag("RightHand"))
        {
            if (!isPressed)
                gameObject.GetComponent<MeshRenderer>().material = pressed;
            else
                gameObject.GetComponent<MeshRenderer>().material = unpressed;

            isPressed = !isPressed;
        }
    }
}
