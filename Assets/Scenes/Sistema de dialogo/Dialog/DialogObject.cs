using UnityEngine;

[CreateAssetMenu(menuName ="Dialog/DialogObject")]

public class DialogObject : ScriptableObject
{
    [SerializeField] [TextArea] private string[] dialogue;
    [SerializeField] private Responses[] responses;

    public string[] Dialogue => dialogue;

    public bool Hasresponses=>Responses != null && Responses.Length>0;

    public Responses[] Responses => responses;
}
