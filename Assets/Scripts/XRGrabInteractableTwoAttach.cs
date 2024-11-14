using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace MyVrSample
{
    /// <summary>
    /// �ΰ��� Attach Point ����
    /// </summary>
    public class XRGrabInteractableTwoAttach : XRGrabInteractable
    {
        #region Variables
        public Transform holder_LeftTransform;
        public Transform holder_RightTransform;
        #endregion

       
        protected override void OnSelectEntered(SelectEnterEventArgs args)
        {
            //�ΰ��� Attach Point �� ��� �տ� ���� �����ؼ� ����
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