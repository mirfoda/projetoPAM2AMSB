namespace passarinhos{
public class NotFlying:Bird{
public NotFlying (int Id, string Name): base(Id,Name)
{
    this.id=Id;
    this.name=Name;
}    
public override void ToFly(){

Console.WriteLine(name + " does not fly");   
Console.WriteLine(id); 
}
}
}