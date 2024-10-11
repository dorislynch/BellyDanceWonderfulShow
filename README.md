
# react-native-belly-dance-wonderful-show

## Getting started

`$ npm install react-native-belly-dance-wonderful-show --save`

### Mostly automatic installation

`$ react-native link react-native-belly-dance-wonderful-show`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-belly-dance-wonderful-show` and add `RNBellyDanceWonderfulShow.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNBellyDanceWonderfulShow.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNBellyDanceWonderfulShowPackage;` to the imports at the top of the file
  - Add `new RNBellyDanceWonderfulShowPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-belly-dance-wonderful-show'
  	project(':react-native-belly-dance-wonderful-show').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-belly-dance-wonderful-show/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-belly-dance-wonderful-show')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNBellyDanceWonderfulShow.sln` in `node_modules/react-native-belly-dance-wonderful-show/windows/RNBellyDanceWonderfulShow.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Belly.Dance.Wonderful.Show.RNBellyDanceWonderfulShow;` to the usings at the top of the file
  - Add `new RNBellyDanceWonderfulShowPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNBellyDanceWonderfulShow from 'react-native-belly-dance-wonderful-show';

// TODO: What to do with the module?
RNBellyDanceWonderfulShow;
```
  