namespace BLL
{
    public class BLLBitacora_82CD
    {
        private DAL.MapperBitacora_82CD mapperBitacora_82CD = new DAL.MapperBitacora_82CD();

        public void RegistrarEvento_82CD(string evento_82CD, string login_82CD)
        {
            mapperBitacora_82CD.RegistrarEvento_82CD(evento_82CD, login_82CD);
        }
    }

}
