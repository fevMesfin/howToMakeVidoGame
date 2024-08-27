using UnityEngine;
using UnityEngine.SceneManagement;
public class Menus : MonoBehaviour
{
   public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
