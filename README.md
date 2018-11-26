
# react-native-react-native-simple-linear-gradient

## Getting started

`$ npm install react-native-react-native-simple-linear-gradient --save`

### Mostly automatic installation

`$ react-native link react-native-react-native-simple-linear-gradient`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-react-native-simple-linear-gradient` and add `RNReactNativeSimpleLinearGradient.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNReactNativeSimpleLinearGradient.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNReactNativeSimpleLinearGradientPackage;` to the imports at the top of the file
  - Add `new RNReactNativeSimpleLinearGradientPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-react-native-simple-linear-gradient'
  	project(':react-native-react-native-simple-linear-gradient').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-react-native-simple-linear-gradient/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-react-native-simple-linear-gradient')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNReactNativeSimpleLinearGradient.sln` in `node_modules/react-native-react-native-simple-linear-gradient/windows/RNReactNativeSimpleLinearGradient.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using React.Native.Simple.Linear.Gradient.RNReactNativeSimpleLinearGradient;` to the usings at the top of the file
  - Add `new RNReactNativeSimpleLinearGradientPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNReactNativeSimpleLinearGradient from 'react-native-react-native-simple-linear-gradient';

// TODO: What to do with the module?
RNReactNativeSimpleLinearGradient;
```
  # react-native-simple-linear-gradient
