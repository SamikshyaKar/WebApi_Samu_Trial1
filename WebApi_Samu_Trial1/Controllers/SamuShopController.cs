using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessSamuTrial;


namespace WebApi_Samu_Trial1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SamuShopController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<SamuShopEmployee> GetAllShopkeeperDetails()
        {

            using(SamuShopEmployeeDBEntities samuShopEmployeeDBEntities = new SamuShopEmployeeDBEntities())
            {
                return samuShopEmployeeDBEntities.SamuShopEmployees.ToList();

            }
        }


       
        public SamuShopEmployee GetEmployeebyID(int ssID)
        {
            using(SamuShopEmployeeDBEntities samuShopEmployeeDBEntities= new SamuShopEmployeeDBEntities())
            {

                return samuShopEmployeeDBEntities.SamuShopEmployees.FirstOrDefault(ssed => ssed.ID == ssID);

            }

        }





    }
}
