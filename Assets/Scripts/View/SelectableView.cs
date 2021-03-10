using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace TestScroll.View
{
    [RequireComponent(typeof(Selectable), typeof(PlayerAccountView))]
    public class SelectableView : MonoBehaviour, ISelectHandler
    {
        private PlayerAccountView _view;

        /// <summary>
        /// Invokes, when view selected
        /// </summary>
        /// <param name="eventData"></param>
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
