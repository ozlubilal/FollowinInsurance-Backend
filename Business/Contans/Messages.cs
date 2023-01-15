using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Contans
{
    public class Messages
    {
        public static string Added = "Ekleme işleme başarılı";

        public static string Deleted = "Silme işlemi başarılı";
        public static string Updated = "Güncelleme işlemi başarılı";
        public static string CompanyNameAlreadyExists = "Bu şirket adı zaten mevcut";
        public static string CustomerAlreadyExists = "Bu Tc Kimlik Numaralı müşteri zaten mevcut";
        public static string InsuranceAlreadyExist = "Bu plakaya ait aktif bir sigorta bulunmaktadır";
    }
}
