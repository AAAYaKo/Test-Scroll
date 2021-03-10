using TestScroll.Model;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace TestScroll.View
{
    [RequireComponent(typeof(Selectable), typeof(PlayerAccountView))]
    public class SelectableView : MonoBehaviour, ISelectHandler
    {
        public PlayerAccountModel Model => _view.Model;

        private PlayerAccountView _view;


        public void OnSelect(BaseEventData eventData)
        {
            _view.OnSelection();
        }

        private void Awake()
        {
            _view = GetComponent<PlayerAccountView>();
        }
    }
}
