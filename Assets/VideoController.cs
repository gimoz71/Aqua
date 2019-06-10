using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer vid;

    public void Play()
    {
        vid.Play();
    }

    public void Stop()
    {
        vid.Stop();
    }
}
