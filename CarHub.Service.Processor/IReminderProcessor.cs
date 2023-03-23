using CarHub.Service.Model.User;

namespace CarHub.Service.Processor
{
    public interface IReminderProcessor
    {
        bool GenerateReminders(Guid userId, string vehicleRegistration);

        IList<Reminder> GetReminders(Guid userId);
    }
}