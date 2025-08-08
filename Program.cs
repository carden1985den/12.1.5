
class Program
{
    static void Main()
    {
        List<User> usersList = new List<User>();
        usersList.Add(new User() { Name = "Denis", Login = "den", IsPremium = true });
        usersList.Add(new User() { Name = "Ivan", Login = "vak", IsPremium = false });
        usersList.Add(new User() { Name = "Georg", Login = "Gore", IsPremium = false });

        foreach (var user in usersList)
        {
            string helloMessage = $"Приветствую тебя {user.Name} ({user.Login})";
            if (user.IsPremium == true)
            {
                Console.WriteLine(helloMessage);
            }else 
            {
                Advertisement.ShowAds();
                Console.WriteLine(helloMessage);
            }
        }
    }
}