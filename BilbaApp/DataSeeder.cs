using BilbaApp.Data;
using System.Runtime.InteropServices;

namespace BilbaApp
{
    public static class DataSeeder
    {
        public static void Seed(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<NotebookDataContext>();
            context.Database.EnsureCreated();
            AddNotebooks(context);
        }
        private static void AddNotebooks(NotebookDataContext context) 
        {
            var notebook = context.Notebooks.FirstOrDefault();
            if (notebook != null) return;

            context.Notebooks.Add(new Notebook
            {
                Title= "HP Deneme", 
                ImageUrl = "www.google.com",
                Price = 4000,
                Spec= new List<Spec>
                {
                    new Spec {Spesifications = "i5 8gb RAM 512SD"},
                }
            });
            context.SaveChanges();
        }
    }
}




