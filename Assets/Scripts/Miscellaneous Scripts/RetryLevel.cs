using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryLevel : MonoBehaviour
{
    [SerializeField] private string _sceneName;
    public void Retry()
    {
        SceneManager.LoadScene(_sceneName);
    }
}
