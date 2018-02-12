using SecurityEssentials.Model;

namespace SecurityEssentials.ViewModel
{
    public class RemoveRoleViewModel
    {
        public bool IsOwnProfile;
        public User User;

        public RemoveRoleViewModel(User user, bool isOwnProfile)
        {
            User = user;
            IsOwnProfile = isOwnProfile;
        }
    }
}