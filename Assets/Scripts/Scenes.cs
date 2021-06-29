using UnityEngine;
using UnityEngine.SceneManagement;


public class Scenes : MonoBehaviour
{
    private string targetSceneName = "";

    public void SetTargetScene(string name) => targetSceneName = name;

    public void LoadScene() => SceneManager.LoadScene(targetSceneName);

    public void LoadScene(float time) => Invoke("LoadScene", time);

    public void Reload() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    
    public void Quit() => Application.Quit();
}
