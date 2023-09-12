using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartButton : MonoBehaviour
{
    public ButtonBox ive;
    public ButtonBox practice;
    public TextMesh errorMsg;
    public static bool isPractice = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("LeftHand") || other.CompareTag("RightHand"))
        {
            if(!ive.isPressed)
            {
                errorMsg.text = "Music is not selected.";
            }
            else
            {
                if (practice.isPressed)
                {
                    // load practice scene
                    Debug.Log("practice scene will be loaded");
                    isPractice = true;
                    SceneManager.LoadScene("PlayPractice");
                }
                else
                {
                    // load game scene
                    Debug.Log("game scene will be loaded");
                    SceneManager.LoadScene("PlayDance");
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("LeftHand") || other.CompareTag("RightHand"))
        {
            errorMsg.text = "";
        }
    }
}
