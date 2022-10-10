# Documentation

## How to install

To install it on unity, go to the package manager, click in the + button, then Add package from git URL, and paste this git:

[https://github.com/MrBaidu/UnityModalController.git](https://github.com/MrBaidu/UnityModalController.git)

Alternatively, you may download the .unityPackage inside the same link.

For more information, follow: [https://docs.unity3d.com/Manual/upm-ui.html](https://docs.unity3d.com/Manual/upm-ui.html)

---

## Components

### ModalController

It is used to control modals and is the base to all other components.

It has 3 modal types, only open, animator and Dotween.

| Modal Type | Description | Requirement |
| --- | --- | --- |
| Only open | Enables/disables the modal | None |
| Animator | Uses animator component to open and close modal | Animator component |
| Dotween | Uses dotween to scale the modal | Modal transform and tween duration |

It has a toogle for control background. The background is an image and is used for disable any interaction with others screens or the environment itself.

For more control, It has two UnityEvents.

| Event | When is called |
| --- | --- |
| OnOpenModal | Called when modal is opened |
| OnCloseModal | Called when modal is closed |

---

### ObjectHighlight

Is used when more accuracy in UI component selection is needed. It has two events, that can be set it in inspector or via scripts.

| Event | When is called |
| --- | --- |
| OnSelected | Called when game object is the focus |
| OnDeselected | Called when game object is no longer the focus |

---

## About

Made by ABilesck

Version 1.0.0