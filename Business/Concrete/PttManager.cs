using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {
        private IAplicantService _aplicantService;
        public PttManager(IAplicantService aplicantService)//constructor new yapıldığında çalışır
        {
            _aplicantService = aplicantService;
        }
        public void GiveMask(Person person)
        {
            //PersonManager personManager = new PersonManager();//bir iş sınıfı baika bir iş sınıfını kullanırken new'liyorsa
                                                              //ileriye dönül değişiklik talebi geldiğinde direnç gösterir.
            if (_aplicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "  için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ");
            }
        }
    }
}
