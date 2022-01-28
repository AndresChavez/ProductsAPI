using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using ProductsAPI.Entities;
using ProductsAPI.Helpers;
using Newtonsoft.Json;
using System.Net.Http;


namespace ProductsAPI.Services
{
    public interface IProductService
    {
        //IEnumerable<Material> GetAll();
        //Material GetById(int id);
        //Material Create(Material material);

    }

    public class ProductService : IProductService
    {
        private DataContext _context;
        private string endpoint { get; set; }
        private httpVerb HttpMethod { get; set; }
        private enum httpVerb
        {
            GET,
            POST,
            PUT,
            DELETE
        }

        public ProductService(DataContext context)
        {
            _context = context;
        }

        //public Material Create(Material material)
        //{
        //    _context.Materials.Add(material);
        //    _context.SaveChanges();

        //    return material;
        //}

        //public IEnumerable<Material> GetAll()
        //{
        //    return _context.Materials;
        //}

        //public Material GetById(int id)
        //{
        //    return _context.Materials.Find(id);
        //}

    }
}
