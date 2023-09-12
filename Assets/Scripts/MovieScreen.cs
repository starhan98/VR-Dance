using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MovieScreen : MonoBehaviour
{
    public PlayButton playButton;
    public VideoPlayer video;

    private bool isPlayed;

    // Start is called before the first frame update
    void Start()
    {
        isPlayed = false;
        video.url = Application.streamingAssetsPath+"/IVE_IAM_Highlight.mp4";
        //video = gameObject.GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playButton.isPressed && !isPlayed)
        {
            video.Play();
            video.gameObject.GetComponent<MeshRenderer>().enabled = true;
            isPlayed = true;
        }
    }
}
