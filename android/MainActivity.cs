using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Microsoft.Xna.Framework;

[Activity(Label = "Sonic 3 HD", 
          MainLauncher = true, 
          Theme = "@android:style/Theme.NoTitleBar.Fullscreen", 
          AlwaysRetainTaskState = true, 
          LaunchMode = LaunchMode.SingleInstance, 
          ScreenOrientation = ScreenOrientation.Landscape, 
          ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize | ConfigChanges.Keyboard | ConfigChanges.KeyboardHidden)]
public class MainActivity : AndroidGameActivity
{
    protected override void OnCreate(Bundle bundle)
    {
        base.OnCreate(bundle);
        
        // Bypasses the Windows Forms startup object Class1 launcher entirely.
        // Launches the primary Game instance engine class loop directly.
        var gameInstance = new global::Sonic_3_HD.Class0(); 
        
        SetContentView((View)gameInstance.Services.GetService(typeof(View)));
        gameInstance.Run();
    }
}
