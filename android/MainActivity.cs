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
        
        // Target the actual, authentic game loop class directly!
        var gameInstance = new global::GClass25(); 
        
        SetContentView((View)gameInstance.Services.GetService(typeof(View)));
        gameInstance.Run();
    }
}
