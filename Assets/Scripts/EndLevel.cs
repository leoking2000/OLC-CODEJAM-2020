using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public int index;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(index);
    }

}
