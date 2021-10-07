using UnityEngine;

public class NpcConversationManager : MonoBehaviour
{
    [SerializeField] private Conversation positiveConversation, negativeConversation, neutralConversation;

    [SerializeField] private int id;

    public void SelectTypeOfCoversation(int id, int state)
    {
        if (id == this.id)
        {
            if (state == 1)
            {
                StartConversation(positiveConversation);
            }
            else if (state == -1)
            {
                StartConversation(negativeConversation);
            }
            else if(state == 0)
            {
                StartConversation(neutralConversation);
            }
        }
    }   
    private void StartConversation(Conversation conv)
    {
        DialogueManager.StartConversation(conv);
    }
}
