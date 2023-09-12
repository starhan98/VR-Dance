using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftTarget : MonoBehaviour
{
    public bool isHit;
    public GameObject leftTarget;
    public Target target;
    public PoseManager poseManager;

    // Start is called before the first frame update
    void Start()
    {
        isHit = false;
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LeftHand"))
        {
            poseManager.AddScore();
            //target.AddScore();
            leftTarget.SetActive(false);
            isHit = true;
        }
    }
}
