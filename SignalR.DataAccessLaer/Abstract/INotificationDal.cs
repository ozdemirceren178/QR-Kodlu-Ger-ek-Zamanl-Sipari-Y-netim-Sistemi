using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLaer.Abstract
{
    public interface INotificationDal: IGenericDal<Notification>
    {
        int NotificationCountByStatusFalse();//durumu okunmayan bildirimlerin sayısı
        List<Notification> GetAllNotificationByFalse();
        void NotificationStatusChangeToTrue(int id);
        void NotificationStatusChangeToFalse(int id);

    }
}
