using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour
{
    public float speed = 0.0f;
    public bool isStart = false;
    public GameObject target;
    //public GameObject plate;
    //public GameObject pose;
    //public Rod rod;

    //public int maxPose;
    //public Material[] poses;


    // Start is called before the first frame update
    void Start()
    {
        //isStart = false;
        transform.position = new Vector3(7.5f, 2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        speed = 0.03f;
        if (isStart == true)
        {
            //gameObject.SetActive(true);
            transform.Translate(Vector3.left * speed);
        }
    }

    //private Material RandomPoseSelector()
    //{
    //    int randomPoseIndicator = Random.Range(0, poses.Length);
    //    Debug.Log(randomPoseIndicator.ToString());
    //    return poses[randomPoseIndicator];
    //}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("ActionBar"))
        {
            Debug.Log("Plate Triggered to plane");

            target.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("ActionBar"))
        {
            // make this plate disabled
            gameObject.SetActive(false);
        }
    }
}
