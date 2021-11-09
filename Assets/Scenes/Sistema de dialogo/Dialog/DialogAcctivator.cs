using UnityEngine;

public class DialogAcctivator : MonoBehaviour, IInteractable
{
    [SerializeField] private DialogObject dialogObject;
    public void Interact(Movimentacao player){
        foreach(DialogueResponseEvents responseEvents in GetComponents<DialogueResponseEvents>()){
            if(responseEvents.DialogueObject==dialogObject){
                player.DialogUI.AddResponseEvents(responseEvents.Events);
                break;
            }
        }

        player.DialogUI.ShowDialogue(dialogObject);
    }

    public void UpdateDialogueObject(DialogObject dialogueObject){
        this.dialogObject=dialogueObject;
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")&& other.TryGetComponent(out Movimentacao player)){
            player.Interactable=this;
            
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("Player")&& other.TryGetComponent(out Movimentacao player)){
            if(player.Interactable is DialogAcctivator dialogAcctivator && dialogAcctivator==this){
                player.Interactable=null;
            }
        }
    }
}
