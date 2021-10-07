using UnityEngine;

[CreateAssetMenu(fileName = "New Speaker", menuName = "Dialogue/New Speaker")]
public class Speaker : ScriptableObject
{
    [SerializeField] private string speakerName;

    public string GetSpeakerName()
    {
        return speakerName;
    }
}
