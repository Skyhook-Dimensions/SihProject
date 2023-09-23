using Assets._Scripts;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalTrigger : MonoBehaviour
{
    public CanvasManager _canvasManager;
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>() != null)
        {
            _canvasManager.ShowPanel("Final");
            other.GetComponent<FirstPersonMovement>().enabled = false;
            other.GetComponent<Jump>().enabled = false;
            other.GetComponent<Crouch>().enabled = false;
            other.transform.GetChild(0).GetComponent<FirstPersonLook>().enabled = false;
        }
    }
}
