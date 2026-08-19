using UnityEngine;

public class PlayerBase : MonoBehaviour
{
    [SerializeField] private string playerName;
    
    [SerializeField] private float intelligence;
    [SerializeField] private float strength;
    [SerializeField] private float strategicAbility;
    [SerializeField] private float socialSkills;

    public void SetName(string newName)
    {
        playerName = newName;
    }
}
