using Principal.Entities;

namespace Principal {
    class Program {
        static void Main(string[] args) {
            Comments comment1 = new Comments("Wow, that's awesome!");
            Comments comment2 = new Comments("Have a nice trip!");
            Posts post1 = new Posts(DateTime.Parse("22/08/2023 11:30:45"), "My trip to NYC", 12, "Empire State Building pic");
            post1.AddComment(comment1);
            post1.AddComment(comment2);
            
            Console.WriteLine(post1);
        }
    }
}
