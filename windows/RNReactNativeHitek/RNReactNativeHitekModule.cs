using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace React.Native.Hitek.RNReactNativeHitek
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativeHitekModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativeHitekModule"/>.
        /// </summary>
        internal RNReactNativeHitekModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativeHitek";
            }
        }
    }
}
