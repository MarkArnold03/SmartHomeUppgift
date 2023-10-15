using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrationsapplikation.MVVM.ViewModels
{
    public class LivingRoomDevice
    {
        public string? DeviceId { get; set; }
        public string? DeviceType { get; set; }
        public string? Placement { get; set; }
        public bool IsActive { get; set; } = false;
        public string? Icon => SetIcon();

        private string SetIcon()
        {
            return (DeviceType?.ToLower()) switch
            {
                _ => "\uf2db",
            };
        }
    }
}
