using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitButtom : MonoBehaviour
{
    public void onRestartClick() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
public void onExitclick() {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
