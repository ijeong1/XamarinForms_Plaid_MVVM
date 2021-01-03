# XamarinForms_Plaid_MVVM
 Plaid Link Integration for Xamarin Forms with MVVM pattern

# Demo Screenshots
![Demo](https://github.com/ijeong1/XamarinForms_Plaid_MVVM/blob/main/screenshot.png)

My previous release works well (https://github.com/ijeong1/Plaid-Link-XamarinForms), but it hurts the structure of the MVVM pattern, so I wrote a sample code to integrate Plaid Link into xamarin forms while maintaining the MVVM pattern.


let's look at the basic settings for operation.

# Xamarin.iOS
You need to add the following code to your info.plist file under your Xamarin.iOS project folder.
```
 <key>NSAppTransportSecurity</key>
 <dict>
      <key>NSAllowsArbitraryLoads</key>
     <true/>
 </dict>
```

# Xamarin.Droid
You need to add the following code to your AndroidManifest.xml file under Xamarinf.Droid/Properties directory.
```
<uses-permission android:name="android.permission.INTERNET" />
```

# ITMS-90809
If you try to upload to the Apple AppStore, you will get an ITMS-90809 error, which can be solved with the following settings.
- See detail here  https://developer.apple.com/documentation/uikit/uiwebview

Add the following flag to your iOS build option
```
--optimize=experimental-xforms-product-type
```
![BuildOption](https://github.com/ijeong1/Plaid-Link-XamarinForms/blob/master/BuildOption.png)

