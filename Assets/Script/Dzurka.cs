using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{
    public Transform player; // transform�cia hr��a
    public Transform objectToCheck; // transform�cia objektu, ktor� chceme skontrolova�

    private void Update()
    {
        if (player.position == objectToCheck.position) // ak poz�cie hr��a a objektu s� zhodn�
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // re�tartuj aktu�lnu sc�nu
        }
    }
}

