namespace Server.Items.MusicBox
{
    public class DragonsLowSong : MusicBoxTrack
    {
        [Constructable]
        public DragonsLowSong()
            : base(1075175)
        {
            Song = MusicName.Dungeon2;
            //Name = "Dragons (Low)";
        }

        public DragonsLowSong(Serial s)
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


