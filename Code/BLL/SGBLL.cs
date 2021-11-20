using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3C1Rodrigo38_ProvaPOO.Code.DAL;
using _3C1Rodrigo38_ProvaPOO.Code.DTO;
using System.Data;


namespace _3C1Rodrigo38_ProvaPOO.Code.BLL
{
    class SGBLL
    {
        SGDAL conexao = new SGDAL();
        public void create(SGDTO DTOSG) {
            string comand = $"insert into savassig values(null, '{DTOSG.JOGO}', '{DTOSG.VALOR}', {DTOSG.PLATAFORMA})";
            conexao.ExecutarComando(comand);
        }
        public void update(SGDTO DTOSG) {
            string comand = $@"update savassig set JOGO = '{DTOSG.JOGO}', PLATAFORMA ='{DTOSG.PLATAFORMA} ',
                            VALOR='{DTOSG.VALOR}' where ID ='{DTOSG.ID}';";
            conexao.ExecutarComando(comand);
        }
        public void destroy(SGDTO DTOSG)
        {
            string comand = $"delete from savassig where ID = {DTOSG.ID}";
            conexao.ExecutarComando(comand);
        }
        public DataTable read(SGDTO DTOSG)
        {
            string comand = $"select * from savassig order by  ID";
            return conexao.ExecutarConsulta(comand);
        }

        internal object read()
        {
            throw new NotImplementedException();
        }
    }
}
