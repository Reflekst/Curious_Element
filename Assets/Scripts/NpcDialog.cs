using System;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class StartDialogEvent : UnityEvent { }

public class NpcDialog : MonoBehaviour
{
    [SerializeField] private GameObject pressEText;

    public static NpcDialog current;

    private void Awake()
    {
        current = this;
    }

    public int id;
    private bool inRange;
    public StartDialogEvent dialogEvent;

    public event Action<int> onNpcDialogStart;
    public void NpcDialogStart(int id)
    {
        if (onNpcDialogStart != null)
        {
            onNpcDialogStart(id);
        }
    }

    private void Start()
    {
        NpcTrigger.current.onNpcTriggerEnter += OnUiShow;
        NpcTrigger.current.onNpcTriggerExit += OnUiHide;
    }
    private void OnUiShow(int id)
    {
        if (id == this.id)
        {
            inRange = true;
            pressEText.SetActive(true);
        }
    }

    private void OnUiHide(int id)
    {
        if (id == this.id)
        {
            inRange = false;
            pressEText.SetActive(false);
        }
    }

    public void OnEpress()
    {
        if (inRange)
        {
            OnDialog();
        }
    }

    public void OnDialog()
    {
        if (dialogEvent != null)
        {
            dialogEvent.Invoke();
        }
    }
    private void OnDestroy()
    {
        NpcTrigger.current.onNpcTriggerEnter -= OnUiShow;
        NpcTrigger.current.onNpcTriggerExit -= OnUiHide;
    }

}
