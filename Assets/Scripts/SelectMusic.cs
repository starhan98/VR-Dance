using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectMusic : MonoBehaviour
{
    public TextMesh selectedMusic;

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
                selectedMusic.text = "\"I AM\" by IVE\nis selected";
            else
                selectedMusic.text = "Select a music";

            isPressed = !isPressed;
        }
    }
}
