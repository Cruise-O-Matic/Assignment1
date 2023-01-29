using UnityEngine;
using UnityEngine.SceneManagement;

public class startLevelTwo : MonoBehaviour
{

    public void LoadLevelTwo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

}
