var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


List<User> repo = [];
app.MapGet("users/{id}", (int id) => repo[id]);
app.MapPost("/users", (User user) => CreateUser(user));
app.MapPut("/users", (User user) => UpdateUser(user));
app.MapDelete("/users/{id}", (int id) => DeleteUser(id));
app.Run();

User FindUser(int id) => repo.Find(x => x.Id == id);
void CreateUser(User user) => repo.Add(user);
void UpdateUser(User dto)
{
    foreach (var u in repo)
        if (u.Id == u.Id)
        {
            if (u.Login != dto.Login && dto.Login != "")
                u.Login = dto.Login;
            if (u.Password!= dto.Password && dto.Password != "")
                u.Password = dto.Password;
        }
}
void DeleteUser(int id) => repo.Remove(FindUser(id));


class User
{
    public int Id { get; set; }
    public double Startdata { get; set; }
    public string Technic { get; set; }
    public string Model { get; set; }
    public string Problem { get; set; }
    public string Client { get; set; }
    public int Telepfon { get; set; }
    public string Master { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
}