using Programming2_UAS.modelDB;

namespace Programming2_UAS.services
{
    public class pizzaservice
    {
        pizzaContext db;
        public pizzaservice(pizzaContext dbp)=> db = dbp;
        public List<Pizza> GetPizza() => db.Pizzas.ToList();
        public void deletepizza(Pizza p){
            var e = db.Pizzas.FirstOrDefault(d=>d.Id == p.Id);
            if(e != null){
                db.Pizzas.Remove(e);
                db.SaveChanges();
            }
        }
        public void updatepizza(Pizza p){
            var e = db.Pizzas.FirstOrDefault(d=>d.Id == p.Id);
            if(e != null){
                e.NamaPizza = p.NamaPizza;
                e.UkuranPizza = p.UkuranPizza;
                e.JenisSaus = p.JenisSaus;
                e.Crust = p.Crust;
                db.Pizzas.Update(e);
                db.SaveChanges();
            }
        }
        public void addpizza(Pizza p){
        db.Pizzas.Add(p);
        db.SaveChanges();
        }
    }
}