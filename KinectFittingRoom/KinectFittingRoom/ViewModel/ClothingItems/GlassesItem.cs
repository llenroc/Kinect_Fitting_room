﻿using Microsoft.Kinect;

namespace KinectFittingRoom.ViewModel.ClothingItems
{
    class GlassesItem : ClothingItemBase
    {
        /// <summary>
        /// Constructor of Glasses object
        /// </summary>
        /// <param name="pathToImage">Path to original image of item</param>
        public GlassesItem(string pathToImage)
            : base(pathToImage, 1.0)
        {
        }

        /// <summary>
        ///Set position for glasses
        /// </summary>
        /// <param name="skeleton">Recognised skeleton</param>
        /// <param name="sensor">Kinect sensor</param>
        /// <param name="width">Kinect image width</param>
        /// <param name="height">Kinect image height</param>
        public override void TrackSkeletonParts(Skeleton skeleton, KinectSensor sensor, double width, double height)
        {
            System.Windows.Point head = KinectService.GetJointPoint(skeleton.Joints[JointType.Head], sensor, width, height);
            System.Windows.Point shoulderLeft = KinectService.GetJointPoint(skeleton.Joints[JointType.ShoulderLeft], sensor, width, height);
            System.Windows.Point shoulderRight = KinectService.GetJointPoint(skeleton.Joints[JointType.ShoulderRight], sensor, width, height);

            double heightToWidth = Height / Width;
            Width = (shoulderRight.X - shoulderLeft.X) * 0.5;
            Height = heightToWidth * Width;
            Top = head.Y + 50;
            Left = head.X - Width / 2;
        }
    }
}