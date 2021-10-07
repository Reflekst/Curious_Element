using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public int id;
    private void OnTriggerEnter(Collider other)
    {
        NpcTrigger.current.NpcTriggerEnter(id);
    }

    private void OnTriggerExit(Collider other)
    {
        NpcTrigger.current.NpcTriggerExit(id);
    }
}
