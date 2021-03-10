using System.Collections.ObjectModel;
using TestScroll.Model;
using TestScroll.View;
using UnityEngine;
using UnityMVVM.ViewModel;

namespace TestScroll.ViewModel
{
    public class PlayerAccountListViewModel : ViewModelBase
    {
        [SerializeField] private PlayerAccountModel _selectedModel;

        public ObservableCollection<PlayerAccountModel> Models { get; private set; } = new ObservableCollection<PlayerAccountModel>();
        public PlayerAccountModel SelectedModel
        {
            get => _selectedModel;
            set
            {
                if(value != _selectedModel)
                {
                    _selectedModel = value;
                    NotifyPropertyChanged(nameof(SelectedModel));
                }
            }
        }
        public RectTransform SelectedView
        {
            get => _selectedView;
            set
            {
                if(value != _selectedView)
                {
                    _selectedView = value;
                    NotifyPropertyChanged(nameof(SelectedView));
                }
            }
        }
        public Vector3 Position
        {
            get => _position;
            set
            {
                if (value != _position)
                {
                    _position = value;
                    NotifyPropertyChanged(nameof(Position));
                }
            }
        }

        private RectTransform _selectedView;
        private Vector3 _position;


        public void MoveSelectedView(Vector2 position)
        {
            Position = _selectedView.position;
        }

        //TODO: Separete test
#if DEBUG
        private void Start()
        {
            for (int i = 1; i < 60; i++)
            {
                Models.Add(new PlayerAccountModel(i, $"Player {i}"));
            }
        }
#endif
    }
}
