﻿using System.Drawing;

namespace KinectFittingRoom.ViewModel.ButtonItems.TopMenuButtons
{
    class MakeWiderButtonViewModel : TopMenuButtonViewModel
    {
        #region Consts
        private const double _plusFactor = 1.05;
        #endregion
        #region .ctor
        /// <summary>
        /// Initializes a new instance of the <see cref="MakeWiderButtonViewModel"/> class.
        /// </summary>
        /// <param name="image">Image of button</param>
        public MakeWiderButtonViewModel(Bitmap image)
            : base(image)
        { }
        #endregion
        #region Methods
        /// <summary>
        /// Makes last added item wider
        /// </summary>
        public override void ClickEventExecuted()
        {
        }
        #endregion
    }
}
