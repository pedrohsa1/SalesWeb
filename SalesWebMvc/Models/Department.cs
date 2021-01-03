
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id{ get; set; }
        public string Name{ get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>(); //Para garantir que a lista será instânciada, ou seja obrigar a associação

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
        
        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        //Total de vendas por Departamento dentro desse intervalo de data
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
