using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialMVC.Services
{
    public interface INotification
    {
        void Send(OrderInfo orderInfo);
    }
    public class Notification : INotification
    {
        public void Send(OrderInfo orderInfo)
        {
            Debug.WriteLine($"已經送出通知給 {orderInfo.Email}");
        }
    }
}
