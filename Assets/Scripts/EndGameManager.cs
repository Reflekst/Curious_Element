using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameManager : MonoBehaviour
{
    [SerializeField] private GameObject winPanel;
    public void CheckAmountOfNumbers(List<Item> items)
    {
        if (items.Count >= 5)
        {
            StartCoroutine(Win());
        }
    }

    private IEnumerator Win()
    {
        yield return new WaitForSeconds(5);
        winPanel.SetActive(true);
    }    
}
