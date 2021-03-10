using System.Collections.ObjectModel;
using TestScroll.Model;
using UnityEngine;
using UnityMVVM.ViewModel;

namespace TestScroll.ViewModel
{
    public class PlayerAccountListViewModel : ViewModelBase
    {
        //Bindable properties
        public ObservableCollection<PlayerAccountModel> Models { get; }
            = new ObservableCollection<PlayerAccountModel>();
        public PlayerAccountModel SelectedModel
        {
            get => _selectedModel;
            set
            {
                if (value != _selectedModel)
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
                if (value != _selectedView)
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
        public bool IsSelectionActive
        {
            get => _isSelectionActive;
            set
            {
                if (value != _isSelectionActive)
                {
                    _isSelectionActive = value;
                    NotifyPropertyChanged(nameof(IsSelectionActive));
                }
            }
        }
        //Fields
        private RectTransform _selectedView;
        private PlayerAccountModel _selectedModel;
        private Vector3 _position;
        private bool _isSelectionActive = false;

        /// <summary>
        /// Invokes by EventBinding, when player scrolls list
        /// </summary>
        /// <param name="position"></param>
        public void MoveSelectedView(Vector2 position)
        {
            if (IsSelectionActive)
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
