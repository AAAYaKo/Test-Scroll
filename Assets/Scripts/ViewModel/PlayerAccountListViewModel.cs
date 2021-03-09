using System.Collections.ObjectModel;
using TestScroll.Model;
using UnityEngine;
using UnityMVVM.ViewModel;

namespace TestScroll.ViewModel
{
    public class PlayerAccountListViewModel : ViewModelBase
    {
        [SerializeField] private PlayerAccountModel _selected;
        public ObservableCollection<PlayerAccountModel> Models { get; set; } = new ObservableCollection<PlayerAccountModel>();

        public PlayerAccountModel Selected
        {
            get => _selected;
            set
            {
                if(value != _selected)
                {
                    _selected = value;
                    NotifyPropertyChanged(nameof(Selected));
                }
            }
        }


        private void Start()
        {
            for (int i = 1; i < 60; i++)
            {
                Models.Add(new PlayerAccountModel(i, $"Player {i}"));
            }
        }
    }
}
