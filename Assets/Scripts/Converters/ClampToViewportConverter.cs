using System;
using UnityEngine;
using UnityMVVM.Binding.Converters;

namespace TestScroll.Converter
{
    public class ClampToViewportConverter : ValueConverterBase
    {
        [SerializeField] private RectTransform _viewport;

        private float _top;
        private float _bottom;


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
            _bottom = GetComponent<RectTransform>().rect.height;
            _top = _viewport.rect.height;
            //Add bottom ofset
            var corners = new Vector3[4];
            _viewport.GetWorldCorners(corners);
            var offset = corners[0].y;
            _top += offset;
            _bottom += offset;
        }
    }
}
