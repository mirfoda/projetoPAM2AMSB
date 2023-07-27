namespace passarinhos
{
    class Program
    {
        static void Main(string[] args){
        
            Bird aguia = new Flying(66, "águia");
            aguia.ToFly();
            Bird pinguim = new NotFlying(63,"pinguim");
            pinguim.ToFly();}
        
    }
}