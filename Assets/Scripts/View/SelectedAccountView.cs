using System;
using TestScroll.Model;
using UnityEngine;
using UnityMVVM.View;

namespace TestScroll.View
{
    [RequireComponent(typeof(PlayerAccountView))]
    public class SelectedAccountView : ViewBase
    {
        //Bindable property
        public PlayerAccountModel Current
        {
            set
            {
                if (value == null)
                    throw new ArgumentNullException();
                _accountView.UpdateItem(value, 0);
            }
        }
        //Field
        private PlayerAccountView _accountView;


        private void Awake()
        {
            _accountView = GetComponent<PlayerAccountView>();
        }
    }
}
