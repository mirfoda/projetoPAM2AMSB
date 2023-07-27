namespace passarinhos
{
    public class Bird{
        protected int id {get;set;}
        protected string name {get;set;}
        public Bird(int Id, string Name)
        {
            this.id =Id;
            this.name =Name;
        }

        public virtual void ToFly(){
            Console.WriteLine(id);
            Console.WriteLine(name + " it's flying"); 
            }

    }
}