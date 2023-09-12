using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public HeadTarget headTarget;
    public LeftTarget leftTarget;
    public RightTarget rightTarget;
    public TextMesh timingText;
    public TextMesh scoreText;

    //private int numPose;
    //private float score;
    //private float sum;
    //private float headScore;
    //private float leftScore;
    //private float rightScore;
    //private float scorePerTarget;

    // Start is called before the first frame update
    void Start()
    {
        //numPose = 23;
        //score = 0;
        //headScore = 0;
        //leftScore = 0;
        //rightScore = 0;
        //scorePerTarget = 100 / (float)numPose / 3;
        //Debug.Log(scorePerTarget.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        if(headTarget.isHit && leftTarget.isHit && rightTarget.isHit)
        {
            // Perfect
            timingText.text = "Perfect";
            
        }
        else if((headTarget.isHit && leftTarget.isHit) || (headTarget.isHit && rightTarget.isHit) || (leftTarget.isHit && rightTarget.isHit))
        {
            // Good
            timingText.text = "Good";
            
        }
        else if(headTarget.isHit || leftTarget.isHit || rightTarget.isHit)
        {
            // OK
            timingText.text = "OK";
            
        }
        else
        {
            // Bad
            timingText.text = "Bad";
        }
    }

    //public void AddScore()
    //{
    //    // need debugging
    //    score += scorePerTarget;

    //    //score = 0;
    //    //sum = headScore + leftScore + rightScore;
    //    //score += sum;
    //    //score += headScore;
    //    //score += leftScore;
    //    //score += rightScore;
    //    //headScore = 0;
    //    //leftScore = 0;
    //    //rightScore = 0;
    //}

    //public void HeadScore()
    //{
    //    headScore = scorePerTarget;
    //}

    //public void LeftScore()
    //{
    //    leftScore = scorePerTarget;
    //}

    //public void RightScore()
    //{
    //    rightScore = scorePerTarget;
    //}

}
