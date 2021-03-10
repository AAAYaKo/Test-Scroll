using TestScroll.Model;
using UnityEngine;
using UnityMVVM.View;

namespace TestScroll.View
{
    [RequireComponent(typeof(PlayerAccountView))]
    public class SelectedAccountView : ViewBase
    {
        public PlayerAccountModel Current
        {
            set
            {
                if (value == null)
                    return;
                _accountView.UpdateItem(value, 0);
            }
        }

        private PlayerAccountView _accountView;


        private void Awake()
        {
            _accountView = GetComponent<PlayerAccountView>();
        }
    }
}
