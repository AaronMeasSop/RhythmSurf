using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeurScene : MonoBehaviour
{
    public string nomDeLaScene = "Niveau2";

    public void ChangeLaScene()
    {
        SceneManager.LoadScene(nomDeLaScene);
    }
}
