﻿using UnityEngine ;
using EasyUI.PickerWheelUI ;
using UnityEngine.UI ;

public class Demo : MonoBehaviour {
   [SerializeField] private Button uiSpinButton ;
   [SerializeField] private Text uiSpinButtonText ;

   [SerializeField] private PickerWheel pickerWheel ;
    [SerializeField] private GameObject leaderboard;


    private void Start () {
      uiSpinButton.onClick.AddListener (() => {

         uiSpinButton.interactable = false ;
         uiSpinButtonText.text = "Spinning" ;

         pickerWheel.OnSpinEnd (wheelPiece => {
             AuthHandler.instance.SaveScore(wheelPiece.Label);
             leaderboard.SetActive(true);
            Debug.Log (
               @" <b>Index:</b> " + wheelPiece.Index + "           <b>Label:</b> " + wheelPiece.Label
               + "\n <b>Amount:</b> " + wheelPiece.Amount + "      <b>Chance:</b> " + wheelPiece.Chance + "%"
            ) ;

            uiSpinButton.interactable = true ;
            uiSpinButtonText.text = "Spin" ;
         }) ;

         pickerWheel.Spin () ;

      }) ;

   }

}
