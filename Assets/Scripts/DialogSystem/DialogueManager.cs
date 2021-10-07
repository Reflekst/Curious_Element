using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DialogueManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI speakerName, dialogue, navButtonText;

    private int currentIndex;
    private Conversation currentConversation;
    private static DialogueManager instance;
    private Animator animator;

    #region Singleton
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            animator = GetComponent<Animator>();
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public static void StartConversation(Conversation conversation)
    {
        instance.animator.SetBool("isOpen", true);
        instance.currentIndex = 0;
        instance.currentConversation = conversation;
        instance.speakerName.text = "";
        instance.dialogue.text = "";
        instance.navButtonText.text = ">";

        instance.ReadNext();
    }
    #endregion

    public void ReadNext()
    {
        if (currentIndex > currentConversation.GetLength())
        {
            instance.animator.SetBool("isOpen", false);
            return;
        }
        speakerName.text = currentConversation.GetLineByIndex(currentIndex).speaker.GetSpeakerName();
        dialogue.text = currentConversation.GetLineByIndex(currentIndex).dialogue;

        if (currentIndex >= currentConversation.GetLength())
        {
            navButtonText.text = "X";
        }
        currentIndex++;
    }
}
