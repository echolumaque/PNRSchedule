using System;
using System.Collections.Generic;
using System.Text;

namespace PNRSched
{
    public interface INotification
    {
        void CreateNotification(String title, String route);
    }

}
