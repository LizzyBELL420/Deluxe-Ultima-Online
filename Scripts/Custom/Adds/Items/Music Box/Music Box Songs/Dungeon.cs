namespace Server.Items.MusicBox
{
    public class DungeonSong : MusicBoxTrack
    {
        [Constructable]
        public DungeonSong()
            : base(1075159)
        {
            Song = MusicName.Cave01;
            //Name = "DungeonSong";
        }

        public DungeonSong(Serial s)
            : base(s)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}


