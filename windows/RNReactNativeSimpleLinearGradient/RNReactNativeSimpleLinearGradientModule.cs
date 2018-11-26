using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace React.Native.Simple.Linear.Gradient.RNReactNativeSimpleLinearGradient
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativeSimpleLinearGradientModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativeSimpleLinearGradientModule"/>.
        /// </summary>
        internal RNReactNativeSimpleLinearGradientModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativeSimpleLinearGradient";
            }
        }
    }
}
