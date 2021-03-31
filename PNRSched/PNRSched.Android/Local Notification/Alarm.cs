using Android.App;
using Android.Content;
using PNRSched.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(LocalNotif))]

namespace PNRSched.Droid
{
    public class LocalNotif : ILocalNotif
    {
        public void Alarm(long trigger)
        {
            AlarmManager manager = Application.Context.GetSystemService(Context.AlarmService) as AlarmManager;
            Intent myIntent = new Intent(Application.Context, typeof(Alarma));
            PendingIntent pendingIntent = PendingIntent.GetBroadcast(Application.Context, 0, myIntent, 0);
            manager.SetRepeating(AlarmType.RtcWakeup, trigger, AlarmManager.IntervalDay, pendingIntent);
        }
        public void CancelAlarm()
        {
            AlarmManager manager = Application.Context.GetSystemService(Context.AlarmService) as AlarmManager;
            Intent myIntent = new Intent(Application.Context, typeof(Alarma));
            PendingIntent pendingIntent = PendingIntent.GetBroadcast(Application.Context, 0, myIntent, 0);
            if (manager != null)
            {
                manager.Cancel(pendingIntent);
            }
        }
    }

}