using UnityEngine;

public class InteractionBrain : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            other.gameObject.GetComponent<InteractionController>().Interact += Sit;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            other.gameObject.GetComponent<InteractionController>().Interact -= Sit;
    }

    public void Sit()
    {
        Debug.Log("Test Interaction Detected!");
    }
}