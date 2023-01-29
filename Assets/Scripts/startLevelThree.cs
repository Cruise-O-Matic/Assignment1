using UnityEngine;
using UnityEngine.SceneManagement;

public class startLevelThree : MonoBehaviour
{

    public void LoadLevelThree()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

}
