using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightTarget : MonoBehaviour
{
    public bool isHit;
    public GameObject rightTarget;
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
        if (other.CompareTag("RightHand"))
        {
            //target.AddScore();
            poseManager.AddScore();
            rightTarget.SetActive(false);
            isHit = true;
        }
    }
}
