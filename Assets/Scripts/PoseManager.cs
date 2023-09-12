using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoseManager : MonoBehaviour
{
    public PlayButton playButton;
    //public Plate[] plates = new Plate[23]; // 23 poses
    public Plate[] plates;
    public TextMesh scoreText;

    private float[] interval = new float[23];
    private int counter;
    private float timer;
    private float beat;
    private float score;
    private float scorePerTarget;
    private int numOfPoses;
    private float speed = 1;
    //private bool isPractice = true;

    private void Awake()
    {
        if (GameStartButton.isPractice)
            speed = 0.75f;
        numOfPoses = 23;
        counter = 0;
        timer = 0f;
        beat = (float)60 / (float)122 / speed;
        scorePerTarget = (float)100 / (float)numOfPoses / 3;
        Debug.Log("beat : " + beat.ToString());
        Debug.Log("score per target : " + scorePerTarget.ToString());
    }

    // Start is called before the first frame update
    void Start()
    {
        //Invoke("TestInvoke", 1.0f);
        if (GameStartButton.isPractice)
        {
            interval[0] = 16.262f;
            scorePerTarget = 0;
        }
        else
            interval[0] = 11.33f;
        interval[1] = beat;
        interval[2] = beat;
        interval[3] = beat;
        interval[4] = beat * 2;
        interval[5] = beat;
        interval[6] = beat;
        interval[7] = beat;
        interval[8] = beat * 2;
        interval[9] = beat * 2;
        interval[10] = beat * 2;
        interval[11] = beat;
        interval[12] = beat;
        interval[13] = beat * 2;
        interval[14] = beat;
        interval[15] = beat;
        interval[16] = beat * 2;
        interval[17] = beat;
        interval[18] = beat;
        interval[19] = beat * 2;
        interval[20] = beat * 3;
        interval[21] = beat;
        interval[22] = beat;
    }

    // Update is called once per frame
    void Update()
    {

        if (playButton.isPressed)
        {
            timer += Time.deltaTime;
            // make the first plate's isStart to true
            if(counter < 23 && timer > interval[counter])
            {
                Debug.Log(interval[counter]);
                DropPlate();
                timer = 0;

                //Invoke("DropPlate", interval[counter]);
            }
        }
        scoreText.text = "Score : " + score.ToString();
    }

    void DropPlate()
    {
        Debug.Log("DropPlate called : " + timer.ToString());
        plates[counter].isStart = true;
        plates[counter].gameObject.SetActive(true);
        counter++;
        //if (counter == 2)
        //    counter = 1;
    }

    public void AddScore()
    {
        score += scorePerTarget;
    }

    void TestInvoke()
    {
        Debug.Log("Test Invoke called: " + timer.ToString());
    }
}
