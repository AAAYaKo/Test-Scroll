using TestScroll.Model;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityMVVM.View;

namespace TestScroll.View
{
    public class PlayerAccountView : CollectionViewItemBase<PlayerAccountModel>
    {
        public UnityEvent SlectionEvent { get; set; } = new UnityEvent();
        
        [SerializeField] private GameObject[] _ratingSprites = new GameObject[3];
        [SerializeField] private Text _ratingText;
        [SerializeField] private Text _nameText;
        //Bindable properties
        public RectTransform Transform { get => _transform; }
        public int Rating
        {
            set
            {
                if (_rating < _ratingSprites.Length + 1)
                {
                    HideTopRatingSprite(_rating);
                }
                if (value < _ratingSprites.Length + 1)
                {
                    ShowTopRatingSprite(value);
                }

                _ratingText.text = value.ToString();
                _rating = value;
            }
        }
        public string Name { set { _nameText.text = value; } }
        public Vector3 Position { get => Transform.position; }
        //Fields
        private RectTransform _transform;
        private int _rating = 1;


        public override void InitItem(PlayerAccountModel model, int idx) { }

        public override void UpdateItem(PlayerAccountModel model, int newIdx)
        {
            Rating = model.Rating;
            Name = model.Name;
        }

        public void OnSelection()
        {
            SlectionEvent.Invoke();
        }

        private void Awake()
        {
            _transform = GetComponent<RectTransform>();
        }

        private void ShowTopRatingSprite(int rating)
        {
            _ratingSprites[rating - 1].SetActive(true);
        }

        private void HideTopRatingSprite(int rating)
        {
            _ratingSprites[rating - 1].SetActive(false);
        }
    }
}