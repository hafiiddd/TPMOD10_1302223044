using Microsoft.AspNetCore.Mvc;

namespace tpmod10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiswa = new List<Mahasiswa> 
        {
            new Mahasiswa("Hafid AlAkhyar","1302223044"),
            new Mahasiswa("Ragadhitya Janatantra Khoeshutama","1302223025"),
            new Mahasiswa("Gina Soraya","1302223070"),
            new Mahasiswa("M.Iqbal Nur Haq","1302223050"),
            new Mahasiswa("Kal El Muhammad Pratama","1302220096"),
        };
        [HttpGet(Name = "GetMahasiswa")]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswa;
        }
        [HttpPost]
        public void post([FromBody] Mahasiswa mahasiswaa)
        {
            mahasiswa.Add(mahasiswaa);
        }
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswa[id];
        }
        [HttpDelete("{id}")]
        public void delete(int id)
        {
            mahasiswa.RemoveAt(id);
        }
    }
}
