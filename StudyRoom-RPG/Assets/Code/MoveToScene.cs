using UnityEngine;
using UnityEngine.SceneManagement;
 
public class MoveToScene : MonoBehaviour
{
    public void NextScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
