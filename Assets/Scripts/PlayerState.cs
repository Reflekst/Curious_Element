using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerState : MonoBehaviour
{
    public void SetDialogState()
    {
        //GetComponent<PlayerMovment>().enabled = false;
    }
    public void SetGameState()
    {
        GetComponent<PlayerMovment>().enabled = true;
    }
}
