
# react-native-react-native-hitek

## Getting started

`$ npm install react-native-react-native-hitek --save`

### Mostly automatic installation

`$ react-native link react-native-react-native-hitek`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-react-native-hitek` and add `RNReactNativeHitek.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNReactNativeHitek.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNReactNativeHitekPackage;` to the imports at the top of the file
  - Add `new RNReactNativeHitekPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-react-native-hitek'
  	project(':react-native-react-native-hitek').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-react-native-hitek/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-react-native-hitek')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNReactNativeHitek.sln` in `node_modules/react-native-react-native-hitek/windows/RNReactNativeHitek.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using React.Native.Hitek.RNReactNativeHitek;` to the usings at the top of the file
  - Add `new RNReactNativeHitekPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNReactNativeHitek from 'react-native-react-native-hitek';

// TODO: What to do with the module?
RNReactNativeHitek;
```
  