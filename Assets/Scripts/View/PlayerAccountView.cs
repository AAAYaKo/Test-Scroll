using System;
using TestScroll.Model;
using UnityEngine;
using UnityEngine.UI;
using UnityMVVM.Model;
using UnityMVVM.View;

namespace TestScroll.View
{
    public class PlayerAccountView : CollectionViewItemBase<PlayerAccountModel>, ISelectable
    {
        [SerializeField] private GameObject[] _ratingSprites = new GameObject[3];
        [SerializeField] private Text _ratingText;
        [SerializeField] private Text _nameText;

        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                if (_isSelected != value)
                {
                    _isSelected = value;
                    SetSelected(value);
                }
            }
        }

        public Action<object, object> OnSelected { get; set; }
        public Action<object, object> OnDeselected { get; set; }

        private bool _isSelected = false;


        public override void InitItem(PlayerAccountModel model, int idx)
        {
            if (model.Rating < _ratingSprites.Length + 1)
            {
                ShowTopRatingSprite(model.Rating);
            }
            _ratingText.text = model.Rating.ToString();
            _nameText.text = model.Name;
        }

        public override void UpdateItem(PlayerAccountModel model, int newIdx)
        {
            
        }

        public void SetSelected(bool selected)
        {
            _isSelected = selected;

        }

        private void ShowTopRatingSprite(int rating)
        {
            _ratingSprites[rating - 1].SetActive(true);
        }
    }
}