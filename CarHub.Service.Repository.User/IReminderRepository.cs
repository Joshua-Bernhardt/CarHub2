using CarHub.Service.Model.User;

namespace CarHub.Service.Repository.User
{
    public interface IReminderRepository
    {
        bool CreateMOTReminder(Guid userId);

        bool CreateServiceReminder(Guid userId);

        IList<Reminder> GetReminders(Guid userId);

        Reminder GetReminder(Guid id);
    }
}