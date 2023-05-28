using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;

namespace DataAccessLayer
{
    public class DALPersonel
    {
        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand komut1 = new SqlCommand("Select * from TBLBILGI",Class1.bgl);
            if(komut1.Connection.State!=ConnectionState.Open) // Baglantının açık olup olmadığını kontrol ettik
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while(dr.Read()) 
            {
                EntityPersonel ent = new EntityPersonel();
                ent.Id = int.Parse(dr["ID"].ToString());
                ent.Ad= dr["AD"].ToString();
                ent.Soyad = dr["SOYAD"].ToString() ;
                ent.Sehir = dr["SEHIR"].ToString();
                ent.Gorev = dr["GOREV"].ToString();
                ent.Maas = short.Parse(dr["MAAS"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int PersonelEkle(EntityPersonel p)
        {
            SqlCommand komut2 = new SqlCommand("insert into TBLBILGI (AD,SOYAD,SEHIR,GOREV,MAAS) VALUES(@p1,@p2,@p3,@p4,@p5)",Class1.bgl);
            if (komut2.Connection.State != ConnectionState.Open) // Baglantının açık olup olmadığını kontrol ettik
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1", p.Ad);
            komut2.Parameters.AddWithValue("@p2", p.Soyad);
            komut2.Parameters.AddWithValue("@p3", p.Sehir);
            komut2.Parameters.AddWithValue("@p4", p.Gorev);
            komut2.Parameters.AddWithValue("@p5", p.Maas);

            return komut2.ExecuteNonQuery();
        }

        public static bool PersonelSil(int p) 
        {
            SqlCommand komut3 = new SqlCommand
                ("Delete from TBLBILGI where ID=@p1",Class1.bgl);
            if(komut3.Connection.State != ConnectionState.Open) 
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", p);
            return komut3.ExecuteNonQuery()>0;
        }
    }
}
