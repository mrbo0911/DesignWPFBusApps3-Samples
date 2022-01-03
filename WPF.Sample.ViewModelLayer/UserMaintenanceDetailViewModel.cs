using WPF.Sample.DataLayer;

namespace WPF.Sample.ViewModelLayer
{
  public class UserMaintenanceDetailViewModel : UserMaintenanceListViewModel
  {
    private User _Entity = new User();

    public User Entity
    {
      get { return _Entity; }
      set {
        _Entity = value;
        RaisePropertyChanged("Entity");
      }
    }

    public override void LoadUsers()
    {
      // Load all users
      base.LoadUsers();

      // Set default user
      if (Users.Count > 0)
      {
        Entity = Users[0];
      }
    }
  }
}
