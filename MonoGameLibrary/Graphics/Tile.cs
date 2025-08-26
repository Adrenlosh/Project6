using Microsoft.Xna.Framework;

namespace MonoGameLibrary.Graphics
{
    /// <summary>
    /// ��ʾһ����ͼ��Ƭ�������赲��Ϣ��
    /// </summary>
    public class Tile
    {
        /// <summary>
        /// ��Ƭ����������
        /// </summary>
        public TextureRegion Region { get; set; }

        /// <summary>
        /// �Ƿ�Ϊ�赲��Ƭ������ͨ������
        /// </summary>
        public bool IsBlocking { get; set; }

        public int TileID { get; set; }

        /// <summary>
        /// ���캯����
        /// </summary>
        /// <param name="region">��Ƭ����������</param>
        /// <param name="isBlocking">�Ƿ��赲��</param>
        public Tile(TextureRegion region, bool isBlocking, int tileID)
        {
            Region = region;
            IsBlocking = isBlocking;
            TileID = tileID;
        }
    }
}