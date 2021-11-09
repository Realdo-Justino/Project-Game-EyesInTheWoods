using System.Collections;
using UnityEngine;
using TMPro;

public class DialogUI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private GameObject dialogueBox;

    public bool IsOpen{ get; private set;}

    private Efeito_Tipewriter efeitoTipewriter;
    private ResponsesHandler responsesHandler;
    private void Start(){
        efeitoTipewriter=GetComponent<Efeito_Tipewriter>();
        responsesHandler=GetComponent<ResponsesHandler>();
        CloseDialogBox();
    }

    public void ShowDialogue(DialogObject dialogueObject){
        IsOpen=true;
        dialogueBox.SetActive(true);
        StartCoroutine(StepThroghtDialogue(dialogueObject));
    }

    public void AddResponseEvents(ResponseEvent[] responseEvents){
        responsesHandler.AddResponseEvents(responseEvents);
    }
   
   private IEnumerator StepThroghtDialogue(DialogObject dialogueObject){

       for(int i=0;i<dialogueObject.Dialogue.Length;i++){
           string dialogue=dialogueObject.Dialogue[i];

           yield return RunTypingEffect(dialogue);

           textLabel.text=dialogue;

           if(i==dialogueObject.Dialogue.Length-1 && dialogueObject.Hasresponses){
               break;
           }
           yield return null;
           yield return new WaitUntil(()=>Input.GetKeyDown(KeyCode.DownArrow));
       }

        if(dialogueObject.Hasresponses){
            responsesHandler.ShowResponses(dialogueObject.Responses);
        }else{
            CloseDialogBox();
        }
   }

   private IEnumerator RunTypingEffect(string dialogue){
       efeitoTipewriter.Run(dialogue,textLabel);

       while(efeitoTipewriter.IsRunning){
           yield return null;

           if(Input.GetKeyDown(KeyCode.DownArrow)){
               efeitoTipewriter.Stop();
           }
       }
   }

   public void CloseDialogBox(){
       IsOpen=false;
       dialogueBox.SetActive(false);
       textLabel.text = string.Empty;
   }
}
