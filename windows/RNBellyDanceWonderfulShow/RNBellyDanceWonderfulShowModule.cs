using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Belly.Dance.Wonderful.Show.RNBellyDanceWonderfulShow
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNBellyDanceWonderfulShowModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNBellyDanceWonderfulShowModule"/>.
        /// </summary>
        internal RNBellyDanceWonderfulShowModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNBellyDanceWonderfulShow";
            }
        }
    }
}
