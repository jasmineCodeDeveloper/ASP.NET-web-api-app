using basitwebapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace basitwebapi.Controllers
{
[ApiController]
[Route("[controller]")]
public class OgrenciController:ControllerBase{
static List<Ogrenci> ogrenciler=new List<Ogrenci>{

new Ogrenci{Id=1,AdSoyad="yasemin elvan"},
new Ogrenci{Id=2,AdSoyad="ayşe elvan"},
new Ogrenci{Id=3,AdSoyad="fatma elvan"}

};
//veriyi listeleme methodu
[HttpGet]
public List<Ogrenci> Get(){

    return ogrenciler;
}
    [HttpGet("{id}")]
    public Ogrenci Get(int id){

        return ogrenciler.FirstOrDefault(o=>o.Id==id);
    }
    //iceri veri alma metodu
    [HttpPost]
    public Ogrenci Post(Ogrenci ogrenci){

        ogrenciler.Add(ogrenci);
        return ogrenci;
    }
    
}

}