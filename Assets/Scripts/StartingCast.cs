using UnityEngine;

public class StartingCast : MonoBehaviour
{
    //Player References
    [SerializeField] private GameObject[] players;
    [SerializeField] private GameObject playerPrefab;
    [SerializeField] private int castSize;
    
    //Player Modifiers
    [SerializeField] private string[] names;

    void Start()
    {
        SetCastSize();
    }

    private void SetCastSize()
    {
        players = new GameObject[castSize];
        
        for (int i = 0; i < castSize; i++)
        {
            players[i] = Instantiate(playerPrefab, transform.position, Quaternion.identity);
            players[i].GetComponent<PlayerBase>().SetName(names[i]);
        }
    }
}
