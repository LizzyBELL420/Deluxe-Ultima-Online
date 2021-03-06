namespace Server.Items.MusicBox
{
    public class DragonsHighSong : MusicBoxTrack
    {
        [Constructable]
        public DragonsHighSong()
            : base(1075160)
        {
            Song = MusicName.Dungeon9;
            //Name = "Dragons (High)";
        }

        public DragonsHighSong(Serial s)
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


