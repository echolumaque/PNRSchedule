using Android.Content;
using System;
using System.Collections.Generic;
using System.Text;

namespace PNRSched
{
    public interface ILocalNotif
    {
        void Alarm(long trigger);
        void CancelAlarm();
    }
}
