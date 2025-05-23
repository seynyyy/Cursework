using System.Collections.Generic;
using Cursework.Models;

namespace Cursework.Models
{
    public interface IMaintenance
    {
        void AddMaintenanceRecord(MaintenanceRecord record);
        IEnumerable<MaintenanceRecord> GetMaintenanceRecords();
        double CalculateTotalMaintenanceCost();
    }
}