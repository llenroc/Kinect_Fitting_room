﻿using System.Drawing;

namespace KinectFittingRoom.ViewModel.ButtonItems.TopMenuButtons
{
    class MakeThinnerButtonViewModel : TopMenuButtonViewModel
    {
         #region Consts
        private const double _minusFactor = 0.95;
        #endregion
        #region .ctor
        /// <summary>
        /// Initializes a new instance of the <see cref="MakeThinnerButtonViewModel"/> class.
        /// </summary>
        /// <param name="image">Image of button</param>
        public MakeThinnerButtonViewModel(Bitmap image)
            : base(image)
        { }
        #endregion
        #region Methods
        /// <summary>
        /// Makes last added item thinner
        /// </summary>
        public override void ClickEventExecuted()
        {
        }
        #endregion
    }
}
