using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public int index;
    public bool isLastLevel;

    private void OnTriggerEnter(Collider other)
    {
        if(isLastLevel == false)
        {
            SceneManager.LoadScene(index);
        }
    }

}
