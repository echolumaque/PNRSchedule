using Android;
using Android.App;
using Android.Content;
using Android.Media;
using Android.OS;
using Android.Support.V4.App;
[assembly: UsesPermission(Manifest.Permission.ReceiveBootCompleted)]

namespace PNRSched.Droid
{
    [BroadcastReceiver(Enabled = true)]
    [IntentFilter(new[] { Intent.ActionBootCompleted, Intent.ActionLockedBootCompleted })]
    public class Alarma : BroadcastReceiver
    {
        public const string ID = "69420";
        private NotificationCompat.Builder mBuilder;
        public override void OnReceive(Context context, Intent intent)
        {
            var sound = Android.Net.Uri.Parse(ContentResolver.SchemeAndroidResource + "://" + Android.App.Application.Context.PackageName + "/" + Resource.Raw.notification);
            var alarmAttributes = new AudioAttributes.Builder();
            mBuilder = new NotificationCompat.Builder(Application.Context, ID);
            mBuilder.SetSmallIcon(Resource.Drawable.appicon);
            mBuilder.SetContentTitle("Trainify")
                    .SetSound(sound)
                    .SetAutoCancel(true)
                    .SetContentTitle("A train has arrived!")
                    .SetContentText("The train arrived at your chosen station")
                    .SetPriority((int)NotificationPriority.Max)
                    .SetVibrate(new long[0])
                    .SetDefaults((int)NotificationDefaults.Sound | (int)NotificationDefaults.Vibrate)
                    .SetVisibility((int)NotificationVisibility.Public)
                    .SetSmallIcon(Resource.Drawable.appicon)
                    .SetShowWhen(true);

            NotificationManager notificationManager = Application.Context.GetSystemService(Context.NotificationService) as NotificationManager;

            if (Build.VERSION.SdkInt >= BuildVersionCodes.O)
            {
                NotificationImportance importance = global::Android.App.NotificationImportance.Max;
                NotificationChannel notificationChannel = new NotificationChannel(ID, "title", importance);
                notificationChannel.EnableLights(true);
                notificationChannel.EnableVibration(true);
                notificationChannel.SetSound(sound, alarmAttributes.Build());
                notificationChannel.SetShowBadge(true);
                notificationChannel.Importance = NotificationImportance.Max;
                notificationChannel.LockscreenVisibility = NotificationVisibility.Public;
                notificationChannel.ShouldVibrate();
                notificationChannel.ShouldShowLights();
                notificationChannel.SetVibrationPattern(new long[] { 100, 200, 300, 400, 500, 400, 300, 200, 400 });

                if (notificationManager != null)
                {
                    mBuilder.SetChannelId(ID);
                    notificationManager.CreateNotificationChannel(notificationChannel);
                }
            }
            notificationManager.Notify(0, mBuilder.Build());
        }
    }

}