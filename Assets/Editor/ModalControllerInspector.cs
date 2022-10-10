using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

[CustomEditor(typeof(ModalController))]
public class ModalControllerInspector : Editor
{
    public override void OnInspectorGUI()
    {
        ModalController modalController = target as ModalController;

        modalController.openType = (ModalOpenType)EditorGUILayout.EnumPopup
            ("Modal type", modalController.openType);

        if (modalController.openType == ModalOpenType.doTween)
        {
            modalController.modal =
                EditorGUILayout.ObjectField("Modal", modalController.modal,
                typeof(Transform), true) as Transform;
            modalController.duration =
                EditorGUILayout.FloatField("Duration", modalController.duration);
        }
        else if(modalController.openType == ModalOpenType.animator)
        {
            modalController.animator =
                EditorGUILayout.ObjectField("Animation", modalController.animator,
                typeof(Animator), true) as Animator;
        }

        modalController.hasBackground =  EditorGUILayout.Toggle("Use background", modalController.hasBackground);
        if (modalController.hasBackground)
        {
            modalController.backgroundImage =
                EditorGUILayout.ObjectField("background image", modalController.backgroundImage,
                typeof(Image), true) as Image;
        }
    }
}
