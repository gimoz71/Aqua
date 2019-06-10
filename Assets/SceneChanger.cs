using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    static public int scene;


    public void sceneChange(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void sceneIntro()
    {
        SceneManager.LoadScene("Intro");
    }
}
