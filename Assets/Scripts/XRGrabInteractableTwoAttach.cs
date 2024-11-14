using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace MyVrSample
{
    /// <summary>
    /// 두개의 Attach Point 구현
    /// </summary>
    public class XRGrabInteractableTwoAttach : XRGrabInteractable
    {
        #region Variables
        public Transform holder_LeftTransform;
        public Transform holder_RightTransform;
        #endregion

       
        protected override void OnSelectEntered(SelectEnterEventArgs args)
        {
            //두개의 Attach Point 를 잡는 손에 따라 구분해서 적용
          if(args.interactorObject.transform.CompareTag("LeftHand"))
            {
                attachTransform = holder_LeftTransform;
            }
            else
            {
                attachTransform = holder_RightTransform;
            }

            base.OnSelectEntered(args);
        }
    }
}