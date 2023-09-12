using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeMode : MonoBehaviour
{
    public TextMesh praticeMode;

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
        if (other.CompareTag("LeftHand") || other.CompareTag("RightHand"))
        {
            if (!isPressed)
                praticeMode.text = "Practice mode\nis selected";
            else
                praticeMode.text = "Practice mode\nnot selected";

            isPressed = !isPressed;
        }
    }
}
