using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;

public class ResponsesHandler : MonoBehaviour
{
    [SerializeField] private RectTransform responseBox;
    [SerializeField] private RectTransform responseButtonTemplate;
    [SerializeField] private RectTransform responseContainer;

    private DialogUI dialogueUI;
    private ResponseEvent[] responseEvents;

    private List<GameObject> tempResponseButton = new List<GameObject>();
    
    private void Start(){
        dialogueUI=GetComponent<DialogUI>();
    }

    public void AddResponseEvents(ResponseEvent[] responseEvents){
        this.responseEvents = responseEvents;
    }

    public void ShowResponses(Responses[] responses){
        float responseBoxHeight = 0;

        for(int i=0;i<responses.Length;i++){
            Responses response = responses[i];
            int responseIndex=i;

            GameObject responseButton= Instantiate(responseButtonTemplate.gameObject, responseContainer);
            responseButton.gameObject.SetActive(true);
            responseButton.GetComponent<TMP_Text>().text=response.ResponseText;
            responseButton.GetComponent<Button>().onClick.AddListener(()=>OnPickedResponse(response,responseIndex));

            tempResponseButton.Add(responseButton);

            responseBoxHeight+=responseButtonTemplate.sizeDelta.y;
        }
        Debug.Log(responseBoxHeight);
        responseBox.sizeDelta= new Vector2(responseBox.sizeDelta.x, responseBoxHeight);
        responseBox.gameObject.SetActive(true);
    }
    private void OnPickedResponse(Responses response, int responseIndex){
        responseBox.gameObject.SetActive(false);

        foreach(GameObject button in tempResponseButton){
            Destroy(button);
        }
        tempResponseButton.Clear();

        if(responseEvents!=null && responseIndex <= responseEvents.Length){
            responseEvents[responseIndex].OnPickedResponse?.Invoke();
        }

        responseEvents=null;
        if(response.DialogObject){
            dialogueUI.ShowDialogue(response.DialogObject);
        }else{
            dialogueUI.CloseDialogBox();
        }
    }
    
}
