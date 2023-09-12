using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadTarget : MonoBehaviour
{
    public bool isHit;
    public GameObject headTarget;
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
        if(other.CompareTag("Head"))
        {
            poseManager.AddScore();
            //target.AddScore();
            headTarget.SetActive(false);
            isHit = true;
        }
    }
}
