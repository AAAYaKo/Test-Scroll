using System;
using UnityEngine;
using UnityMVVM.Binding.Converters;

namespace TestScroll.Converter
{
    public class ClampToViewportConverter : ValueConverterBase
    {
        [SerializeField] private float _bottom;
        [SerializeField] private RectTransform _viewport;

        private float _top;


        public override object Convert(object value, Type targetType, object parameter)
        {
            if (value is float number)
            {
                return Mathf.Clamp(number, _bottom, _top);
            }
            else
                throw new InvalidCastException("Value must be float of float?");
        }

        /// <summary>
        /// In Unity-MVVM now not implemented
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public override object ConvertBack(object value, Type targetType, object parameter)
        {
            throw new NotImplementedException();
        }

        private void Awake()
        {
            _top = _viewport.rect.height;
        }
    }
}
