using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{
    public Transform player; // transformácia hráèa
    public Transform objectToCheck; // transformácia objektu, ktorı chceme skontrolova

    private void Update()
    {
        if (player.position == objectToCheck.position) // ak pozície hráèa a objektu sú zhodné
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // reštartuj aktuálnu scénu
        }
    }
}

